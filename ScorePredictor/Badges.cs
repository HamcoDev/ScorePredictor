using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using System.IO;

namespace ScorePredictor
{
    static class Badges
    {

        public static Image getTeamBadge(string team)
        {
            Image badge = ScorePredictor.Properties.Resources.icon2;
            switch (team)
            {
                case "Arsenal":
                    badge = ScorePredictor.Properties.Resources.ARS;
                    break;
                case "Aston Villa":
                    badge = ScorePredictor.Properties.Resources.AST;
                    break;
                case "AFC Bournemouth":
                    badge = ScorePredictor.Properties.Resources.BOU;
                    break;   
                case "Burnley":
                    badge = ScorePredictor.Properties.Resources.BUR;
                    break;
                case "Chelsea":
                    badge = ScorePredictor.Properties.Resources.CHE;
                    break;
                case "Crystal Palace":
                    badge = ScorePredictor.Properties.Resources.CRY;
                    break;
                case "Everton":
                    badge = ScorePredictor.Properties.Resources.EVE;
                    break;
                case "Hull City":
                    badge = ScorePredictor.Properties.Resources.HUL;
                    break;
                case "Leicester City":
                    badge = ScorePredictor.Properties.Resources.LEI;
                    break;
                case "Liverpool":
                    badge = ScorePredictor.Properties.Resources.LIV;
                    break;
                case "Manchester City":
                    badge = ScorePredictor.Properties.Resources.MNC;
                    break;
                case "Manchester United":
                    badge = ScorePredictor.Properties.Resources.MNU;
                    break;
                case "Norwich City":
                    badge = ScorePredictor.Properties.Resources.NOR;
                    break;
                case "Newcastle United":
                    badge = ScorePredictor.Properties.Resources.NWC;
                    break;
                case "Queens Park Rangers":
                    badge = ScorePredictor.Properties.Resources.QPR;
                    break;
                case "Southampton":
                    badge = ScorePredictor.Properties.Resources.SOU;
                    break;
                case "Stoke City":
                    badge = ScorePredictor.Properties.Resources.STO;
                    break;
                case "Sunderland":
                    badge = ScorePredictor.Properties.Resources.SUN;
                    break;
                case "Swansea City":
                    badge = ScorePredictor.Properties.Resources.SWA;
                    break;
                case "Tottenham Hotspur":
                    badge = ScorePredictor.Properties.Resources.TOT;
                    break;
                case "Watford":
                    badge = ScorePredictor.Properties.Resources.WAT;
                    break;
                case "West Bromwich Albion":
                    badge = ScorePredictor.Properties.Resources.WBA;
                    break;
                case "West Ham United":
                    badge = ScorePredictor.Properties.Resources.WHU;
                    break;
                default:
                    badge = ScorePredictor.Properties.Resources.icon2;

                    break;
            }

            return badge;

        }

        public static Image getCountryFlag(string country)
        {
            Image flag = ScorePredictor.Properties.Resources.icon2;
            switch (country)
            {
                case "Albania":
                    flag = ScorePredictor.Properties.Resources.Alb;
                    break;
                case "Austria":
                    flag = ScorePredictor.Properties.Resources.Aus;
                    break;
                case "Belgium":
                    flag = ScorePredictor.Properties.Resources.Bel;
                    break;
                case "Croatia":
                    flag = ScorePredictor.Properties.Resources.Cro;
                    break;
                case "Czech Republic":
                    flag = ScorePredictor.Properties.Resources.CzR;
                    break;
                case "England":
                    flag = ScorePredictor.Properties.Resources.Eng;
                    break;
                case "France":
                    flag = ScorePredictor.Properties.Resources.Fra;
                    break;
                case "Germany":
                    flag = ScorePredictor.Properties.Resources.Ger;
                    break;
                case "Hungary":
                    flag = ScorePredictor.Properties.Resources.Hun;
                    break;
                case "Iceland":
                    flag = ScorePredictor.Properties.Resources.Ice;
                    break;
                case "Ireland":
                    flag = ScorePredictor.Properties.Resources.Ire;
                    break;
                case "Italy":
                    flag = ScorePredictor.Properties.Resources.Ita;
                    break;
                case "N.Ireland":
                    flag = ScorePredictor.Properties.Resources.NI;
                    break;
                case "Poland":
                    flag = ScorePredictor.Properties.Resources.Pol;
                    break;
                case "Portugal":
                    flag = ScorePredictor.Properties.Resources.Por;
                    break;
                case "Romania":
                    flag = ScorePredictor.Properties.Resources.Rom;
                    break;
                case "Russia":
                    flag = ScorePredictor.Properties.Resources.Rus;
                    break;
                case "Slovakia":
                    flag = ScorePredictor.Properties.Resources.Slo;
                    break;
                case "Spain":
                    flag = ScorePredictor.Properties.Resources.Spa;
                    break;
                case "Sweden":
                    flag = ScorePredictor.Properties.Resources.Swe;
                    break;
                case "Switzerland":
                    flag = ScorePredictor.Properties.Resources.Swi;
                    break;
                case "Turkey":
                    flag = ScorePredictor.Properties.Resources.Tur;
                    break;
                case "Ukraine":
                    flag = ScorePredictor.Properties.Resources.Ukr;
                    break;
                case "Wales":
                    flag = ScorePredictor.Properties.Resources.Wal;
                    break;
                default:
                    flag = ScorePredictor.Properties.Resources.icon2;

                    break;
            }

            return flag;

        }

    }
}
