using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OptiConfigLib;
using OptiConfigLib.Models;
using System.Net;
using System.Security;


namespace OptiConfigUI
{
    public partial class OptiConfigDashboardForm : Form
    {

        private string message = "Operation completed! Do you want to see report?";
        private List<ConfigModel> configs = GlobalConfig.dataProcessor.GetConfigModels();
        public OptiConfigDashboardForm()
        {
            InitializeComponent();
            LoadForm();
        }

        //Utilites
        private void LoadForm()
        {
            //configLabel.Enabled = false;
            //configTextBox.Enabled = false;
            //saveConfigButton.Enabled = false;
            //savedConfigComboBox.Enabled = false;
            //savedConfigLabel.Enabled = false;
            addUserEnableCheckBox.Checked = true;
            secpolEnableCheckBox.Checked = true;
            AddUserGroupBox.Enabled = true;
            seceditGroupBox.Enabled = true;

            savedConfigDropDownList.DataSource = null;
            savedConfigDropDownList.DataSource = configs;
            savedConfigDropDownList.DisplayMember = "Name";

            if (bitlockerCheckBox.Checked != true)
            {
                addBitlockerButton.Enabled = false;
                serviceTagTextBox.Enabled = false;
                usbNameTextBox.Enabled = false;
                serviceTagLabel.Enabled = false;
                usbNameLabel.Enabled = false;
            }
            if (addUserEnableCheckBox.Checked != true)
            {
                AddUserGroupBox.Enabled = false;
            }
            if (secpolEnableCheckBox.Checked != true)
            {
                seceditGroupBox.Enabled = false;
            }

            
        }
        private void updateForm()
        {

        }
        private void updateSavedConfigComboBox(List<ConfigModel> models)
        {
            configs = models;
            savedConfigDropDownList.DataSource = null;
            savedConfigDropDownList.DataSource = configs;
            savedConfigDropDownList.DisplayMember = "Name";
            savedConfigDropDownList.Refresh();
        }


