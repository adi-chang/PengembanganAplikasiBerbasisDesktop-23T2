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
  public partial class FrmDemoTrackBar2 : Form
  {
    public FrmDemoTrackBar2()
    {
      InitializeComponent();
    }

    private void FrmDemoTrackBar2_Load(object sender, EventArgs e)
    {
      this.lblCelcius.Text = $"{this.tbarCelcius.Value}";
      this.lblReamur.Text = $"{this.tbarReamur.Value}";
      this.lblFahreinheit.Text = $"{this.tbarFahreinheit.Value}";
      this.lblKelvin.Text = $"{this.tbarKelvin.Value}";
    }

    private void tbarCelcius_ValueChanged(object sender, EventArgs e)
    {
      TrackBar tbar = sender as TrackBar;
      switch (tbar.Name)
      {
        case "tbarCelcius":
          this.lblCelcius.Text = $"{this.tbarCelcius.Value}";
          break;
        case "tbarReamur":
          this.lblReamur.Text = $"{this.tbarReamur.Value}";
          break;
        case "tbarFahreinheit":
          this.lblFahreinheit.Text = $"{this.tbarFahreinheit.Value}";
          break;
        case "tbarKelvin":
          this.lblKelvin.Text = $"{this.tbarKelvin.Value}";
          break;
      }
    }

    private void tbarCelcius_Scroll(object sender, EventArgs e)
    {
      int c = this.tbarCelcius.Value;
      int r = 4 * c / 5;
      int f = 9 * c / 5 + 32;
      int k = c + 273;
      this.tbarReamur.Value = r;
      this.tbarFahreinheit.Value = f;
      this.tbarKelvin.Value = k;
    }

    private void tbarReamur_Scroll(object sender, EventArgs e)
    {
      int r = this.tbarReamur.Value;
      int c = (int)(r / 0.8);
      int f = (int)(r * 2.25) + 32;
      int k = (int)(r / 0.8) + 273;
      this.tbarCelcius.Value = c;
      this.tbarFahreinheit.Value = f;
      this.tbarKelvin.Value = k;
    }

    private void tbarFahreinheit_Scroll(object sender, EventArgs e)
    {
      int f = this.tbarFahreinheit.Value;
      int c = (f - 32) * 5 / 9;
      int r = 4 * c / 5;
      int k = c + 273;
      this.tbarCelcius.Value = c;
      this.tbarReamur.Value = r;
      this.tbarKelvin.Value = k;
    }

    private void tbarKelvin_Scroll(object sender, EventArgs e)
    {
      int k = this.tbarKelvin.Value;
      int c = k - 273;
      int r = 4 * c / 5;
      int f = 9 * c / 5 + 32;
      this.tbarCelcius.Value = c;
      this.tbarReamur.Value = r;
      this.tbarFahreinheit.Value = f;
    }

  }
}
