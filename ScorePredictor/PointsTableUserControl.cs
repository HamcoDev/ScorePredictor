﻿using System.Drawing;
using System.Windows.Forms;

namespace ScorePredictor
{
    public partial class PointsTableUserControl : UserControl
    {
        public PointsTableUserControl()
        {
            InitializeComponent();
            //pointsTabControl.BackColor = Color.Transparent;
        }

        public void RemoveAll()
        {
            overallFlowLayoutPanel.Controls.Clear();
        }

        public void Add(PointsUserControl usercontrol, int tab)
        {
            overallFlowLayoutPanel.Controls.Add(usercontrol);

            //switch (tab)
            //{
            //    case 0:
            //        overallFlowLayoutPanel.Controls.Add(usercontrol);
            //        break;
            //    case 1:
            //        weekFlowLayoutPanel.Controls.Add(usercontrol);
            //        break;
            //}

        }

        private void pointsTabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SuspendLayout();
            PerformLayout();
        }
    }

    
}
