using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pertemuan_09
{
  public partial class FrmDemo : Form
  {
    public FrmDemo()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var form = new Form1();
      form.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      var form = new Form2();
      form.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      var form = new Form3();
      form.ShowDialog();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      var form = new Form4();
      form.ShowDialog();
    }
  }
}
