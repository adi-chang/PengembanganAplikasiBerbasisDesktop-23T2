namespace Pertemuan_14_A
{
  partial class FrmDataMahasiswa
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.btnBatal = new System.Windows.Forms.Button();
      this.btnSimpan = new System.Windows.Forms.Button();
      this.btnHapus = new System.Windows.Forms.Button();
      this.lblKeterangan = new System.Windows.Forms.Label();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnTambah = new System.Windows.Forms.Button();
      this.cboWaktuKuliah = new System.Windows.Forms.ComboBox();
      this.cboJurusan = new System.Windows.Forms.ComboBox();
      this.cboJenisKelamin = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtNama = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNim = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnMoveLast = new System.Windows.Forms.Button();
      this.btnMoveNext = new System.Windows.Forms.Button();
      this.btnMovePrev = new System.Windows.Forms.Button();
      this.btnMoveFirst = new System.Windows.Forms.Button();
      this.dgvData = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.btnBatal);
      this.splitContainer1.Panel1.Controls.Add(this.btnSimpan);
      this.splitContainer1.Panel1.Controls.Add(this.btnHapus);
      this.splitContainer1.Panel1.Controls.Add(this.lblKeterangan);
      this.splitContainer1.Panel1.Controls.Add(this.btnUpdate);
      this.splitContainer1.Panel1.Controls.Add(this.btnEdit);
      this.splitContainer1.Panel1.Controls.Add(this.btnTambah);
      this.splitContainer1.Panel1.Controls.Add(this.cboWaktuKuliah);
      this.splitContainer1.Panel1.Controls.Add(this.cboJurusan);
      this.splitContainer1.Panel1.Controls.Add(this.cboJenisKelamin);
      this.splitContainer1.Panel1.Controls.Add(this.label5);
      this.splitContainer1.Panel1.Controls.Add(this.label4);
      this.splitContainer1.Panel1.Controls.Add(this.label3);
      this.splitContainer1.Panel1.Controls.Add(this.txtNama);
      this.splitContainer1.Panel1.Controls.Add(this.label2);
      this.splitContainer1.Panel1.Controls.Add(this.txtNim);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      this.splitContainer1.Panel1.Controls.Add(this.btnMoveLast);
      this.splitContainer1.Panel1.Controls.Add(this.btnMoveNext);
      this.splitContainer1.Panel1.Controls.Add(this.btnMovePrev);
      this.splitContainer1.Panel1.Controls.Add(this.btnMoveFirst);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.dgvData);
      this.splitContainer1.Size = new System.Drawing.Size(1264, 561);
      this.splitContainer1.SplitterDistance = 505;
      this.splitContainer1.TabIndex = 0;
      // 
      // btnBatal
      // 
      this.btnBatal.Location = new System.Drawing.Point(417, 252);
      this.btnBatal.Name = "btnBatal";
      this.btnBatal.Size = new System.Drawing.Size(75, 23);
      this.btnBatal.TabIndex = 20;
      this.btnBatal.Text = "&Batal";
      this.btnBatal.UseVisualStyleBackColor = true;
      this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
      // 
      // btnSimpan
      // 
      this.btnSimpan.Location = new System.Drawing.Point(96, 252);
      this.btnSimpan.Name = "btnSimpan";
      this.btnSimpan.Size = new System.Drawing.Size(75, 23);
      this.btnSimpan.TabIndex = 6;
      this.btnSimpan.Text = "&Simpan";
      this.btnSimpan.UseVisualStyleBackColor = true;
      this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
      // 
      // btnHapus
      // 
      this.btnHapus.Location = new System.Drawing.Point(336, 252);
      this.btnHapus.Name = "btnHapus";
      this.btnHapus.Size = new System.Drawing.Size(75, 23);
      this.btnHapus.TabIndex = 9;
      this.btnHapus.Text = "&Hapus";
      this.btnHapus.UseVisualStyleBackColor = true;
      this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
      // 
      // lblKeterangan
      // 
      this.lblKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblKeterangan.Location = new System.Drawing.Point(12, 206);
      this.lblKeterangan.Name = "lblKeterangan";
      this.lblKeterangan.Size = new System.Drawing.Size(246, 23);
      this.lblKeterangan.TabIndex = 19;
      this.lblKeterangan.Text = "{ keterangan }";
      this.lblKeterangan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnUpdate
      // 
      this.btnUpdate.Location = new System.Drawing.Point(258, 252);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(75, 23);
      this.btnUpdate.TabIndex = 8;
      this.btnUpdate.Text = "&Update";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Location = new System.Drawing.Point(177, 252);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(75, 23);
      this.btnEdit.TabIndex = 7;
      this.btnEdit.Text = "&Edit";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnTambah
      // 
      this.btnTambah.Location = new System.Drawing.Point(15, 252);
      this.btnTambah.Name = "btnTambah";
      this.btnTambah.Size = new System.Drawing.Size(75, 23);
      this.btnTambah.TabIndex = 5;
      this.btnTambah.Text = "&Tambah";
      this.btnTambah.UseVisualStyleBackColor = true;
      this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
      // 
      // cboWaktuKuliah
      // 
      this.cboWaktuKuliah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboWaktuKuliah.FormattingEnabled = true;
      this.cboWaktuKuliah.Items.AddRange(new object[] {
            "",
            "Pagi",
            "Sore"});
      this.cboWaktuKuliah.Location = new System.Drawing.Point(137, 165);
      this.cboWaktuKuliah.Name = "cboWaktuKuliah";
      this.cboWaktuKuliah.Size = new System.Drawing.Size(121, 21);
      this.cboWaktuKuliah.TabIndex = 4;
      this.cboWaktuKuliah.Enter += new System.EventHandler(this.txtNim_Enter);
      this.cboWaktuKuliah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
      this.cboWaktuKuliah.Leave += new System.EventHandler(this.txtNim_Leave);
      // 
      // cboJurusan
      // 
      this.cboJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboJurusan.FormattingEnabled = true;
      this.cboJurusan.Items.AddRange(new object[] {
            "",
            "IT",
            "IS"});
      this.cboJurusan.Location = new System.Drawing.Point(137, 139);
      this.cboJurusan.Name = "cboJurusan";
      this.cboJurusan.Size = new System.Drawing.Size(121, 21);
      this.cboJurusan.TabIndex = 3;
      this.cboJurusan.Enter += new System.EventHandler(this.txtNim_Enter);
      this.cboJurusan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
      this.cboJurusan.Leave += new System.EventHandler(this.txtNim_Leave);
      // 
      // cboJenisKelamin
      // 
      this.cboJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboJenisKelamin.FormattingEnabled = true;
      this.cboJenisKelamin.Items.AddRange(new object[] {
            "",
            "Pria",
            "Wanita"});
      this.cboJenisKelamin.Location = new System.Drawing.Point(137, 113);
      this.cboJenisKelamin.Name = "cboJenisKelamin";
      this.cboJenisKelamin.Size = new System.Drawing.Size(121, 21);
      this.cboJenisKelamin.TabIndex = 2;
      this.cboJenisKelamin.Enter += new System.EventHandler(this.txtNim_Enter);
      this.cboJenisKelamin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
      this.cboJenisKelamin.Leave += new System.EventHandler(this.txtNim_Leave);
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(12, 164);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(75, 23);
      this.label5.TabIndex = 12;
      this.label5.Text = "Waktu Kuliah";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(12, 138);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(75, 23);
      this.label4.TabIndex = 10;
      this.label4.Text = "Jurusan";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(12, 112);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(75, 23);
      this.label3.TabIndex = 8;
      this.label3.Text = "Jenis Kelamin";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtNama
      // 
      this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNama.Location = new System.Drawing.Point(137, 87);
      this.txtNama.Name = "txtNama";
      this.txtNama.Size = new System.Drawing.Size(292, 20);
      this.txtNama.TabIndex = 1;
      this.txtNama.Enter += new System.EventHandler(this.txtNim_Enter);
      this.txtNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
      this.txtNama.Leave += new System.EventHandler(this.txtNim_Leave);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 86);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(75, 23);
      this.label2.TabIndex = 6;
      this.label2.Text = "Nama";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtNim
      // 
      this.txtNim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNim.Location = new System.Drawing.Point(137, 61);
      this.txtNim.MaxLength = 10;
      this.txtNim.Name = "txtNim";
      this.txtNim.Size = new System.Drawing.Size(121, 20);
      this.txtNim.TabIndex = 0;
      this.txtNim.Enter += new System.EventHandler(this.txtNim_Enter);
      this.txtNim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
      this.txtNim.Leave += new System.EventHandler(this.txtNim_Leave);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 60);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(75, 23);
      this.label1.TabIndex = 4;
      this.label1.Text = "Nim";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnMoveLast
      // 
      this.btnMoveLast.Location = new System.Drawing.Point(255, 12);
      this.btnMoveLast.Name = "btnMoveLast";
      this.btnMoveLast.Size = new System.Drawing.Size(75, 23);
      this.btnMoveLast.TabIndex = 13;
      this.btnMoveLast.Text = ">|";
      this.btnMoveLast.UseVisualStyleBackColor = true;
      this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
      // 
      // btnMoveNext
      // 
      this.btnMoveNext.Location = new System.Drawing.Point(174, 12);
      this.btnMoveNext.Name = "btnMoveNext";
      this.btnMoveNext.Size = new System.Drawing.Size(75, 23);
      this.btnMoveNext.TabIndex = 12;
      this.btnMoveNext.Text = ">>";
      this.btnMoveNext.UseVisualStyleBackColor = true;
      this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
      // 
      // btnMovePrev
      // 
      this.btnMovePrev.Location = new System.Drawing.Point(93, 12);
      this.btnMovePrev.Name = "btnMovePrev";
      this.btnMovePrev.Size = new System.Drawing.Size(75, 23);
      this.btnMovePrev.TabIndex = 11;
      this.btnMovePrev.Text = "<<";
      this.btnMovePrev.UseVisualStyleBackColor = true;
      this.btnMovePrev.Click += new System.EventHandler(this.btnMovePrev_Click);
      // 
      // btnMoveFirst
      // 
      this.btnMoveFirst.Location = new System.Drawing.Point(12, 12);
      this.btnMoveFirst.Name = "btnMoveFirst";
      this.btnMoveFirst.Size = new System.Drawing.Size(75, 23);
      this.btnMoveFirst.TabIndex = 10;
      this.btnMoveFirst.Text = "|<";
      this.btnMoveFirst.UseVisualStyleBackColor = true;
      this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
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
            this.Column4,
            this.Column5});
      this.dgvData.Location = new System.Drawing.Point(3, 12);
      this.dgvData.Name = "dgvData";
      this.dgvData.ReadOnly = true;
      this.dgvData.Size = new System.Drawing.Size(740, 537);
      this.dgvData.TabIndex = 0;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Nim";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Nama";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 250;
      // 
      // Column3
      // 
      this.Column3.HeaderText = "Jenis Kelamin";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      // 
      // Column4
      // 
      this.Column4.HeaderText = "Jurusan";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      // 
      // Column5
      // 
      this.Column5.HeaderText = "Waktu Kuliah";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      // 
      // FrmDataMahasiswa
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1264, 561);
      this.Controls.Add(this.splitContainer1);
      this.KeyPreview = true;
      this.Name = "FrmDataMahasiswa";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Data Mahasiswa";
      this.Load += new System.EventHandler(this.FrmDataMahasiswa_Load);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.DataGridView dgvData;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtNama;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNim;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnMoveLast;
    private System.Windows.Forms.Button btnMoveNext;
    private System.Windows.Forms.Button btnMovePrev;
    private System.Windows.Forms.Button btnMoveFirst;
    private System.Windows.Forms.ComboBox cboWaktuKuliah;
    private System.Windows.Forms.ComboBox cboJurusan;
    private System.Windows.Forms.ComboBox cboJenisKelamin;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    private System.Windows.Forms.Label lblKeterangan;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnTambah;
    private System.Windows.Forms.Button btnHapus;
    private System.Windows.Forms.Button btnSimpan;
    private System.Windows.Forms.Button btnBatal;
  }
}