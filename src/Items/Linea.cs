using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ServerTools.Items
{
    class Linea
    {       
        static Regex regPlayer = new Regex(@"\'(.+)\'");
        static Regex regItem = new Regex(@" Item: (\d+)");
        static Regex regCount = new Regex(@" Count: (\d+)");
        static Regex regAction = new Regex(@"Player::(\w+)");


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
                    return Convert.ToDateTime(Texto.Substring(0, 19).Replace("_", " "));
                }
                else
                    return new DateTime();
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
        public string Item
        {
            get
            {
                if (Texto.Length > 0)
                {
                    return regItem.Match(Texto).Groups[1].Value;
                }
                else
                    return "";
            }
        }
        public string Count
        {
            get
            {
                if (Texto.Length > 0)
                {
                    return regCount.Match(Texto).Groups[1].Value;
                }
                else
                    return "";
            }
        }
        public string Action
        {
            get
            {
                if (Texto.Length > 0)
                {
                    return regAction.Match(Texto).Groups[1].Value;
                }
                else
                    return "";
            }
        }        
        public string Texto { get; set; }

    }
}
