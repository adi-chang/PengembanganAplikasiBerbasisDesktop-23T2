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
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    private void Tick_UnTick_CheckBox(object sender, EventArgs e)
    {
      CheckBox chk = sender as CheckBox;
      chk.Font = new Font(chk.Font.FontFamily.Name, chk.Font.Size, chk.Checked ? FontStyle.Bold : FontStyle.Regular);
      string strHarga = chk.Text.Substring(chk.Text.IndexOf("(") + 1).Replace(")", "");
      foreach (var ctl in grpPaket.Controls)
      {
        if (ctl is Label lbl && lbl.Name.ToLower().Contains(chk.Name.ToLower().Substring(3)))
        {
          if (chk.Checked)
          {
            lbl.Text = strHarga;
          }
          else
          {
            lbl.Text = "Rp 0";
          }
        }

      }
      decimal total = 0;
      foreach (var ctl in grpPaket.Controls)
      {
        if (ctl is Label lbl)
        {
          decimal harga = Convert.ToDecimal(lbl.Text.Replace("Rp ", "").Replace(".", ""));
          total += harga;
        }
      }
      this.lblTotal.Text = $"Rp {total:n0}";
    }

  }
}
