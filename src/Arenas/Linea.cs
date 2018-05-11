using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ServerTools.Arenas
{
    class Linea
    {
        private Regex regIP = new Regex(@"IP: (\d+.\d+.\d+.\d+)");
        private Regex regPlayer = new Regex(@"for (\w+) |Player: (\w+)");
        private Regex regTeam = new Regex(@"Team: (\d+)");
        private Regex regTeamID1 = new Regex(@"Team1Id: (\d+)");
        private Regex regTeamID2 = new Regex(@"Team2Id: (\d+)");
        private Regex regDamage = new Regex(@"Damage done: (\d+)");
        private Regex regHeal = new Regex(@"Healing done: (\d+)");

        public Linea(string strLinea)
        {
            Texto = strLinea;
        }

        public DateTime Fecha
        {
            get
            {
                if (Texto.Length > 0)
                {
                    return Convert.ToDateTime(Texto.Substring(0, 19).Replace("_"," "));
                }
                else
                    return new DateTime();
            }
        }

        public string IP
        {
            get
            {
                if (Texto.Length > 0)
                {
                    return regIP.Match(Texto).Groups[1].Value;
                }
                else
                    return "";
            }
        }
        public string Player
        {
            get
            {
                if (Texto.Length > 0)
                {
                    return regPlayer.Match(Texto).Groups[1].Value;
                }
                else
                    return "";
            }
        }
        public string Team
        {
            get
            {
                if (Texto.Length > 0)
                {
                    return regTeam.Match(Texto).Groups[1].Value;
                }
                else
                    return "";
            }
        }
        public string TeamID1
        {
            get
            {
                if (Texto.Length > 0)
                {
                    return regTeamID1.Match(Texto).Groups[1].Value;
                }
                else
                    return "";
            }
        }
        public string TeamID2
        {
            get
            {
                if (Texto.Length > 0)
                {
                    return regTeamID2.Match(Texto).Groups[1].Value;
                }
                else
                    return "";
            }
        }
        public string Damage
        {
            get
            {
                if (Texto.Length > 0)
                {
                    return regDamage.Match(Texto).Groups[1].Value;
                }
                else
                    return "";
            }
        }
        public string Heal
        {
            get
            {
                if (Texto.Length > 0)
                {
                    return regHeal.Match(Texto).Groups[1].Value;
                }
                else
                    return "";
            }
        }
        public string Texto { get; set; }

    }
}
