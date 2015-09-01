using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Net;

namespace ScorePredictor
{

    public class Fixture
    {
        public string ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }
        private string m_ID;
        public string Home_Team
        {
            get { return m_Home_Team; }
            set { m_Home_Team = value; }
        }
        private string m_Home_Team;
        public string Away_Team
        {
            get { return m_Away_Team; }
            set { m_Away_Team = value; }
        }
        private string m_Away_Team;
        public string League
        {
            get { return m_League; }
            set { m_League = value; }
        }
        private string m_League;
        public string Date
        {
            get { return m_Date; }
            set { m_Date = value; }
        }
        private string m_Date;
        public string Kick_Off
        {
            get { return m_Kick_Off; }
            set { m_Kick_Off = value; }
        }
        private string m_Kick_Off;
        public int Prediction
        {
            get { return m_prediction; }
            set { m_prediction = value; }
        }
        private int m_prediction;
    }
}
