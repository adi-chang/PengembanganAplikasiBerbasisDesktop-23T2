using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pertemuan02Latihan01
{
  public partial class FrmPenunjukWaktu : Form
  {
    public FrmPenunjukWaktu()
    {
      InitializeComponent();
    }

    private void FrmPenunjukWaktu_Load(object sender, EventArgs e)
    {
      this.timer1_Tick(null, null);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      DateTime sekarang = DateTime.Now;
      this.lblWaktu.Text = $"{sekarang:dddd, dd MMMM yyyy HH:mm:ss}";
      this.lblKeteranganNamaHari.Text = $"{sekarang:ddddd}";
      this.lblKeteranganTanggal.Text = $"{sekarang:dd}";
      this.lblKeteranganBulan.Text = $"{sekarang:MMMM}";
      this.lblKeteranganTahun.Text = $"{sekarang:yyyy}";
      this.lblKeteranganWaktu.Text = $"{sekarang:HH:mm:ss}";
    }

    private void FrmPenunjukWaktu_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape) this.Close();
    }

    private void FrmPenunjukWaktu_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (MessageBox.Show("Exit Program ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      {
        e.Cancel = true;
      }
    }

  }
}
