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

        public MainForm()
        {
            InitializeComponent();
        }

        private void fixturesButton_Click(object sender, EventArgs e)
        {
            mainPanel.Hide();
            app.getFixtures();
        }

        public static void displayMessage(string message)
        {
            MessageBox.Show(message);
        }

    }

}
