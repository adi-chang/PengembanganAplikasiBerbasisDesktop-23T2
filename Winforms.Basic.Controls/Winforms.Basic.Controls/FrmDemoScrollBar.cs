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
  public partial class FrmDemoScrollBar : Form
  {
    public FrmDemoScrollBar()
    {
      InitializeComponent();
    }

    private void FrmDemoScrollBar_Load(object sender, EventArgs e)
    {
      this.lbl1.Text = $"{this.hsb1.Value}";
      this.lbl2.Text = $"{this.vsb1.Value}";
    }

    private void hsb1_ValueChanged(object sender, EventArgs e)
    {
      this.lbl1.Text = $"{this.hsb1.Value}";
    }

    private void vsb1_ValueChanged(object sender, EventArgs e)
    {
      this.lbl2.Text = $"{this.vsb1.Value}";
    }

  }
}
