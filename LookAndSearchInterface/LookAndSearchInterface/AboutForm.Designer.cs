namespace LookAndSearchInterface
{
    partial class AboutForm
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
            this.txtBoxAboutInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxAboutInfo
            // 
            this.txtBoxAboutInfo.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxAboutInfo.Location = new System.Drawing.Point(12, 12);
            this.txtBoxAboutInfo.Multiline = true;
            this.txtBoxAboutInfo.Name = "txtBoxAboutInfo";
            this.txtBoxAboutInfo.Size = new System.Drawing.Size(520, 447);
            this.txtBoxAboutInfo.TabIndex = 0;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 471);
            this.Controls.Add(this.txtBoxAboutInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAboutInfo;
    }
}