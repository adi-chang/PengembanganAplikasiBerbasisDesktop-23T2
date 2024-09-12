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
  public partial class FrmDemoRadioButton : Form
  {
    public FrmDemoRadioButton()
    {
      InitializeComponent();
    }

    private void radNasiGoreng_MouseEnter(object sender, EventArgs e)
    {
      RadioButton rad = sender as RadioButton;
      if (!rad.Checked)
      {
        rad.Font = new Font(rad.Font.FontFamily.Name, rad.Font.Size + 1, FontStyle.Bold);
      }
    }

    private void radNasiGoreng_MouseLeave(object sender, EventArgs e)
    {
      RadioButton rad = sender as RadioButton;
      if (!rad.Checked)
      {
        rad.Font = new Font(rad.Font.FontFamily.Name, 8.25f, FontStyle.Regular);
      }
    }

    private void radNasiGoreng_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton rad = sender as RadioButton;
      rad.Font = new Font(
        rad.Font.FontFamily.Name,
        8.25f,
        rad.Checked ? FontStyle.Bold : FontStyle.Regular);
    }

    private void btnCek_Click(object sender, EventArgs e)
    {
      string makanan = "";
      string minuman = "";
      foreach (Control ctl in this.grpMakanan.Controls)
      {
        if (ctl is RadioButton chk && chk.Checked)
        {
          makanan = chk.Text;
          break;
        }
      }
      foreach (Control ctl in this.grpMinuman.Controls)
      {
        if (ctl is RadioButton chk && chk.Checked)
        {
          minuman = chk.Text;
          break;
        }
      }
      string msg =
        $"Pesanan Anda:\n\n" +
        $"Makanan : {makanan}\n" +
        $"Minuman : {minuman}\n\n" +
        $"{(makanan.Equals("") && minuman.Equals("") ? "Tentukan Pilihan Makanan/Minuman Anda Terlebih Dahulu !!!" : "Selamat Menikmati !")}";

      MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      foreach (Control ctl in this.grpMakanan.Controls)
      {
        if (ctl is RadioButton rad)
          rad.Checked = false;
      }
      foreach (Control ctl in this.grpMinuman.Controls)
      {
        if (ctl is RadioButton rad)
          rad.Checked = false;
      }
    }

  }
}
