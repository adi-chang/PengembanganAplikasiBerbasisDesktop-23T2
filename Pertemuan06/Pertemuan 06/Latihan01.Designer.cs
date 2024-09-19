namespace Pertemuan_06
{
  partial class Latihan01
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
      this.txtNama = new System.Windows.Forms.TextBox();
      this.lstDaftar = new System.Windows.Forms.ListBox();
      this.label2 = new System.Windows.Forms.Label();
      this.lblJumlahMahasiswa = new System.Windows.Forms.Label();
      this.btnEntry = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnClearAll = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nama Mahasiswa";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtNama
      // 
      this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNama.Location = new System.Drawing.Point(12, 42);
      this.txtNama.Name = "txtNama";
      this.txtNama.Size = new System.Drawing.Size(291, 20);
      this.txtNama.TabIndex = 0;
      // 
      // lstDaftar
      // 
      this.lstDaftar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lstDaftar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstDaftar.FormattingEnabled = true;
      this.lstDaftar.ItemHeight = 15;
      this.lstDaftar.Location = new System.Drawing.Point(12, 74);
      this.lstDaftar.Name = "lstDaftar";
      this.lstDaftar.Size = new System.Drawing.Size(291, 257);
      this.lstDaftar.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 350);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(145, 23);
      this.label2.TabIndex = 3;
      this.label2.Text = "Jumlah Mahasiswa";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblJumlahMahasiswa
      // 
      this.lblJumlahMahasiswa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblJumlahMahasiswa.Location = new System.Drawing.Point(182, 350);
      this.lblJumlahMahasiswa.Name = "lblJumlahMahasiswa";
      this.lblJumlahMahasiswa.Size = new System.Drawing.Size(121, 23);
      this.lblJumlahMahasiswa.TabIndex = 4;
      this.lblJumlahMahasiswa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnEntry
      // 
      this.btnEntry.Location = new System.Drawing.Point(309, 41);
      this.btnEntry.Name = "btnEntry";
      this.btnEntry.Size = new System.Drawing.Size(75, 23);
      this.btnEntry.TabIndex = 1;
      this.btnEntry.Text = "Entry";
      this.btnEntry.UseVisualStyleBackColor = true;
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(309, 74);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 2;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      // 
      // btnClearAll
      // 
      this.btnClearAll.Location = new System.Drawing.Point(309, 103);
      this.btnClearAll.Name = "btnClearAll";
      this.btnClearAll.Size = new System.Drawing.Size(75, 23);
      this.btnClearAll.TabIndex = 3;
      this.btnClearAll.Text = "Clear All";
      this.btnClearAll.UseVisualStyleBackColor = true;
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(309, 132);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 4;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // Latihan01
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(395, 383);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnClearAll);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnEntry);
      this.Controls.Add(this.lblJumlahMahasiswa);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lstDaftar);
      this.Controls.Add(this.txtNama);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Latihan01";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Daftar Mahasiswa";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNama;
    private System.Windows.Forms.ListBox lstDaftar;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblJumlahMahasiswa;
    private System.Windows.Forms.Button btnEntry;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnClearAll;
    private System.Windows.Forms.Button btnClose;
  }
}