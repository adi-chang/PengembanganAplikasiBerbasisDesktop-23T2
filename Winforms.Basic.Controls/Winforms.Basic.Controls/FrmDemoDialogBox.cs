using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.Basic.Controls
{
  public partial class FrmDemoDialogBox : Form
  {
    public FrmDemoDialogBox()
    {
      InitializeComponent();
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        foreach (string itemFile in openFileDialog1.FileNames)
        {
          var fi = new FileInfo(itemFile);
          this.lstData.Items.Add(fi.Name);
        }
      }
    }

    private void btnChooseColor_Click(object sender, EventArgs e)
    {
      if (colorDialog1.ShowDialog() == DialogResult.OK)
      {
        Color warna = colorDialog1.Color;
        this.lblColor.BackColor = warna;
      }
    }

  }
}
