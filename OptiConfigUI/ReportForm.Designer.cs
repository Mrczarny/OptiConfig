
namespace OptiConfigUI
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.reportName = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.reportRichTextBox = new System.Windows.Forms.RichTextBox();
            this.reportNameText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportName
            // 
            this.reportName.AutoSize = true;
            this.reportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reportName.Location = new System.Drawing.Point(12, 15);
            this.reportName.Name = "reportName";
            this.reportName.Size = new System.Drawing.Size(130, 25);
            this.reportName.TabIndex = 1;
            this.reportName.Text = "Report form:";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okButton.Location = new System.Drawing.Point(481, 420);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(95, 29);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // reportRichTextBox
            // 
            this.reportRichTextBox.BackColor = System.Drawing.Color.Silver;
            this.reportRichTextBox.Location = new System.Drawing.Point(67, 53);
            this.reportRichTextBox.Name = "reportRichTextBox";
            this.reportRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.reportRichTextBox.Size = new System.Drawing.Size(459, 346);
            this.reportRichTextBox.TabIndex = 0;
            this.reportRichTextBox.Text = "";
            // 
            // reportNameText
            // 
            this.reportNameText.AutoSize = true;
            this.reportNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reportNameText.Location = new System.Drawing.Point(148, 15);
            this.reportNameText.Name = "reportNameText";
            this.reportNameText.Size = new System.Drawing.Size(70, 25);
            this.reportNameText.TabIndex = 3;
            this.reportNameText.Text = "<null>";
            this.reportNameText.Click += new System.EventHandler(this.label2_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(588, 461);
            this.Controls.Add(this.reportNameText);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.reportName);
            this.Controls.Add(this.reportRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportForm";
            this.ShowInTaskbar = false;
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox reportRichTextBox;
        private System.Windows.Forms.Label reportName;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label reportNameText;
    }
}