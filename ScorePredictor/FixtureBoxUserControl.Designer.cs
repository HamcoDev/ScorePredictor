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
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(353, 110);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            // 
            // homeLabel
            // 
            this.homeLabel.BackColor = System.Drawing.Color.Azure;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(50, 148);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeLabel.Size = new System.Drawing.Size(200, 21);
            this.homeLabel.TabIndex = 2;
            this.homeLabel.Text = "Home";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // awayLabel
            // 
            this.awayLabel.BackColor = System.Drawing.Color.Azure;
            this.awayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayLabel.Location = new System.Drawing.Point(482, 149);
            this.awayLabel.Name = "awayLabel";
            this.awayLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.awayLabel.Size = new System.Drawing.Size(200, 18);
            this.awayLabel.TabIndex = 4;
            this.awayLabel.Text = "Away";
            this.awayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // awayBadgeBox
            // 
            this.awayBadgeBox.Location = new System.Drawing.Point(395, 139);
            this.awayBadgeBox.Name = "awayBadgeBox";
            this.awayBadgeBox.Size = new System.Drawing.Size(40, 40);
            this.awayBadgeBox.TabIndex = 8;
            this.awayBadgeBox.TabStop = false;
            // 
            // homeScoreTextBox
            // 
            this.homeScoreTextBox.BackColor = System.Drawing.Color.White;
            this.homeScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeScoreTextBox.Location = new System.Drawing.Point(263, 249);
            this.homeScoreTextBox.Multiline = true;
            this.homeScoreTextBox.Name = "homeScoreTextBox";
            this.homeScoreTextBox.Size = new System.Drawing.Size(50, 50);
            this.homeScoreTextBox.TabIndex = 9;
            this.homeScoreTextBox.Text = "0";
            this.homeScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Location = new System.Drawing.Point(358, 153);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(18, 13);
            this.vsLabel.TabIndex = 10;
            this.vsLabel.Text = "vs";
            this.vsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeBadgeBox
            // 
            this.homeBadgeBox.Location = new System.Drawing.Point(297, 139);
            this.homeBadgeBox.Name = "homeBadgeBox";
            this.homeBadgeBox.Size = new System.Drawing.Size(40, 40);
            this.homeBadgeBox.TabIndex = 11;
            this.homeBadgeBox.TabStop = false;
            // 
            // awayScoreTextBox
            // 
            this.awayScoreTextBox.BackColor = System.Drawing.Color.White;
            this.awayScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayScoreTextBox.Location = new System.Drawing.Point(425, 249);
            this.awayScoreTextBox.Multiline = true;
            this.awayScoreTextBox.Name = "awayScoreTextBox";
            this.awayScoreTextBox.Size = new System.Drawing.Size(50, 50);
            this.awayScoreTextBox.TabIndex = 12;
            this.awayScoreTextBox.Text = "0";
            this.awayScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Size = new System.Drawing.Size(734, 421);
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
