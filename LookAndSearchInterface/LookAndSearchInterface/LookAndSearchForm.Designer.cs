namespace LookAndSearchInterface
{
    partial class MainForm
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
            this.cboBoxMenuSelector = new System.Windows.Forms.ComboBox();
            this.panelLookAndSearch = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cboBoxMenuSelector
            // 
            this.cboBoxMenuSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxMenuSelector.FormattingEnabled = true;
            this.cboBoxMenuSelector.Location = new System.Drawing.Point(12, 12);
            this.cboBoxMenuSelector.Name = "cboBoxMenuSelector";
            this.cboBoxMenuSelector.Size = new System.Drawing.Size(560, 21);
            this.cboBoxMenuSelector.TabIndex = 0;
            this.cboBoxMenuSelector.SelectedIndexChanged += new System.EventHandler(this.cboBoxMenuSelector_SelectedIndexChanged);
            // 
            // panelLookAndSearch
            // 
            this.panelLookAndSearch.Location = new System.Drawing.Point(12, 39);
            this.panelLookAndSearch.Name = "panelLookAndSearch";
            this.panelLookAndSearch.Size = new System.Drawing.Size(560, 510);
            this.panelLookAndSearch.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panelLookAndSearch);
            this.Controls.Add(this.cboBoxMenuSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Watch Info!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBoxMenuSelector;
        private System.Windows.Forms.Panel panelLookAndSearch;
    }
}

