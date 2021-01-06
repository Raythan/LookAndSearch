namespace LookAndSearchInterface
{
    partial class BazaarForm
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
            this.cboBoxWorldFilter = new System.Windows.Forms.ComboBox();
            this.lblBazaarTitle = new System.Windows.Forms.Label();
            this.lblDtaAtualizacaoBazaar = new System.Windows.Forms.Label();
            this.cboBoxVocationFilter = new System.Windows.Forms.ComboBox();
            this.numUpDownBidMaxFilter = new System.Windows.Forms.NumericUpDown();
            this.lblBidMaxFilter = new System.Windows.Forms.Label();
            this.lstBoxCharacterNamesValues = new System.Windows.Forms.ListBox();
            this.chkBoxIsBiddedFilter = new System.Windows.Forms.CheckBox();
            this.lblLevelFilter = new System.Windows.Forms.Label();
            this.numUpDownLevelFilter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateBazaar = new System.Windows.Forms.Button();
            this.grpBoxBazaarEntityStatus = new System.Windows.Forms.GroupBox();
            this.lblBazaarEntityLevelValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityLevelTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityGenderTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityGenderValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityCurrMinBidTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityCurrMinBidValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityUrlAuctionTag = new System.Windows.Forms.LinkLabel();
            this.lblStoreUrlAuctionValueDisabled = new System.Windows.Forms.Label();
            this.lblBazaarEntityStartedAuctionTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityStartedAuctionValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityEndAuctionValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityEndAuctionTag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBidMaxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLevelFilter)).BeginInit();
            this.grpBoxBazaarEntityStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboBoxWorldFilter
            // 
            this.cboBoxWorldFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxWorldFilter.FormattingEnabled = true;
            this.cboBoxWorldFilter.Location = new System.Drawing.Point(12, 25);
            this.cboBoxWorldFilter.Name = "cboBoxWorldFilter";
            this.cboBoxWorldFilter.Size = new System.Drawing.Size(121, 21);
            this.cboBoxWorldFilter.TabIndex = 0;
            this.cboBoxWorldFilter.SelectedIndexChanged += new System.EventHandler(this.cboBoxWorldFilter_SelectedIndexChanged);
            // 
            // lblBazaarTitle
            // 
            this.lblBazaarTitle.AutoSize = true;
            this.lblBazaarTitle.Location = new System.Drawing.Point(12, 9);
            this.lblBazaarTitle.Name = "lblBazaarTitle";
            this.lblBazaarTitle.Size = new System.Drawing.Size(74, 13);
            this.lblBazaarTitle.TabIndex = 1;
            this.lblBazaarTitle.Text = "Bazaar Check";
            // 
            // lblDtaAtualizacaoBazaar
            // 
            this.lblDtaAtualizacaoBazaar.AutoSize = true;
            this.lblDtaAtualizacaoBazaar.Location = new System.Drawing.Point(9, 488);
            this.lblDtaAtualizacaoBazaar.Name = "lblDtaAtualizacaoBazaar";
            this.lblDtaAtualizacaoBazaar.Size = new System.Drawing.Size(138, 13);
            this.lblDtaAtualizacaoBazaar.TabIndex = 2;
            this.lblDtaAtualizacaoBazaar.Text = "Data da última atualização: ";
            // 
            // cboBoxVocationFilter
            // 
            this.cboBoxVocationFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxVocationFilter.FormattingEnabled = true;
            this.cboBoxVocationFilter.Location = new System.Drawing.Point(12, 52);
            this.cboBoxVocationFilter.Name = "cboBoxVocationFilter";
            this.cboBoxVocationFilter.Size = new System.Drawing.Size(121, 21);
            this.cboBoxVocationFilter.TabIndex = 4;
            this.cboBoxVocationFilter.SelectedIndexChanged += new System.EventHandler(this.cboBoxVocationFilter_SelectedIndexChanged);
            // 
            // numUpDownBidMaxFilter
            // 
            this.numUpDownBidMaxFilter.Location = new System.Drawing.Point(12, 92);
            this.numUpDownBidMaxFilter.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numUpDownBidMaxFilter.Name = "numUpDownBidMaxFilter";
            this.numUpDownBidMaxFilter.Size = new System.Drawing.Size(120, 20);
            this.numUpDownBidMaxFilter.TabIndex = 5;
            this.numUpDownBidMaxFilter.ValueChanged += new System.EventHandler(this.numUpDownBidMaxFilter_ValueChanged);
            // 
            // lblBidMaxFilter
            // 
            this.lblBidMaxFilter.AutoSize = true;
            this.lblBidMaxFilter.Location = new System.Drawing.Point(9, 76);
            this.lblBidMaxFilter.Name = "lblBidMaxFilter";
            this.lblBidMaxFilter.Size = new System.Drawing.Size(48, 13);
            this.lblBidMaxFilter.TabIndex = 6;
            this.lblBidMaxFilter.Text = "Max. Bid";
            // 
            // lstBoxCharacterNamesValues
            // 
            this.lstBoxCharacterNamesValues.FormattingEnabled = true;
            this.lstBoxCharacterNamesValues.Location = new System.Drawing.Point(139, 25);
            this.lstBoxCharacterNamesValues.Name = "lstBoxCharacterNamesValues";
            this.lstBoxCharacterNamesValues.Size = new System.Drawing.Size(220, 212);
            this.lstBoxCharacterNamesValues.TabIndex = 7;
            this.lstBoxCharacterNamesValues.SelectedIndexChanged += new System.EventHandler(this.lstBoxCharacterNamesValues_SelectedIndexChanged);
            // 
            // chkBoxIsBiddedFilter
            // 
            this.chkBoxIsBiddedFilter.AutoSize = true;
            this.chkBoxIsBiddedFilter.Location = new System.Drawing.Point(15, 118);
            this.chkBoxIsBiddedFilter.Name = "chkBoxIsBiddedFilter";
            this.chkBoxIsBiddedFilter.Size = new System.Drawing.Size(118, 17);
            this.chkBoxIsBiddedFilter.TabIndex = 9;
            this.chkBoxIsBiddedFilter.Text = "Only Not Auctioned";
            this.chkBoxIsBiddedFilter.UseVisualStyleBackColor = true;
            this.chkBoxIsBiddedFilter.CheckedChanged += new System.EventHandler(this.chkBoxIsBiddedFilter_CheckedChanged);
            // 
            // lblLevelFilter
            // 
            this.lblLevelFilter.AutoSize = true;
            this.lblLevelFilter.Location = new System.Drawing.Point(12, 138);
            this.lblLevelFilter.Name = "lblLevelFilter";
            this.lblLevelFilter.Size = new System.Drawing.Size(56, 13);
            this.lblLevelFilter.TabIndex = 10;
            this.lblLevelFilter.Text = "Min. Level";
            // 
            // numUpDownLevelFilter
            // 
            this.numUpDownLevelFilter.Location = new System.Drawing.Point(13, 154);
            this.numUpDownLevelFilter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDownLevelFilter.Name = "numUpDownLevelFilter";
            this.numUpDownLevelFilter.Size = new System.Drawing.Size(120, 20);
            this.numUpDownLevelFilter.TabIndex = 11;
            this.numUpDownLevelFilter.ValueChanged += new System.EventHandler(this.numUpDownLevelFilter_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Character names, ordered by End Auction.";
            // 
            // btnUpdateBazaar
            // 
            this.btnUpdateBazaar.Location = new System.Drawing.Point(12, 180);
            this.btnUpdateBazaar.Name = "btnUpdateBazaar";
            this.btnUpdateBazaar.Size = new System.Drawing.Size(120, 57);
            this.btnUpdateBazaar.TabIndex = 13;
            this.btnUpdateBazaar.Text = "Refresh";
            this.btnUpdateBazaar.UseVisualStyleBackColor = true;
            this.btnUpdateBazaar.Click += new System.EventHandler(this.btnUpdateBazaar_Click);
            // 
            // grpBoxBazaarEntityStatus
            // 
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityEndAuctionValue);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityEndAuctionTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityStartedAuctionValue);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityStartedAuctionTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblStoreUrlAuctionValueDisabled);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityUrlAuctionTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityCurrMinBidValue);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityCurrMinBidTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityGenderValue);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityGenderTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityLevelTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityLevelValue);
            this.grpBoxBazaarEntityStatus.Location = new System.Drawing.Point(365, 12);
            this.grpBoxBazaarEntityStatus.Name = "grpBoxBazaarEntityStatus";
            this.grpBoxBazaarEntityStatus.Size = new System.Drawing.Size(183, 225);
            this.grpBoxBazaarEntityStatus.TabIndex = 14;
            this.grpBoxBazaarEntityStatus.TabStop = false;
            this.grpBoxBazaarEntityStatus.Text = "Status Info";
            this.grpBoxBazaarEntityStatus.Visible = false;
            // 
            // lblBazaarEntityLevelValue
            // 
            this.lblBazaarEntityLevelValue.AutoSize = true;
            this.lblBazaarEntityLevelValue.Location = new System.Drawing.Point(77, 21);
            this.lblBazaarEntityLevelValue.Name = "lblBazaarEntityLevelValue";
            this.lblBazaarEntityLevelValue.Size = new System.Drawing.Size(90, 13);
            this.lblBazaarEntityLevelValue.TabIndex = 0;
            this.lblBazaarEntityLevelValue.Text = "LevelStatusValue";
            // 
            // lblBazaarEntityLevelTag
            // 
            this.lblBazaarEntityLevelTag.AutoSize = true;
            this.lblBazaarEntityLevelTag.Location = new System.Drawing.Point(6, 21);
            this.lblBazaarEntityLevelTag.Name = "lblBazaarEntityLevelTag";
            this.lblBazaarEntityLevelTag.Size = new System.Drawing.Size(36, 13);
            this.lblBazaarEntityLevelTag.TabIndex = 1;
            this.lblBazaarEntityLevelTag.Text = "Level:";
            // 
            // lblBazaarEntityGenderTag
            // 
            this.lblBazaarEntityGenderTag.AutoSize = true;
            this.lblBazaarEntityGenderTag.Location = new System.Drawing.Point(6, 34);
            this.lblBazaarEntityGenderTag.Name = "lblBazaarEntityGenderTag";
            this.lblBazaarEntityGenderTag.Size = new System.Drawing.Size(45, 13);
            this.lblBazaarEntityGenderTag.TabIndex = 2;
            this.lblBazaarEntityGenderTag.Text = "Gender:";
            // 
            // lblBazaarEntityGenderValue
            // 
            this.lblBazaarEntityGenderValue.AutoSize = true;
            this.lblBazaarEntityGenderValue.Location = new System.Drawing.Point(77, 34);
            this.lblBazaarEntityGenderValue.Name = "lblBazaarEntityGenderValue";
            this.lblBazaarEntityGenderValue.Size = new System.Drawing.Size(99, 13);
            this.lblBazaarEntityGenderValue.TabIndex = 3;
            this.lblBazaarEntityGenderValue.Text = "GenderStatusValue";
            // 
            // lblBazaarEntityCurrMinBidTag
            // 
            this.lblBazaarEntityCurrMinBidTag.AutoSize = true;
            this.lblBazaarEntityCurrMinBidTag.Location = new System.Drawing.Point(6, 48);
            this.lblBazaarEntityCurrMinBidTag.Name = "lblBazaarEntityCurrMinBidTag";
            this.lblBazaarEntityCurrMinBidTag.Size = new System.Drawing.Size(69, 13);
            this.lblBazaarEntityCurrMinBidTag.TabIndex = 4;
            this.lblBazaarEntityCurrMinBidTag.Text = "Curr/Min Bid:";
            // 
            // lblBazaarEntityCurrMinBidValue
            // 
            this.lblBazaarEntityCurrMinBidValue.AutoSize = true;
            this.lblBazaarEntityCurrMinBidValue.Location = new System.Drawing.Point(77, 48);
            this.lblBazaarEntityCurrMinBidValue.Name = "lblBazaarEntityCurrMinBidValue";
            this.lblBazaarEntityCurrMinBidValue.Size = new System.Drawing.Size(85, 13);
            this.lblBazaarEntityCurrMinBidValue.TabIndex = 5;
            this.lblBazaarEntityCurrMinBidValue.Text = "CurrMinBidValue";
            // 
            // lblBazaarEntityUrlAuctionTag
            // 
            this.lblBazaarEntityUrlAuctionTag.AutoSize = true;
            this.lblBazaarEntityUrlAuctionTag.Location = new System.Drawing.Point(6, 196);
            this.lblBazaarEntityUrlAuctionTag.Name = "lblBazaarEntityUrlAuctionTag";
            this.lblBazaarEntityUrlAuctionTag.Size = new System.Drawing.Size(144, 13);
            this.lblBazaarEntityUrlAuctionTag.TabIndex = 6;
            this.lblBazaarEntityUrlAuctionTag.TabStop = true;
            this.lblBazaarEntityUrlAuctionTag.Text = "Offer an Auction on tibia.com";
            this.lblBazaarEntityUrlAuctionTag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBazaarEntityUrlAuctionTag_LinkClicked);
            // 
            // lblStoreUrlAuctionValueDisabled
            // 
            this.lblStoreUrlAuctionValueDisabled.AutoSize = true;
            this.lblStoreUrlAuctionValueDisabled.Location = new System.Drawing.Point(6, 209);
            this.lblStoreUrlAuctionValueDisabled.Name = "lblStoreUrlAuctionValueDisabled";
            this.lblStoreUrlAuctionValueDisabled.Size = new System.Drawing.Size(139, 13);
            this.lblStoreUrlAuctionValueDisabled.TabIndex = 7;
            this.lblStoreUrlAuctionValueDisabled.Text = "LabelStoreUrlValueDisabled";
            this.lblStoreUrlAuctionValueDisabled.Visible = false;
            // 
            // lblBazaarEntityStartedAuctionTag
            // 
            this.lblBazaarEntityStartedAuctionTag.AutoSize = true;
            this.lblBazaarEntityStartedAuctionTag.Location = new System.Drawing.Point(6, 64);
            this.lblBazaarEntityStartedAuctionTag.Name = "lblBazaarEntityStartedAuctionTag";
            this.lblBazaarEntityStartedAuctionTag.Size = new System.Drawing.Size(83, 13);
            this.lblBazaarEntityStartedAuctionTag.TabIndex = 8;
            this.lblBazaarEntityStartedAuctionTag.Text = "Started Auction:";
            // 
            // lblBazaarEntityStartedAuctionValue
            // 
            this.lblBazaarEntityStartedAuctionValue.AutoSize = true;
            this.lblBazaarEntityStartedAuctionValue.Location = new System.Drawing.Point(41, 81);
            this.lblBazaarEntityStartedAuctionValue.Name = "lblBazaarEntityStartedAuctionValue";
            this.lblBazaarEntityStartedAuctionValue.Size = new System.Drawing.Size(104, 13);
            this.lblBazaarEntityStartedAuctionValue.TabIndex = 9;
            this.lblBazaarEntityStartedAuctionValue.Text = "StartedAuctionValue";
            // 
            // lblBazaarEntityEndAuctionValue
            // 
            this.lblBazaarEntityEndAuctionValue.AutoSize = true;
            this.lblBazaarEntityEndAuctionValue.Location = new System.Drawing.Point(41, 107);
            this.lblBazaarEntityEndAuctionValue.Name = "lblBazaarEntityEndAuctionValue";
            this.lblBazaarEntityEndAuctionValue.Size = new System.Drawing.Size(89, 13);
            this.lblBazaarEntityEndAuctionValue.TabIndex = 11;
            this.lblBazaarEntityEndAuctionValue.Text = "EndAuctionValue";
            // 
            // lblBazaarEntityEndAuctionTag
            // 
            this.lblBazaarEntityEndAuctionTag.AutoSize = true;
            this.lblBazaarEntityEndAuctionTag.Location = new System.Drawing.Point(6, 94);
            this.lblBazaarEntityEndAuctionTag.Name = "lblBazaarEntityEndAuctionTag";
            this.lblBazaarEntityEndAuctionTag.Size = new System.Drawing.Size(68, 13);
            this.lblBazaarEntityEndAuctionTag.TabIndex = 10;
            this.lblBazaarEntityEndAuctionTag.Text = "End Auction:";
            // 
            // BazaarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.Controls.Add(this.grpBoxBazaarEntityStatus);
            this.Controls.Add(this.btnUpdateBazaar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDownLevelFilter);
            this.Controls.Add(this.lblLevelFilter);
            this.Controls.Add(this.chkBoxIsBiddedFilter);
            this.Controls.Add(this.lstBoxCharacterNamesValues);
            this.Controls.Add(this.lblBidMaxFilter);
            this.Controls.Add(this.numUpDownBidMaxFilter);
            this.Controls.Add(this.cboBoxVocationFilter);
            this.Controls.Add(this.lblDtaAtualizacaoBazaar);
            this.Controls.Add(this.lblBazaarTitle);
            this.Controls.Add(this.cboBoxWorldFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BazaarForm";
            this.Text = "BazaarForm";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBidMaxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLevelFilter)).EndInit();
            this.grpBoxBazaarEntityStatus.ResumeLayout(false);
            this.grpBoxBazaarEntityStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBoxWorldFilter;
        private System.Windows.Forms.Label lblBazaarTitle;
        private System.Windows.Forms.Label lblDtaAtualizacaoBazaar;
        private System.Windows.Forms.ComboBox cboBoxVocationFilter;
        private System.Windows.Forms.NumericUpDown numUpDownBidMaxFilter;
        private System.Windows.Forms.Label lblBidMaxFilter;
        private System.Windows.Forms.ListBox lstBoxCharacterNamesValues;
        private System.Windows.Forms.CheckBox chkBoxIsBiddedFilter;
        private System.Windows.Forms.Label lblLevelFilter;
        private System.Windows.Forms.NumericUpDown numUpDownLevelFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateBazaar;
        private System.Windows.Forms.GroupBox grpBoxBazaarEntityStatus;
        private System.Windows.Forms.Label lblBazaarEntityLevelTag;
        private System.Windows.Forms.Label lblBazaarEntityLevelValue;
        private System.Windows.Forms.Label lblBazaarEntityGenderValue;
        private System.Windows.Forms.Label lblBazaarEntityGenderTag;
        private System.Windows.Forms.Label lblBazaarEntityCurrMinBidValue;
        private System.Windows.Forms.Label lblBazaarEntityCurrMinBidTag;
        private System.Windows.Forms.Label lblStoreUrlAuctionValueDisabled;
        private System.Windows.Forms.LinkLabel lblBazaarEntityUrlAuctionTag;
        private System.Windows.Forms.Label lblBazaarEntityEndAuctionValue;
        private System.Windows.Forms.Label lblBazaarEntityEndAuctionTag;
        private System.Windows.Forms.Label lblBazaarEntityStartedAuctionValue;
        private System.Windows.Forms.Label lblBazaarEntityStartedAuctionTag;
    }
}