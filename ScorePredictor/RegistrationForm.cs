using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Net;
using System.Windows.Forms;

namespace ScorePredictor
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var fullName = fullnameTextBox.Text.Replace(" ", "%20");
            string UrlBase = "http://www.cgtipster.com/api2/PYBMembers.php?user=";
            string url = UrlBase + usernameTextBox.Text + "&name=" + fullName + "&email=" + emailTextBox.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
