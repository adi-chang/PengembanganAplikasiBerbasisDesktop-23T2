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
  public partial class FrmDemoListBox : Form
  {
    public FrmDemoListBox()
    {
      InitializeComponent();
      this.lblItemCount.Text = $"{this.lstData.Items.Count:n0}";
    }

    private void checkBox1_MouseEnter(object sender, EventArgs e)
    {
      CheckBox chk = sender as CheckBox;
      if (!chk.Checked)
      {
        chk.Font = new Font(chk.Font.FontFamily.Name, chk.Font.Size + 1, FontStyle.Bold);
      }
    }

    private void checkBox1_MouseLeave(object sender, EventArgs e)
    {
      CheckBox chk = sender as CheckBox;
      if (!chk.Checked)
      {
        chk.Font = new Font(chk.Font.FontFamily.Name, 8.25f, FontStyle.Regular);
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      CheckBox chk = sender as CheckBox;
      chk.Font = new Font(chk.Font.FontFamily.Name, 8.25f, chk.Checked ? FontStyle.Bold : FontStyle.Regular);
    }

    private void btnMove_Click(object sender, EventArgs e)
    {
      this.lstData.Items.Clear();
      int count = 0;
      foreach (Control ctl in this.grpPilihan.Controls)
      {
        if (ctl is CheckBox chk && chk.Checked)
        {
          this.lstData.Items.Add(ctl.Text);
          count += 1;
        }
      }
      if (count == 0)
      {
        MessageBox.Show("Sorry, belum ada nama yang dipilih ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      this.lblItemCount.Text = $"{this.lstData.Items.Count:n0}";
    }

    private void btnInfo_Click(object sender, EventArgs e)
    {
      if (this.lstData.Items.Count == 0)
      {
        MessageBox.Show("Sorry, tidak ada data di dalam listbox ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        StringBuilder sb = new StringBuilder();
        foreach (string itemNama in this.lstData.Items)
        {
          sb.AppendLine(itemNama);
        }
        if (sb.ToString().Trim() != "")
        {
          string msg = $"Daftar Nama:\n\n{sb.ToString()}";
          MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }

    private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control ctl = ((ContextMenuStrip)((ToolStripItem)sender).Owner).SourceControl;
      if (ctl.Name.Equals("grpPilihan", StringComparison.CurrentCultureIgnoreCase))
      {
        GroupBox grp = ctl as GroupBox;
        foreach (var c in grp.Controls)
        {
          if (c is CheckBox chk)
            chk.Checked = false;
        }
      }
      else if (ctl.Name.Equals("lstData", StringComparison.CurrentCultureIgnoreCase))
      {
        ListBox lst = ctl as ListBox;
        lst.Items.Clear();
      }
    }

    private void btnCheckAll_Click(object sender, EventArgs e)
    {
      foreach (Control ctl in this.grpPilihan.Controls)
      {
        if (ctl is CheckBox chk)
          chk.Checked = true;
      }
    }


  }
}
