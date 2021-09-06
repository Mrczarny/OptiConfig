
namespace OptiConfigUI
{
    partial class OptiConfigDashboardForm
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
            this.AddUserGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.neverUserCheckBox = new System.Windows.Forms.CheckBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.serviceTagLabel = new System.Windows.Forms.Label();
            this.serviceTagTextBox = new System.Windows.Forms.TextBox();
            this.usbNameTextBox = new System.Windows.Forms.TextBox();
            this.usbNameLabel = new System.Windows.Forms.Label();
            this.seceditGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordComplCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordComplLabel = new System.Windows.Forms.Label();
            this.seceditSetButton = new System.Windows.Forms.Button();
            this.passwordHisSizeLabel = new System.Windows.Forms.Label();
            this.maxPasswordAgeLabel = new System.Windows.Forms.Label();
            this.passwordMinLengLabel = new System.Windows.Forms.Label();
            this.passwordHisSizeTextBox = new System.Windows.Forms.TextBox();
            this.maxPasswordAgeTextBox = new System.Windows.Forms.TextBox();
            this.passwordMinLengTextBox = new System.Windows.Forms.TextBox();
            this.savedConfigComboBox = new System.Windows.Forms.ComboBox();
            this.savedConfigLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.saveConfigButton = new System.Windows.Forms.Button();
            this.configTextBox = new System.Windows.Forms.TextBox();
            this.configLabel = new System.Windows.Forms.Label();
            this.bitlockerCheckBox = new System.Windows.Forms.CheckBox();
            this.addUserEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.secpolEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.addBitlockerButton = new System.Windows.Forms.Button();
            this.AddUserGroupBox.SuspendLayout();
            this.seceditGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddUserGroupBox
            // 
            this.AddUserGroupBox.Controls.Add(this.descriptionLabel);
            this.AddUserGroupBox.Controls.Add(this.groupLabel);
            this.AddUserGroupBox.Controls.Add(this.passwordLabel);
            this.AddUserGroupBox.Controls.Add(this.addUserButton);
            this.AddUserGroupBox.Controls.Add(this.neverUserCheckBox);
            this.AddUserGroupBox.Controls.Add(this.descriptionTextBox);
            this.AddUserGroupBox.Controls.Add(this.groupTextBox);
            this.AddUserGroupBox.Controls.Add(this.passwordTextBox);
            this.AddUserGroupBox.Controls.Add(this.userTextBox);
            this.AddUserGroupBox.Controls.Add(this.userLabel);
            this.AddUserGroupBox.Location = new System.Drawing.Point(28, 151);
            this.AddUserGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.AddUserGroupBox.Name = "AddUserGroupBox";
            this.AddUserGroupBox.Size = new System.Drawing.Size(270, 183);
            this.AddUserGroupBox.TabIndex = 0;
            this.AddUserGroupBox.TabStop = false;
            this.AddUserGroupBox.Text = "Add user";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(10, 101);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Description";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(10, 75);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(65, 13);
            this.groupLabel.TabIndex = 6;
            this.groupLabel.Text = "Local Group";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(10, 49);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(175, 145);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(85, 29);
            this.addUserButton.TabIndex = 5;
            this.addUserButton.Text = "Add user";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // neverUserCheckBox
            // 
            this.neverUserCheckBox.AutoSize = true;
            this.neverUserCheckBox.Location = new System.Drawing.Point(13, 124);
            this.neverUserCheckBox.Name = "neverUserCheckBox";
            this.neverUserCheckBox.Size = new System.Drawing.Size(109, 17);
            this.neverUserCheckBox.TabIndex = 4;
            this.neverUserCheckBox.Text = "User never expire";
            this.neverUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(78, 98);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(78, 72);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(100, 20);
            this.groupTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(78, 46);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(78, 20);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(100, 20);
            this.userTextBox.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(10, 23);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(58, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User name";
            // 
            // serviceTagLabel
            // 
            this.serviceTagLabel.AutoSize = true;
            this.serviceTagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.serviceTagLabel.Location = new System.Drawing.Point(24, 65);
            this.serviceTagLabel.Name = "serviceTagLabel";
            this.serviceTagLabel.Size = new System.Drawing.Size(92, 20);
            this.serviceTagLabel.TabIndex = 9;
            this.serviceTagLabel.Text = "Service Tag";
            // 
            // serviceTagTextBox
            // 
            this.serviceTagTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.serviceTagTextBox.Location = new System.Drawing.Point(140, 62);
            this.serviceTagTextBox.Name = "serviceTagTextBox";
            this.serviceTagTextBox.Size = new System.Drawing.Size(105, 26);
            this.serviceTagTextBox.TabIndex = 10;
            // 
            // usbNameTextBox
            // 
            this.usbNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usbNameTextBox.Location = new System.Drawing.Point(140, 105);
            this.usbNameTextBox.Name = "usbNameTextBox";
            this.usbNameTextBox.Size = new System.Drawing.Size(105, 26);
            this.usbNameTextBox.TabIndex = 12;
            // 
            // usbNameLabel
            // 
            this.usbNameLabel.AutoSize = true;
            this.usbNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usbNameLabel.Location = new System.Drawing.Point(24, 105);
            this.usbNameLabel.Name = "usbNameLabel";
            this.usbNameLabel.Size = new System.Drawing.Size(84, 20);
            this.usbNameLabel.TabIndex = 11;
            this.usbNameLabel.Text = "Usb Name";
            // 
            // seceditGroupBox
            // 
            this.seceditGroupBox.Controls.Add(this.passwordComplCheckBox);
            this.seceditGroupBox.Controls.Add(this.passwordComplLabel);
            this.seceditGroupBox.Controls.Add(this.seceditSetButton);
            this.seceditGroupBox.Controls.Add(this.passwordHisSizeLabel);
            this.seceditGroupBox.Controls.Add(this.maxPasswordAgeLabel);
            this.seceditGroupBox.Controls.Add(this.passwordMinLengLabel);
            this.seceditGroupBox.Controls.Add(this.passwordHisSizeTextBox);
            this.seceditGroupBox.Controls.Add(this.maxPasswordAgeTextBox);
            this.seceditGroupBox.Controls.Add(this.passwordMinLengTextBox);
            this.seceditGroupBox.Location = new System.Drawing.Point(330, 151);
            this.seceditGroupBox.Name = "seceditGroupBox";
            this.seceditGroupBox.Size = new System.Drawing.Size(262, 183);
            this.seceditGroupBox.TabIndex = 13;
            this.seceditGroupBox.TabStop = false;
            this.seceditGroupBox.Text = "Security edit";
            // 
            // passwordComplCheckBox
            // 
            this.passwordComplCheckBox.AutoSize = true;
            this.passwordComplCheckBox.Location = new System.Drawing.Point(141, 26);
            this.passwordComplCheckBox.Name = "passwordComplCheckBox";
            this.passwordComplCheckBox.Size = new System.Drawing.Size(15, 14);
            this.passwordComplCheckBox.TabIndex = 19;
            this.passwordComplCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordComplLabel
            // 
            this.passwordComplLabel.AutoSize = true;
            this.passwordComplLabel.Location = new System.Drawing.Point(12, 26);
            this.passwordComplLabel.Name = "passwordComplLabel";
            this.passwordComplLabel.Size = new System.Drawing.Size(105, 13);
            this.passwordComplLabel.TabIndex = 18;
            this.passwordComplLabel.Text = "Password complexity";
            // 
            // seceditSetButton
            // 
            this.seceditSetButton.Location = new System.Drawing.Point(171, 145);
            this.seceditSetButton.Name = "seceditSetButton";
            this.seceditSetButton.Size = new System.Drawing.Size(85, 29);
            this.seceditSetButton.TabIndex = 17;
            this.seceditSetButton.Text = "set config";
            this.seceditSetButton.UseVisualStyleBackColor = true;
            this.seceditSetButton.Click += new System.EventHandler(this.seceditSetButton_Click);
            // 
            // passwordHisSizeLabel
            // 
            this.passwordHisSizeLabel.AutoSize = true;
            this.passwordHisSizeLabel.Location = new System.Drawing.Point(12, 104);
            this.passwordHisSizeLabel.Name = "passwordHisSizeLabel";
            this.passwordHisSizeLabel.Size = new System.Drawing.Size(107, 13);
            this.passwordHisSizeLabel.TabIndex = 16;
            this.passwordHisSizeLabel.Text = "Password history size";
            // 
            // maxPasswordAgeLabel
            // 
            this.maxPasswordAgeLabel.AutoSize = true;
            this.maxPasswordAgeLabel.Location = new System.Drawing.Point(12, 78);
            this.maxPasswordAgeLabel.Name = "maxPasswordAgeLabel";
            this.maxPasswordAgeLabel.Size = new System.Drawing.Size(120, 13);
            this.maxPasswordAgeLabel.TabIndex = 15;
            this.maxPasswordAgeLabel.Text = "Maximum password age";
            // 
            // passwordMinLengLabel
            // 
            this.passwordMinLengLabel.AutoSize = true;
            this.passwordMinLengLabel.Location = new System.Drawing.Point(12, 52);
            this.passwordMinLengLabel.Name = "passwordMinLengLabel";
            this.passwordMinLengLabel.Size = new System.Drawing.Size(128, 13);
            this.passwordMinLengLabel.TabIndex = 10;
            this.passwordMinLengLabel.Text = "Minimum password length";
            // 
            // passwordHisSizeTextBox
            // 
            this.passwordHisSizeTextBox.Location = new System.Drawing.Point(141, 101);
            this.passwordHisSizeTextBox.Name = "passwordHisSizeTextBox";
            this.passwordHisSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordHisSizeTextBox.TabIndex = 14;
            // 
            // maxPasswordAgeTextBox
            // 
            this.maxPasswordAgeTextBox.Location = new System.Drawing.Point(141, 75);
            this.maxPasswordAgeTextBox.Name = "maxPasswordAgeTextBox";
            this.maxPasswordAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxPasswordAgeTextBox.TabIndex = 11;
            // 
            // passwordMinLengTextBox
            // 
            this.passwordMinLengTextBox.Location = new System.Drawing.Point(141, 49);
            this.passwordMinLengTextBox.Name = "passwordMinLengTextBox";
            this.passwordMinLengTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordMinLengTextBox.TabIndex = 13;
            // 
            // savedConfigComboBox
            // 
            this.savedConfigComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.savedConfigComboBox.FormattingEnabled = true;
            this.savedConfigComboBox.Location = new System.Drawing.Point(594, 65);
            this.savedConfigComboBox.Name = "savedConfigComboBox";
            this.savedConfigComboBox.Size = new System.Drawing.Size(148, 26);
            this.savedConfigComboBox.TabIndex = 14;
            // 
            // savedConfigLabel
            // 
            this.savedConfigLabel.AutoSize = true;
            this.savedConfigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.savedConfigLabel.Location = new System.Drawing.Point(619, 42);
            this.savedConfigLabel.Name = "savedConfigLabel";
            this.savedConfigLabel.Size = new System.Drawing.Size(104, 20);
            this.savedConfigLabel.TabIndex = 15;
            this.savedConfigLabel.Text = "Saved Config";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(614, 383);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(139, 42);
            this.confirmButton.TabIndex = 16;
            this.confirmButton.Text = "confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // saveConfigButton
            // 
            this.saveConfigButton.Location = new System.Drawing.Point(453, 383);
            this.saveConfigButton.Name = "saveConfigButton";
            this.saveConfigButton.Size = new System.Drawing.Size(139, 42);
            this.saveConfigButton.TabIndex = 17;
            this.saveConfigButton.Text = "save config";
            this.saveConfigButton.UseVisualStyleBackColor = true;
            this.saveConfigButton.Click += new System.EventHandler(this.saveConfigButton_Click);
            // 
            // configTextBox
            // 
            this.configTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.configTextBox.Location = new System.Drawing.Point(140, 20);
            this.configTextBox.Name = "configTextBox";
            this.configTextBox.Size = new System.Drawing.Size(105, 26);
            this.configTextBox.TabIndex = 19;
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.configLabel.Location = new System.Drawing.Point(24, 20);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(101, 20);
            this.configLabel.TabIndex = 18;
            this.configLabel.Text = "Config Name";
            // 
            // bitlockerCheckBox
            // 
            this.bitlockerCheckBox.AutoSize = true;
            this.bitlockerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bitlockerCheckBox.Location = new System.Drawing.Point(267, 62);
            this.bitlockerCheckBox.Name = "bitlockerCheckBox";
            this.bitlockerCheckBox.Size = new System.Drawing.Size(93, 24);
            this.bitlockerCheckBox.TabIndex = 20;
            this.bitlockerCheckBox.Text = "Bitlocker ";
            this.bitlockerCheckBox.UseVisualStyleBackColor = true;
            this.bitlockerCheckBox.CheckedChanged += new System.EventHandler(this.bitlockerCheckBox_CheckedChanged);
            // 
            // addUserEnableCheckBox
            // 
            this.addUserEnableCheckBox.AutoSize = true;
            this.addUserEnableCheckBox.Location = new System.Drawing.Point(290, 151);
            this.addUserEnableCheckBox.Name = "addUserEnableCheckBox";
            this.addUserEnableCheckBox.Size = new System.Drawing.Size(15, 14);
            this.addUserEnableCheckBox.TabIndex = 20;
            this.addUserEnableCheckBox.UseVisualStyleBackColor = true;
            this.addUserEnableCheckBox.CheckedChanged += new System.EventHandler(this.addUserEnableCheckBox_CheckedChanged);
            // 
            // secpolEnableCheckBox
            // 
            this.secpolEnableCheckBox.AutoSize = true;
            this.secpolEnableCheckBox.Location = new System.Drawing.Point(585, 151);
            this.secpolEnableCheckBox.Name = "secpolEnableCheckBox";
            this.secpolEnableCheckBox.Size = new System.Drawing.Size(15, 14);
            this.secpolEnableCheckBox.TabIndex = 21;
            this.secpolEnableCheckBox.UseVisualStyleBackColor = true;
            this.secpolEnableCheckBox.CheckedChanged += new System.EventHandler(this.secpolEnableCheckBox_CheckedChanged);
            // 
            // addBitlockerButton
            // 
            this.addBitlockerButton.Location = new System.Drawing.Point(267, 102);
            this.addBitlockerButton.Name = "addBitlockerButton";
            this.addBitlockerButton.Size = new System.Drawing.Size(85, 29);
            this.addBitlockerButton.TabIndex = 22;
            this.addBitlockerButton.Text = "Add bitlocker";
            this.addBitlockerButton.UseVisualStyleBackColor = true;
            this.addBitlockerButton.Click += new System.EventHandler(this.addBitlockerButton_Click);
            // 
            // OptiConfigDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 437);
            this.Controls.Add(this.addBitlockerButton);
            this.Controls.Add(this.secpolEnableCheckBox);
            this.Controls.Add(this.addUserEnableCheckBox);
            this.Controls.Add(this.bitlockerCheckBox);
            this.Controls.Add(this.configTextBox);
            this.Controls.Add(this.configLabel);
            this.Controls.Add(this.saveConfigButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.savedConfigLabel);
            this.Controls.Add(this.savedConfigComboBox);
            this.Controls.Add(this.seceditGroupBox);
            this.Controls.Add(this.usbNameTextBox);
            this.Controls.Add(this.usbNameLabel);
            this.Controls.Add(this.serviceTagTextBox);
            this.Controls.Add(this.serviceTagLabel);
            this.Controls.Add(this.AddUserGroupBox);
            this.Name = "OptiConfigDashboardForm";
            this.Text = "OptiConfig";
            this.Load += new System.EventHandler(this.OptiConfigDashboardForm_Load);
            this.AddUserGroupBox.ResumeLayout(false);
            this.AddUserGroupBox.PerformLayout();
            this.seceditGroupBox.ResumeLayout(false);
            this.seceditGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AddUserGroupBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.CheckBox neverUserCheckBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label serviceTagLabel;
        private System.Windows.Forms.TextBox serviceTagTextBox;
        private System.Windows.Forms.TextBox usbNameTextBox;
        private System.Windows.Forms.Label usbNameLabel;
        private System.Windows.Forms.GroupBox seceditGroupBox;
        private System.Windows.Forms.Button seceditSetButton;
        private System.Windows.Forms.Label passwordHisSizeLabel;
        private System.Windows.Forms.Label maxPasswordAgeLabel;
        private System.Windows.Forms.Label passwordMinLengLabel;
        private System.Windows.Forms.TextBox passwordHisSizeTextBox;
        private System.Windows.Forms.TextBox maxPasswordAgeTextBox;
        private System.Windows.Forms.TextBox passwordMinLengTextBox;
        private System.Windows.Forms.CheckBox passwordComplCheckBox;
        private System.Windows.Forms.Label passwordComplLabel;
        private System.Windows.Forms.ComboBox savedConfigComboBox;
        private System.Windows.Forms.Label savedConfigLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button saveConfigButton;
        private System.Windows.Forms.TextBox configTextBox;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.CheckBox bitlockerCheckBox;
        private System.Windows.Forms.CheckBox addUserEnableCheckBox;
        private System.Windows.Forms.CheckBox secpolEnableCheckBox;
        private System.Windows.Forms.Button addBitlockerButton;
    }
}

