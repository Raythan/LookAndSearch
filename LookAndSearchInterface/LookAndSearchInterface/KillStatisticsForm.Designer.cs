namespace LookAndSearchInterface
{
    partial class KillStatisticsForm
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
            this.lblPollsTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPollsTitle
            // 
            this.lblPollsTitle.AutoSize = true;
            this.lblPollsTitle.Location = new System.Drawing.Point(12, 9);
            this.lblPollsTitle.Name = "lblPollsTitle";
            this.lblPollsTitle.Size = new System.Drawing.Size(65, 13);
            this.lblPollsTitle.TabIndex = 0;
            this.lblPollsTitle.Text = "Kill Statistics";
            // 
            // KillStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.Controls.Add(this.lblPollsTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KillStatisticsForm";
            this.Text = "KillStatisticsForm";
            this.Load += new System.EventHandler(this.KillStatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPollsTitle;
    }
}