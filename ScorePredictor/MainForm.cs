using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScorePredictor
{
    public partial class MainForm : Form
    {
        private List<FixtureBoxUserControl> fixtureBoxList;
        private int fix;
        private int listSize;
        private AppController app = AppController.Instance;
        private PointsTableUserControl tableUsercontrol = new PointsTableUserControl();

        public MainForm()
        {
            InitializeComponent();
            nextButton.Visible = false;
            backButton.Visible = false;
            submitButton.Visible = false;
            menuButton.Visible = false;
            settingsButton.Enabled = false;
        }

        private void fixturesButton_Click(object sender, EventArgs e)
        {

            fixtureBoxList = app.getFixtures();
            listSize = fixtureBoxList.Count - 1;
            foreach (FixtureBoxUserControl fb in fixtureBoxList)
            {
                mainPanel.Controls.Add(fb);
                fb.Visible = false;
            }

            if (fixtureBoxList.Count != 0)
            {
                fix = 0;
                tablePanel.Visible = false;
                submitButton.Visible = false;
                backButton.Enabled = false;
                fixtureBoxList[fix].Visible = true;
                nextButton.Visible = true;
                backButton.Visible = true;
                menuButton.Visible = true;
            }
            
        }

        private void shutdownButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            var fb = new FixtureBuilder();
            var weekStats = fb.getWeekStats();
            var totalStats = fb.getTotalStats();

            tablePanel.Visible = false;
            submitButton.Visible = false;
            backButton.Enabled = false;

            try
            {
                fixtureBoxList[fix].Visible = false;
            }
            catch (Exception ex){}
            nextButton.Visible = false;
            backButton.Visible = false;
            menuButton.Visible = true;

            mainPanel.Controls.Add(tableUsercontrol);

            foreach (KeyValuePair<string, int> user in weekStats)
            {
                var pointsUserControl = new PointsUserControl();
                pointsUserControl.setUserPoints(user.Key + "    " + user.Value, user.Value.ToString());
                tableUsercontrol.Add(pointsUserControl, 1);
            }

            foreach (KeyValuePair<string, int> user in totalStats)
            {
                var pointsUserControl = new PointsUserControl();
                pointsUserControl.setUserPoints(user.Key + "    " + user.Value, user.Value.ToString());
                tableUsercontrol.Add(pointsUserControl, 0);
            }
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            fixtureBoxList[fix].Visible = false;
            fix += 1;
            fixtureBoxList[fix].Visible = true;
            
            if (fix == listSize)
            {
                backButton.Enabled = true;
                backButton.Visible = true;
                nextButton.Visible = false;
                submitButton.Visible = true;
                submitButton.Enabled = true;

            }
            else if (fix > 0)
            {
                backButton.Enabled = true;
                backButton.Visible = true;
                nextButton.Visible = true;
                nextButton.Visible = true;
                submitButton.Visible = false;
            }
            else
            {
                backButton.Visible = true;
                backButton.Enabled = false;
                nextButton.Visible = true;
                nextButton.Enabled = true;
                submitButton.Visible = false;
            }
            ResumeLayout();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            fixtureBoxList[fix].Visible = false;
            fix -= 1;
            fixtureBoxList[fix].Visible = true;

            if (fix == listSize)
            {
                backButton.Enabled = true;
                backButton.Visible = true;
                nextButton.Visible = false;
                submitButton.Visible = true;
                submitButton.Enabled = true;
            }
            else if (fix > 0)
            {
                backButton.Enabled = true;
                backButton.Visible = true;
                nextButton.Visible = true;
                nextButton.Visible = true;
                submitButton.Visible = false;
            }
            else
            {
                backButton.Visible = true;
                backButton.Enabled = false;
                nextButton.Visible = true;
                nextButton.Enabled = true;
                submitButton.Visible = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                app.submitPredictions();
                MessageBox.Show("Predictions submitted.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Error - One or more fixtures contain invalid score predictions.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - Unable to submit predictions at this time.");
                MessageBox.Show(ex.ToString());
            }
            
            foreach (FixtureBoxUserControl fb in fixtureBoxList)
            {
                fb.Visible = false;
            }

            
            backButton.Visible = false;
            nextButton.Visible = false;
            submitButton.Visible = false;
            menuButton.Visible = false;
            tablePanel.Visible = true;
        }

        public static void displayMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (fixtureBoxList != null)
            {
                foreach (FixtureBoxUserControl fb in fixtureBoxList)
                {
                    fb.Visible = false;
                }
            }
            
            backButton.Visible = false;
            nextButton.Visible = false;
            submitButton.Visible = false;
            menuButton.Visible = false;
            tableUsercontrol.Visible = false;
            tablePanel.Visible = true;
        }
    }
}
