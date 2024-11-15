using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Dapper;

namespace Pertemuan_11
{
  public partial class FrmTambahDataMahasiswa : Form
  {

    bool _result = false;

    public bool Run(FrmTambahDataMahasiswa form)
    {
      form.ShowDialog();
      return _result;
    }

    public FrmTambahDataMahasiswa()
    {
      InitializeComponent();
    }

    private void FrmTambahPendaftaranMahasiswa_Load(object sender, EventArgs e)
    {
      this.lblCount.Text = $"{this.txtNim.TextLength}";
    }

    private void radPria_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton rad = sender as RadioButton;
      rad.Font = new Font(rad.Font.FontFamily.Name, rad.Font.Size, rad.Checked ? FontStyle.Bold : FontStyle.Regular);
    }

    private void txtNim_Enter(object sender, EventArgs e)
    {
      Control ctl = sender as Control;
      ctl.BackColor = Color.FromKnownColor(KnownColor.LightGreen);
    }

    private void txtNim_Leave(object sender, EventArgs e)
    {
      Control ctl = sender as Control;
      ctl.BackColor = Color.FromKnownColor(KnownColor.Window);
    }

    private void txtNim_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
    }

    private void txtNim_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = true;
      if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) e.Handled = false;
    }

    private void txtNim_TextChanged(object sender, EventArgs e)
    {
      this.lblCount.Text = $"{this.txtNim.TextLength}";
    }

    private void btnSimpan_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.txtNim.Text.Trim().Equals(""))
          throw new Exception("Sorry, data nim tidak boleh kosong ...");
        else if (this.txtNama.Text.Trim().Equals(""))
          throw new Exception("Sorry, data nama tidak boleh kosong ...");
        else
        {
          string nim = this.txtNim.Text.Trim();
          string nama = this.txtNama.Text.Trim();
          string jenisKelamin = "";
          string jurusan = "";
          string waktuKuliah = "";
          if (this.radPria.Checked)
            jenisKelamin = this.radPria.Text;
          else if (this.radWanita.Checked)
            jenisKelamin = this.radWanita.Text;
          if (this.radIT.Checked)
            jurusan = this.radIT.Text;
          else if (this.radIS.Checked)
            jurusan = this.radIS.Text;
          if (this.radPagi.Checked)
            waktuKuliah = this.radPagi.Text;
          else if (this.radSore.Checked)
            waktuKuliah = this.radSore.Text;
          if (nim.Length != 10)
            throw new Exception("Sorry, data nim harus 10 digit ...");
          if (jenisKelamin.Equals(""))
            throw new Exception("Sorry, data jenis kelamin tidak boleh kosong ...");
          if (jurusan.Equals(""))
            throw new Exception("Sorry, data jurusan tidak boleh kosong ...");
          if (waktuKuliah.Equals(""))
            throw new Exception("Sorry, data waktu kuliah tidak boleh kosong ...");

          // 1. create and open connection
          // 2. create transaction (untuk menjaga konsistensi data)
          // 3. create and execute command via dapper

          // create object bertipe Mahasiswa

          Mahasiswa mhs = new Mahasiswa()
          {
            Nim = this.txtNim.Text.Trim(),
            Nama = this.txtNama.Text.Trim(),
            JenisKelamin = this.radPria.Checked ? this.radPria.Text.Trim() : this.radWanita.Text.Trim(),
            Jurusan = this.radIT.Checked ? this.radIT.Text.Trim() : this.radIS.Text.Trim(),
            WaktuKuliah = this.radPagi.Checked ? this.radPagi.Text.Trim() : this.radSore.Text.Trim(),
          };

          int recCount = 0;

          using (SQLiteConnection conn = new SQLiteConnection(Parameters.ConnectionString))
          {
            conn.Open();
            using (SQLiteTransaction trans = conn.BeginTransaction())
            {
              // sql prepared statement
              recCount = conn.Execute("INSERT INTO Mahasiswa Values (@Nim, @Nama, @JenisKelamin, @Jurusan, @WaktuKuliah)", mhs, trans);
              trans.Commit();
            }
          }

          _result = true;

          if (recCount > 0)
          {
            MessageBox.Show($"{recCount} record berhasil ditambahkan ke dalam database.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
          }

          this.Close();

        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

  }
}
