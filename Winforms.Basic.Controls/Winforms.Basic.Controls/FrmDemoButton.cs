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
  public partial class FrmDemoButton : Form
  {
    public FrmDemoButton()
    {
      InitializeComponent();
      this.lblCount.Text = $"{this.txtNama.TextLength:n0}";
    }

    private void txtNama_Enter(object sender, EventArgs e)
    {
      this.lblNama.ForeColor = Color.Red;
      this.lblNama.Font = new Font(this.lblNama.Font.FontFamily.Name, this.lblNama.Font.Size, FontStyle.Bold);
    }

    private void txtNama_Leave(object sender, EventArgs e)
    {
      this.lblNama.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
      this.lblNama.Font = new Font(this.lblNama.Font.FontFamily.Name, this.lblNama.Font.Size, FontStyle.Regular);
    }

    private void txtNama_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
    }

    private void txtNama_TextChanged(object sender, EventArgs e)
    {
      this.lblCount.Text = $"{this.txtNama.TextLength:n0}";
    }

    private void btnClickMe_Click(object sender, EventArgs e)
    {
      if (this.txtNama.Text.Equals(""))
      {
        MessageBox.Show("Isi nama anda terlebih dahulu ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.txtNama.Focus();
      }
      else
      {
        MessageBox.Show($"Hi ... {this.txtNama.Text.Trim()}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void btnClickMe_MouseEnter(object sender, EventArgs e)
    {
      this.btnClickMe.BackColor = Color.FromKnownColor(KnownColor.LightSkyBlue);
      this.btnClickMe.ForeColor = Color.Gold;
    }

    private void btnClickMe_MouseLeave(object sender, EventArgs e)
    {
      this.btnClickMe.BackColor = Color.FromKnownColor(KnownColor.Control);
      this.btnClickMe.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
    }

  }
}
