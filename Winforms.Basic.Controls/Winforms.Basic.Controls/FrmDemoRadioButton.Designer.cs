namespace Winforms.Basic.Controls
{
  partial class FrmDemoRadioButton
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
      this.grpMakanan = new System.Windows.Forms.GroupBox();
      this.grpMinuman = new System.Windows.Forms.GroupBox();
      this.radNasiGoreng = new System.Windows.Forms.RadioButton();
      this.radMieGoreng = new System.Windows.Forms.RadioButton();
      this.radBuburAyam = new System.Windows.Forms.RadioButton();
      this.radNasiUduk = new System.Windows.Forms.RadioButton();
      this.radMiePangsit = new System.Windows.Forms.RadioButton();
      this.radMartabe = new System.Windows.Forms.RadioButton();
      this.radJusJeruk = new System.Windows.Forms.RadioButton();
      this.radSprite = new System.Windows.Forms.RadioButton();
      this.radMilo = new System.Windows.Forms.RadioButton();
      this.radIceTea = new System.Windows.Forms.RadioButton();
      this.btnCek = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.grpMakanan.SuspendLayout();
      this.grpMinuman.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpMakanan
      // 
      this.grpMakanan.Controls.Add(this.radMiePangsit);
      this.grpMakanan.Controls.Add(this.radNasiUduk);
      this.grpMakanan.Controls.Add(this.radBuburAyam);
      this.grpMakanan.Controls.Add(this.radMieGoreng);
      this.grpMakanan.Controls.Add(this.radNasiGoreng);
      this.grpMakanan.Location = new System.Drawing.Point(12, 12);
      this.grpMakanan.Name = "grpMakanan";
      this.grpMakanan.Size = new System.Drawing.Size(200, 169);
      this.grpMakanan.TabIndex = 2;
      this.grpMakanan.TabStop = false;
      this.grpMakanan.Text = "Makanan";
      // 
      // grpMinuman
      // 
      this.grpMinuman.Controls.Add(this.radMartabe);
      this.grpMinuman.Controls.Add(this.radJusJeruk);
      this.grpMinuman.Controls.Add(this.radSprite);
      this.grpMinuman.Controls.Add(this.radMilo);
      this.grpMinuman.Controls.Add(this.radIceTea);
      this.grpMinuman.Location = new System.Drawing.Point(218, 12);
      this.grpMinuman.Name = "grpMinuman";
      this.grpMinuman.Size = new System.Drawing.Size(200, 169);
      this.grpMinuman.TabIndex = 3;
      this.grpMinuman.TabStop = false;
      this.grpMinuman.Text = "Minuman";
      // 
      // radNasiGoreng
      // 
      this.radNasiGoreng.AutoSize = true;
      this.radNasiGoreng.Location = new System.Drawing.Point(19, 31);
      this.radNasiGoreng.Name = "radNasiGoreng";
      this.radNasiGoreng.Size = new System.Drawing.Size(84, 17);
      this.radNasiGoreng.TabIndex = 0;
      this.radNasiGoreng.TabStop = true;
      this.radNasiGoreng.Text = "Nasi Goreng";
      this.radNasiGoreng.UseVisualStyleBackColor = true;
      this.radNasiGoreng.CheckedChanged += new System.EventHandler(this.radNasiGoreng_CheckedChanged);
      this.radNasiGoreng.MouseEnter += new System.EventHandler(this.radNasiGoreng_MouseEnter);
      this.radNasiGoreng.MouseLeave += new System.EventHandler(this.radNasiGoreng_MouseLeave);
      // 
      // radMieGoreng
      // 
      this.radMieGoreng.AutoSize = true;
      this.radMieGoreng.Location = new System.Drawing.Point(19, 54);
      this.radMieGoreng.Name = "radMieGoreng";
      this.radMieGoreng.Size = new System.Drawing.Size(80, 17);
      this.radMieGoreng.TabIndex = 1;
      this.radMieGoreng.TabStop = true;
      this.radMieGoreng.Text = "Mie Goreng";
      this.radMieGoreng.UseVisualStyleBackColor = true;
      this.radMieGoreng.CheckedChanged += new System.EventHandler(this.radNasiGoreng_CheckedChanged);
      this.radMieGoreng.MouseEnter += new System.EventHandler(this.radNasiGoreng_MouseEnter);
      this.radMieGoreng.MouseLeave += new System.EventHandler(this.radNasiGoreng_MouseLeave);
      // 
      // radBuburAyam
      // 
      this.radBuburAyam.AutoSize = true;
      this.radBuburAyam.Location = new System.Drawing.Point(19, 77);
      this.radBuburAyam.Name = "radBuburAyam";
      this.radBuburAyam.Size = new System.Drawing.Size(82, 17);
      this.radBuburAyam.TabIndex = 2;
      this.radBuburAyam.TabStop = true;
      this.radBuburAyam.Text = "Bubur Ayam";
      this.radBuburAyam.UseVisualStyleBackColor = true;
      this.radBuburAyam.CheckedChanged += new System.EventHandler(this.radNasiGoreng_CheckedChanged);
      this.radBuburAyam.MouseEnter += new System.EventHandler(this.radNasiGoreng_MouseEnter);
      this.radBuburAyam.MouseLeave += new System.EventHandler(this.radNasiGoreng_MouseLeave);
      // 
      // radNasiUduk
      // 
      this.radNasiUduk.AutoSize = true;
      this.radNasiUduk.Location = new System.Drawing.Point(19, 100);
      this.radNasiUduk.Name = "radNasiUduk";
      this.radNasiUduk.Size = new System.Drawing.Size(75, 17);
      this.radNasiUduk.TabIndex = 3;
      this.radNasiUduk.TabStop = true;
      this.radNasiUduk.Text = "Nasi Uduk";
      this.radNasiUduk.UseVisualStyleBackColor = true;
      this.radNasiUduk.CheckedChanged += new System.EventHandler(this.radNasiGoreng_CheckedChanged);
      this.radNasiUduk.MouseEnter += new System.EventHandler(this.radNasiGoreng_MouseEnter);
      this.radNasiUduk.MouseLeave += new System.EventHandler(this.radNasiGoreng_MouseLeave);
      // 
      // radMiePangsit
      // 
      this.radMiePangsit.AutoSize = true;
      this.radMiePangsit.Location = new System.Drawing.Point(19, 123);
      this.radMiePangsit.Name = "radMiePangsit";
      this.radMiePangsit.Size = new System.Drawing.Size(80, 17);
      this.radMiePangsit.TabIndex = 4;
      this.radMiePangsit.TabStop = true;
      this.radMiePangsit.Text = "Mie Pangsit";
      this.radMiePangsit.UseVisualStyleBackColor = true;
      this.radMiePangsit.CheckedChanged += new System.EventHandler(this.radNasiGoreng_CheckedChanged);
      this.radMiePangsit.MouseEnter += new System.EventHandler(this.radNasiGoreng_MouseEnter);
      this.radMiePangsit.MouseLeave += new System.EventHandler(this.radNasiGoreng_MouseLeave);
      // 
      // radMartabe
      // 
      this.radMartabe.AutoSize = true;
      this.radMartabe.Location = new System.Drawing.Point(19, 123);
      this.radMartabe.Name = "radMartabe";
      this.radMartabe.Size = new System.Drawing.Size(83, 17);
      this.radMartabe.TabIndex = 4;
      this.radMartabe.TabStop = true;
      this.radMartabe.Text = "Jus Martabe";
      this.radMartabe.UseVisualStyleBackColor = true;
      this.radMartabe.CheckedChanged += new System.EventHandler(this.radNasiGoreng_CheckedChanged);
      this.radMartabe.MouseEnter += new System.EventHandler(this.radNasiGoreng_MouseEnter);
      this.radMartabe.MouseLeave += new System.EventHandler(this.radNasiGoreng_MouseLeave);
      // 
      // radJusJeruk
      // 
      this.radJusJeruk.AutoSize = true;
      this.radJusJeruk.Location = new System.Drawing.Point(19, 100);
      this.radJusJeruk.Name = "radJusJeruk";
      this.radJusJeruk.Size = new System.Drawing.Size(70, 17);
      this.radJusJeruk.TabIndex = 3;
      this.radJusJeruk.TabStop = true;
      this.radJusJeruk.Text = "Jus Jeruk";
      this.radJusJeruk.UseVisualStyleBackColor = true;
      this.radJusJeruk.CheckedChanged += new System.EventHandler(this.radNasiGoreng_CheckedChanged);
      this.radJusJeruk.MouseEnter += new System.EventHandler(this.radNasiGoreng_MouseEnter);
      this.radJusJeruk.MouseLeave += new System.EventHandler(this.radNasiGoreng_MouseLeave);
      // 
      // radSprite
      // 
      this.radSprite.AutoSize = true;
      this.radSprite.Location = new System.Drawing.Point(19, 77);
      this.radSprite.Name = "radSprite";
      this.radSprite.Size = new System.Drawing.Size(52, 17);
      this.radSprite.TabIndex = 2;
      this.radSprite.TabStop = true;
      this.radSprite.Text = "Sprite";
      this.radSprite.UseVisualStyleBackColor = true;
      this.radSprite.CheckedChanged += new System.EventHandler(this.radNasiGoreng_CheckedChanged);
      this.radSprite.MouseEnter += new System.EventHandler(this.radNasiGoreng_MouseEnter);
      this.radSprite.MouseLeave += new System.EventHandler(this.radNasiGoreng_MouseLeave);
      // 
      // radMilo
      // 
      this.radMilo.AutoSize = true;
      this.radMilo.Location = new System.Drawing.Point(19, 54);
      this.radMilo.Name = "radMilo";
      this.radMilo.Size = new System.Drawing.Size(44, 17);
      this.radMilo.TabIndex = 1;
      this.radMilo.TabStop = true;
      this.radMilo.Text = "Milo";
      this.radMilo.UseVisualStyleBackColor = true;
      this.radMilo.CheckedChanged += new System.EventHandler(this.radNasiGoreng_CheckedChanged);
      this.radMilo.MouseEnter += new System.EventHandler(this.radNasiGoreng_MouseEnter);
      this.radMilo.MouseLeave += new System.EventHandler(this.radNasiGoreng_MouseLeave);
      // 
      // radIceTea
      // 
      this.radIceTea.AutoSize = true;
      this.radIceTea.Location = new System.Drawing.Point(19, 31);
      this.radIceTea.Name = "radIceTea";
      this.radIceTea.Size = new System.Drawing.Size(62, 17);
      this.radIceTea.TabIndex = 0;
      this.radIceTea.TabStop = true;
      this.radIceTea.Text = "Ice Tea";
      this.radIceTea.UseVisualStyleBackColor = true;
      this.radIceTea.CheckedChanged += new System.EventHandler(this.radNasiGoreng_CheckedChanged);
      this.radIceTea.MouseEnter += new System.EventHandler(this.radNasiGoreng_MouseEnter);
      this.radIceTea.MouseLeave += new System.EventHandler(this.radNasiGoreng_MouseLeave);
      // 
      // btnCek
      // 
      this.btnCek.Location = new System.Drawing.Point(12, 198);
      this.btnCek.Name = "btnCek";
      this.btnCek.Size = new System.Drawing.Size(75, 23);
      this.btnCek.TabIndex = 0;
      this.btnCek.Text = "&Cek";
      this.btnCek.UseVisualStyleBackColor = true;
      this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
      // 
      // btnReset
      // 
      this.btnReset.Location = new System.Drawing.Point(344, 198);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(75, 23);
      this.btnReset.TabIndex = 1;
      this.btnReset.Text = "&Reset";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // FrmDemoRadioButton
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(431, 233);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.btnCek);
      this.Controls.Add(this.grpMinuman);
      this.Controls.Add(this.grpMakanan);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoRadioButton";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo RadioButton";
      this.grpMakanan.ResumeLayout(false);
      this.grpMakanan.PerformLayout();
      this.grpMinuman.ResumeLayout(false);
      this.grpMinuman.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox grpMakanan;
    private System.Windows.Forms.GroupBox grpMinuman;
    private System.Windows.Forms.RadioButton radMiePangsit;
    private System.Windows.Forms.RadioButton radNasiUduk;
    private System.Windows.Forms.RadioButton radBuburAyam;
    private System.Windows.Forms.RadioButton radMieGoreng;
    private System.Windows.Forms.RadioButton radNasiGoreng;
    private System.Windows.Forms.RadioButton radMartabe;
    private System.Windows.Forms.RadioButton radJusJeruk;
    private System.Windows.Forms.RadioButton radSprite;
    private System.Windows.Forms.RadioButton radMilo;
    private System.Windows.Forms.RadioButton radIceTea;
    private System.Windows.Forms.Button btnCek;
    private System.Windows.Forms.Button btnReset;
  }
}