namespace ScorePredictor
{
    partial class FixtureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixtureBox));
            this.fixturesPanel = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.awayLabel = new System.Windows.Forms.Label();
            this.vsLabel = new System.Windows.Forms.Label();
            this.homeBadgeBox = new System.Windows.Forms.PictureBox();
            this.awayBadgeBox = new System.Windows.Forms.PictureBox();
            this.homeScoreTextBox = new System.Windows.Forms.TextBox();
            this.awayScoreTextBox = new System.Windows.Forms.PictureBox();
            this.fixturesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBadgeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayBadgeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayScoreTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fixturesPanel
            // 
            this.fixturesPanel.BackColor = System.Drawing.Color.Transparent;
            this.fixturesPanel.Controls.Add(this.awayScoreTextBox);
            this.fixturesPanel.Controls.Add(this.homeScoreTextBox);
            this.fixturesPanel.Controls.Add(this.awayBadgeBox);
            this.fixturesPanel.Controls.Add(this.homeBadgeBox);
            this.fixturesPanel.Controls.Add(this.vsLabel);
            this.fixturesPanel.Controls.Add(this.awayLabel);
            this.fixturesPanel.Controls.Add(this.homeLabel);
            this.fixturesPanel.Controls.Add(this.dateLabel);
            this.fixturesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixturesPanel.Location = new System.Drawing.Point(0, 0);
            this.fixturesPanel.Name = "fixturesPanel";
            this.fixturesPanel.Size = new System.Drawing.Size(734, 421);
            this.fixturesPanel.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(363, 89);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date";
            // 
            // homeLabel
            // 
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(84, 152);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeLabel.Size = new System.Drawing.Size(200, 21);
            this.homeLabel.TabIndex = 1;
            this.homeLabel.Text = "Home";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // awayLabel
            // 
            this.awayLabel.BackColor = System.Drawing.Color.Transparent;
            this.awayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayLabel.Location = new System.Drawing.Point(452, 155);
            this.awayLabel.Name = "awayLabel";
            this.awayLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.awayLabel.Size = new System.Drawing.Size(200, 18);
            this.awayLabel.TabIndex = 3;
            this.awayLabel.Text = "Away";
            this.awayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Location = new System.Drawing.Point(363, 190);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(18, 13);
            this.vsLabel.TabIndex = 4;
            this.vsLabel.Text = "vs";
            this.vsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeBadgeBox
            // 
            this.homeBadgeBox.Location = new System.Drawing.Point(244, 227);
            this.homeBadgeBox.Name = "homeBadgeBox";
            this.homeBadgeBox.Size = new System.Drawing.Size(40, 40);
            this.homeBadgeBox.TabIndex = 6;
            this.homeBadgeBox.TabStop = false;
            // 
            // awayBadgeBox
            // 
            this.awayBadgeBox.Location = new System.Drawing.Point(455, 227);
            this.awayBadgeBox.Name = "awayBadgeBox";
            this.awayBadgeBox.Size = new System.Drawing.Size(40, 40);
            this.awayBadgeBox.TabIndex = 7;
            this.awayBadgeBox.TabStop = false;
            // 
            // homeScoreTextBox
            // 
            this.homeScoreTextBox.BackColor = System.Drawing.Color.White;
            this.homeScoreTextBox.Location = new System.Drawing.Point(313, 142);
            this.homeScoreTextBox.Multiline = true;
            this.homeScoreTextBox.Name = "homeScoreTextBox";
            this.homeScoreTextBox.Size = new System.Drawing.Size(40, 40);
            this.homeScoreTextBox.TabIndex = 8;
            // 
            // awayScoreTextBox
            // 
            this.awayScoreTextBox.BackColor = System.Drawing.Color.White;
            this.awayScoreTextBox.ErrorImage = null;
            this.awayScoreTextBox.Location = new System.Drawing.Point(387, 142);
            this.awayScoreTextBox.Name = "awayScoreTextBox";
            this.awayScoreTextBox.Size = new System.Drawing.Size(40, 40);
            this.awayScoreTextBox.TabIndex = 9;
            this.awayScoreTextBox.TabStop = false;
            // 
            // FixtureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 421);
            this.Controls.Add(this.fixturesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FixtureBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FixtureBox";
            this.fixturesPanel.ResumeLayout(false);
            this.fixturesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBadgeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayBadgeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayScoreTextBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fixturesPanel;
        internal System.Windows.Forms.PictureBox awayScoreTextBox;
        private System.Windows.Forms.TextBox homeScoreTextBox;
        internal System.Windows.Forms.PictureBox awayBadgeBox;
        internal System.Windows.Forms.PictureBox homeBadgeBox;
        internal System.Windows.Forms.Label vsLabel;
        internal System.Windows.Forms.Label awayLabel;
        internal System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}