namespace Pertemuan_06
{
  partial class Latihan02
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
      this.btnTambah = new System.Windows.Forms.Button();
      this.txtInput = new System.Windows.Forms.TextBox();
      this.cboKata = new System.Windows.Forms.ComboBox();
      this.btnHapus = new System.Windows.Forms.Button();
      this.btnHapusSemua = new System.Windows.Forms.Button();
      this.btnKeluar = new System.Windows.Forms.Button();
      this.lblKata = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnTambah
      // 
      this.btnTambah.Location = new System.Drawing.Point(228, 15);
      this.btnTambah.Name = "btnTambah";
      this.btnTambah.Size = new System.Drawing.Size(75, 23);
      this.btnTambah.TabIndex = 1;
      this.btnTambah.Text = "&Tambah";
      this.btnTambah.UseVisualStyleBackColor = true;
      // 
      // txtInput
      // 
      this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtInput.Location = new System.Drawing.Point(12, 16);
      this.txtInput.Name = "txtInput";
      this.txtInput.Size = new System.Drawing.Size(210, 20);
      this.txtInput.TabIndex = 0;
      // 
      // cboKata
      // 
      this.cboKata.FormattingEnabled = true;
      this.cboKata.Location = new System.Drawing.Point(12, 55);
      this.cboKata.Name = "cboKata";
      this.cboKata.Size = new System.Drawing.Size(291, 21);
      this.cboKata.TabIndex = 2;
      // 
      // btnHapus
      // 
      this.btnHapus.Location = new System.Drawing.Point(12, 91);
      this.btnHapus.Name = "btnHapus";
      this.btnHapus.Size = new System.Drawing.Size(87, 23);
      this.btnHapus.TabIndex = 3;
      this.btnHapus.Text = "&Hapus";
      this.btnHapus.UseVisualStyleBackColor = true;
      // 
      // btnHapusSemua
      // 
      this.btnHapusSemua.Location = new System.Drawing.Point(105, 91);
      this.btnHapusSemua.Name = "btnHapusSemua";
      this.btnHapusSemua.Size = new System.Drawing.Size(105, 23);
      this.btnHapusSemua.TabIndex = 4;
      this.btnHapusSemua.Text = "Hapus &Semua";
      this.btnHapusSemua.UseVisualStyleBackColor = true;
      // 
      // btnKeluar
      // 
      this.btnKeluar.Location = new System.Drawing.Point(216, 91);
      this.btnKeluar.Name = "btnKeluar";
      this.btnKeluar.Size = new System.Drawing.Size(87, 23);
      this.btnKeluar.TabIndex = 5;
      this.btnKeluar.Text = "&Keluar";
      this.btnKeluar.UseVisualStyleBackColor = true;
      // 
      // lblKata
      // 
      this.lblKata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblKata.Location = new System.Drawing.Point(12, 128);
      this.lblKata.Name = "lblKata";
      this.lblKata.Size = new System.Drawing.Size(291, 23);
      this.lblKata.TabIndex = 6;
      this.lblKata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Latihan02
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(314, 163);
      this.Controls.Add(this.lblKata);
      this.Controls.Add(this.btnKeluar);
      this.Controls.Add(this.btnHapusSemua);
      this.Controls.Add(this.btnHapus);
      this.Controls.Add(this.cboKata);
      this.Controls.Add(this.btnTambah);
      this.Controls.Add(this.txtInput);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Latihan02";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Input Kata";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnTambah;
    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.ComboBox cboKata;
    private System.Windows.Forms.Button btnHapus;
    private System.Windows.Forms.Button btnHapusSemua;
    private System.Windows.Forms.Button btnKeluar;
    private System.Windows.Forms.Label lblKata;
  }
}