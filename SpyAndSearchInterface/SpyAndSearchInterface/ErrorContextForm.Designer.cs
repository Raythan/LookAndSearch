namespace SpyAndSearchInterface
{
    partial class ErrorContextForm
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
            this.txtBoxErrorForm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxErrorForm
            // 
            this.txtBoxErrorForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxErrorForm.Location = new System.Drawing.Point(12, 12);
            this.txtBoxErrorForm.Multiline = true;
            this.txtBoxErrorForm.Name = "txtBoxErrorForm";
            this.txtBoxErrorForm.ReadOnly = true;
            this.txtBoxErrorForm.Size = new System.Drawing.Size(536, 286);
            this.txtBoxErrorForm.TabIndex = 0;
            this.txtBoxErrorForm.Text = "Erro no momento da consulta, por favor tente mais tarde.";
            // 
            // ErrorContextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 310);
            this.Controls.Add(this.txtBoxErrorForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorContextForm";
            this.Text = "ErrorContextForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxErrorForm;
    }
}