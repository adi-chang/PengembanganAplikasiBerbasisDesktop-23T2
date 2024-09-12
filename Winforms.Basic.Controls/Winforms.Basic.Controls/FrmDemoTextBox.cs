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
  public partial class FrmDemoTextBox : Form
  {
    public FrmDemoTextBox()
    {
      InitializeComponent();
      this.lblCount.Text = $"{this.txtNama.TextLength:n0}";
      this.lblKeterangan.Text = "{ input umur anda }";
    }

    private void txtNama_Enter(object sender, EventArgs e)
    {
      this.lblNama.Font = new Font(this.lblNama.Font.FontFamily.Name, this.lblNama.Font.Size, FontStyle.Bold);
      this.lblNama.ForeColor = Color.Red;
    }

    private void txtNama_Leave(object sender, EventArgs e)
    {
      this.lblNama.Font = new Font(this.lblNama.Font.FontFamily.Name, this.lblNama.Font.Size, FontStyle.Regular);
      this.lblNama.ForeColor=Color.FromKnownColor(KnownColor.ControlText);
    }

    private void txtUmur_Enter(object sender, EventArgs e)
    {
      this.txtUmur.BackColor = Color.FromKnownColor(KnownColor.LightGreen);
    }

    private void txtUmur_Leave(object sender, EventArgs e)
    {
      this.txtUmur.BackColor = Color.FromKnownColor(KnownColor.Window);
    }

    private void txtUmur_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = true;
      if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) e.Handled = false;
    }

    private void txtNama_TextChanged(object sender, EventArgs e)
    {
      this.lblCount.Text = $"{this.txtNama.TextLength:n0}";
    }

    private void txtNama_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
    }

    private void txtUmur_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
    }

    private void txtUmur_TextChanged(object sender, EventArgs e)
    {
      if (this.txtUmur.TextLength > 0)
      {
        this.lblKeterangan.Text = $"Umur Anda: {this.txtUmur.Text}";
      }
      else
      {
        this.lblKeterangan.Text = "{ input umur anda }";
      }
    }

    private void txtHobby_Enter(object sender, EventArgs e)
    {
      txtHobby.BackColor = Color.FromKnownColor(KnownColor.LightGreen);
      if (this.txtHobby.Text.Trim().Equals("hobby anda", StringComparison.CurrentCultureIgnoreCase))
      {
        this.txtHobby.Text = "";
        this.txtHobby.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
        this.txtHobby.Font = new Font(this.txtHobby.Font.FontFamily.Name, this.txtHobby.Font.Size, FontStyle.Regular);
      }
    }

    private void txtHobby_Leave(object sender, EventArgs e)
    {
      txtHobby.BackColor = Color.FromKnownColor(KnownColor.Window);
      if (this.txtHobby.Text.Trim().Equals(""))
      {
        this.txtHobby.Text = "hobby anda";
        this.txtHobby.ForeColor = Color.FromKnownColor(KnownColor.Silver);
        this.txtHobby.Font = new Font(this.txtHobby.Font.FontFamily.Name, this.txtHobby.Font.Size, FontStyle.Italic);
      }
    }

  }
}
