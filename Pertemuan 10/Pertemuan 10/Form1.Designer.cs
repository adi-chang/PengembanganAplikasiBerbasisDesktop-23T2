﻿namespace Pertemuan_09
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.btnTambah = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtKodePegawai = new System.Windows.Forms.TextBox();
      this.cboDepartemen = new System.Windows.Forms.ComboBox();
      this.radPria = new System.Windows.Forms.RadioButton();
      this.txtNamaPegawai = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.radWanita = new System.Windows.Forms.RadioButton();
      this.Departemen = new System.Windows.Forms.Label();
      this.btnTampilSemua = new System.Windows.Forms.Button();
      this.btnTampilPria = new System.Windows.Forms.Button();
      this.btnTampilWanita = new System.Windows.Forms.Button();
      this.lstData = new System.Windows.Forms.ListBox();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.hapusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.btnBatal = new System.Windows.Forms.Button();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnTambah
      // 
      this.btnTambah.Location = new System.Drawing.Point(12, 140);
      this.btnTambah.Name = "btnTambah";
      this.btnTambah.Size = new System.Drawing.Size(286, 23);
      this.btnTambah.TabIndex = 5;
      this.btnTambah.Text = "Tambah";
      this.btnTambah.UseVisualStyleBackColor = true;
      this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 23);
      this.label1.TabIndex = 1;
      this.label1.Text = "Kode Pegawai";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtKodePegawai
      // 
      this.txtKodePegawai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtKodePegawai.Location = new System.Drawing.Point(118, 16);
      this.txtKodePegawai.MinimumSize = new System.Drawing.Size(100, 23);
      this.txtKodePegawai.Name = "txtKodePegawai";
      this.txtKodePegawai.Size = new System.Drawing.Size(338, 20);
      this.txtKodePegawai.TabIndex = 0;
      this.txtKodePegawai.Enter += new System.EventHandler(this.txtKodePegawai_Enter);
      this.txtKodePegawai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKodePegawai_KeyDown);
      this.txtKodePegawai.Leave += new System.EventHandler(this.txtKodePegawai_Leave);
      // 
      // cboDepartemen
      // 
      this.cboDepartemen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboDepartemen.FormattingEnabled = true;
      this.cboDepartemen.Items.AddRange(new object[] {
            "",
            "Gudang",
            "Keuangan",
            "HRD",
            "Pembelian",
            "Penjualan"});
      this.cboDepartemen.Location = new System.Drawing.Point(118, 105);
      this.cboDepartemen.Name = "cboDepartemen";
      this.cboDepartemen.Size = new System.Drawing.Size(338, 21);
      this.cboDepartemen.TabIndex = 4;
      this.cboDepartemen.Enter += new System.EventHandler(this.txtKodePegawai_Enter);
      this.cboDepartemen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKodePegawai_KeyDown);
      this.cboDepartemen.Leave += new System.EventHandler(this.txtKodePegawai_Leave);
      // 
      // radPria
      // 
      this.radPria.AutoSize = true;
      this.radPria.Location = new System.Drawing.Point(118, 80);
      this.radPria.Name = "radPria";
      this.radPria.Size = new System.Drawing.Size(43, 17);
      this.radPria.TabIndex = 2;
      this.radPria.TabStop = true;
      this.radPria.Text = "Pria";
      this.radPria.UseVisualStyleBackColor = true;
      this.radPria.CheckedChanged += new System.EventHandler(this.radPria_CheckedChanged);
      // 
      // txtNamaPegawai
      // 
      this.txtNamaPegawai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNamaPegawai.Location = new System.Drawing.Point(118, 45);
      this.txtNamaPegawai.MinimumSize = new System.Drawing.Size(100, 23);
      this.txtNamaPegawai.Name = "txtNamaPegawai";
      this.txtNamaPegawai.Size = new System.Drawing.Size(338, 20);
      this.txtNamaPegawai.TabIndex = 1;
      this.txtNamaPegawai.Enter += new System.EventHandler(this.txtKodePegawai_Enter);
      this.txtNamaPegawai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKodePegawai_KeyDown);
      this.txtNamaPegawai.Leave += new System.EventHandler(this.txtKodePegawai_Leave);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 45);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 23);
      this.label2.TabIndex = 5;
      this.label2.Text = "Nama Pegawai";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(12, 77);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 23);
      this.label3.TabIndex = 7;
      this.label3.Text = "Jenis Pegawai";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // radWanita
      // 
      this.radWanita.AutoSize = true;
      this.radWanita.Location = new System.Drawing.Point(235, 80);
      this.radWanita.Name = "radWanita";
      this.radWanita.Size = new System.Drawing.Size(59, 17);
      this.radWanita.TabIndex = 3;
      this.radWanita.TabStop = true;
      this.radWanita.Text = "Wanita";
      this.radWanita.UseVisualStyleBackColor = true;
      this.radWanita.CheckedChanged += new System.EventHandler(this.radPria_CheckedChanged);
      // 
      // Departemen
      // 
      this.Departemen.Location = new System.Drawing.Point(12, 104);
      this.Departemen.Name = "Departemen";
      this.Departemen.Size = new System.Drawing.Size(100, 23);
      this.Departemen.TabIndex = 9;
      this.Departemen.Text = "Departemen";
      this.Departemen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnTampilSemua
      // 
      this.btnTampilSemua.Location = new System.Drawing.Point(12, 169);
      this.btnTampilSemua.Name = "btnTampilSemua";
      this.btnTampilSemua.Size = new System.Drawing.Size(133, 23);
      this.btnTampilSemua.TabIndex = 7;
      this.btnTampilSemua.Text = "Tampil Semua";
      this.btnTampilSemua.UseVisualStyleBackColor = true;
      this.btnTampilSemua.Click += new System.EventHandler(this.btnTampilSemua_Click);
      // 
      // btnTampilPria
      // 
      this.btnTampilPria.Location = new System.Drawing.Point(165, 169);
      this.btnTampilPria.Name = "btnTampilPria";
      this.btnTampilPria.Size = new System.Drawing.Size(133, 23);
      this.btnTampilPria.TabIndex = 8;
      this.btnTampilPria.Text = "Tampil Pria";
      this.btnTampilPria.UseVisualStyleBackColor = true;
      this.btnTampilPria.Click += new System.EventHandler(this.btnTampilPria_Click);
      // 
      // btnTampilWanita
      // 
      this.btnTampilWanita.Location = new System.Drawing.Point(323, 169);
      this.btnTampilWanita.Name = "btnTampilWanita";
      this.btnTampilWanita.Size = new System.Drawing.Size(133, 23);
      this.btnTampilWanita.TabIndex = 9;
      this.btnTampilWanita.Text = "Tampil Wanita";
      this.btnTampilWanita.UseVisualStyleBackColor = true;
      this.btnTampilWanita.Click += new System.EventHandler(this.btnTampilWanita_Click);
      // 
      // lstData
      // 
      this.lstData.ContextMenuStrip = this.contextMenuStrip1;
      this.lstData.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstData.FormattingEnabled = true;
      this.lstData.ItemHeight = 15;
      this.lstData.Location = new System.Drawing.Point(12, 212);
      this.lstData.Name = "lstData";
      this.lstData.Size = new System.Drawing.Size(444, 229);
      this.lstData.TabIndex = 10;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.toolStripMenuItem1,
            this.hapusToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(109, 54);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
      this.editToolStripMenuItem.Text = "Edit";
      this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(105, 6);
      // 
      // hapusToolStripMenuItem
      // 
      this.hapusToolStripMenuItem.Name = "hapusToolStripMenuItem";
      this.hapusToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
      this.hapusToolStripMenuItem.Text = "Hapus";
      this.hapusToolStripMenuItem.Click += new System.EventHandler(this.hapusToolStripMenuItem_Click);
      // 
      // btnBatal
      // 
      this.btnBatal.Location = new System.Drawing.Point(323, 140);
      this.btnBatal.Name = "btnBatal";
      this.btnBatal.Size = new System.Drawing.Size(133, 23);
      this.btnBatal.TabIndex = 6;
      this.btnBatal.Text = "Batal";
      this.btnBatal.UseVisualStyleBackColor = true;
      this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(468, 447);
      this.Controls.Add(this.btnBatal);
      this.Controls.Add(this.lstData);
      this.Controls.Add(this.btnTampilWanita);
      this.Controls.Add(this.btnTampilPria);
      this.Controls.Add(this.btnTampilSemua);
      this.Controls.Add(this.Departemen);
      this.Controls.Add(this.radWanita);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtNamaPegawai);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.radPria);
      this.Controls.Add(this.cboDepartemen);
      this.Controls.Add(this.txtKodePegawai);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnTambah);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Daftar Pegawai";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnTambah;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtKodePegawai;
    private System.Windows.Forms.ComboBox cboDepartemen;
    private System.Windows.Forms.RadioButton radPria;
    private System.Windows.Forms.TextBox txtNamaPegawai;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RadioButton radWanita;
    private System.Windows.Forms.Label Departemen;
    private System.Windows.Forms.Button btnTampilSemua;
    private System.Windows.Forms.Button btnTampilPria;
    private System.Windows.Forms.Button btnTampilWanita;
    private System.Windows.Forms.ListBox lstData;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem hapusToolStripMenuItem;
    private System.Windows.Forms.Button btnBatal;
  }
}

