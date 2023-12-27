using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using YAFE.Properties;
using System.Drawing;
using System.Collections.Specialized;

namespace YAFE
{
    public partial class Form1 : Form
    {
        public string _currentScanPath;
        public string _currentMovePath;
        private string quickAppLauchPath;
        private string _fileExtension;

        private int _fileAge;

        private Size _windowSize = new Size(800, 600);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Init List View
            FilesFoundListView.CheckBoxes = true;
            FilesFoundListView.FullRowSelect = true;
            FilesFoundListView.GridLines = true;
            FilesFoundListView.Scrollable = true;
            FilesFoundListView.Columns.Add("File Name", 200, HorizontalAlignment.Left).Name = "FileName";
            FilesFoundListView.Columns.Add("File Path", 300, HorizontalAlignment.Left).Name = "FilePath";
            FilesFoundListView.Columns.Add("Age (Days)", 100, HorizontalAlignment.Left).Name = "FileDate";
            FilesFoundListView.Columns.Add("Install Date", 100, HorizontalAlignment.Left).Name = "InstallDate";

            InitUserSettings();
            FindFiles();
        }


        private void FindFiles()
        {
            FilesFoundListView.Items.Clear();
            List<ListViewItem> fileCollection = new List<ListViewItem>();           

            // Scan the download folder for files ending in .var from the past 30 days
            {
                // Get the date -fileAge days ago
                DateTime fileAgeDays = DateTime.Now.AddDays(-_fileAge);

                // Get the list of files
                string[] files = System.IO.Directory.GetFiles(_currentScanPath, string.Format("*.{0}", _fileExtension));

                // Loop through the list of files
                foreach (string file in files)
                {
                    // Get the file info
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file);

                    // If the file is newer than 30 days ago
                    if (fileInfo.LastWriteTime > fileAgeDays)
                    {
                        // convert the lastwritetime to days
                        // Add the file to the list
                        ListViewItem item = new ListViewItem(fileInfo.Name)
                        {
                            Checked = fileInfo.LastWriteTime > DateTime.Now.AddDays(-2),
                            SubItems = {
                                fileInfo.FullName,
                                (Math.Ceiling((DateTime.Now - fileInfo.LastWriteTime).TotalDays).ToString()),
                                fileInfo.LastWriteTime.ToString(),
                            }
                        };
                        fileCollection.Add(item);
                    }
                }
            }

            fileCollection.Sort((x, y) => int.Parse(x.SubItems[2].Text).CompareTo(int.Parse(y.SubItems[2].Text)));
            FilesFoundListView.Items.AddRange(fileCollection.ToArray());


