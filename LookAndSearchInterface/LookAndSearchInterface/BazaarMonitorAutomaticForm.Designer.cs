namespace LookAndSearchInterface
{
    partial class BazaarMonitorAutomaticForm
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
            this.cboBoxSkillsFilter = new System.Windows.Forms.ComboBox();
            this.numMaxSkillFilter = new System.Windows.Forms.NumericUpDown();
            this.lblMaxSkillFilter = new System.Windows.Forms.Label();
            this.numMinSkillFilter = new System.Windows.Forms.NumericUpDown();
            this.lblMinSkillFilter = new System.Windows.Forms.Label();
            this.numMaxLevelFilter = new System.Windows.Forms.NumericUpDown();
            this.lblMaxLevelFilter = new System.Windows.Forms.Label();
            this.chkLstBoxPvpTypeFilter = new System.Windows.Forms.CheckedListBox();
            this.chkLstBoxVocationFilter = new System.Windows.Forms.CheckedListBox();
            this.chkLstBoxWorldFilter = new System.Windows.Forms.CheckedListBox();
            this.numMinLevelFilter = new System.Windows.Forms.NumericUpDown();
            this.lblMinLevelFilter = new System.Windows.Forms.Label();
            this.chkBoxIsBiddedFilter = new System.Windows.Forms.CheckBox();
            this.lblBidMaxFilter = new System.Windows.Forms.Label();
            this.numUpDownBidMaxFilter = new System.Windows.Forms.NumericUpDown();
            this.lblMonitorBazaarTitle = new System.Windows.Forms.Label();
            this.btnBazaarApplyFilter = new System.Windows.Forms.Button();
            this.btnBazaarStartMonitor = new System.Windows.Forms.Button();
            this.chkBoxNotifiedByEmail = new System.Windows.Forms.CheckBox();
            this.chkBoxBlinkTaskBar = new System.Windows.Forms.CheckBox();
            this.chkBoxSendWindowsSound = new System.Windows.Forms.CheckBox();
            this.numUpDownCheckTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblCheckTimeMinutes = new System.Windows.Forms.Label();
            this.btnBazaarStopMonitor = new System.Windows.Forms.Button();
            this.txtBoxDisplayEmailName = new System.Windows.Forms.TextBox();
            this.lblDisplayEmailName = new System.Windows.Forms.Label();
            this.grpBoxEmailDataFields = new System.Windows.Forms.GroupBox();
            this.lblEmailTo = new System.Windows.Forms.Label();
            this.txtBoxEmailTo = new System.Windows.Forms.TextBox();
            this.lblStatusEmailInfo = new System.Windows.Forms.Label();
            this.lblStatusMonitorInfo = new System.Windows.Forms.Label();
            this.picBoxBazaarCheckResultMonitor = new System.Windows.Forms.PictureBox();
            this.lnkLblBazaarCheckNames = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSkillFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinSkillFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLevelFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLevelFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBidMaxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCheckTimeMinutes)).BeginInit();
            this.grpBoxEmailDataFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBazaarCheckResultMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBoxSkillsFilter
            // 
            this.cboBoxSkillsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxSkillsFilter.FormattingEnabled = true;
            this.cboBoxSkillsFilter.Location = new System.Drawing.Point(139, 106);
            this.cboBoxSkillsFilter.Name = "cboBoxSkillsFilter";
            this.cboBoxSkillsFilter.Size = new System.Drawing.Size(120, 21);
            this.cboBoxSkillsFilter.TabIndex = 11;
            this.cboBoxSkillsFilter.SelectedIndexChanged += new System.EventHandler(this.cboBoxSkillsFilter_SelectedIndexChanged);
            // 
            // numMaxSkillFilter
            // 
            this.numMaxSkillFilter.Enabled = false;
            this.numMaxSkillFilter.Location = new System.Drawing.Point(205, 146);
            this.numMaxSkillFilter.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numMaxSkillFilter.Name = "numMaxSkillFilter";
            this.numMaxSkillFilter.Size = new System.Drawing.Size(55, 20);
            this.numMaxSkillFilter.TabIndex = 15;
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
            this.lblMaxSkillFilter.Location = new System.Drawing.Point(204, 130);
            this.lblMaxSkillFilter.Name = "lblMaxSkillFilter";
            this.lblMaxSkillFilter.Size = new System.Drawing.Size(52, 13);
            this.lblMaxSkillFilter.TabIndex = 14;
            this.lblMaxSkillFilter.Text = "Máx. Skill";
            // 
            // numMinSkillFilter
            // 
            this.numMinSkillFilter.Enabled = false;
            this.numMinSkillFilter.Location = new System.Drawing.Point(140, 146);
            this.numMinSkillFilter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMinSkillFilter.Name = "numMinSkillFilter";
            this.numMinSkillFilter.Size = new System.Drawing.Size(55, 20);
            this.numMinSkillFilter.TabIndex = 13;
            this.numMinSkillFilter.ValueChanged += new System.EventHandler(this.numMinSkillFilter_ValueChanged);
            // 
            // lblMinSkillFilter
            // 
            this.lblMinSkillFilter.AutoSize = true;
            this.lblMinSkillFilter.Location = new System.Drawing.Point(139, 130);
            this.lblMinSkillFilter.Name = "lblMinSkillFilter";
            this.lblMinSkillFilter.Size = new System.Drawing.Size(49, 13);
            this.lblMinSkillFilter.TabIndex = 12;
            this.lblMinSkillFilter.Text = "Min. Skill";
            // 
            // numMaxLevelFilter
            // 
            this.numMaxLevelFilter.Location = new System.Drawing.Point(204, 80);
            this.numMaxLevelFilter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaxLevelFilter.Name = "numMaxLevelFilter";
            this.numMaxLevelFilter.Size = new System.Drawing.Size(55, 20);
            this.numMaxLevelFilter.TabIndex = 10;
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
            this.lblMaxLevelFilter.Location = new System.Drawing.Point(203, 64);
            this.lblMaxLevelFilter.Name = "lblMaxLevelFilter";
            this.lblMaxLevelFilter.Size = new System.Drawing.Size(59, 13);
            this.lblMaxLevelFilter.TabIndex = 9;
            this.lblMaxLevelFilter.Text = "Máx. Level";
            // 
            // chkLstBoxPvpTypeFilter
            // 
            this.chkLstBoxPvpTypeFilter.FormattingEnabled = true;
            this.chkLstBoxPvpTypeFilter.Location = new System.Drawing.Point(12, 25);
            this.chkLstBoxPvpTypeFilter.Name = "chkLstBoxPvpTypeFilter";
            this.chkLstBoxPvpTypeFilter.Size = new System.Drawing.Size(120, 79);
            this.chkLstBoxPvpTypeFilter.TabIndex = 1;
            this.chkLstBoxPvpTypeFilter.Leave += new System.EventHandler(this.chkLstBoxPvpTypeFilter_Leave);
            // 
            // chkLstBoxVocationFilter
            // 
            this.chkLstBoxVocationFilter.FormattingEnabled = true;
            this.chkLstBoxVocationFilter.Location = new System.Drawing.Point(12, 285);
            this.chkLstBoxVocationFilter.Name = "chkLstBoxVocationFilter";
            this.chkLstBoxVocationFilter.Size = new System.Drawing.Size(120, 79);
            this.chkLstBoxVocationFilter.TabIndex = 3;
            this.chkLstBoxVocationFilter.Leave += new System.EventHandler(this.chkLstBoxVocationFilter_Leave);
            // 
            // chkLstBoxWorldFilter
            // 
            this.chkLstBoxWorldFilter.FormattingEnabled = true;
            this.chkLstBoxWorldFilter.Location = new System.Drawing.Point(12, 110);
            this.chkLstBoxWorldFilter.Name = "chkLstBoxWorldFilter";
            this.chkLstBoxWorldFilter.Size = new System.Drawing.Size(120, 169);
            this.chkLstBoxWorldFilter.TabIndex = 2;
            this.chkLstBoxWorldFilter.Leave += new System.EventHandler(this.chkLstBoxWorldFilter_Leave);
            // 
            // numMinLevelFilter
            // 
            this.numMinLevelFilter.Location = new System.Drawing.Point(139, 80);
            this.numMinLevelFilter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMinLevelFilter.Name = "numMinLevelFilter";
            this.numMinLevelFilter.Size = new System.Drawing.Size(55, 20);
            this.numMinLevelFilter.TabIndex = 8;
            this.numMinLevelFilter.ValueChanged += new System.EventHandler(this.numMinLevelFilter_ValueChanged);
            // 
            // lblMinLevelFilter
            // 
            this.lblMinLevelFilter.AutoSize = true;
            this.lblMinLevelFilter.Location = new System.Drawing.Point(138, 64);
            this.lblMinLevelFilter.Name = "lblMinLevelFilter";
            this.lblMinLevelFilter.Size = new System.Drawing.Size(56, 13);
            this.lblMinLevelFilter.TabIndex = 7;
            this.lblMinLevelFilter.Text = "Min. Level";
            // 
            // chkBoxIsBiddedFilter
            // 
            this.chkBoxIsBiddedFilter.AutoSize = true;
            this.chkBoxIsBiddedFilter.Location = new System.Drawing.Point(220, 41);
            this.chkBoxIsBiddedFilter.Name = "chkBoxIsBiddedFilter";
            this.chkBoxIsBiddedFilter.Size = new System.Drawing.Size(118, 17);
            this.chkBoxIsBiddedFilter.TabIndex = 6;
            this.chkBoxIsBiddedFilter.Text = "Only Not Auctioned";
            this.chkBoxIsBiddedFilter.UseVisualStyleBackColor = true;
            this.chkBoxIsBiddedFilter.CheckedChanged += new System.EventHandler(this.chkBoxIsBiddedFilter_CheckedChanged);
            // 
            // lblBidMaxFilter
            // 
            this.lblBidMaxFilter.AutoSize = true;
            this.lblBidMaxFilter.Location = new System.Drawing.Point(138, 25);
            this.lblBidMaxFilter.Name = "lblBidMaxFilter";
            this.lblBidMaxFilter.Size = new System.Drawing.Size(48, 13);
            this.lblBidMaxFilter.TabIndex = 4;
            this.lblBidMaxFilter.Text = "Max. Bid";
            // 
            // numUpDownBidMaxFilter
            // 
            this.numUpDownBidMaxFilter.Location = new System.Drawing.Point(139, 41);
            this.numUpDownBidMaxFilter.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numUpDownBidMaxFilter.Name = "numUpDownBidMaxFilter";
            this.numUpDownBidMaxFilter.Size = new System.Drawing.Size(75, 20);
            this.numUpDownBidMaxFilter.TabIndex = 5;
            this.numUpDownBidMaxFilter.ValueChanged += new System.EventHandler(this.numUpDownBidMaxFilter_ValueChanged);
            // 
            // lblMonitorBazaarTitle
            // 
            this.lblMonitorBazaarTitle.AutoSize = true;
            this.lblMonitorBazaarTitle.Location = new System.Drawing.Point(12, 9);
            this.lblMonitorBazaarTitle.Name = "lblMonitorBazaarTitle";
            this.lblMonitorBazaarTitle.Size = new System.Drawing.Size(78, 13);
            this.lblMonitorBazaarTitle.TabIndex = 0;
            this.lblMonitorBazaarTitle.Text = "Monitor Bazaar";
            // 
            // btnBazaarApplyFilter
            // 
            this.btnBazaarApplyFilter.Enabled = false;
            this.btnBazaarApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBazaarApplyFilter.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnBazaarApplyFilter.Location = new System.Drawing.Point(140, 211);
            this.btnBazaarApplyFilter.Name = "btnBazaarApplyFilter";
            this.btnBazaarApplyFilter.Size = new System.Drawing.Size(120, 93);
            this.btnBazaarApplyFilter.TabIndex = 22;
            this.btnBazaarApplyFilter.Text = "Save Filter!";
            this.btnBazaarApplyFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBazaarApplyFilter.UseVisualStyleBackColor = true;
            this.btnBazaarApplyFilter.Visible = false;
            // 
            // btnBazaarStartMonitor
            // 
            this.btnBazaarStartMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBazaarStartMonitor.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnBazaarStartMonitor.Location = new System.Drawing.Point(282, 250);
            this.btnBazaarStartMonitor.Name = "btnBazaarStartMonitor";
            this.btnBazaarStartMonitor.Size = new System.Drawing.Size(75, 100);
            this.btnBazaarStartMonitor.TabIndex = 23;
            this.btnBazaarStartMonitor.Text = "Start Monitor!";
            this.btnBazaarStartMonitor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBazaarStartMonitor.UseVisualStyleBackColor = true;
            this.btnBazaarStartMonitor.Click += new System.EventHandler(this.btnBazaarStartMonitor_Click);
            // 
            // chkBoxNotifiedByEmail
            // 
            this.chkBoxNotifiedByEmail.AutoSize = true;
            this.chkBoxNotifiedByEmail.Location = new System.Drawing.Point(282, 64);
            this.chkBoxNotifiedByEmail.Name = "chkBoxNotifiedByEmail";
            this.chkBoxNotifiedByEmail.Size = new System.Drawing.Size(163, 17);
            this.chkBoxNotifiedByEmail.TabIndex = 18;
            this.chkBoxNotifiedByEmail.Text = "I want to be notified by email!";
            this.chkBoxNotifiedByEmail.UseVisualStyleBackColor = true;
            this.chkBoxNotifiedByEmail.CheckedChanged += new System.EventHandler(this.chkBoxNotifiedByEmail_CheckedChanged);
            // 
            // chkBoxBlinkTaskBar
            // 
            this.chkBoxBlinkTaskBar.AutoSize = true;
            this.chkBoxBlinkTaskBar.Enabled = false;
            this.chkBoxBlinkTaskBar.Location = new System.Drawing.Point(282, 87);
            this.chkBoxBlinkTaskBar.Name = "chkBoxBlinkTaskBar";
            this.chkBoxBlinkTaskBar.Size = new System.Drawing.Size(180, 17);
            this.chkBoxBlinkTaskBar.TabIndex = 19;
            this.chkBoxBlinkTaskBar.Text = "I want to see a blink on task bar!";
            this.chkBoxBlinkTaskBar.UseVisualStyleBackColor = true;
            // 
            // chkBoxSendWindowsSound
            // 
            this.chkBoxSendWindowsSound.AutoSize = true;
            this.chkBoxSendWindowsSound.Location = new System.Drawing.Point(282, 110);
            this.chkBoxSendWindowsSound.Name = "chkBoxSendWindowsSound";
            this.chkBoxSendWindowsSound.Size = new System.Drawing.Size(132, 17);
            this.chkBoxSendWindowsSound.TabIndex = 20;
            this.chkBoxSendWindowsSound.Text = "I want to hear an alert!";
            this.chkBoxSendWindowsSound.UseVisualStyleBackColor = true;
            // 
            // numUpDownCheckTimeMinutes
            // 
            this.numUpDownCheckTimeMinutes.Location = new System.Drawing.Point(140, 185);
            this.numUpDownCheckTimeMinutes.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numUpDownCheckTimeMinutes.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownCheckTimeMinutes.Name = "numUpDownCheckTimeMinutes";
            this.numUpDownCheckTimeMinutes.Size = new System.Drawing.Size(55, 20);
            this.numUpDownCheckTimeMinutes.TabIndex = 17;
            this.numUpDownCheckTimeMinutes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblCheckTimeMinutes
            // 
            this.lblCheckTimeMinutes.AutoSize = true;
            this.lblCheckTimeMinutes.Location = new System.Drawing.Point(139, 169);
            this.lblCheckTimeMinutes.Name = "lblCheckTimeMinutes";
            this.lblCheckTimeMinutes.Size = new System.Drawing.Size(110, 13);
            this.lblCheckTimeMinutes.TabIndex = 16;
            this.lblCheckTimeMinutes.Text = "Check Time (Minutes)";
            // 
            // btnBazaarStopMonitor
            // 
            this.btnBazaarStopMonitor.Enabled = false;
            this.btnBazaarStopMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBazaarStopMonitor.ForeColor = System.Drawing.Color.Red;
            this.btnBazaarStopMonitor.Location = new System.Drawing.Point(363, 250);
            this.btnBazaarStopMonitor.Name = "btnBazaarStopMonitor";
            this.btnBazaarStopMonitor.Size = new System.Drawing.Size(75, 100);
            this.btnBazaarStopMonitor.TabIndex = 24;
            this.btnBazaarStopMonitor.Text = "Stop Monitor!";
            this.btnBazaarStopMonitor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBazaarStopMonitor.UseVisualStyleBackColor = true;
            this.btnBazaarStopMonitor.Click += new System.EventHandler(this.btnBazaarStopMonitor_Click);
            // 
            // txtBoxDisplayEmailName
            // 
            this.txtBoxDisplayEmailName.Location = new System.Drawing.Point(9, 34);
            this.txtBoxDisplayEmailName.Name = "txtBoxDisplayEmailName";
            this.txtBoxDisplayEmailName.Size = new System.Drawing.Size(235, 20);
            this.txtBoxDisplayEmailName.TabIndex = 1;
            this.txtBoxDisplayEmailName.Leave += new System.EventHandler(this.txtBoxDisplayEmailName_Leave);
            // 
            // lblDisplayEmailName
            // 
            this.lblDisplayEmailName.AutoSize = true;
            this.lblDisplayEmailName.Location = new System.Drawing.Point(6, 16);
            this.lblDisplayEmailName.Name = "lblDisplayEmailName";
            this.lblDisplayEmailName.Size = new System.Drawing.Size(100, 13);
            this.lblDisplayEmailName.TabIndex = 0;
            this.lblDisplayEmailName.Text = "Display email name:";
            // 
            // grpBoxEmailDataFields
            // 
            this.grpBoxEmailDataFields.Controls.Add(this.lblEmailTo);
            this.grpBoxEmailDataFields.Controls.Add(this.txtBoxEmailTo);
            this.grpBoxEmailDataFields.Controls.Add(this.lblDisplayEmailName);
            this.grpBoxEmailDataFields.Controls.Add(this.txtBoxDisplayEmailName);
            this.grpBoxEmailDataFields.Location = new System.Drawing.Point(282, 135);
            this.grpBoxEmailDataFields.Name = "grpBoxEmailDataFields";
            this.grpBoxEmailDataFields.Size = new System.Drawing.Size(250, 109);
            this.grpBoxEmailDataFields.TabIndex = 21;
            this.grpBoxEmailDataFields.TabStop = false;
            this.grpBoxEmailDataFields.Text = "Email data:";
            this.grpBoxEmailDataFields.Visible = false;
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Location = new System.Drawing.Point(6, 57);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(47, 13);
            this.lblEmailTo.TabIndex = 2;
            this.lblEmailTo.Text = "Email to:";
            // 
            // txtBoxEmailTo
            // 
            this.txtBoxEmailTo.Location = new System.Drawing.Point(9, 75);
            this.txtBoxEmailTo.Name = "txtBoxEmailTo";
            this.txtBoxEmailTo.Size = new System.Drawing.Size(235, 20);
            this.txtBoxEmailTo.TabIndex = 3;
            this.txtBoxEmailTo.Leave += new System.EventHandler(this.txtBoxEmailTo_Leave);
            // 
            // lblStatusEmailInfo
            // 
            this.lblStatusEmailInfo.AutoSize = true;
            this.lblStatusEmailInfo.Location = new System.Drawing.Point(9, 449);
            this.lblStatusEmailInfo.Name = "lblStatusEmailInfo";
            this.lblStatusEmailInfo.Size = new System.Drawing.Size(90, 13);
            this.lblStatusEmailInfo.TabIndex = 27;
            this.lblStatusEmailInfo.Text = "lblStatusEmailInfo";
            this.lblStatusEmailInfo.Visible = false;
            // 
            // lblStatusMonitorInfo
            // 
            this.lblStatusMonitorInfo.AutoSize = true;
            this.lblStatusMonitorInfo.Location = new System.Drawing.Point(290, 376);
            this.lblStatusMonitorInfo.Name = "lblStatusMonitorInfo";
            this.lblStatusMonitorInfo.Size = new System.Drawing.Size(100, 13);
            this.lblStatusMonitorInfo.TabIndex = 25;
            this.lblStatusMonitorInfo.Text = "lblStatusMonitorInfo";
            this.lblStatusMonitorInfo.Visible = false;
            // 
            // picBoxBazaarCheckResultMonitor
            // 
            this.picBoxBazaarCheckResultMonitor.Location = new System.Drawing.Point(220, 356);
            this.picBoxBazaarCheckResultMonitor.Name = "picBoxBazaarCheckResultMonitor";
            this.picBoxBazaarCheckResultMonitor.Size = new System.Drawing.Size(64, 64);
            this.picBoxBazaarCheckResultMonitor.TabIndex = 64;
            this.picBoxBazaarCheckResultMonitor.TabStop = false;
            this.picBoxBazaarCheckResultMonitor.Visible = false;
            // 
            // lnkLblBazaarCheckNames
            // 
            this.lnkLblBazaarCheckNames.AutoSize = true;
            this.lnkLblBazaarCheckNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblBazaarCheckNames.Location = new System.Drawing.Point(290, 356);
            this.lnkLblBazaarCheckNames.Name = "lnkLblBazaarCheckNames";
            this.lnkLblBazaarCheckNames.Size = new System.Drawing.Size(147, 20);
            this.lnkLblBazaarCheckNames.TabIndex = 26;
            this.lnkLblBazaarCheckNames.TabStop = true;
            this.lnkLblBazaarCheckNames.Text = "Check Last Names!";
            this.lnkLblBazaarCheckNames.Visible = false;
            this.lnkLblBazaarCheckNames.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblBazaarCheckNames_LinkClicked);
            // 
            // BazaarMonitorAutomaticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 468);
            this.Controls.Add(this.lnkLblBazaarCheckNames);
            this.Controls.Add(this.picBoxBazaarCheckResultMonitor);
            this.Controls.Add(this.lblStatusMonitorInfo);
            this.Controls.Add(this.lblStatusEmailInfo);
            this.Controls.Add(this.grpBoxEmailDataFields);
            this.Controls.Add(this.btnBazaarStopMonitor);
            this.Controls.Add(this.lblCheckTimeMinutes);
            this.Controls.Add(this.numUpDownCheckTimeMinutes);
            this.Controls.Add(this.chkBoxSendWindowsSound);
            this.Controls.Add(this.chkBoxBlinkTaskBar);
            this.Controls.Add(this.chkBoxNotifiedByEmail);
            this.Controls.Add(this.btnBazaarStartMonitor);
            this.Controls.Add(this.btnBazaarApplyFilter);
            this.Controls.Add(this.cboBoxSkillsFilter);
            this.Controls.Add(this.numMaxSkillFilter);
            this.Controls.Add(this.lblMaxSkillFilter);
            this.Controls.Add(this.numMinSkillFilter);
            this.Controls.Add(this.lblMinSkillFilter);
            this.Controls.Add(this.numMaxLevelFilter);
            this.Controls.Add(this.lblMaxLevelFilter);
            this.Controls.Add(this.chkLstBoxPvpTypeFilter);
            this.Controls.Add(this.chkLstBoxVocationFilter);
            this.Controls.Add(this.chkLstBoxWorldFilter);
            this.Controls.Add(this.numMinLevelFilter);
            this.Controls.Add(this.lblMinLevelFilter);
            this.Controls.Add(this.chkBoxIsBiddedFilter);
            this.Controls.Add(this.lblBidMaxFilter);
            this.Controls.Add(this.numUpDownBidMaxFilter);
            this.Controls.Add(this.lblMonitorBazaarTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BazaarMonitorAutomaticForm";
            this.Text = "BazaarMonitorAutomaticForm";
            this.Load += new System.EventHandler(this.BazaarMonitorAutomaticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSkillFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinSkillFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLevelFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLevelFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBidMaxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCheckTimeMinutes)).EndInit();
            this.grpBoxEmailDataFields.ResumeLayout(false);
            this.grpBoxEmailDataFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBazaarCheckResultMonitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboBoxSkillsFilter;
        private System.Windows.Forms.NumericUpDown numMaxSkillFilter;
        private System.Windows.Forms.Label lblMaxSkillFilter;
        private System.Windows.Forms.NumericUpDown numMinSkillFilter;
        private System.Windows.Forms.Label lblMinSkillFilter;
        private System.Windows.Forms.NumericUpDown numMaxLevelFilter;
        private System.Windows.Forms.Label lblMaxLevelFilter;
        private System.Windows.Forms.CheckedListBox chkLstBoxPvpTypeFilter;
        private System.Windows.Forms.CheckedListBox chkLstBoxVocationFilter;
        private System.Windows.Forms.CheckedListBox chkLstBoxWorldFilter;
        private System.Windows.Forms.NumericUpDown numMinLevelFilter;
        private System.Windows.Forms.Label lblMinLevelFilter;
        private System.Windows.Forms.CheckBox chkBoxIsBiddedFilter;
        private System.Windows.Forms.Label lblBidMaxFilter;
        private System.Windows.Forms.NumericUpDown numUpDownBidMaxFilter;
        private System.Windows.Forms.Label lblMonitorBazaarTitle;
        private System.Windows.Forms.Button btnBazaarApplyFilter;
        private System.Windows.Forms.Button btnBazaarStartMonitor;
        private System.Windows.Forms.CheckBox chkBoxNotifiedByEmail;
        private System.Windows.Forms.CheckBox chkBoxBlinkTaskBar;
        private System.Windows.Forms.CheckBox chkBoxSendWindowsSound;
        private System.Windows.Forms.NumericUpDown numUpDownCheckTimeMinutes;
        private System.Windows.Forms.Label lblCheckTimeMinutes;
        private System.Windows.Forms.Button btnBazaarStopMonitor;
        private System.Windows.Forms.TextBox txtBoxDisplayEmailName;
        private System.Windows.Forms.Label lblDisplayEmailName;
        private System.Windows.Forms.GroupBox grpBoxEmailDataFields;
        private System.Windows.Forms.Label lblEmailTo;
        private System.Windows.Forms.TextBox txtBoxEmailTo;
        private System.Windows.Forms.Label lblStatusEmailInfo;
        private System.Windows.Forms.Label lblStatusMonitorInfo;
        private System.Windows.Forms.PictureBox picBoxBazaarCheckResultMonitor;
        private System.Windows.Forms.LinkLabel lnkLblBazaarCheckNames;
    }
}