using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.Basic.Controls
{
  public partial class FrmDemoComboBox : Form
  {
    public FrmDemoComboBox()
    {
      InitializeComponent();
    }

    string[] arrData = new string[] {
      "",
      "Ayam",
      "Beruang",
      "Gajah",
      "Harimau",
      "Ikan",
      "Kura-Kura",
      "Semut",
      "Singa",
    };

    class Data
    {
      public string Item { get; set; }
    }

    IEnumerable<Data> listData = new List<Data>
    {
      new Data { Item = "" },
      new Data { Item = "Ayam" },
      new Data { Item = "Beruang" },
      new Data { Item = "Gajah" },
      new Data { Item = "Harimau" },
      new Data { Item = "Ikan" },
      new Data { Item = "Kura-Kura" },
      new Data { Item = "Semut" },
      new Data { Item = "Singa" },
    };

    private void FrmDemoComboBox_Load(object sender, EventArgs e)
    {
      this.cbo3.Items.AddRange(arrData.ToArray());

      this.cbo4.DataSource = listData;
      this.cbo4.DisplayMember = nameof(Data.Item);
      this.cbo4.ValueMember = nameof(Data.Item);
      this.cbo4.SelectedIndex = 0;

      this.cbo1_SelectedIndexChanged(null, null);
      this.cbo2_SelectedIndexChanged(null, null);
      this.cbo3_SelectedIndexChanged(null, null);
      this.cbo4_SelectedIndexChanged(null, null);

    }

    private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.lbl1.Text = this.cbo1.Text;
    }

    private void cbo2_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.lbl2.Text = this.cbo2.Text;
    }

    private void cbo3_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.lbl3.Text = this.cbo3.Text;
    }

    private void cbo4_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.lbl4.Text = this.cbo4.SelectedValue?.ToString() ?? "";
    }

    private void cbo2_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        ComboBox cbo = sender as ComboBox;
        string isian = cbo.Text;
        if (!isian .Equals(""))
        {
          bool ada = false;
          foreach (string item in cbo.Items)
          {
            if (item.Equals(isian, StringComparison.CurrentCultureIgnoreCase))
            {
              ada = true;
              break;
            }
          }
          if (!ada)
          {
            MessageBox.Show($"Sorry, item: {isian} tidak ada ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbo.Focus();
          }
        }
      }
    }

    private void cbo2_Leave(object sender, EventArgs e)
    {
      ComboBox cbo = sender as ComboBox;
      if (cbo.Name.Equals("cbo3", StringComparison.CurrentCultureIgnoreCase))
      {
        cbo.BackColor = Color.FromKnownColor(KnownColor.Window);
      }
      string isian = cbo.Text;
      if (!isian.Equals(""))
      {
        bool ada = false;
        foreach (string item in cbo.Items)
        {
          if (item.Equals(isian, StringComparison.CurrentCultureIgnoreCase))
          {
            ada = true;
            break;
          }
        }
        if (!ada)
        {
          MessageBox.Show($"Sorry, item: {isian} tidak ada ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
          cbo.Focus();
        }
      }
    }

    private void cbo4_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        ComboBox cbo = sender as ComboBox;
        string isian = cbo.Text;
        if (!isian.Equals(""))
        {
          bool ada = false;
          foreach (Data itemData in cbo.Items)
          {
            if (itemData.Item.Equals(isian, StringComparison.CurrentCultureIgnoreCase))
            {
              ada = true;
              break;
            }
          }
          if (!ada)
          {
            MessageBox.Show($"Sorry, item: {isian} tidak ada ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbo.Focus();
          }
        }
      }
    }

    private void cbo4_Leave(object sender, EventArgs e)
    {
      ComboBox cbo = sender as ComboBox;
      string isian = cbo.Text;
      if (!isian.Equals(""))
      {
        bool ada = false;
        foreach (Data itemData in cbo.Items)
        {
          if (itemData.Item.Equals(isian, StringComparison.CurrentCultureIgnoreCase))
          {
            ada = true;
            break;
          }
        }
        if (!ada)
        {
          MessageBox.Show($"Sorry, item: {isian} tidak ada ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
          cbo.Focus();
        }
      }
    }

    private void cbo2_Enter(object sender, EventArgs e)
    {
      ComboBox cbo = sender as ComboBox;
      cbo.BackColor = Color.FromKnownColor(KnownColor.LightGreen);
    }

  }
}
