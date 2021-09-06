using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptiConfigUI
{
    public partial class ReportForm : Form
    {
        public ReportForm(string[] Report)
        {
            InitializeComponent();
            InitializeForm(Report);
        }
        private void InitializeForm(string[] report)
        {
            reportNameText.Text = report[0];
            reportRichTextBox.Text = report[1];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
