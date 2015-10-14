using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScorePredictor
{
    public partial class PointsUserControl : UserControl
    {
        public PointsUserControl()
        {
            InitializeComponent();
        }

        public void setUserPoints(string username, string points)
        {
            nameLabel.Text = username;
            pointsLabel.Text = points;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
