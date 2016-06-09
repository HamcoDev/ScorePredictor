namespace ScorePredictor
{
    partial class PointsTableUserControl
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
            this.pointsTabControl = new System.Windows.Forms.TabControl();
            this.overallTabPage = new System.Windows.Forms.TabPage();
            this.overallFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.weekTabPage = new System.Windows.Forms.TabPage();
            this.weekFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pointsTabControl.SuspendLayout();
            this.overallTabPage.SuspendLayout();
            this.weekTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pointsTabControl
            // 
            this.pointsTabControl.Controls.Add(this.overallTabPage);
            this.pointsTabControl.Controls.Add(this.weekTabPage);
            this.pointsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointsTabControl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsTabControl.ItemSize = new System.Drawing.Size(360, 25);
            this.pointsTabControl.Location = new System.Drawing.Point(0, 0);
            this.pointsTabControl.Name = "pointsTabControl";
            this.pointsTabControl.SelectedIndex = 0;
            this.pointsTabControl.Size = new System.Drawing.Size(734, 349);
            this.pointsTabControl.TabIndex = 0;
            this.pointsTabControl.SelectedIndexChanged += new System.EventHandler(this.pointsTabControl_SelectedIndexChanged);
            // 
            // overallTabPage
            // 
            this.overallTabPage.BackgroundImage = global::ScorePredictor.Properties.Resources.stadium;
            this.overallTabPage.Controls.Add(this.overallFlowLayoutPanel);
            this.overallTabPage.Location = new System.Drawing.Point(4, 29);
            this.overallTabPage.Name = "overallTabPage";
            this.overallTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.overallTabPage.Size = new System.Drawing.Size(726, 316);
            this.overallTabPage.TabIndex = 0;
            this.overallTabPage.Text = "Overall";
            this.overallTabPage.UseVisualStyleBackColor = true;
            // 
            // overallFlowLayoutPanel
            // 
            this.overallFlowLayoutPanel.AutoScroll = true;
            this.overallFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.overallFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overallFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.overallFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.overallFlowLayoutPanel.Name = "overallFlowLayoutPanel";
            this.overallFlowLayoutPanel.Size = new System.Drawing.Size(720, 310);
            this.overallFlowLayoutPanel.TabIndex = 0;
            this.overallFlowLayoutPanel.WrapContents = false;
            // 
            // weekTabPage
            // 
            this.weekTabPage.Controls.Add(this.weekFlowLayoutPanel);
            this.weekTabPage.Location = new System.Drawing.Point(4, 29);
            this.weekTabPage.Name = "weekTabPage";
            this.weekTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.weekTabPage.Size = new System.Drawing.Size(726, 316);
            this.weekTabPage.TabIndex = 1;
            this.weekTabPage.Text = "This Week";
            this.weekTabPage.UseVisualStyleBackColor = true;
            // 
            // weekFlowLayoutPanel
            // 
            this.weekFlowLayoutPanel.AutoScroll = true;
            this.weekFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.weekFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.weekFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.weekFlowLayoutPanel.Name = "weekFlowLayoutPanel";
            this.weekFlowLayoutPanel.Size = new System.Drawing.Size(720, 310);
            this.weekFlowLayoutPanel.TabIndex = 0;
            this.weekFlowLayoutPanel.WrapContents = false;
            // 
            // PointsTableUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ScorePredictor.Properties.Resources.stadium;
            this.Controls.Add(this.pointsTabControl);
            this.Name = "PointsTableUserControl";
            this.Size = new System.Drawing.Size(734, 349);
            this.pointsTabControl.ResumeLayout(false);
            this.overallTabPage.ResumeLayout(false);
            this.weekTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pointsTabControl;
        private System.Windows.Forms.TabPage overallTabPage;
        private System.Windows.Forms.FlowLayoutPanel overallFlowLayoutPanel;
        private System.Windows.Forms.TabPage weekTabPage;
        private System.Windows.Forms.FlowLayoutPanel weekFlowLayoutPanel;

    }
}
