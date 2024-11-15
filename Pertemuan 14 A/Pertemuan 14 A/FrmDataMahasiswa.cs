using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pertemuan_14_A
{
  public partial class FrmDataMahasiswa : Form
  {
    public FrmDataMahasiswa()
    {
      InitializeComponent();
      this.dgvData.AutoGenerateColumns = false;
      this.dgvData.Columns[0].DataPropertyName = "Nim";
      this.dgvData.Columns[1].DataPropertyName = "Nama";
      this.dgvData.Columns[2].DataPropertyName = "JenisKelamin";
      this.dgvData.Columns[3].DataPropertyName = "Jurusan";
      this.dgvData.Columns[4].DataPropertyName = "WaktuKuliah";
      this.lblKeterangan.Text = "";
    }

    private void AturForm(bool value)
    {
      this.txtNim.Enabled = value;
      this.txtNama.Enabled = value;
      this.cboJenisKelamin.Enabled = value;
      this.cboJurusan.Enabled = value;
      this.cboWaktuKuliah.Enabled = value;
      this.btnMoveFirst.Enabled = !value;
      this.btnMovePrev.Enabled = !value;
      this.btnMoveNext.Enabled = !value;
      this.btnMoveLast.Enabled = !value;
    }

    private void ClearForm()
    {
      this.txtNim.Clear();
      this.txtNama.Clear();
      this.cboJenisKelamin.Text = "";
      this.cboJurusan.Text = "";
      this.cboWaktuKuliah.Text = "";
    }

    private void AturButton(bool tambah, bool simpan, bool edit, bool update, bool hapus, bool batal)
    {
      this.btnTambah.Enabled = tambah;
      this.btnSimpan.Enabled = simpan;
      this.btnEdit.Enabled = edit;
      this.btnUpdate.Enabled = update;
      this.btnHapus.Enabled = hapus;
      this.btnBatal.Enabled = batal;
    }

    SQLiteConnection _conn = null;
    SQLiteDataAdapter _adapter = null;
    DataSet _ds = null;

    int _idx = 0;

    private void FrmDataMahasiswa_Load(object sender, EventArgs e)
    {
      try
      {
        // create and open database connection
        _conn = new SQLiteConnection(Parameters.ConnectionString);
        _conn.Open();

        // initialize dataadapter object
        _adapter = new SQLiteDataAdapter("select * from mahasiswa order by nim", _conn);

        // use commandbuilder object to generate insert, update and delete commands
        SQLiteCommandBuilder cmdBuilder = new SQLiteCommandBuilder(_adapter);

        // create object dataset
        _ds = new DataSet();

        // fill the dataset with data from database
        _adapter.Fill(_ds, "Mahasiswa");
        _adapter.FillSchema(_ds, SchemaType.Source, "Mahasiswa");

        if (_ds?.Tables["Mahasiswa"].Rows.Count > 0)
        {
          // binding to datagridview
          this.dgvData.DataSource = _ds.Tables["Mahasiswa"];

          this.btnMoveFirst_Click(null, null);
        }

        AturForm(false);
        AturButton(true, false, true, false, true, false);

        _conn.Close();

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void ShowDataItem(int index)
    {
      if (_ds?.Tables["Mahasiswa"].Rows.Count > 0)
      {
        var row = _ds.Tables["Mahasiswa"].Rows[index];
        this.txtNim.Text = row["nim"].ToString();
        this.txtNama.Text = row["nama"].ToString();
        this.cboJenisKelamin.Text = row["jeniskelamin"].ToString();
        this.cboJurusan.Text = row["jurusan"].ToString();
        this.cboWaktuKuliah.Text = row["waktukuliah"].ToString();
        this.lblKeterangan.Text = $"{(index+1):n0}/{_ds.Tables["Mahasiswa"].Rows.Count:n0}";
      }
    }

    private void btnMoveFirst_Click(object sender, EventArgs e)
    {
      if (_ds.Tables["Mahasiswa"].Rows.Count > 0)
      {
        _idx = 0;
        ShowDataItem(_idx);
      }
    }

    private void btnMovePrev_Click(object sender, EventArgs e)
    {
      if (_ds.Tables["Mahasiswa"].Rows.Count > 0)
      {
        if (_idx > 0) _idx--;
        ShowDataItem(_idx);
      }
    }

    private void btnMoveNext_Click(object sender, EventArgs e)
    {
      if (_ds.Tables["Mahasiswa"].Rows.Count > 0)
      {
        if (_idx < _ds.Tables["Mahasiswa"].Rows.Count - 1) _idx++;
        ShowDataItem(_idx);
      }
    }

    private void btnMoveLast_Click(object sender, EventArgs e)
    {
      if (_ds.Tables["Mahasiswa"].Rows.Count > 0)
      {
        _idx = _ds.Tables["Mahasiswa"].Rows.Count - 1;
        ShowDataItem(_idx);
      }
    }

    private void btnTambah_Click(object sender, EventArgs e)
    {
      this.lblKeterangan.Text = "Add New Item ...";
      ClearForm();
      AturForm(true);
      AturButton(false, true, false, false, false, true);
      this.txtNim.Focus();
    }

    private void btnSimpan_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.txtNim.Text.Trim() == "")
          throw new Exception("Sorry, nim tidak boleh kosong ...");
        else if (this.txtNama.Text.Trim() == "")
          throw new Exception("Sorry, nama tidak boleh kosong ...");
        else if (this.cboJenisKelamin.Text.Trim() == "")
          throw new Exception("Sorry, jenis kelamin tidak boleh kosong ...");
        else if (this.cboJurusan.Text.Trim() == "")
          throw new Exception("Sorry, jurusan tidak boleh kosong ...");
        else if (this.cboWaktuKuliah.Text.Trim() == "")
          throw new Exception("Sorry, waktu kuliah tidak boleh kosong ...");

        if (MessageBox.Show("Simpan data ini ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          DataRow row = _ds.Tables["Mahasiswa"].NewRow();

          row["Nim"] = this.txtNim.Text.Trim();
          row["Nama"] = this.txtNama.Text.Trim();
          row["JenisKelamin"] = this.cboJenisKelamin.Text.Trim();
          row["Jurusan"] = this.cboJurusan.Text.Trim();
          row["WaktuKuliah"] = this.cboWaktuKuliah.Text.Trim();

          _ds.Tables["Mahasiswa"].Rows.Add(row);

          _adapter.Update(_ds, "Mahasiswa");

          this.btnBatal_Click(null, null);
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      this.lblKeterangan.Text = "Edit Data Item ...";
      AturForm(true);
      AturButton(false, false, false, true, false, true);
      this.txtNim.Enabled = false;
      this.txtNama.Focus();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.txtNim.Text.Trim() == "")
          throw new Exception("Sorry, nim tidak boleh kosong ...");
        else if (this.txtNama.Text.Trim() == "")
          throw new Exception("Sorry, nama tidak boleh kosong ...");
        else if (this.cboJenisKelamin.Text.Trim() == "")
          throw new Exception("Sorry, jenis kelamin tidak boleh kosong ...");
        else if (this.cboJurusan.Text.Trim() == "")
          throw new Exception("Sorry, jurusan tidak boleh kosong ...");
        else if (this.cboWaktuKuliah.Text.Trim() == "")
          throw new Exception("Sorry, waktu kuliah tidak boleh kosong ...");

        if (MessageBox.Show("Update data ini ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          DataRow row = _ds.Tables["Mahasiswa"].Rows.Find(this.txtNim.Text.Trim());

          row.BeginEdit();

          row["Nim"] = this.txtNim.Text.Trim();
          row["Nama"] = this.txtNama.Text.Trim();
          row["JenisKelamin"] = this.cboJenisKelamin.Text.Trim();
          row["Jurusan"] = this.cboJurusan.Text.Trim();
          row["WaktuKuliah"] = this.cboWaktuKuliah.Text.Trim();

          row.EndEdit();

          _adapter.Update(_ds, "Mahasiswa");

          this.btnBatal_Click(null, null);
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void btnHapus_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Hapus item data ini ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        try
        {
          DataRow row = _ds.Tables["Mahasiswa"].Rows.Find(this.txtNim.Text.Trim());
          row.Delete();
          _adapter.Update(_ds, "Mahasiswa");
          this.btnBatal_Click(null, null);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }

    private void btnBatal_Click(object sender, EventArgs e)
    {
      AturForm(false);
      AturButton(true, false, true, false, true, false);
      this.btnMoveLast_Click(null, null);
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

  }
}