            // >:D
            //progressBar1.Value = 75;
            //Thread.Sleep(300);
            //progressBar1.Value = 80;
            //Thread.Sleep(200);
            //progressBar1.Value = 85;
            //Thread.Sleep(250);
            //progressBar1.Value = 100;
            // >:D

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog()
            {
                SelectedPath = _currentScanPath
            };

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                _currentScanPath = folderBrowserDialog1.SelectedPath;
                ScanLocationTextBox.Text = _currentScanPath;
                FindFiles();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindFiles();
            resetFilesChecked();
        }

        private void MovePathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog()
            {
                SelectedPath = _currentMovePath
            };

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                _currentMovePath = folderBrowserDialog1.SelectedPath;
                MovePath.Text = _currentMovePath;
            }

        }

        private void MoveCheckedButton_Click(object sender, EventArgs e)
        {
            if (FilesFoundListView.CheckedItems.Count > 20 && OpenInExplorerRadio.Checked)
            {
                DialogResult dialogResult = MessageBox.Show(String.Format("Are you sure you want to open {0} files in explorer?", FilesFoundListView.CheckedItems.Count), "Are you sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            foreach (ListViewItem item in FilesFoundListView.CheckedItems)
            {

                if (MoveRadio.Checked)
                {
                    System.IO.File.Delete(_currentMovePath + "\\" + item.SubItems[0].Text);
                    System.IO.File.Move(item.SubItems[1].Text, _currentMovePath + "\\" + item.SubItems[0].Text);
                }
                else if (CopyRadio.Checked)
                {
                    System.IO.File.Copy(item.SubItems[1].Text, _currentMovePath + "\\" + item.SubItems[0].Text);
                }
                else if (OpenInExplorerRadio.Checked)
                {
                    System.Diagnostics.Process.Start("explorer.exe", "/select, " + item.SubItems[1].Text);
                }
                else
                {
                    MessageBox.Show("Are you happy you broke it? It's going to copy the files now >:(");
                    System.IO.File.Copy(item.SubItems[1].Text, _currentMovePath + "\\" + item.SubItems[0].Text);
                }

            }
            FindFiles();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteSettings();
        }


        private void FileAgeNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            _fileAge = (int)FileAgeNumUpDown.Value;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            FilesFoundListView.Width = this.Width - 150;
        }

        private void FilesFoundListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            resetFilesChecked();
        }

        private void resetFilesChecked()
        {
            FilesCheckedLabel.Text = string.Format("Files Selected: {0}", FilesFoundListView.CheckedItems.Count);
        }

        private void FileExtTextBox_TextChanged(object sender, EventArgs e)
        {
            _fileExtension = FileExtTextBox.Text;
            
        }

        private void FileExtTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                FindFiles();
            }
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in FilesFoundListView.Items)
            {
                item.Checked = true;
            }
        }
        private void DeSelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in FilesFoundListView.Items)
            {
                item.Checked = false;
            }
        }

        private void QuickAppFolderButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = _currentMovePath,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                quickAppLauchPath = openFileDialog.FileName;
            }

            Settings.Default.quickAppPath = quickAppLauchPath;
        }

        private void LaunchAppButton_Click(object sender, EventArgs e)
        {
            if(Settings.Default.quickAppPath == "None")
            {
                MessageBox.Show("Please select a folder to launch from");
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = quickAppLauchPath;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.WorkingDirectory = quickAppLauchPath.Substring(0, quickAppLauchPath.LastIndexOf("\\"));

            Process.Start(startInfo);

        }
        private void WriteSettings()
        { 
            Settings.Default.currentMovePath = _currentMovePath;
            Settings.Default.currentScanPath = _currentScanPath;
            Settings.Default.fileAge = _fileAge;
            Settings.Default.quickAppPath = quickAppLauchPath;
            Settings.Default.fileExtension = _fileExtension;
            Settings.Default.windowSize = _windowSize;
            Settings.Default.Save();
        }

        private void InitUserSettings()
        {
            _currentMovePath = Settings.Default.currentMovePath;
            _currentScanPath = Settings.Default.currentScanPath;
            quickAppLauchPath = Settings.Default.quickAppPath;
            _fileExtension = Settings.Default.fileExtension;
            _fileAge = Settings.Default.fileAge;
            _windowSize = Settings.Default.windowSize;

            ScanLocationTextBox.Text = _currentScanPath;
            MovePath.Text = _currentMovePath;
            FileExtTextBox.Text = _fileExtension;
            FileAgeNumUpDown.Value = _fileAge;
            
        }

        private void showLocationForm(object sender, EventArgs e)
        {
            WriteSettings();
            
            SavedLocationForm savedLocationsForm = new SavedLocationForm();
            var childReturn = savedLocationsForm.ShowDialog(this.Parent);

            if (childReturn == DialogResult.OK)
            {
                _currentMovePath = savedLocationsForm.saveFormCurrentMovePath;
                _currentScanPath = savedLocationsForm.saveFormCurrentScanPath;
            }
            
            ScanLocationTextBox.Text = _currentScanPath;
            MovePath.Text = _currentMovePath;

        }

        private void MovePath_TextChanged(object sender, EventArgs e)
        {
            _currentMovePath = MovePath.Text;
        }

        private void ScanLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentScanPath = ScanLocationTextBox.Text;
        }

        private void SavedLocationsToButton_Click(object sender, EventArgs e)
        {
            showLocationForm(sender, e);
        }
    }

}
