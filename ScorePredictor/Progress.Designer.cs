namespace ScorePredictor
{
    partial class Progress
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
            this.submitProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // submitProgressBar
            // 
            this.submitProgressBar.BackColor = System.Drawing.Color.White;
            this.submitProgressBar.Location = new System.Drawing.Point(51, 37);
            this.submitProgressBar.Name = "submitProgressBar";
            this.submitProgressBar.Size = new System.Drawing.Size(203, 34);
            this.submitProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.submitProgressBar.TabIndex = 0;
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 120);
            this.Controls.Add(this.submitProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Progress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submitting Predictions...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar submitProgressBar;
    }
}