using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Pertemuan_11
{
  public partial class FrmEditDataMahasiswa : Form
  {

    bool _result = false;

    public bool Run(FrmEditDataMahasiswa form)
    {
      form.ShowDialog();
      return _result;
    }

    readonly string _nimOriginal = string.Empty;

    public FrmEditDataMahasiswa(string nim)
    {
      InitializeComponent();
      _nimOriginal = nim;
    }

    private void FrmEditDataMahasiswa_Load(object sender, EventArgs e)
    {
      this.lblCount.Text = $"{this.txtNim.TextLength}";
      if (_nimOriginal != string.Empty)
      {
        try
        {
          this.lblNim.Text = _nimOriginal;
          using (SQLiteConnection conn = new SQLiteConnection(Parameters.ConnectionString))
          {
            conn.Open();
            Mahasiswa item = conn.QueryFirstOrDefault<Mahasiswa>("Select * From Mahasiswa Where Nim = @Nim", new { Nim = _nimOriginal });
            if (item != null)
            {
              this.txtNim.Text = item.Nim;
              this.txtNama.Text = item.Nama;
              if (item.JenisKelamin.Equals("Pria", StringComparison.CurrentCultureIgnoreCase))
                this.radPria.Checked = true;
              else
                this.radWanita.Checked = true;
              if (item.Jurusan.Equals("IT", StringComparison.CurrentCultureIgnoreCase))
                this.radIT.Checked = true;
              else
                this.radIS.Checked = true;
              if (item.WaktuKuliah.Equals("Pagi", StringComparison.CurrentCultureIgnoreCase))
                this.radPagi.Checked = true;
              else
                this.radSore.Checked = true;
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
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

    private void txtNim_TextChanged(object sender, EventArgs e)
    {
      this.lblCount.Text = $"{this.txtNim.TextLength}";
    }

    private void txtNim_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = true;
      if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) e.Handled = false;
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
          // 2. create and execute command using dapper

          using (SQLiteConnection conn = new SQLiteConnection(Parameters.ConnectionString))
          {
            conn.Open();
            using (SQLiteTransaction trans = conn.BeginTransaction())
            {
              conn.Execute("update mahasiswa set nim = @nimbaru, nama = @nama, jeniskelamin = @jeniskelamin, jurusan = @jurusan, waktukuliah = @waktukuliah where nim = @nimoriginal",
                new { nimbaru = nim, nama = nama, jeniskelamin = jenisKelamin, jurusan = jurusan, waktukuliah = waktuKuliah, nimoriginal = _nimOriginal }, trans);
              trans.Commit();
            }
          }

          _result = true;

          MessageBox.Show($"1 (satu) record berhasil diupdate.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
