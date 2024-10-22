namespace Pertemuan_11
{
  partial class FrmTambahDataMahasiswa
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtNim = new System.Windows.Forms.TextBox();
      this.txtNama = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.grpJenisKelamin = new System.Windows.Forms.GroupBox();
      this.radWanita = new System.Windows.Forms.RadioButton();
      this.radPria = new System.Windows.Forms.RadioButton();
      this.grpWaktuKuliah = new System.Windows.Forms.GroupBox();
      this.radSore = new System.Windows.Forms.RadioButton();
      this.radPagi = new System.Windows.Forms.RadioButton();
      this.grpJurusan = new System.Windows.Forms.GroupBox();
      this.radIS = new System.Windows.Forms.RadioButton();
      this.radIT = new System.Windows.Forms.RadioButton();
      this.btnSimpan = new System.Windows.Forms.Button();
      this.lblCount = new System.Windows.Forms.Label();
      this.grpJenisKelamin.SuspendLayout();
      this.grpWaktuKuliah.SuspendLayout();
      this.grpJurusan.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(71, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nim";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtNim
      // 
      this.txtNim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNim.Location = new System.Drawing.Point(91, 16);
      this.txtNim.MaxLength = 10;
      this.txtNim.MinimumSize = new System.Drawing.Size(100, 23);
      this.txtNim.Name = "txtNim";
      this.txtNim.Size = new System.Drawing.Size(120, 23);
      this.txtNim.TabIndex = 0;
      this.txtNim.TextChanged += new System.EventHandler(this.txtNim_TextChanged);
      this.txtNim.Enter += new System.EventHandler(this.txtNim_Enter);
      this.txtNim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
      this.txtNim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNim_KeyPress);
      this.txtNim.Leave += new System.EventHandler(this.txtNim_Leave);
      // 
      // txtNama
      // 
      this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNama.Location = new System.Drawing.Point(91, 45);
      this.txtNama.MaxLength = 100;
      this.txtNama.MinimumSize = new System.Drawing.Size(100, 23);
      this.txtNama.Name = "txtNama";
      this.txtNama.Size = new System.Drawing.Size(325, 23);
      this.txtNama.TabIndex = 1;
      this.txtNama.Enter += new System.EventHandler(this.txtNim_Enter);
      this.txtNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
      this.txtNama.Leave += new System.EventHandler(this.txtNim_Leave);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 45);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(71, 23);
      this.label2.TabIndex = 2;
      this.label2.Text = "Nama";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // grpJenisKelamin
      // 
      this.grpJenisKelamin.Controls.Add(this.radWanita);
      this.grpJenisKelamin.Controls.Add(this.radPria);
      this.grpJenisKelamin.Location = new System.Drawing.Point(17, 86);
      this.grpJenisKelamin.Name = "grpJenisKelamin";
      this.grpJenisKelamin.Size = new System.Drawing.Size(129, 79);
      this.grpJenisKelamin.TabIndex = 2;
      this.grpJenisKelamin.TabStop = false;
      this.grpJenisKelamin.Text = "Jenis Kelamin";
      // 
      // radWanita
      // 
      this.radWanita.AutoSize = true;
      this.radWanita.Location = new System.Drawing.Point(19, 49);
      this.radWanita.Name = "radWanita";
      this.radWanita.Size = new System.Drawing.Size(59, 17);
      this.radWanita.TabIndex = 1;
      this.radWanita.TabStop = true;
      this.radWanita.Text = "Wanita";
      this.radWanita.UseVisualStyleBackColor = true;
      this.radWanita.CheckedChanged += new System.EventHandler(this.radPria_CheckedChanged);
      // 
      // radPria
      // 
      this.radPria.AutoSize = true;
      this.radPria.Location = new System.Drawing.Point(19, 26);
      this.radPria.Name = "radPria";
      this.radPria.Size = new System.Drawing.Size(43, 17);
      this.radPria.TabIndex = 0;
      this.radPria.TabStop = true;
      this.radPria.Text = "Pria";
      this.radPria.UseVisualStyleBackColor = true;
      this.radPria.CheckedChanged += new System.EventHandler(this.radPria_CheckedChanged);
      // 
      // grpWaktuKuliah
      // 
      this.grpWaktuKuliah.Controls.Add(this.radSore);
      this.grpWaktuKuliah.Controls.Add(this.radPagi);
      this.grpWaktuKuliah.Location = new System.Drawing.Point(287, 86);
      this.grpWaktuKuliah.Name = "grpWaktuKuliah";
      this.grpWaktuKuliah.Size = new System.Drawing.Size(129, 79);
      this.grpWaktuKuliah.TabIndex = 4;
      this.grpWaktuKuliah.TabStop = false;
      this.grpWaktuKuliah.Text = "Waktu Kuliah";
      // 
      // radSore
      // 
      this.radSore.AutoSize = true;
      this.radSore.Location = new System.Drawing.Point(19, 49);
      this.radSore.Name = "radSore";
      this.radSore.Size = new System.Drawing.Size(47, 17);
      this.radSore.TabIndex = 1;
      this.radSore.TabStop = true;
      this.radSore.Text = "Sore";
      this.radSore.UseVisualStyleBackColor = true;
      this.radSore.CheckedChanged += new System.EventHandler(this.radPria_CheckedChanged);
      // 
      // radPagi
      // 
      this.radPagi.AutoSize = true;
      this.radPagi.Location = new System.Drawing.Point(19, 26);
      this.radPagi.Name = "radPagi";
      this.radPagi.Size = new System.Drawing.Size(46, 17);
      this.radPagi.TabIndex = 0;
      this.radPagi.TabStop = true;
      this.radPagi.Text = "Pagi";
      this.radPagi.UseVisualStyleBackColor = true;
      this.radPagi.CheckedChanged += new System.EventHandler(this.radPria_CheckedChanged);
      // 
      // grpJurusan
      // 
      this.grpJurusan.Controls.Add(this.radIS);
      this.grpJurusan.Controls.Add(this.radIT);
      this.grpJurusan.Location = new System.Drawing.Point(152, 86);
      this.grpJurusan.Name = "grpJurusan";
      this.grpJurusan.Size = new System.Drawing.Size(129, 79);
      this.grpJurusan.TabIndex = 3;
      this.grpJurusan.TabStop = false;
      this.grpJurusan.Text = "Jurusan";
      // 
      // radIS
      // 
      this.radIS.AutoSize = true;
      this.radIS.Location = new System.Drawing.Point(19, 49);
      this.radIS.Name = "radIS";
      this.radIS.Size = new System.Drawing.Size(35, 17);
      this.radIS.TabIndex = 1;
      this.radIS.TabStop = true;
      this.radIS.Text = "IS";
      this.radIS.UseVisualStyleBackColor = true;
      this.radIS.CheckedChanged += new System.EventHandler(this.radPria_CheckedChanged);
      // 
      // radIT
      // 
      this.radIT.AutoSize = true;
      this.radIT.Location = new System.Drawing.Point(19, 26);
      this.radIT.Name = "radIT";
      this.radIT.Size = new System.Drawing.Size(35, 17);
      this.radIT.TabIndex = 0;
      this.radIT.TabStop = true;
      this.radIT.Text = "IT";
      this.radIT.UseVisualStyleBackColor = true;
      this.radIT.CheckedChanged += new System.EventHandler(this.radPria_CheckedChanged);
      // 
      // btnSimpan
      // 
      this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSimpan.Location = new System.Drawing.Point(341, 188);
      this.btnSimpan.Name = "btnSimpan";
      this.btnSimpan.Size = new System.Drawing.Size(75, 23);
      this.btnSimpan.TabIndex = 5;
      this.btnSimpan.Text = "&Simpan";
      this.btnSimpan.UseVisualStyleBackColor = true;
      this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
      // 
      // lblCount
      // 
      this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCount.Location = new System.Drawing.Point(217, 16);
      this.lblCount.Name = "lblCount";
      this.lblCount.Size = new System.Drawing.Size(64, 23);
      this.lblCount.TabIndex = 10;
      this.lblCount.Text = "{ count }";
      this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // FrmTambahDataMahasiswa
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(428, 223);
      this.Controls.Add(this.lblCount);
      this.Controls.Add(this.btnSimpan);
      this.Controls.Add(this.grpJurusan);
      this.Controls.Add(this.grpWaktuKuliah);
      this.Controls.Add(this.grpJenisKelamin);
      this.Controls.Add(this.txtNama);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtNim);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmTambahDataMahasiswa";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Tambah Data Mahasiswa";
      this.Load += new System.EventHandler(this.FrmTambahPendaftaranMahasiswa_Load);
      this.grpJenisKelamin.ResumeLayout(false);
      this.grpJenisKelamin.PerformLayout();
      this.grpWaktuKuliah.ResumeLayout(false);
      this.grpWaktuKuliah.PerformLayout();
      this.grpJurusan.ResumeLayout(false);
      this.grpJurusan.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNim;
    private System.Windows.Forms.TextBox txtNama;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox grpJenisKelamin;
    private System.Windows.Forms.RadioButton radWanita;
    private System.Windows.Forms.RadioButton radPria;
    private System.Windows.Forms.GroupBox grpWaktuKuliah;
    private System.Windows.Forms.RadioButton radSore;
    private System.Windows.Forms.RadioButton radPagi;
    private System.Windows.Forms.GroupBox grpJurusan;
    private System.Windows.Forms.RadioButton radIS;
    private System.Windows.Forms.RadioButton radIT;
    private System.Windows.Forms.Button btnSimpan;
    private System.Windows.Forms.Label lblCount;
  }
}