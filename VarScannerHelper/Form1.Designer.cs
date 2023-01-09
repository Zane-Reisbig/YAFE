namespace YAFE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ScanLocationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FilesFoundListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.MoveCheckedButton = new System.Windows.Forms.Button();
            this.MovePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MovePathButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.FileExtTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FileAgeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.MoveRadio = new System.Windows.Forms.RadioButton();
            this.CopyRadio = new System.Windows.Forms.RadioButton();
            this.OpenInExplorerRadio = new System.Windows.Forms.RadioButton();
            this.FilesCheckedLabel = new System.Windows.Forms.Label();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.LaunchAppButton = new System.Windows.Forms.Button();
            this.QuickAppTextBox = new System.Windows.Forms.TextBox();
            this.QuickAppFolderButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DeSelectAllButton = new System.Windows.Forms.Button();
            this.SavedLocationsFromButton = new System.Windows.Forms.Button();
            this.SavedLocationsToButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FileAgeNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ScanLocationTextBox
            // 
            this.ScanLocationTextBox.Location = new System.Drawing.Point(29, 39);
            this.ScanLocationTextBox.Name = "ScanLocationTextBox";
            this.ScanLocationTextBox.Size = new System.Drawing.Size(496, 20);
            this.ScanLocationTextBox.TabIndex = 1;
            this.ScanLocationTextBox.TextChanged += new System.EventHandler(this.ScanLocationTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location Path";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "📂";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Found Information";
            // 
            // FilesFoundListView
            // 
            this.FilesFoundListView.FullRowSelect = true;
            this.FilesFoundListView.GridLines = true;
            this.FilesFoundListView.HideSelection = false;
            this.FilesFoundListView.LabelWrap = false;
            this.FilesFoundListView.Location = new System.Drawing.Point(29, 131);
            this.FilesFoundListView.Name = "FilesFoundListView";
            this.FilesFoundListView.Size = new System.Drawing.Size(691, 210);
            this.FilesFoundListView.TabIndex = 6;
            this.FilesFoundListView.UseCompatibleStateImageBehavior = false;
            this.FilesFoundListView.View = System.Windows.Forms.View.Details;
            this.FilesFoundListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.FilesFoundListView_ItemChecked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Re-Scan For Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MoveCheckedButton
            // 
            this.MoveCheckedButton.Location = new System.Drawing.Point(29, 420);
            this.MoveCheckedButton.Name = "MoveCheckedButton";
            this.MoveCheckedButton.Size = new System.Drawing.Size(121, 23);
            this.MoveCheckedButton.TabIndex = 0;
            this.MoveCheckedButton.Text = "Do Action";
            this.MoveCheckedButton.UseVisualStyleBackColor = true;
            this.MoveCheckedButton.Click += new System.EventHandler(this.MoveCheckedButton_Click);
            // 
            // MovePath
            // 
            this.MovePath.Location = new System.Drawing.Point(29, 396);
            this.MovePath.Name = "MovePath";
            this.MovePath.Size = new System.Drawing.Size(496, 20);
            this.MovePath.TabIndex = 1;
            this.MovePath.TextChanged += new System.EventHandler(this.MovePath_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Move To";
            // 
            // MovePathButton
            // 
            this.MovePathButton.Location = new System.Drawing.Point(531, 396);
            this.MovePathButton.Name = "MovePathButton";
            this.MovePathButton.Size = new System.Drawing.Size(32, 20);
            this.MovePathButton.TabIndex = 3;
            this.MovePathButton.Text = "📂";
            this.MovePathButton.UseVisualStyleBackColor = true;
            this.MovePathButton.Click += new System.EventHandler(this.MovePathButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(35, 347);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(679, 13);
            this.progressBar1.TabIndex = 7;
            // 
            // FileExtTextBox
            // 
            this.FileExtTextBox.Location = new System.Drawing.Point(162, 65);
            this.FileExtTextBox.Name = "FileExtTextBox";
            this.FileExtTextBox.Size = new System.Drawing.Size(72, 20);
            this.FileExtTextBox.TabIndex = 8;
            this.FileExtTextBox.Text = "zip";
            this.FileExtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FileExtTextBox.WordWrap = false;
            this.FileExtTextBox.TextChanged += new System.EventHandler(this.FileExtTextBox_TextChanged);
            this.FileExtTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileExtTextBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "File Extension\r\n(Dont Add \".\")\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "File Age\r\n (Days)";
            // 
            // FileAgeNumUpDown
            // 
            this.FileAgeNumUpDown.Location = new System.Drawing.Point(240, 65);
            this.FileAgeNumUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.FileAgeNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FileAgeNumUpDown.Name = "FileAgeNumUpDown";
            this.FileAgeNumUpDown.Size = new System.Drawing.Size(42, 20);
            this.FileAgeNumUpDown.TabIndex = 10;
            this.FileAgeNumUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.FileAgeNumUpDown.ValueChanged += new System.EventHandler(this.FileAgeNumUpDown_ValueChanged);
            // 
            // MoveRadio
            // 
            this.MoveRadio.AutoSize = true;
            this.MoveRadio.Location = new System.Drawing.Point(156, 423);
            this.MoveRadio.Name = "MoveRadio";
            this.MoveRadio.Size = new System.Drawing.Size(76, 17);
            this.MoveRadio.TabIndex = 12;
            this.MoveRadio.Text = "Move Files";
            this.MoveRadio.UseVisualStyleBackColor = true;
            // 
            // CopyRadio
            // 
            this.CopyRadio.AutoSize = true;
            this.CopyRadio.Checked = true;
            this.CopyRadio.Location = new System.Drawing.Point(238, 423);
            this.CopyRadio.Name = "CopyRadio";
            this.CopyRadio.Size = new System.Drawing.Size(73, 17);
            this.CopyRadio.TabIndex = 13;
            this.CopyRadio.TabStop = true;
            this.CopyRadio.Text = "Copy Files";
            this.CopyRadio.UseVisualStyleBackColor = true;
            // 
            // OpenInExplorerRadio
            // 
            this.OpenInExplorerRadio.AutoSize = true;
            this.OpenInExplorerRadio.Location = new System.Drawing.Point(317, 423);
            this.OpenInExplorerRadio.Name = "OpenInExplorerRadio";
            this.OpenInExplorerRadio.Size = new System.Drawing.Size(128, 17);
            this.OpenInExplorerRadio.TabIndex = 13;
            this.OpenInExplorerRadio.Text = "Open Files In Explorer";
            this.OpenInExplorerRadio.UseVisualStyleBackColor = true;
            // 
            // FilesCheckedLabel
            // 
            this.FilesCheckedLabel.AutoSize = true;
            this.FilesCheckedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilesCheckedLabel.Location = new System.Drawing.Point(660, 433);
            this.FilesCheckedLabel.Name = "FilesCheckedLabel";
            this.FilesCheckedLabel.Size = new System.Drawing.Size(85, 13);
            this.FilesCheckedLabel.TabIndex = 14;
            this.FilesCheckedLabel.Text = "Files Selected: 0";
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Location = new System.Drawing.Point(633, 366);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(87, 23);
            this.SelectAllButton.TabIndex = 15;
            this.SelectAllButton.Text = "Select All";
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // LaunchAppButton
            // 
            this.LaunchAppButton.Location = new System.Drawing.Point(589, 66);
            this.LaunchAppButton.Name = "LaunchAppButton";
            this.LaunchAppButton.Size = new System.Drawing.Size(119, 22);
            this.LaunchAppButton.TabIndex = 16;
            this.LaunchAppButton.Text = "Launch App";
            this.LaunchAppButton.UseVisualStyleBackColor = true;
            this.LaunchAppButton.Click += new System.EventHandler(this.LaunchAppButton_Click);
            // 
            // QuickAppTextBox
            // 
            this.QuickAppTextBox.Location = new System.Drawing.Point(589, 40);
            this.QuickAppTextBox.Name = "QuickAppTextBox";
            this.QuickAppTextBox.Size = new System.Drawing.Size(119, 20);
            this.QuickAppTextBox.TabIndex = 8;
            this.QuickAppTextBox.Text = "No App Selected";
            this.QuickAppTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuickAppTextBox.WordWrap = false;
            this.QuickAppTextBox.TextChanged += new System.EventHandler(this.FileExtTextBox_TextChanged);
            // 
            // QuickAppFolderButton
            // 
            this.QuickAppFolderButton.Location = new System.Drawing.Point(714, 41);
            this.QuickAppFolderButton.Name = "QuickAppFolderButton";
            this.QuickAppFolderButton.Size = new System.Drawing.Size(26, 19);
            this.QuickAppFolderButton.TabIndex = 3;
            this.QuickAppFolderButton.Text = "📂";
            this.QuickAppFolderButton.UseVisualStyleBackColor = true;
            this.QuickAppFolderButton.Click += new System.EventHandler(this.QuickAppFolderButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quick Launch App";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeSelectAllButton
            // 
            this.DeSelectAllButton.Location = new System.Drawing.Point(633, 388);
            this.DeSelectAllButton.Name = "DeSelectAllButton";
            this.DeSelectAllButton.Size = new System.Drawing.Size(87, 23);
            this.DeSelectAllButton.TabIndex = 15;
            this.DeSelectAllButton.Text = "De-Select All";
            this.DeSelectAllButton.UseVisualStyleBackColor = true;
            this.DeSelectAllButton.Click += new System.EventHandler(this.DeSelectAllButton_Click);
            // 
            // SavedLocationsFromButton
            // 
            this.SavedLocationsFromButton.Location = new System.Drawing.Point(464, 63);
            this.SavedLocationsFromButton.Name = "SavedLocationsFromButton";
            this.SavedLocationsFromButton.Size = new System.Drawing.Size(99, 23);
            this.SavedLocationsFromButton.TabIndex = 3;
            this.SavedLocationsFromButton.Text = "Saved Locations";
            this.SavedLocationsFromButton.UseVisualStyleBackColor = true;
            this.SavedLocationsFromButton.Click += new System.EventHandler(this.showLocationForm);
            // 
            // SavedLocationsToButton
            // 
            this.SavedLocationsToButton.Location = new System.Drawing.Point(464, 420);
            this.SavedLocationsToButton.Name = "SavedLocationsToButton";
            this.SavedLocationsToButton.Size = new System.Drawing.Size(99, 23);
            this.SavedLocationsToButton.TabIndex = 3;
            this.SavedLocationsToButton.Text = "Saved Locations";
            this.SavedLocationsToButton.UseVisualStyleBackColor = true;
            this.SavedLocationsToButton.Click += new System.EventHandler(this.SavedLocationsToButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LaunchAppButton);
            this.Controls.Add(this.DeSelectAllButton);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.FilesCheckedLabel);
            this.Controls.Add(this.OpenInExplorerRadio);
            this.Controls.Add(this.CopyRadio);
            this.Controls.Add(this.MoveRadio);
            this.Controls.Add(this.FileAgeNumUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuickAppTextBox);
            this.Controls.Add(this.FileExtTextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FilesFoundListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MovePathButton);
            this.Controls.Add(this.QuickAppFolderButton);
            this.Controls.Add(this.SavedLocationsToButton);
            this.Controls.Add(this.SavedLocationsFromButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovePath);
            this.Controls.Add(this.MoveCheckedButton);
            this.Controls.Add(this.ScanLocationTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "File Handler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.FileAgeNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ScanLocationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView FilesFoundListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MoveCheckedButton;
        private System.Windows.Forms.TextBox MovePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MovePathButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox FileExtTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown FileAgeNumUpDown;
        private System.Windows.Forms.RadioButton MoveRadio;
        private System.Windows.Forms.RadioButton CopyRadio;
        private System.Windows.Forms.RadioButton OpenInExplorerRadio;
        private System.Windows.Forms.Label FilesCheckedLabel;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.Button LaunchAppButton;
        private System.Windows.Forms.TextBox QuickAppTextBox;
        private System.Windows.Forms.Button QuickAppFolderButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeSelectAllButton;
        private System.Windows.Forms.Button SavedLocationsFromButton;
        private System.Windows.Forms.Button SavedLocationsToButton;
    }
}

