﻿using System;
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
  public partial class Form1 : Form
  {

    const string filename = "data.csv";

    public Form1()
    {
      InitializeComponent();
    }

    private void LoadData(string kriteria)
    {
      try
      {
        this.lstData.Items.Clear();
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
              this.lstData.Items.Add($"{kode,-10}|{nama,-20}|{jenisKelamin,-10}|{departemen}");
            }
            else
            {
              if (jenisKelamin.Equals(kriteria, StringComparison.CurrentCultureIgnoreCase))
              {
                this.lstData.Items.Add($"{kode,-10}|{nama,-20}|{jenisKelamin,-10}|{departemen}");
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

    private void Form1_Load(object sender, EventArgs e)
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
        else if(this.radWanita.Checked)
          jenisKelamin = this.radWanita.Text.Trim();
        if(jenisKelamin.Equals(""))
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
          using (var writer = new StreamWriter(filename))
          {
            foreach (string line in arrSource)
            {
              string[] arrLine = line.Split('|');
              string kodeLine = arrLine[0].Trim();
              if (kodeLine.Equals(kode, StringComparison.CurrentCultureIgnoreCase))
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
      this.txtKodePegawai.Enabled = true;
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

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.lstData.SelectedIndex >= 0)
      {
        // rule: kode tidak bisa diedit lagi
        if (MessageBox.Show("Edit item data baris terpilih ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          string line = this.lstData.SelectedItem.ToString();
          string[] arr = line.Split('|');
          this.txtKodePegawai.Text = arr[0].Trim();
          this.txtNamaPegawai.Text = arr[1].Trim();
          if (arr[2].Trim().Equals("pria", StringComparison.CurrentCultureIgnoreCase))
            this.radPria.Checked = true;
          else
            this.radWanita.Checked = true;
          this.cboDepartemen.Text = arr[3].Trim();
          this.txtKodePegawai.Enabled = false;
          this.btnTambah.Text = "Update";
        }
      }
    }

    private void hapusToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.lstData.SelectedIndex >= 0)
      {
        if (MessageBox.Show("Hapus item data baris terpilih ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          try
          {
            string selected = this.lstData.SelectedItem.ToString();
            string[] arr = selected.Split('|');
            string kode  = arr[0].Trim();
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
