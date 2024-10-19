using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pertemuan_09
{
  public partial class Form3 : Form
  {

    const string filename = "data.csv";

    public Form3()
    {
      InitializeComponent();
    }

    private void LoadData(string kriteria)
    {
      try
      {
        this.dgvData.Rows.Clear();
        if (File.Exists(filename))
        {
          string[] arrFileContent = File.ReadAllLines(filename);
          foreach (string line in arrFileContent)
          {
            string[] arr = line.Split('|');
            string kode = arr[0];
            string nama = arr[1];
            string jenisKelamin = arr[2];
            string departemen = arr[3];
            if (kriteria.Equals("all", StringComparison.CurrentCultureIgnoreCase))
            {
              this.dgvData.Rows.Add(new string[] { kode, nama, jenisKelamin, departemen });
            }
            else
            {
              if (jenisKelamin.Equals(kriteria, StringComparison.CurrentCultureIgnoreCase))
              {
                this.dgvData.Rows.Add(new string[] { kode, nama, jenisKelamin, departemen });
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void Form3_Load(object sender, EventArgs e)
    {
      LoadData("all");
    }

    private void btnTambah_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.txtKodePegawai.Text.Trim() == "")
          throw new Exception("Sorry, data kode tidak boleh kosong ...");
        else if (this.txtNamaPegawai.Text.Trim() == "")
          throw new Exception("Sorry, data nama tidak boleh kosong ...");
        else if (this.cboDepartemen.Text.Trim() == "")
          throw new Exception("Sorry, data departemen tidak boleh kosong ...");

        string kode = this.txtKodePegawai.Text.Trim();
        string nama = this.txtNamaPegawai.Text.Trim();
        string departemen = this.cboDepartemen.Text.Trim();

        string jenisKelamin = "";
        if (this.radPria.Checked)
          jenisKelamin = this.radPria.Text.Trim();
        else if (this.radWanita.Checked)
          jenisKelamin = this.radWanita.Text.Trim();
        if (jenisKelamin.Equals(""))
          throw new Exception("Sorry, data jenis kelamin tidak boleh kosong ...");

        string[] arrSource = null;

        if (File.Exists(filename))
          arrSource = File.ReadAllLines(filename);

        if (this.btnTambah.Text.Equals("tambah", StringComparison.CurrentCultureIgnoreCase))
        {

          // validasi - kode tidak boleh sama

          if (arrSource != null)
          {
            foreach (string itemSource in arrSource)
            {
              string kodeItem = itemSource.Split('|')[0].Trim();
              if (kodeItem.Equals(kode, StringComparison.CurrentCultureIgnoreCase))
                throw new Exception("Sorry, kode yang sama sudah terdaftar ...");
            }
          }

          using (var writer = new StreamWriter(filename, true))
          {
            writer.WriteLine($"{kode}|{nama}|{jenisKelamin}|{departemen}");
          }
        }
        else if (this.btnTambah.Text.Equals("update", StringComparison.CurrentCultureIgnoreCase))
        {

          // validasi
          for (int i = 0; i < arrSource.Length; i++)
          {
            if (i != indexItemData)
            {
              string kodeSource = arrSource[i].Split('|')[0].Trim();
              if (kodeSource.Equals(kode, StringComparison.CurrentCultureIgnoreCase))
                throw new Exception("Sorry, kode yang sama sudah terdaftar ...");
            }
          }

          using (var writer = new StreamWriter(filename))
          {
            for (int i = 0; i < arrSource.Length; i++)
            {
              string line = arrSource[i];

              if (i == indexItemData)
              {
                writer.WriteLine($"{kode}|{nama}|{jenisKelamin}|{departemen}");
              }
              else
              {
                writer.WriteLine(line);
              }
            }
          }
        }

        foreach (Control ctl in this.Controls)
        {
          if (ctl is TextBox t) t.Clear();
          if (ctl is RadioButton r) r.Checked = false;
          if (ctl is ComboBox c) c.Text = "";
        }

        this.txtKodePegawai.Focus();

        LoadData("all");

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void btnBatal_Click(object sender, EventArgs e)
    {
      foreach (Control ctl in this.Controls)
      {
        if (ctl is TextBox t) t.Clear();
        if (ctl is RadioButton r) r.Checked = false;
        if (ctl is ComboBox c) c.Text = "";
      }
      this.btnTambah.Text = "Tambah";
    }

    private void btnTampilSemua_Click(object sender, EventArgs e)
    {
      LoadData("all");
    }

    private void btnTampilPria_Click(object sender, EventArgs e)
    {
      LoadData("pria");
    }

    private void btnTampilWanita_Click(object sender, EventArgs e)
    {
      LoadData("wanita");
    }

    private void radPria_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton rad = sender as RadioButton;
      rad.Font = new Font(
        rad.Font.FontFamily.Name,
        rad.Font.Size,
        rad.Checked ? FontStyle.Bold : FontStyle.Regular);
    }

    private void txtKodePegawai_Enter(object sender, EventArgs e)
    {
      Control ctl = sender as Control;
      ctl.BackColor = Color.FromKnownColor(KnownColor.LightGreen);
    }

    private void txtKodePegawai_Leave(object sender, EventArgs e)
    {
      Control ctl = sender as Control;
      ctl.BackColor = Color.FromKnownColor(KnownColor.Window);
    }

    private void txtKodePegawai_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
    }

    int indexItemData = -1;

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.dgvData.CurrentRow != null)
      {
        // rule: kode boleh sekalian diedit
        if (MessageBox.Show("Edit item data baris terpilih ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          DataGridViewRow row = this.dgvData.CurrentRow;
          this.txtKodePegawai.Text = row.Cells[0].Value.ToString().Trim();
          this.txtNamaPegawai.Text = row.Cells[1].Value.ToString().Trim();
          if (row.Cells[2].Value.ToString().Trim().Equals("pria", StringComparison.CurrentCultureIgnoreCase))
            this.radPria.Checked = true;
          else
            this.radWanita.Checked = true;
          this.cboDepartemen.Text = row.Cells[3].Value.ToString().Trim();
          this.btnTambah.Text = "Update";
          indexItemData = row.Index;
        }
      }
    }

    private void hapusToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.dgvData.CurrentRow != null)
      {
        if (MessageBox.Show("Hapus item data baris terpilih ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          try
          {
            DataGridViewRow row = this.dgvData.CurrentRow;
            string kode = row.Cells[0].Value.ToString().Trim();
            string[] arrSource = File.ReadAllLines(filename);
            using (var writer = new StreamWriter(filename))
            {
              foreach (string line in arrSource)
              {
                string[] arrLine = line.Split('|');
                string kodeLine = arrLine[0].Trim();
                if (!kodeLine.Equals(kode, StringComparison.CurrentCultureIgnoreCase))
                {
                  writer.WriteLine(line);
                }
              }
            }
            LoadData("all");
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
      }
    }

  }
}
