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

        public object getFixtures()
        {
            fixtureBoxList.Clear();
            var fb = new FixtureBuilder();
            fixtures = fb.getFixtures();
            fix = 0;


            try
            {
                foreach (Fixture Fixture in fixtures)
                {
                    var usercontrol = new FixtureBoxUserControl();
                    fixtureBoxList.Add(usercontrol);
                    fix = fix + 1;
                }

                fixtureBoxList[0].Visible = true;
                fixtureBoxList[0].backButton.Enabled = false;
                this.submitButton.Visible = false;
                this.editButton.Visible = false;

            }
            catch (NullReferenceException ex)
            {
                Interaction.MsgBox("No fixtures available");
            }

            if (fix != 10)
            {
                this.MainFlowLayoutPanel.Controls.Clear();
                fixtureBoxList.Clear();
                Interaction.MsgBox("There are currently no fixtures to display");
            }
        }

    }
}
