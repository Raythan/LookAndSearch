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
            this.picBoxSelectionFace = new System.Windows.Forms.PictureBox();
            this.lblStartSelectForm = new System.Windows.Forms.Label();
            this.picBoxSelectionAdSense = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSelectionFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSelectionAdSense)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxSelectionFace
            // 
            this.picBoxSelectionFace.Location = new System.Drawing.Point(12, 25);
            this.picBoxSelectionFace.Name = "picBoxSelectionFace";
            this.picBoxSelectionFace.Size = new System.Drawing.Size(250, 250);
            this.picBoxSelectionFace.TabIndex = 0;
            this.picBoxSelectionFace.TabStop = false;
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
            // picBoxSelectionAdSense
            // 
            this.picBoxSelectionAdSense.Location = new System.Drawing.Point(268, 25);
            this.picBoxSelectionAdSense.Name = "picBoxSelectionAdSense";
            this.picBoxSelectionAdSense.Size = new System.Drawing.Size(250, 250);
            this.picBoxSelectionAdSense.TabIndex = 2;
            this.picBoxSelectionAdSense.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Esta aplicação é patrocinada por:";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxSelectionAdSense);
            this.Controls.Add(this.lblStartSelectForm);
            this.Controls.Add(this.picBoxSelectionFace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectionForm";
            this.Text = "SelectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSelectionFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSelectionAdSense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxSelectionFace;
        private System.Windows.Forms.Label lblStartSelectForm;
        private System.Windows.Forms.PictureBox picBoxSelectionAdSense;
        private System.Windows.Forms.Label label1;
    }
}