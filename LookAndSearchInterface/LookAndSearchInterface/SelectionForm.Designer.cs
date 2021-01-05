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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSelectionForm)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxSelectionForm
            // 
            this.picBoxSelectionForm.Location = new System.Drawing.Point(12, 25);
            this.picBoxSelectionForm.Name = "picBoxSelectionForm";
            this.picBoxSelectionForm.Size = new System.Drawing.Size(536, 273);
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
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 310);
            this.Controls.Add(this.lblStartSelectForm);
            this.Controls.Add(this.picBoxSelectionForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectionForm";
            this.Text = "SelectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSelectionForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxSelectionForm;
        private System.Windows.Forms.Label lblStartSelectForm;
    }
}