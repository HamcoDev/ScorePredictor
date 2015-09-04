using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePredictor
{
    class AppController
    {

        private List<Fixture> fixtures = new List<Fixture>();
        private List<FixtureBoxUserControl> fixtureBoxList = new List<FixtureBoxUserControl>();
        private List<string> userList = new List<string>();
        private List<string> submittedList = new List<string>();
        private List<Users> userResultList = new List<Users>();
        private int fix;

        public List<FixtureBoxUserControl> getFixtures()
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
                return fixtureBoxList;
            }
            else
            {
                fixtureBoxList[0].Visible = true;
                return fixtureBoxList;
            }
        }

        public void SubmitPredictions()
        {
            bool submitted = false;


            while ((!submitted))
            {

                foreach (Fixture fixture in fixtures)
                {
                    //My.MyProject.Forms.ProgressBarForm.ProgressBar1.PerformStep();
                    //string UrlBase = "http://www.predictresults.co.uk/API/InsertDataUsingSP.php?userid=";
                    //string user = currentUser.ToString();
                    //string fixtureID = fixture.ID.ToString();
                    //string prediction = fixture.Prediction.ToString();
                    //string url = UrlBase + user + "&fixtureid=" + fixtureID + "&prediction=" + prediction;
                    //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    //HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    ////Get the stream associated with the response. 
                    //Stream receiveStream = response.GetResponseStream();
                    //StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

                    //response.Close();
                    //readStream.Close();

                }

                submitted = true;

            }
        }

        //public void makeFixtureVisible(bool forward)
        //{
        //    try
        //    {

        //        if ((forward))
        //        {
        //            int previousFixtureNo = fixtureNo;
        //            fixtureNo = fixtureNo + 1;
        //            fixtureBoxList[previousFixtureNo].Visible = false;

                //    if (fixtureNo == 9)
                //    {
                //        fixtureBoxList[fixtureNo].nextButton.Text = "Review >";
                //        fixtureBoxList[fixtureNo].nextButton.BackColor = Color.LightGreen;
                //    }

                //    if (fixtureBoxList[previousFixtureNo].homeRadioButton.Checked == true)
                //    {
                //        fixtures[previousFixtureNo].Prediction = 1;
                //    }
                //    if (fixtureBoxList[previousFixtureNo].awayRadioButton.Checked == true)
                //    {
                //        fixtures[previousFixtureNo].Prediction = 2;
                //    }
                //    if (fixtureBoxList[previousFixtureNo].drawRadioButton.Checked == true)
                //    {
                //        fixtures[previousFixtureNo].Prediction = 3;
                //    }

                //}
                //else
                //{
                //    fixtureNo = fixtureNo - 1;
                //    fixtureBoxList[fixtureNo + 1].Visible = false;

    //            }

    //            fixtureBoxList[fixtureNo].Visible = true;

    //        }
    //        catch (ArgumentOutOfRangeException ex)
    //        {
    //            //Interaction.MsgBox("The full set of fixtures is not available. Please email complaints to michael.cole@advancedcomputersoftware.com");
    //        }
    //    }

    }
}
