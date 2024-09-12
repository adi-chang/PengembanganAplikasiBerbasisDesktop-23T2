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
  public partial class FrmDemoButton2 : Form
  {
    public FrmDemoButton2()
    {
      InitializeComponent();
      this.Text = $"{this.btnClickMe.Location}";
    }

    Random rnd = new Random();

    private void btnClickMe_MouseMove(object sender, MouseEventArgs e)
    {
      Point buttonLoc = this.btnClickMe.Location;
      Point mouseLoc = e.Location;

      int arah = rnd.Next(0, 3);

      if (arah == 0)
      {
        // up
        buttonLoc.X -= mouseLoc.X / 2;
        buttonLoc.Y -= mouseLoc.Y;
      }
      else if (arah == 1)
      {
        // down
        buttonLoc.X += mouseLoc.X / 2;
        buttonLoc.Y += mouseLoc.Y;
      }
      else if (arah == 2)
      {
        // left
        buttonLoc.X -= mouseLoc.X;
        buttonLoc.Y -= mouseLoc.Y / 2;
      }
      else if (arah == 3)
      {
        buttonLoc.X += mouseLoc.X;
        buttonLoc.Y += mouseLoc.Y / 2;
      }

      if (buttonLoc.X < 0)
      {
        buttonLoc.X = rnd.Next(this.Width);
      }
      if (buttonLoc.X + this.btnClickMe.Width > this.Width)
      {
        buttonLoc.X = rnd.Next(this.Width);
      }
      if (buttonLoc.Y < 0)
      {
        buttonLoc.Y = rnd.Next(this.Width);
      }
      if (buttonLoc.Y + this.btnClickMe.Height > this.Height)
      {
        buttonLoc.Y = rnd.Next(this.Width);
      }

      this.btnClickMe.Location = buttonLoc;

      this.Text = $"{this.btnClickMe.Location}";

    }

    private void btnClickMe_Click(object sender, EventArgs e)
    {
      MessageBox.Show("YES !!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
