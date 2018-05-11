using System;
using System.Windows.Forms;
using ServerTools.Items;
using ServerTools.Arenas;
namespace ServerTools
{
  public partial class SelectorForm : Form
  {
    public SelectorForm()
    {
      InitializeComponent();
    }

    private void btn_Items_Click(object sender, EventArgs e)
    {
      ItemsReaderForm items_f = new ItemsReaderForm();
      items_f.ShowDialog();
    }

    private void btn_Arenas_Click(object sender, EventArgs e)
    {
      ArenasReaderForm arenas_f = new ArenasReaderForm();
      arenas_f.ShowDialog();
    }
  }
}
