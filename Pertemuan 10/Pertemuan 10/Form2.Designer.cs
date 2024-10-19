namespace Pertemuan_09
{
  partial class Form2
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnBatal = new System.Windows.Forms.Button();
      this.btnTampilWanita = new System.Windows.Forms.Button();
      this.btnTampilPria = new System.Windows.Forms.Button();
      this.btnTampilSemua = new System.Windows.Forms.Button();
      this.Departemen = new System.Windows.Forms.Label();
      this.radWanita = new System.Windows.Forms.RadioButton();
      this.label3 = new System.Windows.Forms.Label();
      this.txtNamaPegawai = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.radPria = new System.Windows.Forms.RadioButton();
      this.cboDepartemen = new System.Windows.Forms.ComboBox();
      this.txtKodePegawai = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnTambah = new System.Windows.Forms.Button();
      this.dgvData = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.hapusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnBatal
      // 
      this.btnBatal.Location = new System.Drawing.Point(437, 140);
      this.btnBatal.Name = "btnBatal";
      this.btnBatal.Size = new System.Drawing.Size(133, 23);
      this.btnBatal.TabIndex = 6;
      this.btnBatal.Text = "Batal";
      this.btnBatal.UseVisualStyleBackColor = true;
      this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
      // 
      // btnTampilWanita
      // 
      this.btnTampilWanita.Location = new System.Drawing.Point(298, 169);
      this.btnTampilWanita.Name = "btnTampilWanita";
      this.btnTampilWanita.Size = new System.Drawing.Size(133, 23);
      this.btnTampilWanita.TabIndex = 9;
      this.btnTampilWanita.Text = "Tampil Wanita";
      this.btnTampilWanita.UseVisualStyleBackColor = true;
      this.btnTampilWanita.Click += new System.EventHandler(this.btnTampilWanita_Click);
      // 
      // btnTampilPria
      // 
      this.btnTampilPria.Location = new System.Drawing.Point(155, 169);
      this.btnTampilPria.Name = "btnTampilPria";
      this.btnTampilPria.Size = new System.Drawing.Size(133, 23);
      this.btnTampilPria.TabIndex = 8;
      this.btnTampilPria.Text = "Tampil Pria";
      this.btnTampilPria.UseVisualStyleBackColor = true;
      this.btnTampilPria.Click += new System.EventHandler(this.btnTampilPria_Click);
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
      // Departemen
      // 
      this.Departemen.Location = new System.Drawing.Point(12, 104);
      this.Departemen.Name = "Departemen";
      this.Departemen.Size = new System.Drawing.Size(100, 23);
      this.Departemen.TabIndex = 24;
      this.Departemen.Text = "Departemen";
      this.Departemen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(12, 77);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 23);
      this.label3.TabIndex = 22;
      this.label3.Text = "Jenis Pegawai";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
      this.label2.TabIndex = 18;
      this.label2.Text = "Nama Pegawai";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 23);
      this.label1.TabIndex = 14;
      this.label1.Text = "Kode Pegawai";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnTambah
      // 
      this.btnTambah.Location = new System.Drawing.Point(12, 140);
      this.btnTambah.Name = "btnTambah";
      this.btnTambah.Size = new System.Drawing.Size(419, 23);
      this.btnTambah.TabIndex = 5;
      this.btnTambah.Text = "Tambah";
      this.btnTambah.UseVisualStyleBackColor = true;
      this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
      // 
      // dgvData
      // 
      this.dgvData.AllowUserToAddRows = false;
      this.dgvData.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
      this.dgvData.ContextMenuStrip = this.contextMenuStrip1;
      this.dgvData.Location = new System.Drawing.Point(12, 210);
      this.dgvData.MultiSelect = false;
      this.dgvData.Name = "dgvData";
      this.dgvData.ReadOnly = true;
      this.dgvData.Size = new System.Drawing.Size(558, 226);
      this.dgvData.TabIndex = 10;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Kode";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Width = 80;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Nama";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 150;
      // 
      // Column3
      // 
      this.Column3.HeaderText = "Jenis Kelamin";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      // 
      // Column4
      // 
      this.Column4.HeaderText = "Departemen";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Width = 150;
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
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(582, 448);
      this.Controls.Add(this.dgvData);
      this.Controls.Add(this.btnBatal);
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
      this.Name = "Form2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Daftar Pegawai";
      this.Load += new System.EventHandler(this.Form2_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnBatal;
    private System.Windows.Forms.Button btnTampilWanita;
    private System.Windows.Forms.Button btnTampilPria;
    private System.Windows.Forms.Button btnTampilSemua;
    private System.Windows.Forms.Label Departemen;
    private System.Windows.Forms.RadioButton radWanita;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtNamaPegawai;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RadioButton radPria;
    private System.Windows.Forms.ComboBox cboDepartemen;
    private System.Windows.Forms.TextBox txtKodePegawai;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnTambah;
    private System.Windows.Forms.DataGridView dgvData;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem hapusToolStripMenuItem;
  }
}