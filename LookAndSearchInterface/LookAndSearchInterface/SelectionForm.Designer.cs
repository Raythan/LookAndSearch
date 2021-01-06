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
            this.picBoxAdSenseLogo = new System.Windows.Forms.PictureBox();
            this.linkLblOtServerAdSense = new System.Windows.Forms.LinkLabel();
            this.lblUrlStoreServer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSelectionFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSelectionAdSense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdSenseLogo)).BeginInit();
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
            // picBoxAdSenseLogo
            // 
            this.picBoxAdSenseLogo.Location = new System.Drawing.Point(12, 281);
            this.picBoxAdSenseLogo.Name = "picBoxAdSenseLogo";
            this.picBoxAdSenseLogo.Size = new System.Drawing.Size(170, 175);
            this.picBoxAdSenseLogo.TabIndex = 4;
            this.picBoxAdSenseLogo.TabStop = false;
            // 
            // linkLblOtServerAdSense
            // 
            this.linkLblOtServerAdSense.AutoSize = true;
            this.linkLblOtServerAdSense.Location = new System.Drawing.Point(188, 281);
            this.linkLblOtServerAdSense.Name = "linkLblOtServerAdSense";
            this.linkLblOtServerAdSense.Size = new System.Drawing.Size(118, 13);
            this.linkLblOtServerAdSense.TabIndex = 5;
            this.linkLblOtServerAdSense.TabStop = true;
            this.linkLblOtServerAdSense.Text = "Ot Server Patrocinador.";
            this.linkLblOtServerAdSense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblOtServerAdSense_LinkClicked);
            // 
            // lblUrlStoreServer
            // 
            this.lblUrlStoreServer.AutoSize = true;
            this.lblUrlStoreServer.Location = new System.Drawing.Point(188, 294);
            this.lblUrlStoreServer.Name = "lblUrlStoreServer";
            this.lblUrlStoreServer.Size = new System.Drawing.Size(121, 13);
            this.lblUrlStoreServer.TabIndex = 6;
            this.lblUrlStoreServer.Text = "LabelStoringOtServerUrl";
            this.lblUrlStoreServer.Visible = false;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.Controls.Add(this.lblUrlStoreServer);
            this.Controls.Add(this.linkLblOtServerAdSense);
            this.Controls.Add(this.picBoxAdSenseLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxSelectionAdSense);
            this.Controls.Add(this.lblStartSelectForm);
            this.Controls.Add(this.picBoxSelectionFace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectionForm";
            this.Text = "SelectionForm";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSelectionFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSelectionAdSense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdSenseLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxSelectionFace;
        private System.Windows.Forms.Label lblStartSelectForm;
        private System.Windows.Forms.PictureBox picBoxSelectionAdSense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxAdSenseLogo;
        private System.Windows.Forms.LinkLabel linkLblOtServerAdSense;
        private System.Windows.Forms.Label lblUrlStoreServer;
    }
}