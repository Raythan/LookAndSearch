namespace LookAndSearchInterface
{
    partial class ErrorForm
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
            this.picBoxErrorImage = new System.Windows.Forms.PictureBox();
            this.lblErrorInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxErrorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxErrorImage
            // 
            this.picBoxErrorImage.Location = new System.Drawing.Point(80, 55);
            this.picBoxErrorImage.Name = "picBoxErrorImage";
            this.picBoxErrorImage.Size = new System.Drawing.Size(400, 400);
            this.picBoxErrorImage.TabIndex = 0;
            this.picBoxErrorImage.TabStop = false;
            // 
            // lblErrorInformation
            // 
            this.lblErrorInformation.AutoSize = true;
            this.lblErrorInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorInformation.Location = new System.Drawing.Point(12, 9);
            this.lblErrorInformation.Name = "lblErrorInformation";
            this.lblErrorInformation.Size = new System.Drawing.Size(323, 20);
            this.lblErrorInformation.TabIndex = 1;
            this.lblErrorInformation.Text = "Something ocurr when the page was loaded.";
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.Controls.Add(this.lblErrorInformation);
            this.Controls.Add(this.picBoxErrorImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorForm";
            this.Text = "ErrorForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxErrorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxErrorImage;
        private System.Windows.Forms.Label lblErrorInformation;
    }
}