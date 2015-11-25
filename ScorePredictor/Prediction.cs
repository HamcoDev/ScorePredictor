using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePredictor
{
    public class Prediction
    {
        public int userId { get; set; }
        public string homeTeam { get; set; }
        public int homeScore { get; set; }
        public int awayScore { get; set; }
        public string awayTeam { get; set; }
    }
}