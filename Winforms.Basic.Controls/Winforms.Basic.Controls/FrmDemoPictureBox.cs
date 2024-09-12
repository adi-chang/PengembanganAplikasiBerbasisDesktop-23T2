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
  public partial class FrmDemoPictureBox : Form
  {
    public FrmDemoPictureBox()
    {
      InitializeComponent();
      this.cboSizeMode.SelectedIndex = 1;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      using (var ofd = new OpenFileDialog())
      {
        ofd.Title = "Choose Picture";
        ofd.Filter = "JPEG File (*.jpg)|*.jpg|PNG File (*.png)|*.png";
        ofd.FilterIndex = 0;
        ofd.Multiselect = false;
        ofd.CheckPathExists = true;
        ofd.CheckFileExists = true;
        ofd.FileName = "";
        if (ofd.ShowDialog() == DialogResult.OK)
        {
          this.pictureBox1.Image = Image.FromFile(ofd.FileName);
        }
      }
    }

    private void cboSizeMode_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (this.cboSizeMode.SelectedIndex)
      {
        case 0:
          this.pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
          break;
        case 1:
          this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
          break;
        case 2:
          this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
          break;
        case 3:
          this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
          break;
      }
    }

  }
}
