using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pertemuan05
{
  public partial class Form1 : Form
  {
    public Form1() // constructor
    {
      InitializeComponent();
      UpdateTotal();
    }

    decimal total = 0;

    private void UpdateTotal()
    {
      this.lblTotal.Text = $"Rp {total:n0}";
    }

    private void chkMonitor_CheckedChanged(object sender, EventArgs e)
    {
      CheckBox chk = sender as CheckBox;
      chk.Font = new Font(
        chk.Font.FontFamily.Name, chk.Font.Size,
        chk.Checked ? FontStyle.Bold : FontStyle.Regular);
      decimal harga = Convert.ToDecimal(
        chk.Text.Substring(chk.Text.IndexOf("(")+1)
        .Replace("Rp ", "").Replace(".", "").Replace(")", ""));
      if (chk.Checked)
      {
        total += harga;
      }
      else
      {
        total -= harga;
      }
      UpdateTotal();
    }

  }
}
