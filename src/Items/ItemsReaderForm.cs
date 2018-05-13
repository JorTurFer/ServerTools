using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ServerTools.Items
{
    public partial class ItemsReaderForm : Form
    {
        private List<Linea> m_lstLineas = new List<Linea>();
        private AutoResetEvent m_Parsing = new AutoResetEvent(true);
        private string m_strPath = "";
        public ItemsReaderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_Parsing.WaitOne(0))
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_lstLineas = new List<Linea>();
                    m_strPath = openFileDialog1.FileName;
                    new Thread(() => Parse()).Start();
                }
            }
        }

        void Parse()
        {
            m_lstLineas = new List<Linea>();
            foreach (string lin in File.ReadAllLines(m_strPath))
            {
                m_lstLineas.Add(new Linea(lin));
            }
            dataGridView1.Invoke(new MethodInvoker(() => dataGridView1.DataSource = m_lstLineas));
            cb_players.Invoke(new MethodInvoker(() =>
            {
                var names = m_lstLineas.Select(x => x.Player).Distinct().OrderBy(x => x).ToList();
                names.Insert(0, "");
                cb_players.DataSource = names;

            }));
            cb_Action.Invoke(new MethodInvoker(() =>
            {
                var names = m_lstLineas.Select(x => x.Action).Distinct().OrderBy(x => x).ToList();
                names.Insert(0, "");
                cb_Action.DataSource = names;

            }));

            m_Parsing.Set();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strPlayer = cb_players.Text;
            string strItem = textBox1.Text;
            string strAction = cb_Action.Text;
            List<Linea> result = new List<Linea>();

            bool bPlayer = !string.IsNullOrWhiteSpace(strPlayer);
            bool bItem = !string.IsNullOrWhiteSpace(strItem);
            bool bAction = !string.IsNullOrWhiteSpace(strAction);

            result = m_lstLineas.AsParallel().Where(x => (bPlayer ? x.Player == strPlayer : true) &&
             (bItem ? x.Item == strItem : true) &&
             (bAction ? x.Action == strAction : true)).ToList();

            int nCount = result.Count();
            dataGridView1.DataSource = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = m_lstLineas;
        }
    }
}
