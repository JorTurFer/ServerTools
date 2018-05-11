using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ServerTools.BGs
{
  class Linea
  {
    private Regex regRemove = new Regex(@"Removed");
    private Regex regPlayer = new Regex(@"player (\w+)");
    private Regex regBG = new Regex(@"for bg (\d+)");
    private Regex regBGType = new Regex(@"bgtype (\d+)");
    private Regex regQueueType = new Regex(@"queue type (\d+)");


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

    public string Accion
    {
      get
      {
        if (Texto.Length > 0 && regRemove.IsMatch(Texto))
        {
          return "Salir";
        }
        else
          return "Entrar";
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
    public string BG
    {
      get
      {
        if (Texto.Length > 0)
        {
          return regBG.Match(Texto).Groups[1].Value;
        }
        else
          return "";
      }
    }
    public string BGType
    {
      get
      {
        if (Texto.Length > 0)
        {
          return regBGType.Match(Texto).Groups[1].Value;
        }
        else
          return "";
      }
    }
    public string QueueType
    {
      get
      {
        if (Texto.Length > 0)
        {
          return regQueueType.Match(Texto).Groups[1].Value;
        }
        else
          return "";
      }
    }

    public string Texto { get; set; }

  }
}
