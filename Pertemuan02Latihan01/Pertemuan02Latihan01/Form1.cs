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
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private const string MY_PASSWORD = "password";

    private void Form1_Load(object sender, EventArgs e)
    {
      this.lblCount.Text = $"{this.txtInput.Text.Length}";
      this.btnMasuk.Enabled = false;
    }

    private void btnValidasi_Click(object sender, EventArgs e)
    {
      if (!this.txtInput.Text.Equals(""))
      {
        if (this.txtInput.Text.Equals(MY_PASSWORD))
        {
          this.lblKeterangan.Text = "Password Benar!";
          this.lblKeterangan.ForeColor = Color.Green;
          this.btnMasuk.Enabled = true;
          this.btnValidasi.Enabled = false;
        }
        else
        {
          this.lblKeterangan.Text = "Password Salah! ulangi lagi!";
          this.lblKeterangan.ForeColor = Color.Red;
        }
      }
    }

    private void btnMasuk_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form2 form = new Form2();
      form.ShowDialog();
      this.Show();
      this.txtInput.Clear();
      this.btnValidasi.Enabled = true;
      this.btnMasuk.Enabled = false;
      this.lblKeterangan.Text = "";
      this.txtInput.Focus();
    }

    private void btnKeluar_Click(object sender, EventArgs e)
    {
      this.Close();
      //Application.Exit();
    }

    private void txtInput_TextChanged(object sender, EventArgs e)
    {
      this.lblCount.Text = $"{this.txtInput.TextLength}";
    }

    private void txtInput_Enter(object sender, EventArgs e)
    {
      this.txtInput.BackColor = Color.FromKnownColor(KnownColor.LightGreen);
    }

    private void txtInput_Leave(object sender, EventArgs e)
    {
      this.txtInput.BackColor = Color.FromKnownColor(KnownColor.Window);
    }

  }
}
