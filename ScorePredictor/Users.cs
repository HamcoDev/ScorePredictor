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
        public string username { get; set; }

        public int submitted { get; set; }

        public double correct { get; set; }

        public int UserID { get; set; }
    }
}
