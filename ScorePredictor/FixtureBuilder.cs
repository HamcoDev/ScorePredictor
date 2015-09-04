using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
namespace ScorePredictor
{

    public class FixtureBuilder
    {

        public List<Fixture> getFixtures()
        {
            //var client = new WebClient();
            //var reply = client.DownloadString("http://cgtipster.com/api2/PYBFixtures.php");

            var fileReader = File.ReadAllText("JSONexample - fixtures.txt");
            var f = JsonConvert.DeserializeObject<FixtureList>(fileReader);

            //var f = JsonConvert.DeserializeObject<FixtureList>(reply);

            return f.stock;
        }

        public List<Fixture> getBet()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBPredictions.php");

            //Dim fileReader As String
            //fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\hamptons\Google Drive\PlaceYourBets\JSONexample - predictions.txt")
            //Dim f = JsonConvert.DeserializeObject(Of FixtureList)(fileReader)

            var f = JsonConvert.DeserializeObject<FixtureList>(reply);

            return f.stock;
        }

        public List<string> getUsers()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBUsers.php");
            var f = JsonConvert.DeserializeObject<UserList>(reply);

            //Dim fileReader As String
            //fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\hamptons\Google Drive\PlaceYourBets\JSONexample - users.txt")
            //Dim f = JsonConvert.DeserializeObject(Of UserList)(fileReader)

            var list = new List<string>();

            foreach (Users user in f.stock)
            {
                list.Add(user.username);
            }

            return list;

        }

        public List<Users> getScores()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBUserStats.php");
            var f = JsonConvert.DeserializeObject<UserList>(reply);

            //Dim fileReader As String
            //fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\hamptons\Google Drive\PlaceYourBets\JSONexample - users.txt")
            //Dim f = JsonConvert.DeserializeObject(Of UserList)(fileReader)

            return f.stock;
        }

        public List<string> usersSubmitted()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBWhoBet.php");
            var f = JsonConvert.DeserializeObject<UserList>(reply);

            var list = new List<string>();


            try
            {
                foreach (Users user in f.stock)
                {
                    list.Add(user.username);
                }


            }
            catch (NullReferenceException ex)
            {
            }
            return list;

        }

        public Dictionary<string, int> getUsersAndIds()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBUsers.php");
            var f = JsonConvert.DeserializeObject<UserList>(reply);

            var dictionary = new Dictionary<string, int>();

            foreach (Users user in f.stock)
            {
                dictionary.Add(user.username.ToLower(), user.UserID);
            }

            return dictionary;

        }

        public Dictionary<int, string> getIdsandUsers()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBUsers.php");
            var f = JsonConvert.DeserializeObject<UserList>(reply);

            var dictionary = new Dictionary<int, string>();

            foreach (Users user in f.stock)
            {
                dictionary.Add(user.UserID, user.username);
            }

            return dictionary;

        }

        public List<int> getIds()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBUsers.php");
            var f = JsonConvert.DeserializeObject<UserList>(reply);

            var list = new List<int>();

            foreach (Users user in f.stock)
            {
                list.Add(user.UserID);
            }

            return list;

        }

        public List<string> getPRUsers()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PRUsers.php");
            var f = JsonConvert.DeserializeObject<UserList>(reply);

            var list = new List<string>();

            foreach (Users user in f.stock)
            {
                list.Add(user.username);
            }

            return list;
        }

        public void submitScores(string fixtureId, string currentUser, int homePrediction, int awayPrediction)
        {

            string UrlBase = "http://www.cgtipster.com/api2/PYBInsertPredictions.php?fixtureid=";
            string url = UrlBase + fixtureId + "&userid=" + currentUser + "&homeprediction=" + homePrediction + "&awayprediction=" + awayPrediction;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Get the stream associated with the response. 
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            response.Close();
            readStream.Close();
        }

    }
}
