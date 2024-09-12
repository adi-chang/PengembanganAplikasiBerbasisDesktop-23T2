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
  public partial class FrmDemoCheckBox : Form
  {
    public FrmDemoCheckBox()
    {
      InitializeComponent();
    }

    private void chkNasiGoreng_CheckedChanged(object sender, EventArgs e)
    {
      CheckBox chk = sender as CheckBox;
      chk.Font = new Font(chk.Font.FontFamily.Name, 8.25f, chk.Checked ? FontStyle.Bold : FontStyle.Regular);
    }

    private void btnClearAll_Click(object sender, EventArgs e)
    {
      // manual un-tick one by one

      this.chkNasiGoreng.Checked = false;
      this.chkMieGoreng.Checked = false;
      this.chkBuburAyam.Checked = false;
      this.chkNasiUduk.Checked = false;
      this.chkMiePangsit.Checked = false;

      // auto un-tick in one group
      foreach (Control ctl in this.grpMinuman.Controls)
      {
        if (ctl is CheckBox chk)
          chk.Checked = false;
      }
    }

    private void chkNasiGoreng_MouseEnter(object sender, EventArgs e)
    {
      CheckBox chk = sender as CheckBox;
      if (!chk.Checked)
      {
        chk.Font = new Font(chk.Font.FontFamily.Name, chk.Font.Size+1, FontStyle.Bold);
      }
    }

    private void chkNasiGoreng_MouseLeave(object sender, EventArgs e)
    {
      CheckBox chk = sender as CheckBox;
      if (!chk.Checked)
      {
        chk.Font = new Font(chk.Font.FontFamily.Name, 8.25f, FontStyle.Regular);
      }
    }

    private void btnTickAll_Click(object sender, EventArgs e)
    {
      // use looping
      foreach (Control ctl in this.pnlMakanan.Controls)
      {
        if (ctl is CheckBox chk)
          chk.Checked = true;
      }
    }

    private void btnTickAll2_Click(object sender, EventArgs e)
    {
      // manually tick one by one
      this.chkIceTea.Checked = true;
      this.chkMilo.Checked = true;
      this.chkSprite.Checked = true;
      this.chkJusJeruk.Checked = true;
      this.chkJusMartabe.Checked = true;
    }

  }
}
