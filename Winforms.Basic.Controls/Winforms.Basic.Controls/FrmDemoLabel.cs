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
  public partial class FrmDemoLabel : Form
  {
    public FrmDemoLabel()
    {
      InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {
      MessageBox.Show($"You Click Label with text:\n{label2.Text}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void label2_MouseEnter(object sender, EventArgs e)
    {
      label2.Font = new Font(label2.Font.FontFamily.Name, label2.Font.Size, FontStyle.Bold);
    }

    private void label2_MouseLeave(object sender, EventArgs e)
    {
      label2.Font = new Font(label2.Font.FontFamily.Name, label2.Font.Size, FontStyle.Regular);
    }

    private void label3_MouseEnter(object sender, EventArgs e)
    {
      label3.BackColor = Color.FromKnownColor(KnownColor.Green);
      label3.ForeColor = Color.White;
    }

    private void label3_MouseLeave(object sender, EventArgs e)
    {
      label3.BackColor = Color.FromKnownColor(KnownColor.Control);
      label3.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
    }

  }
}
