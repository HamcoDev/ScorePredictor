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
        private PredictionUserControl predictionsUserControl = new PredictionUserControl();

        public MainForm()
        {
            InitializeComponent();
            nextButton.Visible = false;
            backButton.Visible = false;
            submitButton.Visible = false;
            menuButton.Visible = false;
            usersComboBox.Visible = false;
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
            //var weekStats = fb.getWeekStats();
            var totalStats = fb.getTotalStats();

            //if (weekStats.Count < 1 || totalStats.Count < 1)
            if (totalStats.Count < 1)
            {
                MessageBox.Show("There are no stats to display.");
            }
            else
            {
                tablePanel.Visible = false;
                submitButton.Visible = false;
                backButton.Enabled = false;

                try
                {
                    fixtureBoxList[fix].Visible = false;
                }
                catch (Exception) { }

                nextButton.Visible = false;
                backButton.Visible = false;
                menuButton.Visible = true;

                mainPanel.Controls.Add(tableUsercontrol);

                //foreach (KeyValuePair<string, int> user in weekStats)
                //{
                //    var pointsUserControl = new PointsUserControl();
                //    pointsUserControl.setUserPoints(user.Key + "    " + user.Value, user.Value.ToString());
                //    tableUsercontrol.Add(pointsUserControl, 1);
                //}

                tableUsercontrol.RemoveAll();

                foreach (KeyValuePair<string, int> user in totalStats)
                {
                    var pointsUserControl = new PointsUserControl();
                    pointsUserControl.setUserPoints(user.Key + "    " + user.Value, user.Value.ToString());
                    tableUsercontrol.Add(pointsUserControl, 0);
                }

                tableUsercontrol.Visible = true;
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
//                submitButton.Text = <form action="https://www.paypal.com/cgi-bin/webscr" method="post" target="_top">
//<input type="hidden" name="cmd" value="_xclick">
//<input type="hidden" name="business" value="coleburg76@hotmail.com">
//<input type="hidden" name="lc" value="GB">
//<input type="hidden" name="item_name" value="Enter Predictions">
//<input type="hidden" name="amount" value="1.00">
//<input type="hidden" name="currency_code" value="GBP">
//<input type="hidden" name="button_subtype" value="services">
//<input type="hidden" name="no_note" value="0">
//<input type="hidden" name="bn" value="PP-BuyNowBF:btn_paynow_LG.gif:NonHostedGuest">
//<input type="image" src="https://www.paypalobjects.com/en_GB/i/btn/btn_paynow_LG.gif" border="0" name="submit" alt="PayPal – The safer, easier way to pay online.">
//<img alt="" border="0" src="https://www.paypalobjects.com/en_US/i/scr/pixel.gif" width="1" height="1">
//</form>;

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
            //var paymentMade = false;

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
            usersComboBox.Visible = false;

            if (predictionsUserControl != null)
            {
                predictionsUserControl.Visible = false;
            }
            
            tablePanel.Visible = true;            
        }

        private void myPredictionsButton_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            
            try
            {
                var app = AppController.Instance;
                var CurrentUserId = app.getCurrentUser().UserID;
                var fb = new FixtureBuilder();
                var CurrentUserName = fb.getUsername(CurrentUserId);
                var predictionsList = fb.getPredictions(CurrentUserId);
                var usersSubmitted = fb.usersSubmitted();

                usersComboBox.Items.Clear();

                foreach (String u in usersSubmitted)
                {
                    usersComboBox.Items.Add(u);
                }

                usersComboBox.SelectedIndex = usersComboBox.FindStringExact(CurrentUserName);

                if (predictionsList.Count > 0)
                {
                    predictionsUserControl.Update(predictionsList);
                    mainPanel.Controls.Add(predictionsUserControl);

                    usersComboBox.Visible = true;
                    backButton.Visible = false;
                    nextButton.Visible = false;
                    submitButton.Visible = false;
                    menuButton.Visible = true;
                    tableUsercontrol.Visible = false;
                    tablePanel.Visible = false;
                    predictionsUserControl.Visible = true;
                }
                else
                {
                    displayMessage("Predictions currently unavailable. Are you sure you've submitted them?");
                }
            }
            catch (Exception)
            {
                displayMessage("Your predictions for this week are currently unavailable.");
                tablePanel.Visible = true;
            }

            ResumeLayout();
        }

        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SuspendLayout();
            
            var fb = new FixtureBuilder();
            var UserId = fb.getUserId(usersComboBox.SelectedItem.ToString());
            var predictionsList = fb.getPredictions(UserId);

            predictionsUserControl.Update(predictionsList);

            ResumeLayout();
        }

       
    }
}
