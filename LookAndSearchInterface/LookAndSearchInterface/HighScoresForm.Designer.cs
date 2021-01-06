namespace LookAndSearchInterface
{
    partial class HighScoreForm
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
            this.lblHighScoresTitle = new System.Windows.Forms.Label();
            this.dtGridViewHighScores = new System.Windows.Forms.DataGridView();
            this.lblHighScoreLastTimeUpdate = new System.Windows.Forms.Label();
            this.btnHighScoreRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewHighScores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHighScoresTitle
            // 
            this.lblHighScoresTitle.AutoSize = true;
            this.lblHighScoresTitle.Location = new System.Drawing.Point(12, 9);
            this.lblHighScoresTitle.Name = "lblHighScoresTitle";
            this.lblHighScoresTitle.Size = new System.Drawing.Size(65, 13);
            this.lblHighScoresTitle.TabIndex = 0;
            this.lblHighScoresTitle.Text = "High Scores";
            // 
            // dtGridViewHighScores
            // 
            this.dtGridViewHighScores.AllowUserToAddRows = false;
            this.dtGridViewHighScores.AllowUserToDeleteRows = false;
            this.dtGridViewHighScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewHighScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewHighScores.Location = new System.Drawing.Point(12, 25);
            this.dtGridViewHighScores.Name = "dtGridViewHighScores";
            this.dtGridViewHighScores.ReadOnly = true;
            this.dtGridViewHighScores.RowHeadersVisible = false;
            this.dtGridViewHighScores.Size = new System.Drawing.Size(536, 415);
            this.dtGridViewHighScores.TabIndex = 1;
            // 
            // lblHighScoreLastTimeUpdate
            // 
            this.lblHighScoreLastTimeUpdate.AutoSize = true;
            this.lblHighScoreLastTimeUpdate.Location = new System.Drawing.Point(201, 485);
            this.lblHighScoreLastTimeUpdate.Name = "lblHighScoreLastTimeUpdate";
            this.lblHighScoreLastTimeUpdate.Size = new System.Drawing.Size(138, 13);
            this.lblHighScoreLastTimeUpdate.TabIndex = 2;
            this.lblHighScoreLastTimeUpdate.Text = "Data da última atualização: ";
            // 
            // btnHighScoreRefresh
            // 
            this.btnHighScoreRefresh.Location = new System.Drawing.Point(12, 446);
            this.btnHighScoreRefresh.Name = "btnHighScoreRefresh";
            this.btnHighScoreRefresh.Size = new System.Drawing.Size(183, 52);
            this.btnHighScoreRefresh.TabIndex = 3;
            this.btnHighScoreRefresh.Text = "Atualizar!";
            this.btnHighScoreRefresh.UseVisualStyleBackColor = true;
            this.btnHighScoreRefresh.Click += new System.EventHandler(this.btnHighScoreRefresh_Click);
            // 
            // HighScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.Controls.Add(this.btnHighScoreRefresh);
            this.Controls.Add(this.lblHighScoreLastTimeUpdate);
            this.Controls.Add(this.dtGridViewHighScores);
            this.Controls.Add(this.lblHighScoresTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HighScoreForm";
            this.Text = "High Scores";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewHighScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHighScoresTitle;
        private System.Windows.Forms.DataGridView dtGridViewHighScores;
        private System.Windows.Forms.Label lblHighScoreLastTimeUpdate;
        private System.Windows.Forms.Button btnHighScoreRefresh;
    }
}