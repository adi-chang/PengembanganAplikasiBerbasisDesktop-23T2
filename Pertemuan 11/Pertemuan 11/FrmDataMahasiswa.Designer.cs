namespace Pertemuan_11
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
      this.grpKriteria = new System.Windows.Forms.GroupBox();
      this.lblCount = new System.Windows.Forms.Label();
      this.btnFilter = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.cboWaktuKuliah = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.cboJurusan = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.cboJenisKelamin = new System.Windows.Forms.ComboBox();
      this.txtNama = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNim = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dgvData = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblBanyakRecordData = new System.Windows.Forms.Label();
      this.btnTambah = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnHapus = new System.Windows.Forms.Button();
      this.grpKriteria.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
      this.SuspendLayout();
      // 
      // grpKriteria
      // 
      this.grpKriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpKriteria.Controls.Add(this.lblCount);
      this.grpKriteria.Controls.Add(this.btnFilter);
      this.grpKriteria.Controls.Add(this.label5);
      this.grpKriteria.Controls.Add(this.cboWaktuKuliah);
      this.grpKriteria.Controls.Add(this.label4);
      this.grpKriteria.Controls.Add(this.cboJurusan);
      this.grpKriteria.Controls.Add(this.label3);
      this.grpKriteria.Controls.Add(this.cboJenisKelamin);
      this.grpKriteria.Controls.Add(this.txtNama);
      this.grpKriteria.Controls.Add(this.label2);
      this.grpKriteria.Controls.Add(this.txtNim);
      this.grpKriteria.Controls.Add(this.label1);
      this.grpKriteria.Location = new System.Drawing.Point(12, 12);
      this.grpKriteria.Name = "grpKriteria";
      this.grpKriteria.Size = new System.Drawing.Size(984, 172);
      this.grpKriteria.TabIndex = 0;
      this.grpKriteria.TabStop = false;
      this.grpKriteria.Text = "Kriteria";
      // 
      // lblCount
      // 
      this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCount.Location = new System.Drawing.Point(218, 26);
      this.lblCount.Name = "lblCount";
      this.lblCount.Size = new System.Drawing.Size(64, 23);
      this.lblCount.TabIndex = 14;
      this.lblCount.Text = "{ count }";
      this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnFilter
      // 
      this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFilter.Location = new System.Drawing.Point(903, 27);
      this.btnFilter.Name = "btnFilter";
      this.btnFilter.Size = new System.Drawing.Size(75, 23);
      this.btnFilter.TabIndex = 5;
      this.btnFilter.Text = "&Filter";
      this.btnFilter.UseVisualStyleBackColor = true;
      this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(15, 135);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(71, 23);
      this.label5.TabIndex = 13;
      this.label5.Text = "Waktu Kuliah";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cboWaktuKuliah
      // 
      this.cboWaktuKuliah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboWaktuKuliah.FormattingEnabled = true;
      this.cboWaktuKuliah.Items.AddRange(new object[] {
            "",
            "Pagi",
            "Sore"});
      this.cboWaktuKuliah.Location = new System.Drawing.Point(92, 136);
      this.cboWaktuKuliah.Name = "cboWaktuKuliah";
      this.cboWaktuKuliah.Size = new System.Drawing.Size(121, 21);
      this.cboWaktuKuliah.TabIndex = 4;
      this.cboWaktuKuliah.Enter += new System.EventHandler(this.txtNim_Enter);
      this.cboWaktuKuliah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
      this.cboWaktuKuliah.Leave += new System.EventHandler(this.txtNim_Leave);
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(15, 108);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(71, 23);
      this.label4.TabIndex = 11;
      this.label4.Text = "Jurusan";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cboJurusan
      // 
      this.cboJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboJurusan.FormattingEnabled = true;
      this.cboJurusan.Items.AddRange(new object[] {
            "",
            "IT",
            "IS"});
      this.cboJurusan.Location = new System.Drawing.Point(92, 109);
      this.cboJurusan.Name = "cboJurusan";
      this.cboJurusan.Size = new System.Drawing.Size(121, 21);
      this.cboJurusan.TabIndex = 3;
      this.cboJurusan.Enter += new System.EventHandler(this.txtNim_Enter);
      this.cboJurusan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
      this.cboJurusan.Leave += new System.EventHandler(this.txtNim_Leave);
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(15, 81);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(71, 23);
      this.label3.TabIndex = 9;
      this.label3.Text = "Jenis Kelamin";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cboJenisKelamin
      // 
      this.cboJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboJenisKelamin.FormattingEnabled = true;
      this.cboJenisKelamin.Items.AddRange(new object[] {
            "",
            "Pria",
            "Wanita"});
      this.cboJenisKelamin.Location = new System.Drawing.Point(92, 82);
      this.cboJenisKelamin.Name = "cboJenisKelamin";
      this.cboJenisKelamin.Size = new System.Drawing.Size(121, 21);
      this.cboJenisKelamin.TabIndex = 2;
      this.cboJenisKelamin.Enter += new System.EventHandler(this.txtNim_Enter);
      this.cboJenisKelamin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
      this.cboJenisKelamin.Leave += new System.EventHandler(this.txtNim_Leave);
      // 
      // txtNama
      // 
      this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNama.Location = new System.Drawing.Point(92, 53);
      this.txtNama.MaxLength = 100;
      this.txtNama.MinimumSize = new System.Drawing.Size(100, 23);
      this.txtNama.Name = "txtNama";
      this.txtNama.Size = new System.Drawing.Size(500, 23);
      this.txtNama.TabIndex = 1;
      this.txtNama.Enter += new System.EventHandler(this.txtNim_Enter);
      this.txtNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
      this.txtNama.Leave += new System.EventHandler(this.txtNim_Leave);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(15, 53);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(71, 23);
      this.label2.TabIndex = 6;
      this.label2.Text = "Nama";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtNim
      // 
      this.txtNim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNim.Location = new System.Drawing.Point(92, 27);
      this.txtNim.MaxLength = 10;
      this.txtNim.MinimumSize = new System.Drawing.Size(100, 23);
      this.txtNim.Name = "txtNim";
      this.txtNim.Size = new System.Drawing.Size(120, 20);
      this.txtNim.TabIndex = 0;
      this.txtNim.TextChanged += new System.EventHandler(this.txtNim_TextChanged);
      this.txtNim.Enter += new System.EventHandler(this.txtNim_Enter);
      this.txtNim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
      this.txtNim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNim_KeyPress);
      this.txtNim.Leave += new System.EventHandler(this.txtNim_Leave);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(15, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(71, 23);
      this.label1.TabIndex = 4;
      this.label1.Text = "Nim";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Column5,
            this.Column6});
      this.dgvData.Location = new System.Drawing.Point(12, 222);
      this.dgvData.MultiSelect = false;
      this.dgvData.Name = "dgvData";
      this.dgvData.ReadOnly = true;
      this.dgvData.Size = new System.Drawing.Size(984, 327);
      this.dgvData.TabIndex = 1;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Nim";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Width = 150;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Nama";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 300;
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
      this.Column4.Visible = false;
      // 
      // Column5
      // 
      this.Column5.HeaderText = "Keterangan Jurusan";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column5.Width = 200;
      // 
      // Column6
      // 
      this.Column6.HeaderText = "Waktu Kuliah";
      this.Column6.Name = "Column6";
      this.Column6.ReadOnly = true;
      // 
      // lblBanyakRecordData
      // 
      this.lblBanyakRecordData.Location = new System.Drawing.Point(12, 196);
      this.lblBanyakRecordData.Name = "lblBanyakRecordData";
      this.lblBanyakRecordData.Size = new System.Drawing.Size(417, 23);
      this.lblBanyakRecordData.TabIndex = 14;
      this.lblBanyakRecordData.Text = "{ banyak baris data }";
      this.lblBanyakRecordData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnTambah
      // 
      this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnTambah.Location = new System.Drawing.Point(759, 193);
      this.btnTambah.Name = "btnTambah";
      this.btnTambah.Size = new System.Drawing.Size(75, 23);
      this.btnTambah.TabIndex = 15;
      this.btnTambah.Text = "&Tambah";
      this.btnTambah.UseVisualStyleBackColor = true;
      this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnEdit.Location = new System.Drawing.Point(840, 193);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(75, 23);
      this.btnEdit.TabIndex = 16;
      this.btnEdit.Text = "&Edit";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnHapus
      // 
      this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnHapus.Location = new System.Drawing.Point(921, 193);
      this.btnHapus.Name = "btnHapus";
      this.btnHapus.Size = new System.Drawing.Size(75, 23);
      this.btnHapus.TabIndex = 17;
      this.btnHapus.Text = "&Hapus";
      this.btnHapus.UseVisualStyleBackColor = true;
      this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
      // 
      // FrmDataMahasiswa
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1008, 561);
      this.Controls.Add(this.btnHapus);
      this.Controls.Add(this.btnEdit);
      this.Controls.Add(this.btnTambah);
      this.Controls.Add(this.lblBanyakRecordData);
      this.Controls.Add(this.dgvData);
      this.Controls.Add(this.grpKriteria);
      this.KeyPreview = true;
      this.Name = "FrmDataMahasiswa";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Data Mahasiswa";
      this.Load += new System.EventHandler(this.FrmPendaftaranMahasiswa_Load);
      this.Resize += new System.EventHandler(this.FrmDataMahasiswa_Resize);
      this.grpKriteria.ResumeLayout(false);
      this.grpKriteria.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox grpKriteria;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cboWaktuKuliah;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cboJurusan;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cboJenisKelamin;
    private System.Windows.Forms.TextBox txtNama;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNim;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnFilter;
    private System.Windows.Forms.DataGridView dgvData;
    private System.Windows.Forms.Label lblBanyakRecordData;
    private System.Windows.Forms.Label lblCount;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    private System.Windows.Forms.Button btnTambah;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnHapus;
  }
}

