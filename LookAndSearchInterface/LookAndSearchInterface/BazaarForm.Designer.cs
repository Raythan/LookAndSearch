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
            this.lblDteUpdatedBazaar = new System.Windows.Forms.Label();
            this.numUpDownBidMaxFilter = new System.Windows.Forms.NumericUpDown();
            this.lblBidMaxFilter = new System.Windows.Forms.Label();
            this.lstBoxCharacterNamesValues = new System.Windows.Forms.ListBox();
            this.chkBoxIsBiddedFilter = new System.Windows.Forms.CheckBox();
            this.lblMinLevelFilter = new System.Windows.Forms.Label();
            this.numMinLevelFilter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateBazaar = new System.Windows.Forms.Button();
            this.grpBoxBazaarEntityStatus = new System.Windows.Forms.GroupBox();
            this.lblBazaarEntityVocationValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityVocationTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityUrlStatusTag = new System.Windows.Forms.LinkLabel();
            this.lblBazaarEntityWorldValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityWorldTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityEndAuctionValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityEndAuctionTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityStartedAuctionValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityStartedAuctionTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityUrlAuctionTag = new System.Windows.Forms.LinkLabel();
            this.lblBazaarEntityCurrMinBidValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityCurrMinBidTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityGenderValue = new System.Windows.Forms.Label();
            this.lblBazaarEntityGenderTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityLevelTag = new System.Windows.Forms.Label();
            this.lblBazaarEntityLevelValue = new System.Windows.Forms.Label();
            this.lblStoreUrlAuctionValueDisabled = new System.Windows.Forms.Label();
            this.prgBarBazaarLoadingInfo = new System.Windows.Forms.ProgressBar();
            this.chkLstBoxWorldFilter = new System.Windows.Forms.CheckedListBox();
            this.chkLstBoxVocationFilter = new System.Windows.Forms.CheckedListBox();
            this.btnBazaarApplyFilter = new System.Windows.Forms.Button();
            this.chkLstBoxPvpTypeFilter = new System.Windows.Forms.CheckedListBox();
            this.numMaxLevelFilter = new System.Windows.Forms.NumericUpDown();
            this.lblMaxLevelFilter = new System.Windows.Forms.Label();
            this.numMaxSkillFilter = new System.Windows.Forms.NumericUpDown();
            this.lblMaxSkillFilter = new System.Windows.Forms.Label();
            this.numMinSkillFilter = new System.Windows.Forms.NumericUpDown();
            this.lblMinSkillFilter = new System.Windows.Forms.Label();
            this.cboBoxSkillsFilter = new System.Windows.Forms.ComboBox();
            this.dtaGridSkillsPart2Info = new System.Windows.Forms.DataGridView();
            this.grpBoxBazaarEntitySkills = new System.Windows.Forms.GroupBox();
            this.btnResetFields = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBidMaxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLevelFilter)).BeginInit();
            this.grpBoxBazaarEntityStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLevelFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSkillFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinSkillFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridSkillsPart2Info)).BeginInit();
            this.grpBoxBazaarEntitySkills.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBazaarTitle
            // 
            this.lblBazaarTitle.AutoSize = true;
            this.lblBazaarTitle.Location = new System.Drawing.Point(12, 9);
            this.lblBazaarTitle.Name = "lblBazaarTitle";
            this.lblBazaarTitle.Size = new System.Drawing.Size(74, 13);
            this.lblBazaarTitle.TabIndex = 0;
            this.lblBazaarTitle.Text = "Bazaar Check";
            // 
            // lblDteUpdatedBazaar
            // 
            this.lblDteUpdatedBazaar.AutoSize = true;
            this.lblDteUpdatedBazaar.Location = new System.Drawing.Point(10, 472);
            this.lblDteUpdatedBazaar.Name = "lblDteUpdatedBazaar";
            this.lblDteUpdatedBazaar.Size = new System.Drawing.Size(176, 13);
            this.lblDteUpdatedBazaar.TabIndex = 21;
            this.lblDteUpdatedBazaar.Text = "Last time updated: Not updated yet!";
            // 
            // numUpDownBidMaxFilter
            // 
            this.numUpDownBidMaxFilter.Enabled = false;
            this.numUpDownBidMaxFilter.Location = new System.Drawing.Point(139, 259);
            this.numUpDownBidMaxFilter.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numUpDownBidMaxFilter.Name = "numUpDownBidMaxFilter";
            this.numUpDownBidMaxFilter.Size = new System.Drawing.Size(75, 20);
            this.numUpDownBidMaxFilter.TabIndex = 7;
            this.numUpDownBidMaxFilter.ValueChanged += new System.EventHandler(this.numUpDownBidMaxFilter_ValueChanged);
            // 
            // lblBidMaxFilter
            // 
            this.lblBidMaxFilter.AutoSize = true;
            this.lblBidMaxFilter.Location = new System.Drawing.Point(138, 243);
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
            this.lstBoxCharacterNamesValues.Size = new System.Drawing.Size(169, 212);
            this.lstBoxCharacterNamesValues.TabIndex = 5;
            this.lstBoxCharacterNamesValues.SelectedIndexChanged += new System.EventHandler(this.lstBoxCharacterNamesValues_SelectedIndexChanged);
            // 
            // chkBoxIsBiddedFilter
            // 
            this.chkBoxIsBiddedFilter.AutoSize = true;
            this.chkBoxIsBiddedFilter.Enabled = false;
            this.chkBoxIsBiddedFilter.Location = new System.Drawing.Point(220, 259);
            this.chkBoxIsBiddedFilter.Name = "chkBoxIsBiddedFilter";
            this.chkBoxIsBiddedFilter.Size = new System.Drawing.Size(118, 17);
            this.chkBoxIsBiddedFilter.TabIndex = 8;
            this.chkBoxIsBiddedFilter.Text = "Only Not Auctioned";
            this.chkBoxIsBiddedFilter.UseVisualStyleBackColor = true;
            this.chkBoxIsBiddedFilter.CheckedChanged += new System.EventHandler(this.chkBoxIsBiddedFilter_CheckedChanged);
            // 
            // lblMinLevelFilter
            // 
            this.lblMinLevelFilter.AutoSize = true;
            this.lblMinLevelFilter.Location = new System.Drawing.Point(138, 282);
            this.lblMinLevelFilter.Name = "lblMinLevelFilter";
            this.lblMinLevelFilter.Size = new System.Drawing.Size(56, 13);
            this.lblMinLevelFilter.TabIndex = 9;
            this.lblMinLevelFilter.Text = "Min. Level";
            // 
            // numMinLevelFilter
            // 
            this.numMinLevelFilter.Location = new System.Drawing.Point(139, 298);
            this.numMinLevelFilter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMinLevelFilter.Name = "numMinLevelFilter";
            this.numMinLevelFilter.Size = new System.Drawing.Size(55, 20);
            this.numMinLevelFilter.TabIndex = 10;
            this.numMinLevelFilter.ValueChanged += new System.EventHandler(this.numMinLevelFilter_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character names, ordered by End Auction.";
            // 
            // btnUpdateBazaar
            // 
            this.btnUpdateBazaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBazaar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnUpdateBazaar.Location = new System.Drawing.Point(140, 388);
            this.btnUpdateBazaar.Name = "btnUpdateBazaar";
            this.btnUpdateBazaar.Size = new System.Drawing.Size(119, 75);
            this.btnUpdateBazaar.TabIndex = 19;
            this.btnUpdateBazaar.Text = "Refresh Data!";
            this.btnUpdateBazaar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateBazaar.UseVisualStyleBackColor = true;
            this.btnUpdateBazaar.Click += new System.EventHandler(this.btnUpdateBazaar_Click);
            // 
            // grpBoxBazaarEntityStatus
            // 
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityVocationValue);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityVocationTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityUrlStatusTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityWorldValue);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityWorldTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityEndAuctionValue);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityEndAuctionTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityStartedAuctionValue);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityStartedAuctionTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityUrlAuctionTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityCurrMinBidValue);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityCurrMinBidTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityGenderValue);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityGenderTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityLevelTag);
            this.grpBoxBazaarEntityStatus.Controls.Add(this.lblBazaarEntityLevelValue);
            this.grpBoxBazaarEntityStatus.Location = new System.Drawing.Point(314, 25);
            this.grpBoxBazaarEntityStatus.Name = "grpBoxBazaarEntityStatus";
            this.grpBoxBazaarEntityStatus.Size = new System.Drawing.Size(234, 212);
            this.grpBoxBazaarEntityStatus.TabIndex = 23;
            this.grpBoxBazaarEntityStatus.TabStop = false;
            this.grpBoxBazaarEntityStatus.Text = "Status Info";
            this.grpBoxBazaarEntityStatus.Visible = false;
            // 
            // lblBazaarEntityVocationValue
            // 
            this.lblBazaarEntityVocationValue.AutoSize = true;
            this.lblBazaarEntityVocationValue.BackColor = System.Drawing.SystemColors.Control;
            this.lblBazaarEntityVocationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityVocationValue.ForeColor = System.Drawing.Color.Maroon;
            this.lblBazaarEntityVocationValue.Location = new System.Drawing.Point(95, 133);
            this.lblBazaarEntityVocationValue.Name = "lblBazaarEntityVocationValue";
            this.lblBazaarEntityVocationValue.Size = new System.Drawing.Size(89, 13);
            this.lblBazaarEntityVocationValue.TabIndex = 13;
            this.lblBazaarEntityVocationValue.Text = "VocationValue";
            // 
            // lblBazaarEntityVocationTag
            // 
            this.lblBazaarEntityVocationTag.AutoSize = true;
            this.lblBazaarEntityVocationTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityVocationTag.Location = new System.Drawing.Point(6, 133);
            this.lblBazaarEntityVocationTag.Name = "lblBazaarEntityVocationTag";
            this.lblBazaarEntityVocationTag.Size = new System.Drawing.Size(61, 13);
            this.lblBazaarEntityVocationTag.TabIndex = 12;
            this.lblBazaarEntityVocationTag.Text = "Vocation:";
            // 
            // lblBazaarEntityUrlStatusTag
            // 
            this.lblBazaarEntityUrlStatusTag.AutoSize = true;
            this.lblBazaarEntityUrlStatusTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityUrlStatusTag.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBazaarEntityUrlStatusTag.Location = new System.Drawing.Point(6, 168);
            this.lblBazaarEntityUrlStatusTag.Name = "lblBazaarEntityUrlStatusTag";
            this.lblBazaarEntityUrlStatusTag.Size = new System.Drawing.Size(172, 17);
            this.lblBazaarEntityUrlStatusTag.TabIndex = 14;
            this.lblBazaarEntityUrlStatusTag.TabStop = true;
            this.lblBazaarEntityUrlStatusTag.Text = "Check specific information";
            this.lblBazaarEntityUrlStatusTag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBazaarEntityUrlStatusTag_LinkClicked);
            // 
            // lblBazaarEntityWorldValue
            // 
            this.lblBazaarEntityWorldValue.AutoSize = true;
            this.lblBazaarEntityWorldValue.BackColor = System.Drawing.SystemColors.Control;
            this.lblBazaarEntityWorldValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityWorldValue.ForeColor = System.Drawing.Color.Maroon;
            this.lblBazaarEntityWorldValue.Location = new System.Drawing.Point(95, 120);
            this.lblBazaarEntityWorldValue.Name = "lblBazaarEntityWorldValue";
            this.lblBazaarEntityWorldValue.Size = new System.Drawing.Size(72, 13);
            this.lblBazaarEntityWorldValue.TabIndex = 11;
            this.lblBazaarEntityWorldValue.Text = "WorldValue";
            // 
            // lblBazaarEntityWorldTag
            // 
            this.lblBazaarEntityWorldTag.AutoSize = true;
            this.lblBazaarEntityWorldTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityWorldTag.Location = new System.Drawing.Point(6, 120);
            this.lblBazaarEntityWorldTag.Name = "lblBazaarEntityWorldTag";
            this.lblBazaarEntityWorldTag.Size = new System.Drawing.Size(44, 13);
            this.lblBazaarEntityWorldTag.TabIndex = 10;
            this.lblBazaarEntityWorldTag.Text = "World:";
            // 
            // lblBazaarEntityEndAuctionValue
            // 
            this.lblBazaarEntityEndAuctionValue.AutoSize = true;
            this.lblBazaarEntityEndAuctionValue.BackColor = System.Drawing.SystemColors.Control;
            this.lblBazaarEntityEndAuctionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityEndAuctionValue.ForeColor = System.Drawing.Color.Maroon;
            this.lblBazaarEntityEndAuctionValue.Location = new System.Drawing.Point(59, 107);
            this.lblBazaarEntityEndAuctionValue.Name = "lblBazaarEntityEndAuctionValue";
            this.lblBazaarEntityEndAuctionValue.Size = new System.Drawing.Size(104, 13);
            this.lblBazaarEntityEndAuctionValue.TabIndex = 9;
            this.lblBazaarEntityEndAuctionValue.Text = "EndAuctionValue";
            // 
            // lblBazaarEntityEndAuctionTag
            // 
            this.lblBazaarEntityEndAuctionTag.AutoSize = true;
            this.lblBazaarEntityEndAuctionTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityEndAuctionTag.Location = new System.Drawing.Point(6, 94);
            this.lblBazaarEntityEndAuctionTag.Name = "lblBazaarEntityEndAuctionTag";
            this.lblBazaarEntityEndAuctionTag.Size = new System.Drawing.Size(80, 13);
            this.lblBazaarEntityEndAuctionTag.TabIndex = 8;
            this.lblBazaarEntityEndAuctionTag.Text = "End Auction:";
            // 
            // lblBazaarEntityStartedAuctionValue
            // 
            this.lblBazaarEntityStartedAuctionValue.AutoSize = true;
            this.lblBazaarEntityStartedAuctionValue.BackColor = System.Drawing.SystemColors.Control;
            this.lblBazaarEntityStartedAuctionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityStartedAuctionValue.ForeColor = System.Drawing.Color.Maroon;
            this.lblBazaarEntityStartedAuctionValue.Location = new System.Drawing.Point(59, 81);
            this.lblBazaarEntityStartedAuctionValue.Name = "lblBazaarEntityStartedAuctionValue";
            this.lblBazaarEntityStartedAuctionValue.Size = new System.Drawing.Size(123, 13);
            this.lblBazaarEntityStartedAuctionValue.TabIndex = 7;
            this.lblBazaarEntityStartedAuctionValue.Text = "StartedAuctionValue";
            // 
            // lblBazaarEntityStartedAuctionTag
            // 
            this.lblBazaarEntityStartedAuctionTag.AutoSize = true;
            this.lblBazaarEntityStartedAuctionTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityStartedAuctionTag.Location = new System.Drawing.Point(6, 64);
            this.lblBazaarEntityStartedAuctionTag.Name = "lblBazaarEntityStartedAuctionTag";
            this.lblBazaarEntityStartedAuctionTag.Size = new System.Drawing.Size(99, 13);
            this.lblBazaarEntityStartedAuctionTag.TabIndex = 6;
            this.lblBazaarEntityStartedAuctionTag.Text = "Started Auction:";
            // 
            // lblBazaarEntityUrlAuctionTag
            // 
            this.lblBazaarEntityUrlAuctionTag.AutoSize = true;
            this.lblBazaarEntityUrlAuctionTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityUrlAuctionTag.Location = new System.Drawing.Point(6, 194);
            this.lblBazaarEntityUrlAuctionTag.Name = "lblBazaarEntityUrlAuctionTag";
            this.lblBazaarEntityUrlAuctionTag.Size = new System.Drawing.Size(202, 15);
            this.lblBazaarEntityUrlAuctionTag.TabIndex = 15;
            this.lblBazaarEntityUrlAuctionTag.TabStop = true;
            this.lblBazaarEntityUrlAuctionTag.Text = "Offer an Auction on Official Web Site";
            this.lblBazaarEntityUrlAuctionTag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBazaarEntityUrlAuctionTag_LinkClicked);
            // 
            // lblBazaarEntityCurrMinBidValue
            // 
            this.lblBazaarEntityCurrMinBidValue.AutoSize = true;
            this.lblBazaarEntityCurrMinBidValue.BackColor = System.Drawing.SystemColors.Control;
            this.lblBazaarEntityCurrMinBidValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityCurrMinBidValue.ForeColor = System.Drawing.Color.Maroon;
            this.lblBazaarEntityCurrMinBidValue.Location = new System.Drawing.Point(95, 48);
            this.lblBazaarEntityCurrMinBidValue.Name = "lblBazaarEntityCurrMinBidValue";
            this.lblBazaarEntityCurrMinBidValue.Size = new System.Drawing.Size(100, 13);
            this.lblBazaarEntityCurrMinBidValue.TabIndex = 5;
            this.lblBazaarEntityCurrMinBidValue.Text = "CurrMinBidValue";
            // 
            // lblBazaarEntityCurrMinBidTag
            // 
            this.lblBazaarEntityCurrMinBidTag.AutoSize = true;
            this.lblBazaarEntityCurrMinBidTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityCurrMinBidTag.Location = new System.Drawing.Point(6, 48);
            this.lblBazaarEntityCurrMinBidTag.Name = "lblBazaarEntityCurrMinBidTag";
            this.lblBazaarEntityCurrMinBidTag.Size = new System.Drawing.Size(82, 13);
            this.lblBazaarEntityCurrMinBidTag.TabIndex = 4;
            this.lblBazaarEntityCurrMinBidTag.Text = "Curr/Min Bid:";
            // 
            // lblBazaarEntityGenderValue
            // 
            this.lblBazaarEntityGenderValue.AutoSize = true;
            this.lblBazaarEntityGenderValue.BackColor = System.Drawing.SystemColors.Control;
            this.lblBazaarEntityGenderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityGenderValue.ForeColor = System.Drawing.Color.Maroon;
            this.lblBazaarEntityGenderValue.Location = new System.Drawing.Point(95, 34);
            this.lblBazaarEntityGenderValue.Name = "lblBazaarEntityGenderValue";
            this.lblBazaarEntityGenderValue.Size = new System.Drawing.Size(116, 13);
            this.lblBazaarEntityGenderValue.TabIndex = 3;
            this.lblBazaarEntityGenderValue.Text = "GenderStatusValue";
            // 
            // lblBazaarEntityGenderTag
            // 
            this.lblBazaarEntityGenderTag.AutoSize = true;
            this.lblBazaarEntityGenderTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityGenderTag.Location = new System.Drawing.Point(6, 34);
            this.lblBazaarEntityGenderTag.Name = "lblBazaarEntityGenderTag";
            this.lblBazaarEntityGenderTag.Size = new System.Drawing.Size(52, 13);
            this.lblBazaarEntityGenderTag.TabIndex = 2;
            this.lblBazaarEntityGenderTag.Text = "Gender:";
            // 
            // lblBazaarEntityLevelTag
            // 
            this.lblBazaarEntityLevelTag.AutoSize = true;
            this.lblBazaarEntityLevelTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityLevelTag.Location = new System.Drawing.Point(6, 21);
            this.lblBazaarEntityLevelTag.Name = "lblBazaarEntityLevelTag";
            this.lblBazaarEntityLevelTag.Size = new System.Drawing.Size(42, 13);
            this.lblBazaarEntityLevelTag.TabIndex = 0;
            this.lblBazaarEntityLevelTag.Text = "Level:";
            // 
            // lblBazaarEntityLevelValue
            // 
            this.lblBazaarEntityLevelValue.AutoSize = true;
            this.lblBazaarEntityLevelValue.BackColor = System.Drawing.SystemColors.Control;
            this.lblBazaarEntityLevelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaarEntityLevelValue.ForeColor = System.Drawing.Color.Maroon;
            this.lblBazaarEntityLevelValue.Location = new System.Drawing.Point(95, 21);
            this.lblBazaarEntityLevelValue.Name = "lblBazaarEntityLevelValue";
            this.lblBazaarEntityLevelValue.Size = new System.Drawing.Size(106, 13);
            this.lblBazaarEntityLevelValue.TabIndex = 1;
            this.lblBazaarEntityLevelValue.Text = "LevelStatusValue";
            // 
            // lblStoreUrlAuctionValueDisabled
            // 
            this.lblStoreUrlAuctionValueDisabled.AutoSize = true;
            this.lblStoreUrlAuctionValueDisabled.Location = new System.Drawing.Point(409, 472);
            this.lblStoreUrlAuctionValueDisabled.Name = "lblStoreUrlAuctionValueDisabled";
            this.lblStoreUrlAuctionValueDisabled.Size = new System.Drawing.Size(139, 13);
            this.lblStoreUrlAuctionValueDisabled.TabIndex = 25;
            this.lblStoreUrlAuctionValueDisabled.Text = "LabelStoreUrlValueDisabled";
            this.lblStoreUrlAuctionValueDisabled.Visible = false;
            // 
            // prgBarBazaarLoadingInfo
            // 
            this.prgBarBazaarLoadingInfo.Location = new System.Drawing.Point(12, 488);
            this.prgBarBazaarLoadingInfo.Name = "prgBarBazaarLoadingInfo";
            this.prgBarBazaarLoadingInfo.Size = new System.Drawing.Size(536, 10);
            this.prgBarBazaarLoadingInfo.TabIndex = 22;
            // 
            // chkLstBoxWorldFilter
            // 
            this.chkLstBoxWorldFilter.Enabled = false;
            this.chkLstBoxWorldFilter.FormattingEnabled = true;
            this.chkLstBoxWorldFilter.Location = new System.Drawing.Point(12, 110);
            this.chkLstBoxWorldFilter.Name = "chkLstBoxWorldFilter";
            this.chkLstBoxWorldFilter.Size = new System.Drawing.Size(120, 169);
            this.chkLstBoxWorldFilter.TabIndex = 3;
            // 
            // chkLstBoxVocationFilter
            // 
            this.chkLstBoxVocationFilter.Enabled = false;
            this.chkLstBoxVocationFilter.FormattingEnabled = true;
            this.chkLstBoxVocationFilter.Location = new System.Drawing.Point(12, 285);
            this.chkLstBoxVocationFilter.Name = "chkLstBoxVocationFilter";
            this.chkLstBoxVocationFilter.Size = new System.Drawing.Size(120, 79);
            this.chkLstBoxVocationFilter.TabIndex = 4;
            // 
            // btnBazaarApplyFilter
            // 
            this.btnBazaarApplyFilter.Enabled = false;
            this.btnBazaarApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBazaarApplyFilter.ForeColor = System.Drawing.Color.LightCoral;
            this.btnBazaarApplyFilter.Location = new System.Drawing.Point(15, 370);
            this.btnBazaarApplyFilter.Name = "btnBazaarApplyFilter";
            this.btnBazaarApplyFilter.Size = new System.Drawing.Size(119, 93);
            this.btnBazaarApplyFilter.TabIndex = 18;
            this.btnBazaarApplyFilter.Text = "Apply Filter!";
            this.btnBazaarApplyFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBazaarApplyFilter.UseVisualStyleBackColor = true;
            this.btnBazaarApplyFilter.Click += new System.EventHandler(this.btnBazaarApplyFilter_Click);
            // 
            // chkLstBoxPvpTypeFilter
            // 
            this.chkLstBoxPvpTypeFilter.Enabled = false;
            this.chkLstBoxPvpTypeFilter.FormattingEnabled = true;
            this.chkLstBoxPvpTypeFilter.Location = new System.Drawing.Point(12, 25);
            this.chkLstBoxPvpTypeFilter.Name = "chkLstBoxPvpTypeFilter";
            this.chkLstBoxPvpTypeFilter.Size = new System.Drawing.Size(120, 79);
            this.chkLstBoxPvpTypeFilter.TabIndex = 2;
            this.chkLstBoxPvpTypeFilter.Leave += new System.EventHandler(this.chkLstBoxPvpTypeFilter_Leave);
            // 
            // numMaxLevelFilter
            // 
            this.numMaxLevelFilter.Location = new System.Drawing.Point(204, 298);
            this.numMaxLevelFilter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaxLevelFilter.Name = "numMaxLevelFilter";
            this.numMaxLevelFilter.Size = new System.Drawing.Size(55, 20);
            this.numMaxLevelFilter.TabIndex = 12;
            this.numMaxLevelFilter.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaxLevelFilter.ValueChanged += new System.EventHandler(this.numMaxLevelFilter_ValueChanged);
            // 
            // lblMaxLevelFilter
            // 
            this.lblMaxLevelFilter.AutoSize = true;
            this.lblMaxLevelFilter.Location = new System.Drawing.Point(203, 282);
            this.lblMaxLevelFilter.Name = "lblMaxLevelFilter";
            this.lblMaxLevelFilter.Size = new System.Drawing.Size(59, 13);
            this.lblMaxLevelFilter.TabIndex = 11;
            this.lblMaxLevelFilter.Text = "Máx. Level";
            // 
            // numMaxSkillFilter
            // 
            this.numMaxSkillFilter.Location = new System.Drawing.Point(205, 364);
            this.numMaxSkillFilter.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numMaxSkillFilter.Name = "numMaxSkillFilter";
            this.numMaxSkillFilter.Size = new System.Drawing.Size(55, 20);
            this.numMaxSkillFilter.TabIndex = 17;
            this.numMaxSkillFilter.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numMaxSkillFilter.ValueChanged += new System.EventHandler(this.numMaxSkillFilter_ValueChanged);
            // 
            // lblMaxSkillFilter
            // 
            this.lblMaxSkillFilter.AutoSize = true;
            this.lblMaxSkillFilter.Location = new System.Drawing.Point(204, 348);
            this.lblMaxSkillFilter.Name = "lblMaxSkillFilter";
            this.lblMaxSkillFilter.Size = new System.Drawing.Size(52, 13);
            this.lblMaxSkillFilter.TabIndex = 16;
            this.lblMaxSkillFilter.Text = "Máx. Skill";
            // 
            // numMinSkillFilter
            // 
            this.numMinSkillFilter.Location = new System.Drawing.Point(140, 364);
            this.numMinSkillFilter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMinSkillFilter.Name = "numMinSkillFilter";
            this.numMinSkillFilter.Size = new System.Drawing.Size(55, 20);
            this.numMinSkillFilter.TabIndex = 15;
            this.numMinSkillFilter.ValueChanged += new System.EventHandler(this.numMinSkillFilter_ValueChanged);
            // 
            // lblMinSkillFilter
            // 
            this.lblMinSkillFilter.AutoSize = true;
            this.lblMinSkillFilter.Location = new System.Drawing.Point(139, 348);
            this.lblMinSkillFilter.Name = "lblMinSkillFilter";
            this.lblMinSkillFilter.Size = new System.Drawing.Size(49, 13);
            this.lblMinSkillFilter.TabIndex = 14;
            this.lblMinSkillFilter.Text = "Min. Skill";
            // 
            // cboBoxSkillsFilter
            // 
            this.cboBoxSkillsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxSkillsFilter.FormattingEnabled = true;
            this.cboBoxSkillsFilter.Location = new System.Drawing.Point(139, 324);
            this.cboBoxSkillsFilter.Name = "cboBoxSkillsFilter";
            this.cboBoxSkillsFilter.Size = new System.Drawing.Size(120, 21);
            this.cboBoxSkillsFilter.TabIndex = 13;
            // 
            // dtaGridSkillsPart2Info
            // 
            this.dtaGridSkillsPart2Info.AllowUserToAddRows = false;
            this.dtaGridSkillsPart2Info.AllowUserToDeleteRows = false;
            this.dtaGridSkillsPart2Info.AllowUserToOrderColumns = true;
            this.dtaGridSkillsPart2Info.AllowUserToResizeColumns = false;
            this.dtaGridSkillsPart2Info.AllowUserToResizeRows = false;
            this.dtaGridSkillsPart2Info.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtaGridSkillsPart2Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtaGridSkillsPart2Info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtaGridSkillsPart2Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridSkillsPart2Info.ColumnHeadersVisible = false;
            this.dtaGridSkillsPart2Info.EnableHeadersVisualStyles = false;
            this.dtaGridSkillsPart2Info.Location = new System.Drawing.Point(3, 16);
            this.dtaGridSkillsPart2Info.Name = "dtaGridSkillsPart2Info";
            this.dtaGridSkillsPart2Info.ReadOnly = true;
            this.dtaGridSkillsPart2Info.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtaGridSkillsPart2Info.RowHeadersVisible = false;
            this.dtaGridSkillsPart2Info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtaGridSkillsPart2Info.Size = new System.Drawing.Size(181, 177);
            this.dtaGridSkillsPart2Info.TabIndex = 0;
            // 
            // grpBoxBazaarEntitySkills
            // 
            this.grpBoxBazaarEntitySkills.Controls.Add(this.dtaGridSkillsPart2Info);
            this.grpBoxBazaarEntitySkills.Location = new System.Drawing.Point(358, 243);
            this.grpBoxBazaarEntitySkills.Name = "grpBoxBazaarEntitySkills";
            this.grpBoxBazaarEntitySkills.Size = new System.Drawing.Size(190, 199);
            this.grpBoxBazaarEntitySkills.TabIndex = 24;
            this.grpBoxBazaarEntitySkills.TabStop = false;
            this.grpBoxBazaarEntitySkills.Text = "Skills";
            this.grpBoxBazaarEntitySkills.Visible = false;
            // 
            // btnResetFields
            // 
            this.btnResetFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFields.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnResetFields.Location = new System.Drawing.Point(266, 361);
            this.btnResetFields.Name = "btnResetFields";
            this.btnResetFields.Size = new System.Drawing.Size(75, 102);
            this.btnResetFields.TabIndex = 20;
            this.btnResetFields.Text = "Reset Fields!";
            this.btnResetFields.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResetFields.UseVisualStyleBackColor = true;
            this.btnResetFields.Click += new System.EventHandler(this.btnResetFields_Click);
            // 
            // BazaarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.Controls.Add(this.btnResetFields);
            this.Controls.Add(this.grpBoxBazaarEntitySkills);
            this.Controls.Add(this.cboBoxSkillsFilter);
            this.Controls.Add(this.numMaxSkillFilter);
            this.Controls.Add(this.lblMaxSkillFilter);
            this.Controls.Add(this.numMinSkillFilter);
            this.Controls.Add(this.lblMinSkillFilter);
            this.Controls.Add(this.numMaxLevelFilter);
            this.Controls.Add(this.lblMaxLevelFilter);
            this.Controls.Add(this.lblStoreUrlAuctionValueDisabled);
            this.Controls.Add(this.chkLstBoxPvpTypeFilter);
            this.Controls.Add(this.btnBazaarApplyFilter);
            this.Controls.Add(this.chkLstBoxVocationFilter);
            this.Controls.Add(this.chkLstBoxWorldFilter);
            this.Controls.Add(this.prgBarBazaarLoadingInfo);
            this.Controls.Add(this.grpBoxBazaarEntityStatus);
            this.Controls.Add(this.btnUpdateBazaar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numMinLevelFilter);
            this.Controls.Add(this.lblMinLevelFilter);
            this.Controls.Add(this.chkBoxIsBiddedFilter);
            this.Controls.Add(this.lstBoxCharacterNamesValues);
            this.Controls.Add(this.lblBidMaxFilter);
            this.Controls.Add(this.numUpDownBidMaxFilter);
            this.Controls.Add(this.lblDteUpdatedBazaar);
            this.Controls.Add(this.lblBazaarTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BazaarForm";
            this.Text = "BazaarForm";
            this.Load += new System.EventHandler(this.BazaarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBidMaxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLevelFilter)).EndInit();
            this.grpBoxBazaarEntityStatus.ResumeLayout(false);
            this.grpBoxBazaarEntityStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLevelFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSkillFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinSkillFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridSkillsPart2Info)).EndInit();
            this.grpBoxBazaarEntitySkills.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBazaarTitle;
        private System.Windows.Forms.Label lblDteUpdatedBazaar;
        private System.Windows.Forms.NumericUpDown numUpDownBidMaxFilter;
        private System.Windows.Forms.Label lblBidMaxFilter;
        private System.Windows.Forms.ListBox lstBoxCharacterNamesValues;
        private System.Windows.Forms.CheckBox chkBoxIsBiddedFilter;
        private System.Windows.Forms.Label lblMinLevelFilter;
        private System.Windows.Forms.NumericUpDown numMinLevelFilter;
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
        private System.Windows.Forms.Button btnBazaarApplyFilter;
        private System.Windows.Forms.CheckedListBox chkLstBoxPvpTypeFilter;
        private System.Windows.Forms.LinkLabel lblBazaarEntityUrlStatusTag;
        private System.Windows.Forms.NumericUpDown numMaxLevelFilter;
        private System.Windows.Forms.Label lblMaxLevelFilter;
        private System.Windows.Forms.NumericUpDown numMaxSkillFilter;
        private System.Windows.Forms.Label lblMaxSkillFilter;
        private System.Windows.Forms.NumericUpDown numMinSkillFilter;
        private System.Windows.Forms.Label lblMinSkillFilter;
        private System.Windows.Forms.ComboBox cboBoxSkillsFilter;
        private System.Windows.Forms.Label lblBazaarEntityVocationValue;
        private System.Windows.Forms.Label lblBazaarEntityVocationTag;
        private System.Windows.Forms.DataGridView dtaGridSkillsPart2Info;
        private System.Windows.Forms.GroupBox grpBoxBazaarEntitySkills;
        private System.Windows.Forms.Button btnResetFields;
    }
}