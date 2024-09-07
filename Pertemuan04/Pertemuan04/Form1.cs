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
  public partial class Form1 : Form
  {
    public Form1()
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
      if (this.txtHargaBeli.Text.Trim() != "")
      {
        if (double.TryParse(this.txtHargaBeli.Text, out double nilai))
        {
          this.txtHargaBeli.Text = $"{nilai:n0}";
          this.txtHargaBeli.SelectionStart = this.txtHargaBeli.TextLength;
        }
      }
    }

    private void txtHargaBeli_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendKeys.Send("{tab}");
      }
    }

    private void btnHitung_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.txtHargaBeli.Text.Trim() == "")
          throw new Exception("Sorry, nilai beli tidak boleh kosong ...");
        else if (this.txtJumlahUnit.Text.Trim() == "")
          throw new Exception("Sorry, jumlah unit tidak boleh kosong ...");
        else if (this.txtPotongan.Text.Trim() == "")
          throw new Exception("Sorry, potongan tidak boleh kosong ...");
        else
        {
          // show time

          decimal hargaBeli = Convert.ToDecimal(txtHargaBeli.Text);
          int jumlahUnit = Convert.ToInt32(txtJumlahUnit.Text);
          int potongan = Convert.ToInt32(txtPotongan.Text);

          decimal total = hargaBeli * jumlahUnit;

          decimal nilaiPotongan = total * potongan / 100;

          decimal totalAkhir = total - nilaiPotongan;

          lblNilaiPotongan.Text = $"Rp {nilaiPotongan:n2}";

          lblKeterangan.Text = $"Besaran total dari pembelian anda adalah Rp {totalAkhir:n2}";

        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

  }
}
