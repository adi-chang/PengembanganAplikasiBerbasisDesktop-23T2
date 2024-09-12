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
  public partial class FrmDemoTimer : Form
  {
    public FrmDemoTimer()
    {
      InitializeComponent();
    }

    private void FrmDemoTimer_Load(object sender, EventArgs e)
    {
      this.lblTime.Text = $"{DateTime.Now:dddd, dd MMMM yyyy HH:mm:ss}";
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.lblTime.Text = $"{DateTime.Now:dddd, dd MMMM yyyy HH:mm:ss}";
    }

  }
}
