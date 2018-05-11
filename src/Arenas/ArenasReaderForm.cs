using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerTools.Arenas
{
    public partial class ArenasReaderForm : Form
    {
        private List<Linea> m_lstLineas = new List<Linea>();
        public ArenasReaderForm()
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
                    m_lstLineas.Add(new Linea(lin));
                }
                comboBox1.DataSource = m_lstLineas.Select(x => x.Fecha).Distinct().ToList();
                dataGridView1.DataSource = m_lstLineas;
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;
            Color CurrentColor = Color.White;
            DateTime lastDate = Convert.ToDateTime(dataGridView1.Rows[0].Cells[0].Value);
            foreach (var item in dataGridView1.Rows.Cast<DataGridViewRow>())
            {
                if (Convert.ToDateTime(item.Cells[0].Value) != lastDate)
                {
                    CurrentColor = CurrentColor == Color.White ? Color.LightGray : Color.White;
                    lastDate = Convert.ToDateTime(item.Cells[0].Value);
                }
                item.DefaultCellStyle.BackColor = CurrentColor;
                try
                {
                    if (Convert.ToInt32(item.Cells[6].Value) + Convert.ToInt32(item.Cells[7].Value) < 5000)
                        item.DefaultCellStyle.BackColor = Color.Red;
                }
                catch
                { }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           var sub = m_lstLineas.Where(x => x.Fecha == Convert.ToDateTime(comboBox1.Text)).ToList();
            dataGridView1.DataSource = sub;
        }
    }
}
