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
  public partial class FrmDemoNumericUpDown : Form
  {
    public FrmDemoNumericUpDown()
    {
      InitializeComponent();
    }

    private void FrmDemoNumericUpDown_Load(object sender, EventArgs e)
    {
      this.numCelcius_ValueChanged(null, null);
    }

    private void numCelcius_ValueChanged(object sender, EventArgs e)
    {
      int c = (int)this.numCelcius.Value;
      int r = 4 * c / 5;
      int f = 9 * c / 5 + 32;
      int k = c + 273;
      this.lblReamur.Text = r.ToString();
      this.lblFahreinheit.Text = f.ToString();
      this.lblKelvin.Text = k.ToString();
    }

  }
}
