using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScorePredictor
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var app = AppController.Instance;
            var query = new FixtureBuilder();

            Dictionary<string, int> userDictionary = new Dictionary<string, int>();
            userDictionary = query.getUsernamesAndIds();

            string username = usernameTextBox.Text.ToLower();
            int userId;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username");
            }
            else
            {
                if (userDictionary.TryGetValue(username, out userId))
                {
                    app.setCurrentUser(username, userId);
                    this.Hide();
                    new MainForm().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username not recognised");
                    usernameTextBox.Clear();
                }
            }
            
            
        }

        private void usernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            usernameTextBox.SelectAll();
        }

        private void usernameTextBox_GotFocus(object sender, MouseEventArgs e)
        {
            usernameTextBox.SelectAll();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click_1(object sender, EventArgs e)
        {
            var regForm = new RegistrationForm();
            regForm.Show();
        }
    }
}
