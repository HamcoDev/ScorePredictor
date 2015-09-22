using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
namespace ScorePredictor
{

    public class FixtureBuilder
    {

        public List<Fixture> getFixtures()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBFixtures.php");

            //var fileReader = File.ReadAllText("JSONexample - fixtures.txt");
            //var f = JsonConvert.DeserializeObject<FixtureList>(fileReader);

            var f = JsonConvert.DeserializeObject<FixtureList>(reply);

            return f.stock;
        }

        public Dictionary<string, double> getScores()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBUserStats.php");
            var f = JsonConvert.DeserializeObject<UserList>(reply);

            //Dim fileReader As String
            //fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\hamptons\Google Drive\PlaceYourBets\JSONexample - users.txt")
            //Dim f = JsonConvert.DeserializeObject(Of UserList)(fileReader)

            var dictionary = new Dictionary<string, double>();

            foreach (Users user in f.stock)
            {
                dictionary.Add(user.name, user.totalScore);
            }

            return dictionary;
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
                    list.Add(user.name);
                }


            }
            catch (NullReferenceException ex)
            {
            }
            return list;

        }

        public Dictionary<string, int> getNamesAndIds()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBUsers.php");
            var f = JsonConvert.DeserializeObject<UserList>(reply);

            var dictionary = new Dictionary<string, int>();

            foreach (Users user in f.stock)
            {
                dictionary.Add(user.name.ToLower(), user.UserID);
            }

            return dictionary;

        }

        public Dictionary<string, int> getUsernamesAndIds()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBUsers.php");
            var f = JsonConvert.DeserializeObject<UserList>(reply);

            var dictionary = new Dictionary<string, int>();

            foreach (Users user in f.stock)
            {
                dictionary.Add(user.user.ToLower(), user.UserID);
            }

            return dictionary;

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

        public Dictionary<string, int> getWeekStats()
        {
            //var client = new WebClient();
            //var reply = client.DownloadString("http://www.cgtipster.com/api2/PYBUserStats.php");
            //var f = JsonConvert.DeserializeObject<UserList>(reply);
            
            var fileReader = File.ReadAllText("JSONexample - stats.txt");
            var f = JsonConvert.DeserializeObject<UserList>(fileReader);

            return f.stock.ToDictionary(user => user.name, user => user.weekScore);
        }

        public Dictionary<string, int> getTotalStats() 
        {
            //var client = new WebClient();
            //var reply = client.DownloadString("http://www.cgtipster.com/api2/PYBUserStats.php");
            //var f = JsonConvert.DeserializeObject<UserList>(reply);

            var fileReader = File.ReadAllText("JSONexample - stats.txt");
            var f = JsonConvert.DeserializeObject<UserList>(fileReader);

            return f.stock.ToDictionary(user => user.name, user => user.totalScore);
        }

    }
}
