namespace LookAndSearchInterface
{
    partial class SelectionForm
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
            this.picBoxSelectionForm = new System.Windows.Forms.PictureBox();
            this.lblStartSelectForm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSelectionForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxSelectionForm
            // 
            this.picBoxSelectionForm.Location = new System.Drawing.Point(12, 25);
            this.picBoxSelectionForm.Name = "picBoxSelectionForm";
            this.picBoxSelectionForm.Size = new System.Drawing.Size(250, 250);
            this.picBoxSelectionForm.TabIndex = 0;
            this.picBoxSelectionForm.TabStop = false;
            // 
            // lblStartSelectForm
            // 
            this.lblStartSelectForm.AutoSize = true;
            this.lblStartSelectForm.Location = new System.Drawing.Point(12, 9);
            this.lblStartSelectForm.Name = "lblStartSelectForm";
            this.lblStartSelectForm.Size = new System.Drawing.Size(167, 13);
            this.lblStartSelectForm.TabIndex = 1;
            this.lblStartSelectForm.Text = "Selecione uma opção para iniciar!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(268, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStartSelectForm);
            this.Controls.Add(this.picBoxSelectionForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectionForm";
            this.Text = "SelectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSelectionForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxSelectionForm;
        private System.Windows.Forms.Label lblStartSelectForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}