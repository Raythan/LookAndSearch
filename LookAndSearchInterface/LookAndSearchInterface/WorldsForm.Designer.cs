namespace LookAndSearchInterface
{
    partial class WorldsForm
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
            this.lblWorldOverview = new System.Windows.Forms.Label();
            this.picBoxBattleEye = new System.Windows.Forms.PictureBox();
            this.cboBoxWorldNames = new System.Windows.Forms.ComboBox();
            this.lblOnline = new System.Windows.Forms.Label();
            this.txtBoxOnline = new System.Windows.Forms.TextBox();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtBoxPvpType = new System.Windows.Forms.TextBox();
            this.lblPvpType = new System.Windows.Forms.Label();
            this.lblBattleEye = new System.Windows.Forms.Label();
            this.txtBoxAdditionalInformation = new System.Windows.Forms.TextBox();
            this.lblAdditionalInformation = new System.Windows.Forms.Label();
            this.lblHoraUltimaAtualizacao = new System.Windows.Forms.Label();
            this.btnRefreshWorldDictionary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBattleEye)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWorldOverview
            // 
            this.lblWorldOverview.AutoSize = true;
            this.lblWorldOverview.Location = new System.Drawing.Point(12, 9);
            this.lblWorldOverview.Name = "lblWorldOverview";
            this.lblWorldOverview.Size = new System.Drawing.Size(114, 13);
            this.lblWorldOverview.TabIndex = 0;
            this.lblWorldOverview.Text = "Game World Overview";
            // 
            // picBoxBattleEye
            // 
            this.picBoxBattleEye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxBattleEye.ImageLocation = "";
            this.picBoxBattleEye.Location = new System.Drawing.Point(123, 133);
            this.picBoxBattleEye.Name = "picBoxBattleEye";
            this.picBoxBattleEye.Size = new System.Drawing.Size(18, 18);
            this.picBoxBattleEye.TabIndex = 2;
            this.picBoxBattleEye.TabStop = false;
            // 
            // cboBoxWorldNames
            // 
            this.cboBoxWorldNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxWorldNames.FormattingEnabled = true;
            this.cboBoxWorldNames.Location = new System.Drawing.Point(12, 25);
            this.cboBoxWorldNames.Name = "cboBoxWorldNames";
            this.cboBoxWorldNames.Size = new System.Drawing.Size(208, 21);
            this.cboBoxWorldNames.TabIndex = 3;
            this.cboBoxWorldNames.SelectedIndexChanged += new System.EventHandler(this.cboBoxWorldNames_SelectedIndexChanged);
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Location = new System.Drawing.Point(9, 56);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(37, 13);
            this.lblOnline.TabIndex = 4;
            this.lblOnline.Text = "Online";
            // 
            // txtBoxOnline
            // 
            this.txtBoxOnline.Location = new System.Drawing.Point(123, 53);
            this.txtBoxOnline.Name = "txtBoxOnline";
            this.txtBoxOnline.ReadOnly = true;
            this.txtBoxOnline.Size = new System.Drawing.Size(170, 20);
            this.txtBoxOnline.TabIndex = 5;
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Location = new System.Drawing.Point(123, 79);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.ReadOnly = true;
            this.txtBoxLocation.Size = new System.Drawing.Size(170, 20);
            this.txtBoxLocation.TabIndex = 7;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(9, 82);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "Location";
            // 
            // txtBoxPvpType
            // 
            this.txtBoxPvpType.Location = new System.Drawing.Point(123, 105);
            this.txtBoxPvpType.Name = "txtBoxPvpType";
            this.txtBoxPvpType.ReadOnly = true;
            this.txtBoxPvpType.Size = new System.Drawing.Size(170, 20);
            this.txtBoxPvpType.TabIndex = 9;
            // 
            // lblPvpType
            // 
            this.lblPvpType.AutoSize = true;
            this.lblPvpType.Location = new System.Drawing.Point(9, 108);
            this.lblPvpType.Name = "lblPvpType";
            this.lblPvpType.Size = new System.Drawing.Size(53, 13);
            this.lblPvpType.TabIndex = 8;
            this.lblPvpType.Text = "Pvp Type";
            // 
            // lblBattleEye
            // 
            this.lblBattleEye.AutoSize = true;
            this.lblBattleEye.Location = new System.Drawing.Point(9, 134);
            this.lblBattleEye.Name = "lblBattleEye";
            this.lblBattleEye.Size = new System.Drawing.Size(55, 13);
            this.lblBattleEye.TabIndex = 10;
            this.lblBattleEye.Text = "Battle Eye";
            // 
            // txtBoxAdditionalInformation
            // 
            this.txtBoxAdditionalInformation.Location = new System.Drawing.Point(123, 157);
            this.txtBoxAdditionalInformation.Name = "txtBoxAdditionalInformation";
            this.txtBoxAdditionalInformation.ReadOnly = true;
            this.txtBoxAdditionalInformation.Size = new System.Drawing.Size(170, 20);
            this.txtBoxAdditionalInformation.TabIndex = 13;
            // 
            // lblAdditionalInformation
            // 
            this.lblAdditionalInformation.AutoSize = true;
            this.lblAdditionalInformation.Location = new System.Drawing.Point(9, 160);
            this.lblAdditionalInformation.Name = "lblAdditionalInformation";
            this.lblAdditionalInformation.Size = new System.Drawing.Size(108, 13);
            this.lblAdditionalInformation.TabIndex = 12;
            this.lblAdditionalInformation.Text = "Additional Information";
            // 
            // lblHoraUltimaAtualizacao
            // 
            this.lblHoraUltimaAtualizacao.AutoSize = true;
            this.lblHoraUltimaAtualizacao.Location = new System.Drawing.Point(12, 488);
            this.lblHoraUltimaAtualizacao.Name = "lblHoraUltimaAtualizacao";
            this.lblHoraUltimaAtualizacao.Size = new System.Drawing.Size(176, 13);
            this.lblHoraUltimaAtualizacao.TabIndex = 14;
            this.lblHoraUltimaAtualizacao.Text = "Last time updated: Not updated yet!";
            // 
            // btnRefreshWorldDictionary
            // 
            this.btnRefreshWorldDictionary.Location = new System.Drawing.Point(12, 186);
            this.btnRefreshWorldDictionary.Name = "btnRefreshWorldDictionary";
            this.btnRefreshWorldDictionary.Size = new System.Drawing.Size(281, 40);
            this.btnRefreshWorldDictionary.TabIndex = 15;
            this.btnRefreshWorldDictionary.Text = "Refresh";
            this.btnRefreshWorldDictionary.UseVisualStyleBackColor = true;
            this.btnRefreshWorldDictionary.Click += new System.EventHandler(this.btnRefreshWorldDictionary_Click);
            // 
            // WorldsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefreshWorldDictionary);
            this.Controls.Add(this.lblHoraUltimaAtualizacao);
            this.Controls.Add(this.txtBoxAdditionalInformation);
            this.Controls.Add(this.lblAdditionalInformation);
            this.Controls.Add(this.lblBattleEye);
            this.Controls.Add(this.txtBoxPvpType);
            this.Controls.Add(this.lblPvpType);
            this.Controls.Add(this.txtBoxLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtBoxOnline);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.cboBoxWorldNames);
            this.Controls.Add(this.picBoxBattleEye);
            this.Controls.Add(this.lblWorldOverview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorldsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Worlds";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBattleEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWorldOverview;
        private System.Windows.Forms.PictureBox picBoxBattleEye;
        private System.Windows.Forms.ComboBox cboBoxWorldNames;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.TextBox txtBoxOnline;
        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtBoxPvpType;
        private System.Windows.Forms.Label lblPvpType;
        private System.Windows.Forms.Label lblBattleEye;
        private System.Windows.Forms.TextBox txtBoxAdditionalInformation;
        private System.Windows.Forms.Label lblAdditionalInformation;
        private System.Windows.Forms.Label lblHoraUltimaAtualizacao;
        private System.Windows.Forms.Button btnRefreshWorldDictionary;
    }
}