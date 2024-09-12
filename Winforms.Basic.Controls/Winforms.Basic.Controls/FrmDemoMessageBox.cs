using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.Basic.Controls
{
  public partial class FrmDemoMessageBox : Form
  {
    public FrmDemoMessageBox()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Pesan Anda", "Header Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Error Message", "Header Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Yes / No ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Are you OK (yes/no) ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
      {
        MessageBox.Show("Good!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        MessageBox.Show("Sorry!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      if (this.txtNama.Text.Trim().Equals(""))
      {
        MessageBox.Show("Sorry, Lengkapi data nama anda terlebih dahulu ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      else
      {
        string nama = this.txtNama.Text.Trim();
        MessageBox.Show($"Hi, {nama}!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

  }
}
