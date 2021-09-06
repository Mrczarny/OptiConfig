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


namespace OptiConfigUI
{
    public partial class OptiConfigDashboardForm : Form
    {

        private string message = "Operation completed! Do you want to see report?";
        public OptiConfigDashboardForm()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            configLabel.Enabled = false;
            configTextBox.Enabled = false;
            saveConfigButton.Enabled = false;
            savedConfigComboBox.Enabled = false;
            savedConfigLabel.Enabled = false;
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
                user.UserPassword = passwordTextBox.Text;
                user.UserLocalGroup = userTextBox.Text;
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
            //TODO - add in later update
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
