using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ServerTools.BGs
{
  public partial class BGsReaderForm : Form
  {
    private List<Linea> m_lstLineas = new List<Linea>();

    const int MINFORCHECK = 3;

    public BGsReaderForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        m_lstLineas = new List<Linea>();
        string strPath = openFileDialog1.FileName;
        foreach (string lin in File.ReadAllLines(strPath))
        {
          if (lin.Contains("GetBGCreature"))
            continue;
          m_lstLineas.Add(new Linea(lin));
        }
        if (cb_PreFilter.Checked)
          FirstCheck();
        else
        {
          var names = m_lstLineas.Select(x => x.Player).Distinct().OrderBy(x => x).ToList();
          names.Insert(0, "");
          comboBox1.DataSource = names;
        }
        dataGridView1.DataSource = m_lstLineas;
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      string strPlayer = comboBox1.Text;
      DateTime selectedDate = dateTimePicker1.Value;
      List<Linea> result = new List<Linea>();

      bool bPlayer = !string.IsNullOrWhiteSpace(strPlayer);
      bool bDate = cb_Date.Checked;
      result = m_lstLineas.AsParallel().Where(x => bPlayer ? x.Player == strPlayer : true
      && bDate ? x.Fecha.Date == selectedDate.Date : true).ToList();

      int nCount = result.Count();
      dataGridView1.DataSource = result;

      for (int i = 0; i < result.Count() - 1; i++)
      {
        if (result[i].Accion == "Salir")
          continue;

        bool bCheck = (result[i + 1].Fecha - result[i].Fecha).TotalMinutes < MINFORCHECK;
        if (bCheck)
        {
          dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
          dataGridView1.Rows[i + 1].DefaultCellStyle.BackColor = Color.Red;
        }
      }
    }

    void FirstCheck()
    {
      List<string> NamesToCheck = new List<string>();
      List<(string, DateTime)> tmpData = new List<(string, DateTime)>();
            
      foreach (var lin in m_lstLineas.Where(x=> cb_Date.Checked ? x.Fecha.Date == dateTimePicker1.Value.Date : true))
      {
        if (lin.Accion == "Entrar")
        {
          tmpData.Add((lin.Player, lin.Fecha));
        }
        else
        {
          var inserted = tmpData.Where(x => x.Item1 == lin.Player).FirstOrDefault();
          //No hay concidencia
          if (inserted.Item1 == null)
          {
            continue;
          }
          if ((lin.Fecha - inserted.Item2).TotalMinutes < MINFORCHECK)
          {
            NamesToCheck.Add(lin.Player);
          }

          tmpData.RemoveAll(x => x.Item1 == lin.Player);
        }
      }
      NamesToCheck.Insert(0, "");
     
      comboBox1.DataSource = NamesToCheck.Distinct().OrderBy(x => x).ToList();
    }
  }
}
