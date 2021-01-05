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
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBidMaxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLevelFilter)).BeginInit();
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
            this.lblDtaAtualizacaoBazaar.Location = new System.Drawing.Point(12, 288);
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
            this.lstBoxCharacterNamesValues.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBoxCharacterNamesValues.Size = new System.Drawing.Size(220, 212);
            this.lstBoxCharacterNamesValues.TabIndex = 7;
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
            // BazaarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 310);
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
    }
}