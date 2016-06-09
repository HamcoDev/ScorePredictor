namespace ScorePredictor
{
    partial class FixtureBoxUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixtureBoxUserControl));
            this.dateLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.awayLabel = new System.Windows.Forms.Label();
            this.awayBadgeBox = new System.Windows.Forms.PictureBox();
            this.homeScoreTextBox = new System.Windows.Forms.TextBox();
            this.vsLabel = new System.Windows.Forms.Label();
            this.homeBadgeBox = new System.Windows.Forms.PictureBox();
            this.awayScoreTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.awayBadgeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBadgeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateLabel.Location = new System.Drawing.Point(304, 244);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 14);
            this.dateLabel.TabIndex = 100;
            this.dateLabel.Text = "Date";
            // 
            // homeLabel
            // 
            this.homeLabel.BackColor = System.Drawing.Color.Transparent;
            this.homeLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.homeLabel.ForeColor = System.Drawing.Color.White;
            this.homeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.homeLabel.Location = new System.Drawing.Point(69, 56);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeLabel.Size = new System.Drawing.Size(200, 29);
            this.homeLabel.TabIndex = 100;
            this.homeLabel.Text = "Home";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // awayLabel
            // 
            this.awayLabel.BackColor = System.Drawing.Color.Transparent;
            this.awayLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.awayLabel.ForeColor = System.Drawing.Color.White;
            this.awayLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.awayLabel.Location = new System.Drawing.Point(480, 57);
            this.awayLabel.Name = "awayLabel";
            this.awayLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.awayLabel.Size = new System.Drawing.Size(200, 28);
            this.awayLabel.TabIndex = 100;
            this.awayLabel.Text = "Away";
            this.awayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // awayBadgeBox
            // 
            this.awayBadgeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.awayBadgeBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.awayBadgeBox.Location = new System.Drawing.Point(411, 85);
            this.awayBadgeBox.Name = "awayBadgeBox";
            this.awayBadgeBox.Size = new System.Drawing.Size(48, 48);
            this.awayBadgeBox.TabIndex = 8;
            this.awayBadgeBox.TabStop = false;
            // 
            // homeScoreTextBox
            // 
            this.homeScoreTextBox.BackColor = System.Drawing.Color.White;
            this.homeScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.homeScoreTextBox.Location = new System.Drawing.Point(307, 158);
            this.homeScoreTextBox.Multiline = true;
            this.homeScoreTextBox.Name = "homeScoreTextBox";
            this.homeScoreTextBox.Size = new System.Drawing.Size(50, 50);
            this.homeScoreTextBox.TabIndex = 0;
            this.homeScoreTextBox.Text = "0";
            this.homeScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.homeScoreTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.homeScoreTextBox_MouseClick);
            this.homeScoreTextBox.TextChanged += new System.EventHandler(this.homeScoreTextBox_TextChanged);
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vsLabel.Location = new System.Drawing.Point(367, 99);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(18, 13);
            this.vsLabel.TabIndex = 100;
            this.vsLabel.Text = "vs";
            this.vsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeBadgeBox
            // 
            this.homeBadgeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeBadgeBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.homeBadgeBox.Location = new System.Drawing.Point(294, 85);
            this.homeBadgeBox.Name = "homeBadgeBox";
            this.homeBadgeBox.Size = new System.Drawing.Size(48, 48);
            this.homeBadgeBox.TabIndex = 11;
            this.homeBadgeBox.TabStop = false;
            // 
            // awayScoreTextBox
            // 
            this.awayScoreTextBox.BackColor = System.Drawing.Color.White;
            this.awayScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.awayScoreTextBox.Location = new System.Drawing.Point(395, 158);
            this.awayScoreTextBox.Multiline = true;
            this.awayScoreTextBox.Name = "awayScoreTextBox";
            this.awayScoreTextBox.Size = new System.Drawing.Size(50, 50);
            this.awayScoreTextBox.TabIndex = 1;
            this.awayScoreTextBox.Text = "0";
            this.awayScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.awayScoreTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.awayScoreTextBox_MouseClick);
            // 
            // FixtureBoxUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.awayScoreTextBox);
            this.Controls.Add(this.homeBadgeBox);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.homeScoreTextBox);
            this.Controls.Add(this.awayBadgeBox);
            this.Controls.Add(this.awayLabel);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.dateLabel);
            this.Name = "FixtureBoxUserControl";
            this.Size = new System.Drawing.Size(734, 349);
            this.Load += new System.EventHandler(this.homeScoreTextBox_GotFocus);
            ((System.ComponentModel.ISupportInitialize)(this.awayBadgeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBadgeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        internal System.Windows.Forms.Label homeLabel;
        internal System.Windows.Forms.Label awayLabel;
        internal System.Windows.Forms.PictureBox awayBadgeBox;
        private System.Windows.Forms.TextBox homeScoreTextBox;
        internal System.Windows.Forms.Label vsLabel;
        internal System.Windows.Forms.PictureBox homeBadgeBox;
        private System.Windows.Forms.TextBox awayScoreTextBox;
    }
}
