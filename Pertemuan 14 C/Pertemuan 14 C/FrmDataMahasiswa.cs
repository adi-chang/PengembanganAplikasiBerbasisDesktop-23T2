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

    AkademikDataSet _ds = null;

    BindingSource _bs = null;

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
        _ds = new AkademikDataSet();

        // create object bindingsource
        _bs = new BindingSource();

        // fill the dataset with data from database
        _adapter.Fill(_ds.Mahasiswa);
        _adapter.FillSchema(_ds.Mahasiswa, SchemaType.Source);

        // set object bindingsource ke tabel mahasiswa yang ada di dalam dataset
        _bs.DataSource = _ds.Mahasiswa;

        if (_bs.Count > 0)
        {
          // binding to datagridview
          this.dgvData.DataSource = _bs;

          this.btnMoveFirst_Click(null, null);
        }

        // binding textbox dan combobox
        this.txtNim.DataBindings.Add("Text", _bs, "Nim");
        this.txtNama.DataBindings.Add("Text", _bs, "Nama");
        this.cboJenisKelamin.DataBindings.Add("Text", _bs, "JenisKelamin");
        this.cboJurusan.DataBindings.Add("Text", _bs, "Jurusan");
        this.cboWaktuKuliah.DataBindings.Add("Text", _bs, "WaktuKuliah");

        AturForm(false);
        AturButton(true, false, true, false, true, false);

        _conn.Close();

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void btnMoveFirst_Click(object sender, EventArgs e)
    {
      if (_bs?.Count > 0)
      {
        _bs.MoveFirst();
        this.lblKeterangan.Text = $"{_bs.Position + 1:n0}/{_bs.Count:n0}";
      }
    }

    private void btnMovePrev_Click(object sender, EventArgs e)
    {
      if (_bs != null && _bs.Position > 0)
      {
        _bs.MovePrevious();
        this.lblKeterangan.Text = $"{_bs.Position + 1:n0}/{_bs.Count:n0}";
      }
    }

    private void btnMoveNext_Click(object sender, EventArgs e)
    {
      if (_bs != null && _bs.Position < _bs.Count - 1)
      {
        _bs.MoveNext();
        this.lblKeterangan.Text = $"{_bs.Position + 1:n0}/{_bs.Count:n0}";
      }
    }

    private void btnMoveLast_Click(object sender, EventArgs e)
    {
      if (_bs?.Count > 0)
      {
        _bs.MoveLast();
        this.lblKeterangan.Text = $"{_bs.Position + 1:n0}/{_bs.Count:n0}";
      }
    }

    private void btnTambah_Click(object sender, EventArgs e)
    {
      this.lblKeterangan.Text = "Add New Item ...";
      _bs.AddNew();
      _bs.MoveLast();
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
          AkademikDataSet.MahasiswaRow row = _ds.Mahasiswa.NewMahasiswaRow();

          row.Nim = this.txtNim.Text.Trim();
          row.Nama = this.txtNama.Text.Trim();
          row.JenisKelamin = this.cboJenisKelamin.Text.Trim();
          row.Jurusan = this.cboJurusan.Text.Trim();
          row.WaktuKuliah = this.cboWaktuKuliah.Text.Trim();

          _ds.Mahasiswa.Rows.Add(row);

          _adapter.Update(_ds.Mahasiswa);

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
          AkademikDataSet.MahasiswaRow row = (AkademikDataSet.MahasiswaRow)_ds.Mahasiswa.Rows.Find(this.txtNim.Text.Trim());

          row.BeginEdit();

          row.Nim = this.txtNim.Text.Trim();
          row.Nama = this.txtNama.Text.Trim();
          row.JenisKelamin = this.cboJenisKelamin.Text.Trim();
          row.Jurusan = this.cboJurusan.Text.Trim();
          row.WaktuKuliah = this.cboWaktuKuliah.Text.Trim();

          row.EndEdit();

          _adapter.Update(_ds.Mahasiswa);

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
          AkademikDataSet.MahasiswaRow row = (AkademikDataSet.MahasiswaRow)_ds.Mahasiswa.Rows.Find(this.txtNim.Text.Trim());
          row.Delete();
          _adapter.Update(_ds.Mahasiswa);
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
      _bs.CancelEdit();
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
