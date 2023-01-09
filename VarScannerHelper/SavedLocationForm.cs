using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using YAFE.Properties;
using System.Runtime.InteropServices;

namespace YAFE
{

    public partial class SavedLocationForm : Form
    {
        [DllImport("user32.dll")]
        private static extern bool LockWindowUpdate(IntPtr hWndLock);

        private StringCollection _savedLocationsTo;
        private StringCollection _savedLocationsFrom;

        private bool isDelFrom;
        private bool isDelTo;

        public String saveFormCurrentScanPath;
        public String saveFormCurrentMovePath;
        
        public SavedLocationForm()
        {
            InitializeComponent();
            InitSettings();
            InitContent();
        }

        public void InitSettings()
        {
            FromListView.HeaderStyle = ColumnHeaderStyle.Clickable;
            FromListView.Columns.Add(new ColumnHeader() { Text = "Locations", Width = 200 });
            FromListView.ItemChecked += FromListView_ItemChecked;
            FromLocationFolderButton.Click += FromLocationFolderButton_Click;
            DeleteSelectedFromButton.Enabled = false;

            ToListView.HeaderStyle = ColumnHeaderStyle.Clickable;
            ToListView.Columns.Add(new ColumnHeader() { Text = "Locations", Width = 200 });
            ToListView.ItemChecked += ToListView_ItemChecked;
            ToLocationFolderButton.Click += ToLocationFolderButton_Click;
            DeleteSelectedToButton.Enabled = false;

            _savedLocationsTo = Settings.Default.savedLocationsTo;
            _savedLocationsFrom = Settings.Default.savedLocationsFrom;
            saveFormCurrentScanPath = Settings.Default.currentScanPath;
            saveFormCurrentMovePath = Settings.Default.currentMovePath;
        }

        public void InitContent()
        {
            FromListView.Items.AddRange(_savedLocationsFrom.Cast<string>().Select(x => new ListViewItem(x)).ToArray());
            ToListView.Items.AddRange(_savedLocationsTo.Cast<string>().Select(x => new ListViewItem(x)).ToArray());

            CurrentPathFromTextBox.Text = saveFormCurrentScanPath;
            CurrentPathToTextBox.Text = saveFormCurrentMovePath;
        }

        private void SavedLocationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Me_Close();
            Settings.Default.Save();
        }

        private void ConfirmFormCloseButton_Click(object sender, EventArgs e)
        {
            Me_Close();
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Me_Close();
            Close();
        }

        private void Me_Close()
        {
            StringCollection savedLocationsTo = new StringCollection();
            StringCollection savedLocationsFrom = new StringCollection();
            foreach (ListViewItem item in ToListView.Items) { savedLocationsTo.Add(item.Text); }
            foreach (ListViewItem item in FromListView.Items) { savedLocationsFrom.Add(item.Text); }

            Settings.Default.savedLocationsTo = savedLocationsTo;
            Settings.Default.savedLocationsFrom = savedLocationsFrom;
        }

        private void SetReturnValues(int caller)
        {
            // caller -
            // - 0 : FromSwitchButton
            // - 1 : ToSwitchButton

            if (FromListView.SelectedItems.Count == 1)
            {
                saveFormCurrentScanPath = FromListView.SelectedItems[0].Text;
            }
            else if (FromListView.SelectedItems.Count == 0 && caller == 0)
            {
                MessageBox.Show("No FROM LOCATION Selected\nUse the corrisponding button!");
                return;
            }

            if (ToListView.SelectedItems.Count == 1)
            {
                saveFormCurrentMovePath = ToListView.SelectedItems[0].Text;
            }
            else if (ToListView.SelectedItems.Count == 0 && caller == 1)
            {
                MessageBox.Show("No TO LOCATION Selected\nUse the corrisponding button!");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        /* General Form Stuff */

        private void FromLocationFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                SelectedPath = saveFormCurrentScanPath
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                saveFormCurrentScanPath = folderBrowserDialog.SelectedPath;
                CurrentPathFromTextBox.Text = saveFormCurrentScanPath;
            }
        }

