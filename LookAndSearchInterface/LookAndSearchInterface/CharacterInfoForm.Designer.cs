namespace LookAndSearchInterface
{
    partial class CharacterInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCharacterInfoTitle = new System.Windows.Forms.Label();
            this.txtBoxCharacterNameSearch = new System.Windows.Forms.TextBox();
            this.btnCharacterSearch = new System.Windows.Forms.Button();
            this.dtaGridCharacterInformationList = new System.Windows.Forms.DataGridView();
            this.dtaGridAchievementInformationList = new System.Windows.Forms.DataGridView();
            this.dtaGridDeathInformationList = new System.Windows.Forms.DataGridView();
            this.dtaGridCharacterInformation = new System.Windows.Forms.DataGridView();
            this.cboBoxTheme = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridCharacterInformationList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridAchievementInformationList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridDeathInformationList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridCharacterInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCharacterInfoTitle
            // 
            this.lblCharacterInfoTitle.AutoSize = true;
            this.lblCharacterInfoTitle.Location = new System.Drawing.Point(12, 9);
            this.lblCharacterInfoTitle.Name = "lblCharacterInfoTitle";
            this.lblCharacterInfoTitle.Size = new System.Drawing.Size(74, 13);
            this.lblCharacterInfoTitle.TabIndex = 0;
            this.lblCharacterInfoTitle.Text = "Character Info";
            // 
            // txtBoxCharacterNameSearch
            // 
            this.txtBoxCharacterNameSearch.Location = new System.Drawing.Point(12, 25);
            this.txtBoxCharacterNameSearch.Name = "txtBoxCharacterNameSearch";
            this.txtBoxCharacterNameSearch.Size = new System.Drawing.Size(328, 20);
            this.txtBoxCharacterNameSearch.TabIndex = 1;
            // 
            // btnCharacterSearch
            // 
            this.btnCharacterSearch.Location = new System.Drawing.Point(346, 24);
            this.btnCharacterSearch.Name = "btnCharacterSearch";
            this.btnCharacterSearch.Size = new System.Drawing.Size(75, 22);
            this.btnCharacterSearch.TabIndex = 2;
            this.btnCharacterSearch.Text = "Search";
            this.btnCharacterSearch.UseVisualStyleBackColor = true;
            this.btnCharacterSearch.Click += new System.EventHandler(this.btnCharacterSearch_Click);
            // 
            // dtaGridCharacterInformationList
            // 
            this.dtaGridCharacterInformationList.AllowUserToAddRows = false;
            this.dtaGridCharacterInformationList.AllowUserToDeleteRows = false;
            this.dtaGridCharacterInformationList.AllowUserToOrderColumns = true;
            this.dtaGridCharacterInformationList.AllowUserToResizeRows = false;
            this.dtaGridCharacterInformationList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtaGridCharacterInformationList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtaGridCharacterInformationList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtaGridCharacterInformationList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridCharacterInformationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dtaGridCharacterInformationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaGridCharacterInformationList.DefaultCellStyle = dataGridViewCellStyle26;
            this.dtaGridCharacterInformationList.EnableHeadersVisualStyles = false;
            this.dtaGridCharacterInformationList.GridColor = System.Drawing.Color.White;
            this.dtaGridCharacterInformationList.Location = new System.Drawing.Point(268, 51);
            this.dtaGridCharacterInformationList.Name = "dtaGridCharacterInformationList";
            this.dtaGridCharacterInformationList.ReadOnly = true;
            this.dtaGridCharacterInformationList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridCharacterInformationList.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dtaGridCharacterInformationList.RowHeadersVisible = false;
            this.dtaGridCharacterInformationList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtaGridCharacterInformationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGridCharacterInformationList.Size = new System.Drawing.Size(280, 150);
            this.dtaGridCharacterInformationList.TabIndex = 4;
            // 
            // dtaGridAchievementInformationList
            // 
            this.dtaGridAchievementInformationList.AllowUserToAddRows = false;
            this.dtaGridAchievementInformationList.AllowUserToDeleteRows = false;
            this.dtaGridAchievementInformationList.AllowUserToOrderColumns = true;
            this.dtaGridAchievementInformationList.AllowUserToResizeRows = false;
            this.dtaGridAchievementInformationList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtaGridAchievementInformationList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtaGridAchievementInformationList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtaGridAchievementInformationList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridAchievementInformationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dtaGridAchievementInformationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaGridAchievementInformationList.DefaultCellStyle = dataGridViewCellStyle29;
            this.dtaGridAchievementInformationList.EnableHeadersVisualStyles = false;
            this.dtaGridAchievementInformationList.GridColor = System.Drawing.Color.White;
            this.dtaGridAchievementInformationList.Location = new System.Drawing.Point(268, 207);
            this.dtaGridAchievementInformationList.Name = "dtaGridAchievementInformationList";
            this.dtaGridAchievementInformationList.ReadOnly = true;
            this.dtaGridAchievementInformationList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridAchievementInformationList.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dtaGridAchievementInformationList.RowHeadersVisible = false;
            this.dtaGridAchievementInformationList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtaGridAchievementInformationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGridAchievementInformationList.Size = new System.Drawing.Size(280, 150);
            this.dtaGridAchievementInformationList.TabIndex = 8;
            // 
            // dtaGridDeathInformationList
            // 
            this.dtaGridDeathInformationList.AllowUserToAddRows = false;
            this.dtaGridDeathInformationList.AllowUserToDeleteRows = false;
            this.dtaGridDeathInformationList.AllowUserToOrderColumns = true;
            this.dtaGridDeathInformationList.AllowUserToResizeRows = false;
            this.dtaGridDeathInformationList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtaGridDeathInformationList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtaGridDeathInformationList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtaGridDeathInformationList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaGridDeathInformationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dtaGridDeathInformationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridDeathInformationList.DefaultCellStyle = dataGridViewCellStyle32;
            this.dtaGridDeathInformationList.EnableHeadersVisualStyles = false;
            this.dtaGridDeathInformationList.GridColor = System.Drawing.Color.White;
            this.dtaGridDeathInformationList.Location = new System.Drawing.Point(12, 367);
            this.dtaGridDeathInformationList.Name = "dtaGridDeathInformationList";
            this.dtaGridDeathInformationList.ReadOnly = true;
            this.dtaGridDeathInformationList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridDeathInformationList.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dtaGridDeathInformationList.RowHeadersVisible = false;
            this.dtaGridDeathInformationList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtaGridDeathInformationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGridDeathInformationList.Size = new System.Drawing.Size(536, 131);
            this.dtaGridDeathInformationList.TabIndex = 9;
            // 
            // dtaGridCharacterInformation
            // 
            this.dtaGridCharacterInformation.AllowUserToAddRows = false;
            this.dtaGridCharacterInformation.AllowUserToDeleteRows = false;
            this.dtaGridCharacterInformation.AllowUserToOrderColumns = true;
            this.dtaGridCharacterInformation.AllowUserToResizeRows = false;
            this.dtaGridCharacterInformation.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtaGridCharacterInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtaGridCharacterInformation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtaGridCharacterInformation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaGridCharacterInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dtaGridCharacterInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaGridCharacterInformation.DefaultCellStyle = dataGridViewCellStyle35;
            this.dtaGridCharacterInformation.EnableHeadersVisualStyles = false;
            this.dtaGridCharacterInformation.GridColor = System.Drawing.Color.White;
            this.dtaGridCharacterInformation.Location = new System.Drawing.Point(12, 51);
            this.dtaGridCharacterInformation.Name = "dtaGridCharacterInformation";
            this.dtaGridCharacterInformation.ReadOnly = true;
            this.dtaGridCharacterInformation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridCharacterInformation.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dtaGridCharacterInformation.RowHeadersVisible = false;
            this.dtaGridCharacterInformation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtaGridCharacterInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGridCharacterInformation.Size = new System.Drawing.Size(250, 310);
            this.dtaGridCharacterInformation.TabIndex = 10;
            // 
            // cboBoxTheme
            // 
            this.cboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxTheme.FormattingEnabled = true;
            this.cboBoxTheme.Location = new System.Drawing.Point(427, 25);
            this.cboBoxTheme.Name = "cboBoxTheme";
            this.cboBoxTheme.Size = new System.Drawing.Size(121, 21);
            this.cboBoxTheme.TabIndex = 11;
            this.cboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.cboBoxTheme_SelectedIndexChanged);
            // 
            // CharacterInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.Controls.Add(this.cboBoxTheme);
            this.Controls.Add(this.dtaGridCharacterInformation);
            this.Controls.Add(this.dtaGridDeathInformationList);
            this.Controls.Add(this.dtaGridAchievementInformationList);
            this.Controls.Add(this.dtaGridCharacterInformationList);
            this.Controls.Add(this.btnCharacterSearch);
            this.Controls.Add(this.txtBoxCharacterNameSearch);
            this.Controls.Add(this.lblCharacterInfoTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CharacterInfoForm";
            this.Text = "CharacterInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridCharacterInformationList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridAchievementInformationList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridDeathInformationList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridCharacterInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCharacterInfoTitle;
        private System.Windows.Forms.TextBox txtBoxCharacterNameSearch;
        private System.Windows.Forms.Button btnCharacterSearch;
        private System.Windows.Forms.DataGridView dtaGridCharacterInformationList;
        private System.Windows.Forms.DataGridView dtaGridAchievementInformationList;
        private System.Windows.Forms.DataGridView dtaGridDeathInformationList;
        private System.Windows.Forms.DataGridView dtaGridCharacterInformation;
        private System.Windows.Forms.ComboBox cboBoxTheme;
    }
}