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
namespace ScorePredictor
{
    public class Users
    {

        public string user
        {
            get { return m_user; }
            set { m_user = value; }
        }
        private string m_user;
        public int submitted
        {
            get { return m_submitted; }
            set { m_submitted = value; }
        }
        private int m_submitted;
        public double correct
        {
            get { return m_correct; }
            set { m_correct = value; }
        }
        private double m_correct;
        public int UserID
        {
            get { return m_UserID; }
            set { m_UserID = value; }
        }
        private int m_UserID;
    }
}
