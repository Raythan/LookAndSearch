namespace LookAndSearchInterface
{
    partial class DialogListCharacterNamesForm
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
            this.txtBoxCharactersNames = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxCharactersNames
            // 
            this.txtBoxCharactersNames.Location = new System.Drawing.Point(12, 12);
            this.txtBoxCharactersNames.Multiline = true;
            this.txtBoxCharactersNames.Name = "txtBoxCharactersNames";
            this.txtBoxCharactersNames.Size = new System.Drawing.Size(199, 206);
            this.txtBoxCharactersNames.TabIndex = 0;
            // 
            // DialogListCharacterNamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 230);
            this.Controls.Add(this.txtBoxCharactersNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogListCharacterNamesForm";
            this.Text = "Characters Names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCharactersNames;
    }
}