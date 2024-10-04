using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pertemuan_07
{
  public partial class FrmColoring : Form
  {
    public FrmColoring()
    {
      InitializeComponent();
    }

    private void FrmColoring_Load(object sender, EventArgs e)
    {
      Type colorType = typeof(System.Drawing.Color);
      PropertyInfo[] propInfos = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
      foreach (PropertyInfo propInfo in propInfos)
      {
        this.cboKnownColor.Items.Add(propInfo.Name);
      }
      if (this.cboKnownColor.Items.Count > 0)
        this.cboKnownColor.Items.Insert(0, "");
      this.hsbRed_ValueChanged(null, null);
      this.cboMyColor.Items.Add("");
    }

    private void hsbRed_ValueChanged(object sender, EventArgs e)
    {
      this.lblRedValue.Text = $"{this.hsbRed.Value:n0}";
      this.lblGreenValue.Text = $"{this.hsbGreen.Value:n0}";
      this.lblBlueValue.Text = $"{this.hsbBlue.Value:n0}";
      this.lblColor.BackColor = Color.FromArgb(this.hsbRed.Value, this.hsbGreen.Value, this.hsbBlue.Value);
      this.lblRedValue.ForeColor = Color.FromArgb(this.hsbRed.Value, 0, 0);
      this.lblGreenValue.ForeColor = Color.FromArgb(0, this.hsbGreen.Value, 0);
      this.lblBlueValue.ForeColor = Color.FromArgb(0, 0, this.hsbBlue.Value);
    }

    private void pickColorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (var dlg = new ColorDialog())
      {
        if (dlg.ShowDialog() == DialogResult.OK)
        {
          Color color = dlg.Color;
          this.hsbRed.Value = color.R;
          this.hsbGreen.Value = color.G;
          this.hsbBlue.Value = color.B;
        }
      }

    }

    private void cboKnownColor_SelectedIndexChanged(object sender, EventArgs e)
    {
      Color color;
      if (this.cboKnownColor.Text.Trim() != "")
      {
        color = Color.FromName(this.cboKnownColor.Text);
      }
      else
      {
        color = Color.FromKnownColor(KnownColor.Control);
      }
      this.hsbRed.Value = color.R;
      this.hsbGreen.Value = color.G;
      this.hsbBlue.Value = color.B;
    }

    List<(string name, int r, int g, int b)> _listMyColor = new List<(string name, int r, int g, int b)>();

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (this.txtColorName.Text.Trim() == "")
      {
        MessageBox.Show("Sorry, isi nama warna terlebih dahulu ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        this.txtColorName.Focus();
      }
      else
      {
        bool ada = false;
        foreach (var item in _listMyColor)
        {
          if(item.name.Equals(this.txtColorName.Text.Trim(), StringComparison.CurrentCultureIgnoreCase))
          {
            ada = true;
            break;
          }
        }
        if (ada)
        {
          MessageBox.Show("Sorry, nama warna yang sama sudah terdaftar ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
          this.txtColorName.Focus();
        }
        else
        {
          _listMyColor.Add((this.txtColorName.Text.ToUpper().Trim(), this.hsbRed.Value, this.hsbGreen.Value, this.hsbBlue.Value));
          this.cboMyColor.Items.Add(this.txtColorName.Text.ToUpper().Trim());
          this.txtColorName.Clear();
          this.txtColorName.Focus();
        }
      }
    }

    private void cboMyColor_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.cboMyColor.Items.Count > 0)
      {
        Color color;
        if (this.cboMyColor.Text.Trim() != "")
        {
          // LINQ
          var itemMyColor = (from item in _listMyColor
                             where item.name.Equals(this.cboMyColor.Text.Trim(), StringComparison.CurrentCultureIgnoreCase)
                             select item).First();
          color = Color.FromArgb(itemMyColor.r, itemMyColor.g, itemMyColor.b);
        }
        else
        {
          color = Color.FromKnownColor(KnownColor.Control);
        }
        this.hsbRed.Value = color.R;
        this.hsbGreen.Value = color.G;
        this.hsbBlue.Value = color.B;
      }
    }

    private void txtColorName_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
    }
  }
}
