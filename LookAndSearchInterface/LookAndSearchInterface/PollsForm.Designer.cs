namespace LookAndSearchInterface
{
    partial class PollsForm
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
            this.lblPollsTitle = new System.Windows.Forms.Label();
            this.lblPollsLastTimeUpdate = new System.Windows.Forms.Label();
            this.lblPollsStatus = new System.Windows.Forms.Label();
            this.lblPollsStatusValue = new System.Windows.Forms.Label();
            this.cboBoxPollsTopicsData = new System.Windows.Forms.ComboBox();
            this.grpBoxPollsTopics = new System.Windows.Forms.GroupBox();
            this.btnRefreshPollsInfo = new System.Windows.Forms.Button();
            this.lnkLabelPollsToRedirectClick = new System.Windows.Forms.LinkLabel();
            this.lblPollsEndDateValue = new System.Windows.Forms.Label();
            this.lnkLblPollsTopicAnchorDisabled = new System.Windows.Forms.LinkLabel();
            this.lblPollsEndDate = new System.Windows.Forms.Label();
            this.grpBoxPollsTopics.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPollsTitle
            // 
            this.lblPollsTitle.AutoSize = true;
            this.lblPollsTitle.Location = new System.Drawing.Point(9, 9);
            this.lblPollsTitle.Name = "lblPollsTitle";
            this.lblPollsTitle.Size = new System.Drawing.Size(29, 13);
            this.lblPollsTitle.TabIndex = 0;
            this.lblPollsTitle.Text = "Polls";
            // 
            // lblPollsLastTimeUpdate
            // 
            this.lblPollsLastTimeUpdate.AutoSize = true;
            this.lblPollsLastTimeUpdate.Location = new System.Drawing.Point(9, 488);
            this.lblPollsLastTimeUpdate.Name = "lblPollsLastTimeUpdate";
            this.lblPollsLastTimeUpdate.Size = new System.Drawing.Size(176, 13);
            this.lblPollsLastTimeUpdate.TabIndex = 1;
            this.lblPollsLastTimeUpdate.Text = "Last time updated: Not updated yet!";
            // 
            // lblPollsStatus
            // 
            this.lblPollsStatus.AutoSize = true;
            this.lblPollsStatus.Location = new System.Drawing.Point(6, 43);
            this.lblPollsStatus.Name = "lblPollsStatus";
            this.lblPollsStatus.Size = new System.Drawing.Size(40, 13);
            this.lblPollsStatus.TabIndex = 3;
            this.lblPollsStatus.Text = "Status:";
            // 
            // lblPollsStatusValue
            // 
            this.lblPollsStatusValue.AutoSize = true;
            this.lblPollsStatusValue.Location = new System.Drawing.Point(108, 43);
            this.lblPollsStatusValue.Name = "lblPollsStatusValue";
            this.lblPollsStatusValue.Size = new System.Drawing.Size(37, 13);
            this.lblPollsStatusValue.TabIndex = 4;
            this.lblPollsStatusValue.Text = "Active";
            // 
            // cboBoxPollsTopicsData
            // 
            this.cboBoxPollsTopicsData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxPollsTopicsData.FormattingEnabled = true;
            this.cboBoxPollsTopicsData.Location = new System.Drawing.Point(6, 19);
            this.cboBoxPollsTopicsData.Name = "cboBoxPollsTopicsData";
            this.cboBoxPollsTopicsData.Size = new System.Drawing.Size(524, 21);
            this.cboBoxPollsTopicsData.TabIndex = 5;
            this.cboBoxPollsTopicsData.SelectedIndexChanged += new System.EventHandler(this.cboBoxPollsTopicsData_SelectedIndexChanged);
            // 
            // grpBoxPollsTopics
            // 
            this.grpBoxPollsTopics.Controls.Add(this.btnRefreshPollsInfo);
            this.grpBoxPollsTopics.Controls.Add(this.lnkLabelPollsToRedirectClick);
            this.grpBoxPollsTopics.Controls.Add(this.lblPollsEndDateValue);
            this.grpBoxPollsTopics.Controls.Add(this.lnkLblPollsTopicAnchorDisabled);
            this.grpBoxPollsTopics.Controls.Add(this.lblPollsEndDate);
            this.grpBoxPollsTopics.Controls.Add(this.cboBoxPollsTopicsData);
            this.grpBoxPollsTopics.Controls.Add(this.lblPollsStatus);
            this.grpBoxPollsTopics.Controls.Add(this.lblPollsStatusValue);
            this.grpBoxPollsTopics.Location = new System.Drawing.Point(12, 28);
            this.grpBoxPollsTopics.Name = "grpBoxPollsTopics";
            this.grpBoxPollsTopics.Size = new System.Drawing.Size(536, 457);
            this.grpBoxPollsTopics.TabIndex = 7;
            this.grpBoxPollsTopics.TabStop = false;
            this.grpBoxPollsTopics.Text = "Topics";
            // 
            // btnRefreshPollsInfo
            // 
            this.btnRefreshPollsInfo.Location = new System.Drawing.Point(6, 108);
            this.btnRefreshPollsInfo.Name = "btnRefreshPollsInfo";
            this.btnRefreshPollsInfo.Size = new System.Drawing.Size(208, 58);
            this.btnRefreshPollsInfo.TabIndex = 10;
            this.btnRefreshPollsInfo.Text = "Refresh!";
            this.btnRefreshPollsInfo.UseVisualStyleBackColor = true;
            this.btnRefreshPollsInfo.Click += new System.EventHandler(this.btnRefreshPollsInfo_Click);
            // 
            // lnkLabelPollsToRedirectClick
            // 
            this.lnkLabelPollsToRedirectClick.AutoSize = true;
            this.lnkLabelPollsToRedirectClick.Location = new System.Drawing.Point(6, 69);
            this.lnkLabelPollsToRedirectClick.Name = "lnkLabelPollsToRedirectClick";
            this.lnkLabelPollsToRedirectClick.Size = new System.Drawing.Size(211, 13);
            this.lnkLabelPollsToRedirectClick.TabIndex = 9;
            this.lnkLabelPollsToRedirectClick.TabStop = true;
            this.lnkLabelPollsToRedirectClick.Text = "Double click here for check the official poll!";
            this.lnkLabelPollsToRedirectClick.DoubleClick += new System.EventHandler(this.lnkLabelPollsToRedirectClick_DoubleClick);
            // 
            // lblPollsEndDateValue
            // 
            this.lblPollsEndDateValue.AutoSize = true;
            this.lblPollsEndDateValue.Location = new System.Drawing.Point(108, 56);
            this.lblPollsEndDateValue.Name = "lblPollsEndDateValue";
            this.lblPollsEndDateValue.Size = new System.Drawing.Size(82, 13);
            this.lblPollsEndDateValue.TabIndex = 7;
            this.lblPollsEndDateValue.Text = "End Date Value";
            // 
            // lnkLblPollsTopicAnchorDisabled
            // 
            this.lnkLblPollsTopicAnchorDisabled.AutoSize = true;
            this.lnkLblPollsTopicAnchorDisabled.Enabled = false;
            this.lnkLblPollsTopicAnchorDisabled.Location = new System.Drawing.Point(6, 82);
            this.lnkLblPollsTopicAnchorDisabled.Name = "lnkLblPollsTopicAnchorDisabled";
            this.lnkLblPollsTopicAnchorDisabled.Size = new System.Drawing.Size(85, 13);
            this.lnkLblPollsTopicAnchorDisabled.TabIndex = 8;
            this.lnkLblPollsTopicAnchorDisabled.TabStop = true;
            this.lnkLblPollsTopicAnchorDisabled.Text = "Anchor Disabled";
            this.lnkLblPollsTopicAnchorDisabled.Visible = false;
            // 
            // lblPollsEndDate
            // 
            this.lblPollsEndDate.AutoSize = true;
            this.lblPollsEndDate.Location = new System.Drawing.Point(6, 56);
            this.lblPollsEndDate.Name = "lblPollsEndDate";
            this.lblPollsEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblPollsEndDate.TabIndex = 6;
            this.lblPollsEndDate.Text = "End Date:";
            // 
            // PollsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.Controls.Add(this.grpBoxPollsTopics);
            this.Controls.Add(this.lblPollsLastTimeUpdate);
            this.Controls.Add(this.lblPollsTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PollsForm";
            this.Text = "PollsForm";
            this.grpBoxPollsTopics.ResumeLayout(false);
            this.grpBoxPollsTopics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPollsTitle;
        private System.Windows.Forms.Label lblPollsLastTimeUpdate;
        private System.Windows.Forms.Label lblPollsStatus;
        private System.Windows.Forms.Label lblPollsStatusValue;
        private System.Windows.Forms.ComboBox cboBoxPollsTopicsData;
        private System.Windows.Forms.GroupBox grpBoxPollsTopics;
        private System.Windows.Forms.LinkLabel lnkLblPollsTopicAnchorDisabled;
        private System.Windows.Forms.Label lblPollsEndDateValue;
        private System.Windows.Forms.Label lblPollsEndDate;
        private System.Windows.Forms.LinkLabel lnkLabelPollsToRedirectClick;
        private System.Windows.Forms.Button btnRefreshPollsInfo;
    }
}