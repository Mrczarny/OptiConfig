
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptiConfigDashboardForm));
            this.AddUserGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.visibilityButton = new System.Windows.Forms.Button();
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
            this.button2 = new System.Windows.Forms.Button();
            this.AddUserGroupBox.SuspendLayout();
            this.seceditGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddUserGroupBox
            // 
            this.AddUserGroupBox.Controls.Add(this.descriptionLabel);
            this.AddUserGroupBox.Controls.Add(this.visibilityButton);
            this.AddUserGroupBox.Controls.Add(this.groupLabel);
            this.AddUserGroupBox.Controls.Add(this.passwordLabel);
            this.AddUserGroupBox.Controls.Add(this.addUserButton);
            this.AddUserGroupBox.Controls.Add(this.neverUserCheckBox);
            this.AddUserGroupBox.Controls.Add(this.descriptionTextBox);
            this.AddUserGroupBox.Controls.Add(this.groupTextBox);
            this.AddUserGroupBox.Controls.Add(this.passwordTextBox);
            this.AddUserGroupBox.Controls.Add(this.userTextBox);
            this.AddUserGroupBox.Controls.Add(this.userLabel);
            resources.ApplyResources(this.AddUserGroupBox, "AddUserGroupBox");
            this.AddUserGroupBox.Name = "AddUserGroupBox";
            this.AddUserGroupBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            resources.ApplyResources(this.descriptionLabel, "descriptionLabel");
            this.descriptionLabel.Name = "descriptionLabel";
            // 
            // visibilityButton
            // 
            resources.ApplyResources(this.visibilityButton, "visibilityButton");
            this.visibilityButton.FlatAppearance.BorderSize = 0;
            this.visibilityButton.Image = global::OptiConfigUI.Properties.Resources.eyeNo;
            this.visibilityButton.Name = "visibilityButton";
            this.visibilityButton.UseVisualStyleBackColor = true;
            this.visibilityButton.Click += new System.EventHandler(this.visibilityButton_Click);
            this.visibilityButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.visibilityButton_MouseDown);
            this.visibilityButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.visibilityButton_MouseUp);
            // 
            // groupLabel
            // 
            resources.ApplyResources(this.groupLabel, "groupLabel");
            this.groupLabel.Name = "groupLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // addUserButton
            // 
            resources.ApplyResources(this.addUserButton, "addUserButton");
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // neverUserCheckBox
            // 
            resources.ApplyResources(this.neverUserCheckBox, "neverUserCheckBox");
            this.neverUserCheckBox.Name = "neverUserCheckBox";
            this.neverUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            resources.ApplyResources(this.descriptionTextBox, "descriptionTextBox");
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // groupTextBox
            // 
            resources.ApplyResources(this.groupTextBox, "groupTextBox");
            this.groupTextBox.Name = "groupTextBox";
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // userTextBox
            // 
            resources.ApplyResources(this.userTextBox, "userTextBox");
            this.userTextBox.Name = "userTextBox";
            // 
            // userLabel
            // 
            resources.ApplyResources(this.userLabel, "userLabel");
            this.userLabel.Name = "userLabel";
            // 
            // serviceTagLabel
            // 
            resources.ApplyResources(this.serviceTagLabel, "serviceTagLabel");
            this.serviceTagLabel.Name = "serviceTagLabel";
            // 
            // serviceTagTextBox
            // 
            resources.ApplyResources(this.serviceTagTextBox, "serviceTagTextBox");
            this.serviceTagTextBox.Name = "serviceTagTextBox";
            // 
            // usbNameTextBox
            // 
            resources.ApplyResources(this.usbNameTextBox, "usbNameTextBox");
            this.usbNameTextBox.Name = "usbNameTextBox";
            // 
            // usbNameLabel
            // 
            resources.ApplyResources(this.usbNameLabel, "usbNameLabel");
            this.usbNameLabel.Name = "usbNameLabel";
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
            resources.ApplyResources(this.seceditGroupBox, "seceditGroupBox");
            this.seceditGroupBox.Name = "seceditGroupBox";
            this.seceditGroupBox.TabStop = false;
            // 
            // passwordComplCheckBox
            // 
            resources.ApplyResources(this.passwordComplCheckBox, "passwordComplCheckBox");
            this.passwordComplCheckBox.Name = "passwordComplCheckBox";
            this.passwordComplCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordComplLabel
            // 
            resources.ApplyResources(this.passwordComplLabel, "passwordComplLabel");
            this.passwordComplLabel.Name = "passwordComplLabel";
            // 
            // seceditSetButton
            // 
            resources.ApplyResources(this.seceditSetButton, "seceditSetButton");
            this.seceditSetButton.Name = "seceditSetButton";
            this.seceditSetButton.UseVisualStyleBackColor = true;
            this.seceditSetButton.Click += new System.EventHandler(this.seceditSetButton_Click);
            // 
            // passwordHisSizeLabel
            // 
            resources.ApplyResources(this.passwordHisSizeLabel, "passwordHisSizeLabel");
            this.passwordHisSizeLabel.Name = "passwordHisSizeLabel";
            // 
            // maxPasswordAgeLabel
            // 
            resources.ApplyResources(this.maxPasswordAgeLabel, "maxPasswordAgeLabel");
            this.maxPasswordAgeLabel.Name = "maxPasswordAgeLabel";
            // 
            // passwordMinLengLabel
            // 
            resources.ApplyResources(this.passwordMinLengLabel, "passwordMinLengLabel");
            this.passwordMinLengLabel.Name = "passwordMinLengLabel";
            // 
            // passwordHisSizeTextBox
            // 
            resources.ApplyResources(this.passwordHisSizeTextBox, "passwordHisSizeTextBox");
            this.passwordHisSizeTextBox.Name = "passwordHisSizeTextBox";
            // 
            // maxPasswordAgeTextBox
            // 
            resources.ApplyResources(this.maxPasswordAgeTextBox, "maxPasswordAgeTextBox");
            this.maxPasswordAgeTextBox.Name = "maxPasswordAgeTextBox";
            // 
            // passwordMinLengTextBox
            // 
            resources.ApplyResources(this.passwordMinLengTextBox, "passwordMinLengTextBox");
            this.passwordMinLengTextBox.Name = "passwordMinLengTextBox";
            // 
            // savedConfigComboBox
            // 
            resources.ApplyResources(this.savedConfigComboBox, "savedConfigComboBox");
            this.savedConfigComboBox.FormattingEnabled = true;
            this.savedConfigComboBox.Name = "savedConfigComboBox";
            this.savedConfigComboBox.SelectedIndexChanged += new System.EventHandler(this.savedConfigComboBox_SelectedIndexChanged);
            // 
            // savedConfigLabel
            // 
            resources.ApplyResources(this.savedConfigLabel, "savedConfigLabel");
            this.savedConfigLabel.Name = "savedConfigLabel";
            // 
            // confirmButton
            // 
            resources.ApplyResources(this.confirmButton, "confirmButton");
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // saveConfigButton
            // 
            resources.ApplyResources(this.saveConfigButton, "saveConfigButton");
            this.saveConfigButton.Name = "saveConfigButton";
            this.saveConfigButton.UseVisualStyleBackColor = true;
            this.saveConfigButton.Click += new System.EventHandler(this.saveConfigButton_Click);
            // 
            // configTextBox
            // 
            resources.ApplyResources(this.configTextBox, "configTextBox");
            this.configTextBox.Name = "configTextBox";
            // 
            // configLabel
            // 
            resources.ApplyResources(this.configLabel, "configLabel");
            this.configLabel.Name = "configLabel";
            // 
            // bitlockerCheckBox
            // 
            resources.ApplyResources(this.bitlockerCheckBox, "bitlockerCheckBox");
            this.bitlockerCheckBox.Name = "bitlockerCheckBox";
            this.bitlockerCheckBox.UseVisualStyleBackColor = true;
            this.bitlockerCheckBox.CheckedChanged += new System.EventHandler(this.bitlockerCheckBox_CheckedChanged);
            // 
            // addUserEnableCheckBox
            // 
            resources.ApplyResources(this.addUserEnableCheckBox, "addUserEnableCheckBox");
            this.addUserEnableCheckBox.Name = "addUserEnableCheckBox";
            this.addUserEnableCheckBox.UseVisualStyleBackColor = true;
            this.addUserEnableCheckBox.CheckedChanged += new System.EventHandler(this.addUserEnableCheckBox_CheckedChanged);
            // 
            // secpolEnableCheckBox
            // 
            resources.ApplyResources(this.secpolEnableCheckBox, "secpolEnableCheckBox");
            this.secpolEnableCheckBox.Name = "secpolEnableCheckBox";
            this.secpolEnableCheckBox.UseVisualStyleBackColor = true;
            this.secpolEnableCheckBox.CheckedChanged += new System.EventHandler(this.secpolEnableCheckBox_CheckedChanged);
            // 
            // addBitlockerButton
            // 
            resources.ApplyResources(this.addBitlockerButton, "addBitlockerButton");
            this.addBitlockerButton.Name = "addBitlockerButton";
            this.addBitlockerButton.UseVisualStyleBackColor = true;
            this.addBitlockerButton.Click += new System.EventHandler(this.addBitlockerButton_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(471, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 29);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OptiConfigDashboardForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OptiConfigDashboardForm";
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
        private System.Windows.Forms.Button visibilityButton;
    }
}

