using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pertemuan02Latihan01
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

      // untuk latihan soal 01
      //Application.Run(new Form1());

      // untuk latihan soal 02
      Application.Run(new FrmPenunjukWaktu());

    }
  }
}
