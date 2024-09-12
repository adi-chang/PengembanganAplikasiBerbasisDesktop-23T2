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
  public partial class FrmDemoTrackBar : Form
  {
    public FrmDemoTrackBar()
    {
      InitializeComponent();
    }

    private void FrmDemoTrackBar_Load(object sender, EventArgs e)
    {
      this.tbar5.Value = this.tbar5.Maximum;

      this.lbl1.Text = $"{this.tbar1.Value}";
      this.lbl2.Text = $"{this.tbar2.Value}";
      this.lbl3.Text = $"{this.tbar3.Value}";
      this.lbl4.Text = $"{this.tbar4.Value}";
      this.lbl5.Text = $"{this.tbar5.Value}";

    }

    private void tbar1_ValueChanged(object sender, EventArgs e)
    {
      TrackBar tbar = sender as TrackBar;
      switch (tbar.Name)
      {
        case "tbar1":
          this.lbl1.Text = $"{this.tbar1.Value}";
          break;
        case "tbar2":
          this.lbl2.Text = $"{this.tbar2.Value}";
          break;
        case "tbar3":
          this.lbl3.Text = $"{this.tbar3.Value}";
          break;
        case "tbar4":
          this.lbl4.Text = $"{this.tbar4.Value}";
          break;
        case "tbar5":
          this.lbl5.Text = $"{this.tbar5.Value}";
          break;
      }
    }
  }
}
