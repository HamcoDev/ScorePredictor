using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScorePredictor
{
    public partial class MainForm : Form
    {
        private AppController app = new AppController();
        private List<FixtureBoxUserControl> fixtureBoxList;
        private int fix;
        private int listSize;

        public MainForm()
        {
            InitializeComponent();
            nextButton.Visible = false;
            backButton.Visible = false;
            submitButton.Visible = false;
            menuButton.Visible = false;
            settingsButton.Enabled = false;
            app.setCurrentUser("sam", 001);
            fixtureBoxList = app.getFixtures();
            listSize = fixtureBoxList.Count - 1;
            
            
            foreach (FixtureBoxUserControl fb in fixtureBoxList)
            {
                mainPanel.Controls.Add(fb);
                fb.Visible = false;
            }
        }

        private void fixturesButton_Click(object sender, EventArgs e)
        {
            
            if (fixtureBoxList != null)
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
            tablePanel.Visible = false;
            submitButton.Visible = false;
            backButton.Enabled = false;
            fixtureBoxList[fix].Visible = false;
            nextButton.Visible = false;
            backButton.Visible = false;
            menuButton.Visible = true;

            var tableUsercontrol = new PointsTableUserControl();
            mainPanel.Controls.Add(tableUsercontrol);
            var pointsUserControl = new PointsUserControl();
            pointsUserControl.setUserPoints("Sam", "74");
            tableUsercontrol.Add(pointsUserControl, 0);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
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
    }
}
