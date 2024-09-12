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
  public partial class FrmDemoProgressBar : Form
  {
    public FrmDemoProgressBar()
    {
      InitializeComponent();
    }

    private void FrmDemoProgressBar_Load(object sender, EventArgs e)
    {
      this.lblMinimum.Text = $"{pbar.Minimum}";
      this.lblMaximum.Text = $"{pbar.Maximum}";
      this.lblValue.Text = $"{pbar.Value}";
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if(this.pbar.Value+1 <= this.pbar.Maximum)
      {
        this.pbar.Value += 1;
        this.lblValue.Text = $"{this.pbar.Value}";
      }
      else
      {
        this.timer1.Stop();
      }
    }

  }
}
