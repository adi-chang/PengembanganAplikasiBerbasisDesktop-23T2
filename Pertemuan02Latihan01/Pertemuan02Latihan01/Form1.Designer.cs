namespace Pertemuan02Latihan01
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtInput = new System.Windows.Forms.TextBox();
      this.btnValidasi = new System.Windows.Forms.Button();
      this.btnMasuk = new System.Windows.Forms.Button();
      this.btnKeluar = new System.Windows.Forms.Button();
      this.lblKeterangan = new System.Windows.Forms.Label();
      this.lblCount = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(304, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "Masukkan Password Anda ? ";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtInput
      // 
      this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtInput.Location = new System.Drawing.Point(12, 42);
      this.txtInput.Name = "txtInput";
      this.txtInput.PasswordChar = '*';
      this.txtInput.Size = new System.Drawing.Size(304, 20);
      this.txtInput.TabIndex = 0;
      this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
      this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
      this.txtInput.Leave += new System.EventHandler(this.txtInput_Leave);
      // 
      // btnValidasi
      // 
      this.btnValidasi.Location = new System.Drawing.Point(11, 68);
      this.btnValidasi.Name = "btnValidasi";
      this.btnValidasi.Size = new System.Drawing.Size(75, 23);
      this.btnValidasi.TabIndex = 1;
      this.btnValidasi.Text = "&Validasi";
      this.btnValidasi.UseVisualStyleBackColor = true;
      this.btnValidasi.Click += new System.EventHandler(this.btnValidasi_Click);
      // 
      // btnMasuk
      // 
      this.btnMasuk.Location = new System.Drawing.Point(126, 68);
      this.btnMasuk.Name = "btnMasuk";
      this.btnMasuk.Size = new System.Drawing.Size(75, 23);
      this.btnMasuk.TabIndex = 2;
      this.btnMasuk.Text = "&Masuk";
      this.btnMasuk.UseVisualStyleBackColor = true;
      this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
      // 
      // btnKeluar
      // 
      this.btnKeluar.Location = new System.Drawing.Point(240, 68);
      this.btnKeluar.Name = "btnKeluar";
      this.btnKeluar.Size = new System.Drawing.Size(75, 23);
      this.btnKeluar.TabIndex = 3;
      this.btnKeluar.Text = "&Keluar";
      this.btnKeluar.UseVisualStyleBackColor = true;
      this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
      // 
      // lblKeterangan
      // 
      this.lblKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblKeterangan.Location = new System.Drawing.Point(11, 106);
      this.lblKeterangan.Name = "lblKeterangan";
      this.lblKeterangan.Size = new System.Drawing.Size(304, 23);
      this.lblKeterangan.TabIndex = 5;
      this.lblKeterangan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblCount
      // 
      this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCount.Location = new System.Drawing.Point(240, 16);
      this.lblCount.Name = "lblCount";
      this.lblCount.Size = new System.Drawing.Size(76, 23);
      this.lblCount.TabIndex = 6;
      this.lblCount.Text = "{ count }";
      this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(328, 139);
      this.Controls.Add(this.lblCount);
      this.Controls.Add(this.lblKeterangan);
      this.Controls.Add(this.btnKeluar);
      this.Controls.Add(this.btnMasuk);
      this.Controls.Add(this.btnValidasi);
      this.Controls.Add(this.txtInput);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Validasi Password";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.Button btnValidasi;
    private System.Windows.Forms.Button btnMasuk;
    private System.Windows.Forms.Button btnKeluar;
    private System.Windows.Forms.Label lblKeterangan;
    private System.Windows.Forms.Label lblCount;
  }
}

