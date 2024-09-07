namespace Pertemuan04
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
      this.txtPotongan = new System.Windows.Forms.TextBox();
      this.txtJumlahUnit = new System.Windows.Forms.TextBox();
      this.txtHargaBeli = new System.Windows.Forms.TextBox();
      this.lblNilaiPotongan = new System.Windows.Forms.Label();
      this.lblKeterangan = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtPotongan
      // 
      this.txtPotongan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtPotongan.Location = new System.Drawing.Point(152, 69);
      this.txtPotongan.Name = "txtPotongan";
      this.txtPotongan.Size = new System.Drawing.Size(73, 20);
      this.txtPotongan.TabIndex = 10;
      this.txtPotongan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtPotongan.TextChanged += new System.EventHandler(this.txtHargaBeli_TextChanged);
      this.txtPotongan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHargaBeli_KeyDown);
      this.txtPotongan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaBeli_KeyPress);
      // 
      // txtJumlahUnit
      // 
      this.txtJumlahUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtJumlahUnit.Location = new System.Drawing.Point(152, 43);
      this.txtJumlahUnit.Name = "txtJumlahUnit";
      this.txtJumlahUnit.Size = new System.Drawing.Size(121, 20);
      this.txtJumlahUnit.TabIndex = 8;
      this.txtJumlahUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtJumlahUnit.TextChanged += new System.EventHandler(this.txtHargaBeli_TextChanged);
      this.txtJumlahUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHargaBeli_KeyDown);
      this.txtJumlahUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaBeli_KeyPress);
      // 
      // txtHargaBeli
      // 
      this.txtHargaBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtHargaBeli.Location = new System.Drawing.Point(152, 17);
      this.txtHargaBeli.Name = "txtHargaBeli";
      this.txtHargaBeli.Size = new System.Drawing.Size(121, 20);
      this.txtHargaBeli.TabIndex = 6;
      this.txtHargaBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtHargaBeli.TextChanged += new System.EventHandler(this.txtHargaBeli_TextChanged);
      this.txtHargaBeli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHargaBeli_KeyDown);
      this.txtHargaBeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaBeli_KeyPress);
      // 
      // lblNilaiPotongan
      // 
      this.lblNilaiPotongan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblNilaiPotongan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNilaiPotongan.Location = new System.Drawing.Point(231, 68);
      this.lblNilaiPotongan.Name = "lblNilaiPotongan";
      this.lblNilaiPotongan.Size = new System.Drawing.Size(151, 23);
      this.lblNilaiPotongan.TabIndex = 15;
      this.lblNilaiPotongan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblKeterangan
      // 
      this.lblKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblKeterangan.Location = new System.Drawing.Point(15, 121);
      this.lblKeterangan.Name = "lblKeterangan";
      this.lblKeterangan.Size = new System.Drawing.Size(430, 23);
      this.lblKeterangan.TabIndex = 14;
      this.lblKeterangan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(12, 98);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(134, 23);
      this.label4.TabIndex = 13;
      this.label4.Text = "Keterangan";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(12, 66);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(134, 23);
      this.label3.TabIndex = 11;
      this.label3.Text = "Potongan (%)";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(134, 23);
      this.label2.TabIndex = 9;
      this.label2.Text = "Jumlah Unit";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(134, 23);
      this.label1.TabIndex = 7;
      this.label1.Text = "Harga Beli / Unit (Rp)";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(457, 155);
      this.Controls.Add(this.txtPotongan);
      this.Controls.Add(this.txtJumlahUnit);
      this.Controls.Add(this.txtHargaBeli);
      this.Controls.Add(this.lblNilaiPotongan);
      this.Controls.Add(this.lblKeterangan);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Pembelian v2";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtPotongan;
    private System.Windows.Forms.TextBox txtJumlahUnit;
    private System.Windows.Forms.TextBox txtHargaBeli;
    private System.Windows.Forms.Label lblNilaiPotongan;
    private System.Windows.Forms.Label lblKeterangan;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
  }
}