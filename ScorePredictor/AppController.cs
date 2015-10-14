using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePredictor
{
    internal class AppController
    {

        private static AppController instance;

        private AppController() {}
        
        private List<Fixture> fixtures = new List<Fixture>();
        private List<FixtureBoxUserControl> fixtureBoxList = new List<FixtureBoxUserControl>();
        private List<string> userList = new List<string>();
        private List<string> submittedList = new List<string>();
        private List<Users> userResultList = new List<Users>();
        private int fix;
        private Users currentUser;
        private FixtureBuilder fb = new FixtureBuilder();

        public static AppController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppController();
                }
                return instance;
            }
        }

        public void setCurrentUser(string username, int id)
        {
            currentUser = new Users();
            currentUser.name = username;
            currentUser.UserID = id;
        }

        public Users getCurrentUser()
        {
            return currentUser;
        }

        public List<FixtureBoxUserControl> getFixtures()
        {
            fixtureBoxList.Clear();
            fixtures = fb.getFixtures();
            fix = 0;

            try
            {
                foreach (Fixture Fixture in fixtures)
                {
                    var usercontrol = new FixtureBoxUserControl(Fixture.ID, Fixture.Home_Team, Fixture.Away_Team, Fixture.Date,
                        Badges.getTeamBadge(Fixture.Home_Team), Badges.getTeamBadge(Fixture.Away_Team));
                    fixtureBoxList.Add(usercontrol);
                    fix = fix + 1;
                }
            }
            catch (NullReferenceException ex)
            {
            
            }

            if (fix != 10)
            {
                fixtureBoxList.Clear();
                MainForm.displayMessage("No fixtures available");
                return fixtureBoxList;
            }
            else
            {
                fixtureBoxList[0].Visible = true;
                return fixtureBoxList;
            }
        }

        public void submitPredictions()
        {
            var progress = new Progress();
            try
            {
                progress.setProgressBarSize(fixtureBoxList.Count - 1);
                progress.Visible = true;

                foreach (FixtureBoxUserControl fixture in fixtureBoxList)
                {
                    progress.incrementProgressBar(1);
                    fb.submitScores(fixture.getFixtureId(), currentUser.UserID, fixture.getHomeScore(), fixture.getAwayScore());
                }
            }
            catch (Exception)
            {
                progress.Visible = false;
                throw;
            }

            progress.Visible = false;
        }
    }
}
