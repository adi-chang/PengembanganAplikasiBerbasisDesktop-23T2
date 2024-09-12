using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.Basic.Controls
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //Application.Run(new FrmDemoLabel());
      //Application.Run(new FrmDemoTextBox());
      //Application.Run(new FrmDemoTimer());
      //Application.Run(new FrmDemoButton());
      //Application.Run(new FrmDemoButton2());
      //Application.Run(new FrmDemoCheckBox());
      //Application.Run(new FrmDemoRadioButton());
      //Application.Run(new FrmDemoProgressBar());
      //Application.Run(new FrmDemoTrackBar());
      //Application.Run(new FrmDemoTrackBar2());
      //Application.Run(new FrmDemoScrollBar());
      //Application.Run(new FrmDemoListBox());
      //Application.Run(new FrmDemoComboBox());
      //Application.Run(new FrmDemoMessageBox());
      //Application.Run(new FrmDemoDialogBox());
      //Application.Run(new FrmDemoPictureBox());
      //Application.Run(new FrmDemoNumericUpDown());
      Application.Run(new FrmDemoDataGridView());
    }
  }
}