        //Events
        private void bitlockerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            addBitlockerButton.Enabled = !addBitlockerButton.Enabled;
            serviceTagTextBox.Enabled = !serviceTagTextBox.Enabled;
            usbNameTextBox.Enabled = !usbNameTextBox.Enabled;
            serviceTagLabel.Enabled = !serviceTagLabel.Enabled;
            usbNameLabel.Enabled = !usbNameLabel.Enabled;
        }
        private void addUserButton_Click(object sender, EventArgs e)
        {
            addUser();
        }
        private void addUser()
        {
            if (validateUser())
            {
                UserModel user = new UserModel();
                user.UserName = userTextBox.Text;
                user.UserPassword = new NetworkCredential("", passwordTextBox.Text).SecurePassword;
                user.UserLocalGroup = groupTextBox.Text;
                user.UserDescription = descriptionTextBox.Text;
                user.UserNeverExpires = neverUserCheckBox.Checked;

                string[] Report = new string[2];
                Report = GlobalConfig.Commands.UserAdd(user);
                DialogResult resultBox = MessageBox.Show(message, "Add user", MessageBoxButtons.YesNo);
                if (resultBox == DialogResult.Yes)
                {
                    ReportForm rForm = new ReportForm(Report);
                    rForm.Show();
                }
            }
        }
        private void seceditSetButton_Click(object sender, EventArgs e)
        {
            seceditSet();
        }
        private void seceditSet()
        {
            if (validateSecpolEdit())
            {
                SecpolModel secpol = new SecpolModel();
                secpol.PasswordComplexity = passwordComplCheckBox.Checked;
                secpol.MinimumPasswordLength = Convert.ToInt32(passwordMinLengTextBox.Text);
                secpol.MaximumPasswordAge = Convert.ToInt32(maxPasswordAgeTextBox.Text);
                secpol.PasswordHistorySize = Convert.ToInt32(passwordHisSizeTextBox.Text);

                string[] Report = new string[2];
                Report = GlobalConfig.Commands.SecPolEdit(secpol);
                DialogResult resultBox = MessageBox.Show(message, "Secpol edit", MessageBoxButtons.YesNo);
                if (resultBox == DialogResult.Yes)
                {
                    ReportForm rForm = new ReportForm(Report);
                    rForm.Show();
                }
            }
        }
        private void addBitlockerButton_Click(object sender, EventArgs e)
        {
            addBitlocker();
        }
        private void addBitlocker()
        {
            if (validateBitlocker())
            {
                BitlockerModel bitlocker = new BitlockerModel();
                bitlocker.ServiceTag = serviceTagTextBox.Text;
                bitlocker.UsbName = usbNameTextBox.Text;

                string[] Report = new string[2];
                Report = GlobalConfig.Commands.BitlockerEdit(bitlocker);
                DialogResult resultBox = MessageBox.Show(message, "Bitlocker edit", MessageBoxButtons.YesNo);
                if (resultBox == DialogResult.Yes)
                {
                    ReportForm rForm = new ReportForm(Report);
                    rForm.Show();
                }
            }
        }
        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            ConfigModel config = new ConfigModel();
            if (configTextBox.Text != "")
            {
                config.Name = configTextBox.Text;
                if (secpolEnableCheckBox.Checked)
                {
                    if (validateSecpolEdit())
                    {
                        SecpolModel secpol = new SecpolModel();
                        secpol.PasswordComplexity = passwordComplCheckBox.Checked;
                        secpol.MinimumPasswordLength = Convert.ToInt32(passwordMinLengTextBox.Text);
                        secpol.MaximumPasswordAge = Convert.ToInt32(maxPasswordAgeTextBox.Text);
                        secpol.PasswordHistorySize = Convert.ToInt32(passwordHisSizeTextBox.Text);
                        config.SecpolConfig = secpol;
                    }
                }
                if (addUserEnableCheckBox.Checked)
                {
                    if (validateUser())
                    {
                        UserModel user = new UserModel();
                        user.UserName = userTextBox.Text;
                        user.UserPassword = new NetworkCredential("", passwordTextBox.Text).SecurePassword;
                        user.UserLocalGroup = groupTextBox.Text;
                        user.UserDescription = descriptionTextBox.Text;
                        user.UserNeverExpires = neverUserCheckBox.Checked;
                        config.UserConfig = user;
                    }
                }
                if (bitlockerCheckBox.Checked)
                {
                    if (validateBitlocker())
                    {
                        BitlockerModel bitlocker = new BitlockerModel();
                        bitlocker.ServiceTag = serviceTagTextBox.Text;
                        bitlocker.UsbName = usbNameTextBox.Text;
                        config.BitlockerConfig = bitlocker;
                    }
                }
                updateSavedConfigComboBox(GlobalConfig.dataProcessor.ConfigModelToJson(config));

            }
            else
            {
                MessageBox.Show("Please add cofiguration name.", "Error saving config");
            }
        }
        private void savedConfigComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigModel config = (ConfigModel)savedConfigDropDownList.SelectedItem;

            if (config != null)
            {
                configTextBox.Text = config.Name;
                if (config.SecpolConfig != null)
                {
                    secpolEnableCheckBox.Checked = true;
                    passwordComplCheckBox.Checked = config.SecpolConfig.PasswordComplexity;
                    passwordMinLengTextBox.Text = null;
                    passwordMinLengTextBox.Text = config.SecpolConfig.MinimumPasswordLength.ToString();
                    maxPasswordAgeTextBox.Text = null;
                    maxPasswordAgeTextBox.Text = config.SecpolConfig.MaximumPasswordAge.ToString();
                    passwordHisSizeTextBox.Text = null;
                    passwordHisSizeTextBox.Text = config.SecpolConfig.PasswordHistorySize.ToString();
                }
                else
                {
                    secpolEnableCheckBox.Checked = false;
                    passwordMinLengTextBox.Text = null;
                    maxPasswordAgeTextBox.Text = null;
                    passwordHisSizeTextBox.Text = null;
                }
                if (config.UserConfig != null)
                {
                    addUserEnableCheckBox.Checked = true;
                    userTextBox.Text = null;
                    userTextBox.Text = config.UserConfig.UserName;
                    passwordTextBox.Text = null;
                    passwordTextBox.Text = new NetworkCredential("", config.UserConfig.UserPassword).Password;
                    groupTextBox.Text = null;
                    groupTextBox.Text = config.UserConfig.UserLocalGroup;
                    descriptionTextBox.Text = null;
                    descriptionTextBox.Text = config.UserConfig.UserDescription;
                    neverUserCheckBox.Checked = config.UserConfig.UserNeverExpires;
                }
                else
                {
                    addUserEnableCheckBox.Checked = false;
                    userTextBox.Text = null;
                    passwordTextBox.Text = null;
                    groupTextBox.Text = null;
                    descriptionTextBox.Text = null;
                    neverUserCheckBox.Checked = false;
                }
                if (config.BitlockerConfig != null)
                {
                    bitlockerCheckBox.Checked = true;
                    serviceTagTextBox.Text = null;
                    serviceTagTextBox.Text = config.BitlockerConfig.ServiceTag;
                    usbNameTextBox.Text = null;
                    usbNameTextBox.Text = config.BitlockerConfig.UsbName;
                }
                else
                {
                    bitlockerCheckBox.Checked = false;
                    serviceTagTextBox.Text = null;
                    usbNameTextBox.Text = null;
                }
            }
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (secpolEnableCheckBox.Checked)
            {
                seceditSet();
            }
            if (addUserEnableCheckBox.Checked)
            {
                addUser();
            }
            if (bitlockerCheckBox.Checked)
            {
                DialogResult confirmationDialog = MessageBox.Show("This action will force your computer to shutdown. Continue?", "Bitlocker edit", MessageBoxButtons.YesNo);
                if (confirmationDialog == DialogResult.Yes)
                {
                    addBitlocker();
                }           
            }
        }
        private void OptiConfigDashboardForm_Load(object sender, EventArgs e)
        {

        }
        private void addUserEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AddUserGroupBox.Enabled = !AddUserGroupBox.Enabled;
        }
        private void secpolEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            seceditGroupBox.Enabled = !seceditGroupBox.Enabled;
        }
        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void visibilityButton_Click(object sender, EventArgs e)
        {

        }
        private void visibilityButton_MouseDown(object sender, MouseEventArgs e)
        {
            //visibilityButton.BackColor = Color.Red; -- very good for debbuging! 
            visibilityButton.Image = Image.FromFile(Application.StartupPath + @"\Resources\eyeYes.png");
            passwordTextBox.UseSystemPasswordChar = false;
        }
        private void visibilityButton_MouseUp(object sender, MouseEventArgs e)
        {
            //visibilityButton.BackColor = Color.Transparent;
            visibilityButton.Image = Image.FromFile(Application.StartupPath + @"\Resources\eyeNo.png");
            passwordTextBox.UseSystemPasswordChar = true;
        }


        //Validation
        private bool validateUser()
        {
            bool output = true;
            if (userTextBox.Text == "")
            {
                output = false;
                MessageBox.Show("Please enter username.", "Error adding user");
            }
            if (passwordTextBox.Text == "")
            {
                output = false;
                MessageBox.Show("Please enter password.", "Error adding user");
            }
            return output;
        }
        private bool validateBitlocker()
        {
            bool output = true;
            if (serviceTagTextBox.Text == "")
            {
                output = false;
                MessageBox.Show("Please enter service tag.", "Error enabling bitlocker");
            }
            if (usbNameTextBox.Text == "")
            {
                output = false;
                MessageBox.Show("Please enter usb name.", "Error enabling bitlocker");
            }
            return output;
        }
        private bool validateSecpolEdit()
        {
            bool output = true;
            if (passwordMinLengTextBox.Text == "" || !int.TryParse(passwordMinLengTextBox.Text, out _) )
            {
                output = false;
                MessageBox.Show("Please valid password length.", "Error editing security policy");
            }
            if (maxPasswordAgeTextBox.Text == "" || !int.TryParse(passwordMinLengTextBox.Text, out _))
            {
                output = false;
                MessageBox.Show("Please enter valid password age.", "Error editing security policy");
            }
            if (passwordHisSizeTextBox.Text == "" || !int.TryParse(passwordHisSizeTextBox.Text, out _))
            {
                output = false;
                MessageBox.Show("Please enter valid password history size.", "Error editing security policy");
            }
            return output;
        }
    }
}
