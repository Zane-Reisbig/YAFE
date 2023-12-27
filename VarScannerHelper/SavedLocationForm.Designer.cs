namespace YAFE
{
    partial class SavedLocationForm
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
            this.FromListView = new System.Windows.Forms.ListView();
            this.ToListView = new System.Windows.Forms.ListView();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ConfirmFormCloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentPathToTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentPathFromTextBox = new System.Windows.Forms.TextBox();
            this.CurrentPathFromClearButton = new System.Windows.Forms.Button();
            this.CurrentPathFromAddButton = new System.Windows.Forms.Button();
            this.DeleteSelectedFromButton = new System.Windows.Forms.Button();
            this.ItemsSelectedFromCountLabel = new System.Windows.Forms.Label();
            this.CurrentPathToClearButton = new System.Windows.Forms.Button();
            this.CurrentPathToAddButton = new System.Windows.Forms.Button();
            this.DeleteSelectedToButton = new System.Windows.Forms.Button();
            this.FromLocationFolderButton = new System.Windows.Forms.Button();
            this.ToLocationFolderButton = new System.Windows.Forms.Button();
            this.FromSwitchButton = new System.Windows.Forms.Button();
            this.ToSwitchButton = new System.Windows.Forms.Button();
            this.DelModeFromCheck = new System.Windows.Forms.CheckBox();
            this.DelModeToCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FromListView
            // 
            this.FromListView.GridLines = true;
            this.FromListView.HideSelection = false;
            this.FromListView.Location = new System.Drawing.Point(12, 40);
            this.FromListView.Name = "FromListView";
            this.FromListView.Size = new System.Drawing.Size(591, 113);
            this.FromListView.TabIndex = 0;
            this.FromListView.UseCompatibleStateImageBehavior = false;
            this.FromListView.View = System.Windows.Forms.View.Details;
            // 
            // ToListView
            // 
            this.ToListView.GridLines = true;
            this.ToListView.HideSelection = false;
            this.ToListView.Location = new System.Drawing.Point(12, 212);
            this.ToListView.Name = "ToListView";
            this.ToListView.Size = new System.Drawing.Size(591, 113);
            this.ToListView.TabIndex = 0;
            this.ToListView.UseCompatibleStateImageBehavior = false;
            this.ToListView.View = System.Windows.Forms.View.Details;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CloseButton.Location = new System.Drawing.Point(12, 370);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(195, 35);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ConfirmFormCloseButton
            // 
            this.ConfirmFormCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ConfirmFormCloseButton.Location = new System.Drawing.Point(568, 370);
            this.ConfirmFormCloseButton.Name = "ConfirmFormCloseButton";
            this.ConfirmFormCloseButton.Size = new System.Drawing.Size(195, 35);
            this.ConfirmFormCloseButton.TabIndex = 1;
            this.ConfirmFormCloseButton.Text = "Confirm";
            this.ConfirmFormCloseButton.UseVisualStyleBackColor = false;
            this.ConfirmFormCloseButton.Click += new System.EventHandler(this.ConfirmFormCloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To Location";
            // 
            // CurrentPathToTextBox
            // 
            this.CurrentPathToTextBox.Location = new System.Drawing.Point(12, 330);
            this.CurrentPathToTextBox.Name = "CurrentPathToTextBox";
            this.CurrentPathToTextBox.Size = new System.Drawing.Size(550, 20);
            this.CurrentPathToTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 2;
            // 
            // CurrentPathFromTextBox
            // 
            this.CurrentPathFromTextBox.Location = new System.Drawing.Point(12, 159);
            this.CurrentPathFromTextBox.Name = "CurrentPathFromTextBox";
            this.CurrentPathFromTextBox.Size = new System.Drawing.Size(550, 20);
            this.CurrentPathFromTextBox.TabIndex = 3;
            // 
            // CurrentPathFromClearButton
            // 
            this.CurrentPathFromClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CurrentPathFromClearButton.Location = new System.Drawing.Point(607, 159);
            this.CurrentPathFromClearButton.Name = "CurrentPathFromClearButton";
            this.CurrentPathFromClearButton.Size = new System.Drawing.Size(75, 20);
            this.CurrentPathFromClearButton.TabIndex = 4;
            this.CurrentPathFromClearButton.Text = "Clear";
            this.CurrentPathFromClearButton.UseVisualStyleBackColor = false;
            this.CurrentPathFromClearButton.Click += new System.EventHandler(this.CurrentPathFromClearButton_Click);
            // 
            // CurrentPathFromAddButton
            // 
            this.CurrentPathFromAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CurrentPathFromAddButton.Location = new System.Drawing.Point(688, 159);
            this.CurrentPathFromAddButton.Name = "CurrentPathFromAddButton";
            this.CurrentPathFromAddButton.Size = new System.Drawing.Size(75, 20);
            this.CurrentPathFromAddButton.TabIndex = 4;
            this.CurrentPathFromAddButton.Text = "Add";
            this.CurrentPathFromAddButton.UseVisualStyleBackColor = false;
            this.CurrentPathFromAddButton.Click += new System.EventHandler(this.CurrentPathFromAddButton_Click);
            // 
            // DeleteSelectedFromButton
            // 
            this.DeleteSelectedFromButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteSelectedFromButton.Location = new System.Drawing.Point(607, 130);
            this.DeleteSelectedFromButton.Name = "DeleteSelectedFromButton";
            this.DeleteSelectedFromButton.Size = new System.Drawing.Size(156, 23);
            this.DeleteSelectedFromButton.TabIndex = 5;
            this.DeleteSelectedFromButton.Text = "Delete Selected";
            this.DeleteSelectedFromButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedFromButton.Click += new System.EventHandler(this.DeleteSelectedFromButton_Click);
            // 
            // ItemsSelectedFromCountLabel
            // 
            this.ItemsSelectedFromCountLabel.AutoSize = true;
            this.ItemsSelectedFromCountLabel.Location = new System.Drawing.Point(509, 182);
            this.ItemsSelectedFromCountLabel.Name = "ItemsSelectedFromCountLabel";
            this.ItemsSelectedFromCountLabel.Size = new System.Drawing.Size(89, 13);
            this.ItemsSelectedFromCountLabel.TabIndex = 6;
            this.ItemsSelectedFromCountLabel.Text = "Items Selected: 0";
            // 
            // CurrentPathToClearButton
            // 
            this.CurrentPathToClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CurrentPathToClearButton.Location = new System.Drawing.Point(607, 331);
            this.CurrentPathToClearButton.Name = "CurrentPathToClearButton";
            this.CurrentPathToClearButton.Size = new System.Drawing.Size(75, 20);
            this.CurrentPathToClearButton.TabIndex = 4;
            this.CurrentPathToClearButton.Text = "Clear";
            this.CurrentPathToClearButton.UseVisualStyleBackColor = false;
            this.CurrentPathToClearButton.Click += new System.EventHandler(this.CurrentPathToClearButton_Click);
            // 
            // CurrentPathToAddButton
            // 
            this.CurrentPathToAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CurrentPathToAddButton.Location = new System.Drawing.Point(688, 331);
            this.CurrentPathToAddButton.Name = "CurrentPathToAddButton";
            this.CurrentPathToAddButton.Size = new System.Drawing.Size(75, 20);
            this.CurrentPathToAddButton.TabIndex = 4;
            this.CurrentPathToAddButton.Text = "Add";
            this.CurrentPathToAddButton.UseVisualStyleBackColor = false;
            this.CurrentPathToAddButton.Click += new System.EventHandler(this.CurrentPathToAddButton_Click);
            // 
            // DeleteSelectedToButton
            // 
            this.DeleteSelectedToButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteSelectedToButton.Location = new System.Drawing.Point(607, 302);
            this.DeleteSelectedToButton.Name = "DeleteSelectedToButton";
            this.DeleteSelectedToButton.Size = new System.Drawing.Size(156, 23);
            this.DeleteSelectedToButton.TabIndex = 5;
            this.DeleteSelectedToButton.Text = "Delete Selected";
            this.DeleteSelectedToButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedToButton.Click += new System.EventHandler(this.DeleteSelectedToButton_Click);
            // 
            // FromLocationFolderButton
            // 
            this.FromLocationFolderButton.Location = new System.Drawing.Point(568, 159);
            this.FromLocationFolderButton.Name = "FromLocationFolderButton";
            this.FromLocationFolderButton.Size = new System.Drawing.Size(32, 20);
            this.FromLocationFolderButton.TabIndex = 3;
            this.FromLocationFolderButton.Text = "📂";
            this.FromLocationFolderButton.UseVisualStyleBackColor = true;
            // 
            // ToLocationFolderButton
            // 
            this.ToLocationFolderButton.Location = new System.Drawing.Point(568, 330);
            this.ToLocationFolderButton.Name = "ToLocationFolderButton";
            this.ToLocationFolderButton.Size = new System.Drawing.Size(32, 20);
            this.ToLocationFolderButton.TabIndex = 3;
            this.ToLocationFolderButton.Text = "📂";
            this.ToLocationFolderButton.UseVisualStyleBackColor = true;
            // 
            // FromSwitchButton
            // 
            this.FromSwitchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FromSwitchButton.Location = new System.Drawing.Point(610, 40);
            this.FromSwitchButton.Name = "FromSwitchButton";
            this.FromSwitchButton.Size = new System.Drawing.Size(153, 31);
            this.FromSwitchButton.TabIndex = 8;
            this.FromSwitchButton.Text = "Switch!";
            this.FromSwitchButton.UseVisualStyleBackColor = false;
            this.FromSwitchButton.Click += new System.EventHandler(this.FromSwitchButton_Click);
            // 
            // ToSwitchButton
            // 
            this.ToSwitchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ToSwitchButton.Location = new System.Drawing.Point(610, 212);
            this.ToSwitchButton.Name = "ToSwitchButton";
            this.ToSwitchButton.Size = new System.Drawing.Size(153, 31);
            this.ToSwitchButton.TabIndex = 8;
            this.ToSwitchButton.Text = "Switch!";
            this.ToSwitchButton.UseVisualStyleBackColor = false;
            this.ToSwitchButton.Click += new System.EventHandler(this.ToSwitchButton_Click);
            // 
            // DelModeFromCheck
            // 
            this.DelModeFromCheck.AutoSize = true;
            this.DelModeFromCheck.Location = new System.Drawing.Point(610, 107);
            this.DelModeFromCheck.Name = "DelModeFromCheck";
            this.DelModeFromCheck.Size = new System.Drawing.Size(87, 17);
            this.DelModeFromCheck.TabIndex = 9;
            this.DelModeFromCheck.Text = "Delete Mode";
            this.DelModeFromCheck.UseVisualStyleBackColor = true;
            this.DelModeFromCheck.CheckedChanged += new System.EventHandler(this.DelModeFromCheck_CheckedChanged);
            // 
            // DelModeToCheck
            // 
            this.DelModeToCheck.AutoSize = true;
            this.DelModeToCheck.Location = new System.Drawing.Point(609, 279);
            this.DelModeToCheck.Name = "DelModeToCheck";
            this.DelModeToCheck.Size = new System.Drawing.Size(87, 17);
            this.DelModeToCheck.TabIndex = 9;
            this.DelModeToCheck.Text = "Delete Mode";
            this.DelModeToCheck.UseVisualStyleBackColor = true;
            this.DelModeToCheck.CheckedChanged += new System.EventHandler(this.DelModeToCheck_CheckedChanged);
            // 
            // SavedLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.DelModeToCheck);
            this.Controls.Add(this.DelModeFromCheck);
            this.Controls.Add(this.ToSwitchButton);
            this.Controls.Add(this.FromSwitchButton);
            this.Controls.Add(this.ItemsSelectedFromCountLabel);
            this.Controls.Add(this.DeleteSelectedToButton);
            this.Controls.Add(this.DeleteSelectedFromButton);
            this.Controls.Add(this.CurrentPathToAddButton);
            this.Controls.Add(this.CurrentPathFromAddButton);
            this.Controls.Add(this.CurrentPathToClearButton);
            this.Controls.Add(this.CurrentPathFromClearButton);
            this.Controls.Add(this.CurrentPathFromTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CurrentPathToTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmFormCloseButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ToListView);
            this.Controls.Add(this.FromListView);
            this.Controls.Add(this.ToLocationFolderButton);
            this.Controls.Add(this.FromLocationFolderButton);
            this.Name = "SavedLocationForm";
            this.Text = "Saved Locations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SavedLocationForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView FromListView;
        private System.Windows.Forms.ListView ToListView;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ConfirmFormCloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CurrentPathToTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CurrentPathFromTextBox;
        private System.Windows.Forms.Button CurrentPathFromClearButton;
        private System.Windows.Forms.Button CurrentPathFromAddButton;
        private System.Windows.Forms.Button DeleteSelectedFromButton;
        private System.Windows.Forms.Label ItemsSelectedFromCountLabel;
        private System.Windows.Forms.Button CurrentPathToClearButton;
        private System.Windows.Forms.Button CurrentPathToAddButton;
        private System.Windows.Forms.Button DeleteSelectedToButton;
        private System.Windows.Forms.Button FromLocationFolderButton;
        private System.Windows.Forms.Button ToLocationFolderButton;
        private System.Windows.Forms.Button FromSwitchButton;
        private System.Windows.Forms.Button ToSwitchButton;
        private System.Windows.Forms.CheckBox DelModeFromCheck;
        private System.Windows.Forms.CheckBox DelModeToCheck;
    }
}