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
using Newtonsoft.Json;
namespace ScorePredictor
{

    public class FixtureBuilder
    {

        public List<Fixture> getFixtures()
        {
            //var client = new WebClient();
            //var reply = client.DownloadString("http://cgtipster.com/api2/PYBFixtures.php");

            var fileReader =
                File.ReadAllText("C:\\Users\\hamptons\\Google Drive\\PlaceYourBets\\JSONexample - fixtures.txt");
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
                list.Add(user.user);
            }

            return list;

        }

        public object getScores()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBUserStats.php");
            var f = JsonConvert.DeserializeObject<UserList>(reply);

            //Dim fileReader As String
            //fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\hamptons\Google Drive\PlaceYourBets\JSONexample - users.txt")
            //Dim f = JsonConvert.DeserializeObject(Of UserList)(fileReader)

            return f.stock;
        }

        public object usersSubmitted()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBWhoBet.php");
            var f = JsonConvert.DeserializeObject<UserList>(reply);

            var list = new List<string>();


            try
            {
                foreach (Users user in f.stock)
                {
                    list.Add(user.user);
                }


            }
            catch (NullReferenceException ex)
            {
            }



            return list;

        }

        public object getUsersAndIds()
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

        public object getIdsandUsers()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PYBUsers.php");
            var f = JsonConvert.DeserializeObject<UserList>(reply);

            var dictionary = new Dictionary<int, string>();

            foreach (Users user in f.stock)
            {
                dictionary.Add(user.UserID, user.user);
            }

            return dictionary;

        }

        public object getIds()
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

        public object getPRUsers()
        {
            var client = new WebClient();
            var reply = client.DownloadString("http://cgtipster.com/api2/PRUsers.php");
            var f = JsonConvert.DeserializeObject<UserList>(reply);

            var list = new List<string>();

            foreach (Users user in f.stock)
            {
                list.Add(user.user);
            }

            return list;
        }

    }
}
