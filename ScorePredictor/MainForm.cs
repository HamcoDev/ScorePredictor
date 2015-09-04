using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void fixturesButton_Click(object sender, EventArgs e)
        {
            
            fixtureBoxList = app.getFixtures();
            listSize = fixtureBoxList.Count - 1;
            if (fixtureBoxList != null)
            {
                foreach (FixtureBoxUserControl fb in fixtureBoxList)
                {
                    mainPanel.Controls.Add(fb);
                    fb.Visible = false;
                }

                tablePanel.Visible = false;
                submitButton.Visible = false;
                backButton.Enabled = false;
                //mainPanel.Controls.Add(fixtureBoxList[0]);
                fixtureBoxList[0].Visible = true;
                nextButton.Visible = true;
                backButton.Visible = true;
            }
            
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
           // app.submitPredictions();
        }

        public static void displayMessage(string message)
        {
            MessageBox.Show(message);
        }

        

    }

}
