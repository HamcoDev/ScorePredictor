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
    public partial class FixtureBoxUserControl : UserControl
    {
        public FixtureBoxUserControl(string homeTeam, string awayTeam, string date, Image homeTeamImage, Image awayTeamImage)
        {
            InitializeComponent();
            this.homeLabel.Text = homeTeam;
            this.awayLabel.Text = awayTeam;
            this.dateLabel.Text = date;
            this.homeBadgeBox.Image = homeTeamImage;
            this.awayBadgeBox.Image = awayTeamImage;

        }
    }
}
