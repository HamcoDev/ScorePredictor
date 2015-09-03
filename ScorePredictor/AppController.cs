using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePredictor
{
    class AppController
    {

        private int fixtureNo = 0;
        private List<Fixture> fixtures = new List<Fixture>();
        private List<FixtureBoxUserControl> fixtureBoxList = new List<FixtureBoxUserControl>();
        private List<string> userList = new List<string>();
        private List<string> submittedList = new List<string>();
        private List<Users> userResultList = new List<Users>();
        private int fix;

        public void getFixtures()
        {
            fixtureBoxList.Clear();
            var fb = new FixtureBuilder();
            fixtures = fb.getFixtures();
            fix = 0;


            try
            {
                foreach (Fixture Fixture in fixtures)
                {
                    var usercontrol = new FixtureBoxUserControl(Fixture.Home_Team, Fixture.Away_Team, Fixture.Date, Badges.getTeamBadge(Fixture.Home_Team), Badges.getTeamBadge(Fixture.Away_Team));
                    fixtureBoxList.Add(usercontrol);
                    fix = fix + 1;
                }

                

            }
            catch (NullReferenceException ex)
            {
                MainForm.displayMessage("No fixtures available");
            }

            if (fix != 10)
            {
                fixtureBoxList.Clear();
                MainForm.displayMessage("There are currently no fixtures to display");
            }
            else
            {
                fixtureBoxList[0].Visible = true;
                fixtureBoxList[0].backButton.Enabled = false;
                fixtureBoxList[0].nextButton.Enabled = true;
            }
        }

        public void makeFixtureVisible(bool forward)
        {
            try
            {

                if ((forward))
                {
                    int previousFixtureNo = fixtureNo;
                    fixtureNo = fixtureNo + 1;
                    fixtureBoxList[previousFixtureNo].Visible = false;

                    if (fixtureNo == 9)
                    {
                        fixtureBoxList[fixtureNo].nextButton.Text = "Review >";
                        fixtureBoxList[fixtureNo].nextButton.BackColor = Color.LightGreen;
                    }

                    if (fixtureBoxList[previousFixtureNo].homeRadioButton.Checked == true)
                    {
                        fixtures[previousFixtureNo].Prediction = 1;
                    }
                    if (fixtureBoxList[previousFixtureNo].awayRadioButton.Checked == true)
                    {
                        fixtures[previousFixtureNo].Prediction = 2;
                    }
                    if (fixtureBoxList[previousFixtureNo].drawRadioButton.Checked == true)
                    {
                        fixtures[previousFixtureNo].Prediction = 3;
                    }

                }
                else
                {
                    fixtureNo = fixtureNo - 1;
                    fixtureBoxList[fixtureNo + 1].Visible = false;

                }

                fixtureBoxList[fixtureNo].Visible = true;

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Interaction.MsgBox("The full set of fixtures is not available. Please email complaints to michael.cole@advancedcomputersoftware.com");
            }
        }

    }
}
