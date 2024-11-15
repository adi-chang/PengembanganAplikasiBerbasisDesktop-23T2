using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Pertemuan_11
{
  public partial class FrmDataMahasiswa : Form
  {

    public FrmDataMahasiswa()
    {
      InitializeComponent();
      //Set Double buffering on the Grid using reflection and the bindingflags enum.
      typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dgvData, new object[] { true });
      this.dgvData.AutoGenerateColumns = false;
      // data binding
      this.dgvData.Columns[0].DataPropertyName = nameof(Mahasiswa.Nim);
      this.dgvData.Columns[1].DataPropertyName = nameof(Mahasiswa.Nama);
      this.dgvData.Columns[2].DataPropertyName = nameof(Mahasiswa.JenisKelamin);
      this.dgvData.Columns[3].DataPropertyName = nameof(Mahasiswa.Jurusan);
      this.dgvData.Columns[4].DataPropertyName = nameof(Mahasiswa.KeteranganJurusan);
      this.dgvData.Columns[5].DataPropertyName = nameof(Mahasiswa.WaktuKuliah);
      this.lblCount.Text = $"{this.txtNim.TextLength}";
      this.lblBanyakRecordData.Text = $"{this.dgvData.RowCount:n0} Record.";
    }

    private void QueryData(string nim, string nama, string jenisKelamin, string jurusan, string waktuKuliah)
    {
      try
      {
        this.dgvData.DataSource = null;
        this.lblBanyakRecordData.Text = "";

        // 1. create and open connection
        using (SQLiteConnection conn = new SQLiteConnection(Parameters.ConnectionString))
        {
          conn.Open(); // open connection

          // 2. create and execute sql command (pure sql command) using dapper
          IEnumerable<Mahasiswa> listData = conn.Query<Mahasiswa>(
            $"SELECT m.Nim, m.Nama, m.JenisKelamin, m.Jurusan, m.WaktuKuliah, j.Keterangan as [keteranganjurusan] " +
            $"FROM Mahasiswa m " +
            $"INNER JOIN Jurusan j ON m.Jurusan = j.Kode " +
            $"WHERE Nim Like '{this.txtNim.Text.Trim()}%' " +
            $"And Nama Like '{this.txtNama.Text.Trim()}%' " +
            $"{(!this.cboJenisKelamin.Text.Trim().Equals("") ? $"And JenisKelamin = '{this.cboJenisKelamin.Text.Trim()}'" : "")} " +
            $"{(!this.cboJurusan.Text.Trim().Equals("") ? $"And Jurusan = '{this.cboJurusan.Text.Trim()}'" : "")} " +
            $"{(!this.cboWaktuKuliah.Text.Trim().Equals("") ? $"And WaktuKuliah = '{this.cboWaktuKuliah.Text.Trim()}'" : "")} " +
            $"Order By Nim");

          if (listData != null && listData.Any()) // validasi, only binding if ada data nya
          {
            this.dgvData.DataSource = listData; // binding listdata (koleksi data mahasiswa) to datagridview (visual/gui view)
          }
        }

      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        this.lblBanyakRecordData.Text = $"{this.dgvData.RowCount:n0} Record.";
      }
    }

    int[] _arrGridViewSize;

    private void FrmPendaftaranMahasiswa_Load(object sender, EventArgs e)
    {
      try
      {
        _arrGridViewSize = new int[this.dgvData.ColumnCount];
        for (int i = 0; i < this.dgvData.ColumnCount; i++)
        {
          var col = this.dgvData.Columns[i];
          _arrGridViewSize[i] = (int)(col.Width * 1.0 / this.dgvData.Width * 100);
        }
        QueryData(this.txtNim.Text.Trim(), this.txtNama.Text.Trim(), this.cboJenisKelamin.Text.Trim(), this.cboJurusan.Text.Trim(), this.cboWaktuKuliah.Text.Trim());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
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
      if (e.KeyCode == Keys.Enter)
        this.btnFilter_Click(null, null);
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
      try
      {
        QueryData(this.txtNim.Text.Trim(), this.txtNama.Text.Trim(), this.cboJenisKelamin.Text.Trim(), this.cboJurusan.Text.Trim(), this.cboWaktuKuliah.Text.Trim());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
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

    private void btnTambah_Click(object sender, EventArgs e)
    {
      FrmTambahDataMahasiswa form = new FrmTambahDataMahasiswa();
      if (form.Run(form))
      {
        this.btnFilter_Click(null, null);
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (this.dgvData.CurrentRow != null)
      {
        string nim = this.dgvData.CurrentRow.Cells[0].Value.ToString().Trim();
        FrmEditDataMahasiswa form = new FrmEditDataMahasiswa(nim);
        if (form.Run(form))
        {
          this.btnFilter_Click(null, null);
        }
      }
    }

    private void btnHapus_Click(object sender, EventArgs e)
    {
      if (this.dgvData.CurrentRow != null)
      {
        string nim = this.dgvData.CurrentRow.Cells[0].Value.ToString().Trim();
        string nama = this.dgvData.CurrentRow.Cells[1].Value.ToString().Trim();
        string msg =
          $"Hapus item data:\n\n" +
          $"Nim\t: {nim}\n" +
          $"Nama\t: {nama}\n\n" +
          $"Lanjut ? ";
        if (MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          try
          {
            // 1. create and open connection
            // 2. create transaction di atas koneksi aktif tersebut (untuk menjaga konsistensi data)
            // 3. create command and execute command (DELETE statement) using dapper
            using (SQLiteConnection conn = new SQLiteConnection(Parameters.ConnectionString))
            {
              conn.Open();
              using (SQLiteTransaction trans = conn.BeginTransaction())
              {
                conn.Execute("Delete From Mahasiswa Where Nim = @Nim", new { Nim = nim }, trans);
                trans.Commit(); // commit transaction
              }
            }
            this.btnFilter_Click(null, null);
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
      }
    }

    private void FrmDataMahasiswa_Resize(object sender, EventArgs e)
    {
      for (int i = 0; i < _arrGridViewSize.Length; i++)
      {
        this.dgvData.Columns[i].Width = this.dgvData.Width * _arrGridViewSize[i] / 100;
      }
    }

  }
}
