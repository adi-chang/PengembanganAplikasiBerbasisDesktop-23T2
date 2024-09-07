using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pertemuan04
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    private void txtHargaBeli_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = true;
      if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) e.Handled = false;
    }

    private void txtHargaBeli_TextChanged(object sender, EventArgs e)
    {
      TextBox ctl = sender as TextBox;
      if (ctl.Text.Trim() != "")
      {
        if (double.TryParse(ctl.Text, out double nilai))
        {
          ctl.Text = $"{nilai:n0}";
          ctl.SelectionStart = ctl.TextLength;
        }
      }
      Hitung();
    }

    private void Hitung()
    {
      this.lblNilaiPotongan.Text = "";
      this.lblKeterangan.Text = "";

      decimal hargaBeli = 0;

      int jumlahUnit = 0;
      int persentasePotongan = 0;

      decimal nilaiPotongan = 0;

      decimal nilaiAkhir = 0;

      decimal.TryParse(this.txtHargaBeli.Text, out hargaBeli);

      int.TryParse(this.txtJumlahUnit.Text, System.Globalization.NumberStyles.AllowThousands, System.Threading.Thread.CurrentThread.CurrentCulture, out jumlahUnit);

      if (int.TryParse(this.txtPotongan.Text, System.Globalization.NumberStyles.AllowThousands, System.Threading.Thread.CurrentThread.CurrentCulture, out persentasePotongan))
      {
        nilaiPotongan = (hargaBeli * jumlahUnit) * persentasePotongan / 100;
      }

      this.lblNilaiPotongan.Text = $"Rp {nilaiPotongan:n2}";

      nilaiAkhir = hargaBeli * jumlahUnit - nilaiPotongan;

      if (nilaiAkhir >= 0)
      {
        this.lblKeterangan.Text = $"Besaran total dari pembelian anda adalah Rp {nilaiAkhir:n2}";
      }
    }

    private void txtHargaBeli_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendKeys.Send("{tab}");
      }
    }

  }
}
