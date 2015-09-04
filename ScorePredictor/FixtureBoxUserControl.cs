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
        private string fixtureId;

        public FixtureBoxUserControl(string fixtureId, string homeTeam, string awayTeam, string date, Image homeTeamImage, Image awayTeamImage)
        {
            InitializeComponent();
            this.homeLabel.Text = homeTeam;
            this.awayLabel.Text = awayTeam;
            this.dateLabel.Text = date;
            this.homeBadgeBox.Image = homeTeamImage;
            this.awayBadgeBox.Image = awayTeamImage;
            this.fixtureId = fixtureId;

        }

        public int getHomeScore()
        {
            return Int32.Parse(homeScoreTextBox.Text);
        }

        public int getAwayScore()
        {
            return Int32.Parse(awayScoreTextBox.Text);
        }

        public string getFixtureId()
        {
            return fixtureId;
        }

        private void homeScoreTextBox_GotFocus(object sender, EventArgs e)
        {
            homeScoreTextBox.SelectAll();
        }

        private void awayScoreTextBox_GotFocus(object sender, EventArgs e)
        {
            awayScoreTextBox.SelectAll();
        }

        private void homeScoreTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            homeScoreTextBox.SelectAll();
        }

        private void awayScoreTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            awayScoreTextBox.SelectAll();
        }
    }
}