        public void FromListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            if (FromListView.CheckedItems.Count == 2 && isDelFrom == false)
            {
                MessageBox.Show("Turn on \"Delete Mode\" to select more than one item");
                e.Item.Checked = false;
                return;
            }

            ItemsSelectedFromCountLabel.Text = "Items Selected: " + FromListView.SelectedItems.Count.ToString();

        }

        private void DelModeFromCheck_CheckedChanged(object sender, EventArgs e)
        {
            isDelFrom = !isDelFrom;
            DeleteSelectedFromButton.Enabled = isDelFrom;
            FromSwitchButton.Enabled = !isDelFrom;
            FromListView.CheckBoxes = isDelFrom;
        }

        private void CurrentPathFromAddButton_Click(object sender, EventArgs e)
        {
            if (FromListView.Items.Cast<ListViewItem>().Any(x => x.Text == saveFormCurrentScanPath))
            {
                MessageBox.Show("This location is already saved");
                return;
            }

            FromListView.Items.Add(saveFormCurrentScanPath);
        }

        private void CurrentPathFromClearButton_Click(object sender, EventArgs e)
        {
            saveFormCurrentScanPath = "";
            CurrentPathFromTextBox.Text = saveFormCurrentScanPath;
        }
        private void DeleteSelectedFromButton_Click(object sender, EventArgs e)
        {

            if (FromListView.CheckedItems.Count == 0)
            {
                MessageBox.Show("No items selected");
                return;
            }

            LockWindowUpdate(ActiveForm.Handle);

            foreach (ListViewItem item in FromListView.CheckedItems)
            {
                FromListView.Items.Remove(item);
            }

            LockWindowUpdate(IntPtr.Zero);

        }

        private void FromSwitchButton_Click(object sender, EventArgs e)
        {
            SetReturnValues(0);
        }


        /* Cheeky Little Comment here to seperate the two sections of code */


        private void ToLocationFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                SelectedPath = saveFormCurrentMovePath
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                saveFormCurrentScanPath = folderBrowserDialog.SelectedPath;
                CurrentPathToTextBox.Text = saveFormCurrentMovePath;
            }
        }

        public void ToListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (ToListView.CheckedItems.Count == 2 && isDelTo == false)
            {
                MessageBox.Show("Turn on \"Delete Mode\" to select more than one item");
                e.Item.Checked = false;
                return;
            }

            ItemsSelectedToCountLabel.Text = "Items Selected: " + ToListView.SelectedItems.Count.ToString();
        }

        private void DelModeToCheck_CheckedChanged(object sender, EventArgs e)
        {
            isDelTo = !isDelTo;
            DeleteSelectedToButton.Enabled = isDelTo;
            ToListView.CheckBoxes = isDelTo;
            ToSwitchButton.Enabled = !isDelTo;
        }
        private void CurrentPathToAddButton_Click(object sender, EventArgs e)
        {
            if (ToListView.Items.Cast<ListViewItem>().Any(x => x.Text == saveFormCurrentMovePath))
            {
                MessageBox.Show("This location is already saved");
                return;
            }

            ToListView.Items.Add(saveFormCurrentMovePath);
        }
        private void CurrentPathToClearButton_Click(object sender, EventArgs e)
        {
            saveFormCurrentMovePath = "";
            CurrentPathToTextBox.Text = saveFormCurrentMovePath;
        }

        private void DeleteSelectedToButton_Click(object sender, EventArgs e)
        {
            LockWindowUpdate(ActiveForm.Handle);

            if (ToListView.CheckedItems.Count == 0)
            {
                MessageBox.Show("No items selected");
                return;
            }

            foreach (ListViewItem item in ToListView.CheckedItems)
            {
                ToListView.Items.Remove(item);
            }

            LockWindowUpdate(IntPtr.Zero);
        }

        private void ToSwitchButton_Click(object sender, EventArgs e)
        {
            SetReturnValues(1);
        }
    }
}
