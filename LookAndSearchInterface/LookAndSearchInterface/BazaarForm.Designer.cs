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
            this.lblBazaarTitle = new System.Windows.Forms.Label();
            this.lblDtaAtualizacaoBazaar = new System.Windows.Forms.Label();
            this.numUpDownBidMaxFilter = new System.Windows.Forms.NumericUpDown();
            this.lblBidMaxFilter = new System.Windows.Forms.Label();
            this.lstBoxCharacterNamesValues = new System.Windows.Forms.ListBox();
            this.chkBoxIsBiddedFilter = new System.Windows.Forms.CheckBox();
            this.lblLevelFilter = new System.Windows.Forms.Label();
            this.numUpDownLevelFilter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateBazaar = new System.Windows.Forms.Button();
            this.grpBoxBazaarEntityStatus = new System.Windows.Forms.GroupBox();
            this.lblBazaarEntityWorldValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityWorldTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityEndAuctionValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityEndAuctionTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityStartedAuctionValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityStartedAuctionTag = new System.Windows.Forms.Label();
            this.lblStoreUrlAuctionValueDisabled = new System.Windows.Forms.Label();
            this.lblBazaarEntityUrlAuctionTag = new System.Windows.Forms.LinkLabel();
            this.lblBazaarEntityCurrMinBidValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityCurrMinBidTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityGenderValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityGenderTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityLevelTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityLevelValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityUrlStatusTag = new System.Windows.Forms.LinkLabel();
            this.prgBarBazaarLoadingInfo = new System.Windows.Forms.ProgressBar();
            this.chkLstBoxWorldFilter = new System.Windows.Forms.CheckedListBox();
            this.chkLstBoxVocationFilter = new System.Windows.Forms.CheckedListBox();
            this.btnBazaarAppleFilter = new System.Windows.Forms.Button();
            this.chkLstBoxPvpTypeFilter = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBidMaxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLevelFilter)).BeginInit();
            this.grpBoxBazaarEntityStatus.SuspendLayout();
            this.SuspendLayout();
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
            this.lblDtaAtualizacaoBazaar.Location = new System.Drawing.Point(10, 472);
            this.lblDtaAtualizacaoBazaar.Name = "lblDtaAtualizacaoBazaar";
            this.lblDtaAtualizacaoBazaar.Size = new System.Drawing.Size(176, 13);
            this.lblDtaAtualizacaoBazaar.TabIndex = 2;
            this.lblDtaAtualizacaoBazaar.Text = "Last time updated: Not updated yet!";
            // 
            // numUpDownBidMaxFilter
            // 
            this.numUpDownBidMaxFilter.Location = new System.Drawing.Point(141, 256);
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
            this.lblBidMaxFilter.Location = new System.Drawing.Point(138, 240);
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
            this.lstBoxCharacterNamesValues.Size = new System.Drawing.Size(207, 212);
            this.lstBoxCharacterNamesValues.TabIndex = 7;
            this.lstBoxCharacterNamesValues.SelectedIndexChanged += new System.EventHandler(this.lstBoxCharacterNamesValues_SelectedIndexChanged);
            // 
            // chkBoxIsBiddedFilter
            // 
            this.chkBoxIsBiddedFilter.AutoSize = true;
            this.chkBoxIsBiddedFilter.Location = new System.Drawing.Point(141, 321);
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
            this.lblLevelFilter.Location = new System.Drawing.Point(140, 279);
            this.lblLevelFilter.Name = "lblLevelFilter";
            this.lblLevelFilter.Size = new System.Drawing.Size(56, 13);
            this.lblLevelFilter.TabIndex = 10;
            this.lblLevelFilter.Text = "Min. Level";
            // 
            // numUpDownLevelFilter
            // 
            this.numUpDownLevelFilter.Location = new System.Drawing.Point(141, 295);
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
            this.btnUpdateBazaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBazaar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnUpdateBazaar.Location = new System.Drawing.Point(269, 344);
            this.btnUpdateBazaar.Name = "btnUpdateBazaar";
            this.btnUpdateBazaar.Size = new System.Drawing.Size(120, 121);
            this.btnUpdateBazaar.TabIndex = 13;
            this.btnUpdateBazaar.Text = "Refresh Data!";
            this.btnUpdateBazaar.UseVisualStyleBackColor = true;
            this.btnUpdateBazaar.Click += new System.EventHandler(this.btnUpdateBazaar_Click);
            // 
            // grpBoxBazaarEntityStatus
            // 
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityUrlStatusTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityWorldValue);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityWorldTag);
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
            this.grpBoxBazaarEntityStatus.Location = new System.Drawing.Point(352, 12);
            this.grpBoxBazaarEntityStatus.Name = "grpBoxBazaarEntityStatus";
            this.grpBoxBazaarEntityStatus.Size = new System.Drawing.Size(196, 225);
            this.grpBoxBazaarEntityStatus.TabIndex = 14;
            this.grpBoxBazaarEntityStatus.TabStop = false;
            this.grpBoxBazaarEntityStatus.Text = "Status Info";
            this.grpBoxBazaarEntityStatus.Visible = false;
            // 
            // lblBazaarEntityWorldValue
            // 
            this.lblBazaarEntityWorldValue.AutoSize = true;
            this.lblBazaarEntityWorldValue.Location = new System.Drawing.Point(77, 120);
            this.lblBazaarEntityWorldValue.Name = "lblBazaarEntityWorldValue";
            this.lblBazaarEntityWorldValue.Size = new System.Drawing.Size(62, 13);
            this.lblBazaarEntityWorldValue.TabIndex = 13;
            this.lblBazaarEntityWorldValue.Text = "WorldValue";
            // 
            // lblBazaarEntityWorldTag
            // 
            this.lblBazaarEntityWorldTag.AutoSize = true;
            this.lblBazaarEntityWorldTag.Location = new System.Drawing.Point(6, 120);
            this.lblBazaarEntityWorldTag.Name = "lblBazaarEntityWorldTag";
            this.lblBazaarEntityWorldTag.Size = new System.Drawing.Size(38, 13);
            this.lblBazaarEntityWorldTag.TabIndex = 12;
            this.lblBazaarEntityWorldTag.Text = "World:";
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
            // lblBazaarEntityStartedAuctionValue
            // 
            this.lblBazaarEntityStartedAuctionValue.AutoSize = true;
            this.lblBazaarEntityStartedAuctionValue.Location = new System.Drawing.Point(41, 81);
            this.lblBazaarEntityStartedAuctionValue.Name = "lblBazaarEntityStartedAuctionValue";
            this.lblBazaarEntityStartedAuctionValue.Size = new System.Drawing.Size(104, 13);
            this.lblBazaarEntityStartedAuctionValue.TabIndex = 9;
            this.lblBazaarEntityStartedAuctionValue.Text = "StartedAuctionValue";
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
            // lblStoreUrlAuctionValueDisabled
            // 
            this.lblStoreUrlAuctionValueDisabled.AutoSize = true;
            this.lblStoreUrlAuctionValueDisabled.Location = new System.Drawing.Point(6, 182);
            this.lblStoreUrlAuctionValueDisabled.Name = "lblStoreUrlAuctionValueDisabled";
            this.lblStoreUrlAuctionValueDisabled.Size = new System.Drawing.Size(139, 13);
            this.lblStoreUrlAuctionValueDisabled.TabIndex = 7;
            this.lblStoreUrlAuctionValueDisabled.Text = "LabelStoreUrlValueDisabled";
            this.lblStoreUrlAuctionValueDisabled.Visible = false;
            // 
            // lblBazaarEntityUrlAuctionTag
            // 
            this.lblBazaarEntityUrlAuctionTag.AutoSize = true;
            this.lblBazaarEntityUrlAuctionTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityUrlAuctionTag.Location = new System.Drawing.Point(6, 165);
            this.lblBazaarEntityUrlAuctionTag.Name = "lblBazaarEntityUrlAuctionTag";
            this.lblBazaarEntityUrlAuctionTag.Size = new System.Drawing.Size(191, 17);
            this.lblBazaarEntityUrlAuctionTag.TabIndex = 6;
            this.lblBazaarEntityUrlAuctionTag.TabStop = true;
            this.lblBazaarEntityUrlAuctionTag.Text = "Offer an Auction on tibia.com";
            this.lblBazaarEntityUrlAuctionTag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBazaarEntityUrlAuctionTag_LinkClicked);
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
            // lblBazaarEntityCurrMinBidTag
            // 
            this.lblBazaarEntityCurrMinBidTag.AutoSize = true;
            this.lblBazaarEntityCurrMinBidTag.Location = new System.Drawing.Point(6, 48);
            this.lblBazaarEntityCurrMinBidTag.Name = "lblBazaarEntityCurrMinBidTag";
            this.lblBazaarEntityCurrMinBidTag.Size = new System.Drawing.Size(69, 13);
            this.lblBazaarEntityCurrMinBidTag.TabIndex = 4;
            this.lblBazaarEntityCurrMinBidTag.Text = "Curr/Min Bid:";
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
            // lblBazaarEntityGenderTag
            // 
            this.lblBazaarEntityGenderTag.AutoSize = true;
            this.lblBazaarEntityGenderTag.Location = new System.Drawing.Point(6, 34);
            this.lblBazaarEntityGenderTag.Name = "lblBazaarEntityGenderTag";
            this.lblBazaarEntityGenderTag.Size = new System.Drawing.Size(45, 13);
            this.lblBazaarEntityGenderTag.TabIndex = 2;
            this.lblBazaarEntityGenderTag.Text = "Gender:";
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
            // lblBazaarEntityLevelValue
            // 
            this.lblBazaarEntityLevelValue.AutoSize = true;
            this.lblBazaarEntityLevelValue.Location = new System.Drawing.Point(77, 21);
            this.lblBazaarEntityLevelValue.Name = "lblBazaarEntityLevelValue";
            this.lblBazaarEntityLevelValue.Size = new System.Drawing.Size(90, 13);
            this.lblBazaarEntityLevelValue.TabIndex = 0;
            this.lblBazaarEntityLevelValue.Text = "LevelStatusValue";
            // 
            // lblBazaarEntityUrlStatusTag
            // 
            this.lblBazaarEntityUrlStatusTag.AutoSize = true;
            this.lblBazaarEntityUrlStatusTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityUrlStatusTag.Location = new System.Drawing.Point(6, 133);
            this.lblBazaarEntityUrlStatusTag.Name = "lblBazaarEntityUrlStatusTag";
            this.lblBazaarEntityUrlStatusTag.Size = new System.Drawing.Size(164, 17);
            this.lblBazaarEntityUrlStatusTag.TabIndex = 14;
            this.lblBazaarEntityUrlStatusTag.TabStop = true;
            this.lblBazaarEntityUrlStatusTag.Text = "Check the specific status";
            this.lblBazaarEntityUrlStatusTag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBazaarEntityUrlStatusTag_LinkClicked);
            // 
            // prgBarBazaarLoadingInfo
            // 
            this.prgBarBazaarLoadingInfo.Location = new System.Drawing.Point(12, 488);
            this.prgBarBazaarLoadingInfo.Name = "prgBarBazaarLoadingInfo";
            this.prgBarBazaarLoadingInfo.Size = new System.Drawing.Size(536, 10);
            this.prgBarBazaarLoadingInfo.TabIndex = 15;
            // 
            // chkLstBoxWorldFilter
            // 
            this.chkLstBoxWorldFilter.FormattingEnabled = true;
            this.chkLstBoxWorldFilter.Location = new System.Drawing.Point(12, 110);
            this.chkLstBoxWorldFilter.Name = "chkLstBoxWorldFilter";
            this.chkLstBoxWorldFilter.Size = new System.Drawing.Size(120, 169);
            this.chkLstBoxWorldFilter.TabIndex = 16;
            // 
            // chkLstBoxVocationFilter
            // 
            this.chkLstBoxVocationFilter.FormattingEnabled = true;
            this.chkLstBoxVocationFilter.Location = new System.Drawing.Point(12, 285);
            this.chkLstBoxVocationFilter.Name = "chkLstBoxVocationFilter";
            this.chkLstBoxVocationFilter.Size = new System.Drawing.Size(120, 79);
            this.chkLstBoxVocationFilter.TabIndex = 17;
            // 
            // btnBazaarAppleFilter
            // 
            this.btnBazaarAppleFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBazaarAppleFilter.ForeColor = System.Drawing.Color.LightCoral;
            this.btnBazaarAppleFilter.Location = new System.Drawing.Point(142, 344);
            this.btnBazaarAppleFilter.Name = "btnBazaarAppleFilter";
            this.btnBazaarAppleFilter.Size = new System.Drawing.Size(121, 121);
            this.btnBazaarAppleFilter.TabIndex = 18;
            this.btnBazaarAppleFilter.Text = "Apply Filter!";
            this.btnBazaarAppleFilter.UseVisualStyleBackColor = true;
            this.btnBazaarAppleFilter.Click += new System.EventHandler(this.btnBazaarAppleFilter_Click);
            // 
            // chkLstBoxPvpTypeFilter
            // 
            this.chkLstBoxPvpTypeFilter.FormattingEnabled = true;
            this.chkLstBoxPvpTypeFilter.Location = new System.Drawing.Point(12, 25);
            this.chkLstBoxPvpTypeFilter.Name = "chkLstBoxPvpTypeFilter";
            this.chkLstBoxPvpTypeFilter.Size = new System.Drawing.Size(120, 79);
            this.chkLstBoxPvpTypeFilter.TabIndex = 19;
            this.chkLstBoxPvpTypeFilter.Leave += new System.EventHandler(this.chkLstBoxPvpTypeFilter_Leave);
            // 
            // BazaarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.Controls.Add(this.chkLstBoxPvpTypeFilter);
            this.Controls.Add(this.btnBazaarAppleFilter);
            this.Controls.Add(this.chkLstBoxVocationFilter);
            this.Controls.Add(this.chkLstBoxWorldFilter);
            this.Controls.Add(this.prgBarBazaarLoadingInfo);
            this.Controls.Add(this.grpBoxBazaarEntityStatus);
            this.Controls.Add(this.btnUpdateBazaar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDownLevelFilter);
            this.Controls.Add(this.lblLevelFilter);
            this.Controls.Add(this.chkBoxIsBiddedFilter);
            this.Controls.Add(this.lstBoxCharacterNamesValues);
            this.Controls.Add(this.lblBidMaxFilter);
            this.Controls.Add(this.numUpDownBidMaxFilter);
            this.Controls.Add(this.lblDtaAtualizacaoBazaar);
            this.Controls.Add(this.lblBazaarTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BazaarForm";
            this.Text = "BazaarForm";
            this.Load += new System.EventHandler(this.BazaarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBidMaxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLevelFilter)).EndInit();
            this.grpBoxBazaarEntityStatus.ResumeLayout(false);
            this.grpBoxBazaarEntityStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBazaarTitle;
        private System.Windows.Forms.Label lblDtaAtualizacaoBazaar;
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
        private System.Windows.Forms.ProgressBar prgBarBazaarLoadingInfo;
        private System.Windows.Forms.Label lblBazaarEntityWorldValue;
        private System.Windows.Forms.Label lblBazaarEntityWorldTag;
        private System.Windows.Forms.CheckedListBox chkLstBoxWorldFilter;
        private System.Windows.Forms.CheckedListBox chkLstBoxVocationFilter;
        private System.Windows.Forms.Button btnBazaarAppleFilter;
        private System.Windows.Forms.CheckedListBox chkLstBoxPvpTypeFilter;
        private System.Windows.Forms.LinkLabel lblBazaarEntityUrlStatusTag;
    }
}