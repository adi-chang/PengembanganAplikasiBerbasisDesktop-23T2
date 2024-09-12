namespace Winforms.Basic.Controls
{
  partial class FrmDemoCheckBox
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
      this.pnlMakanan = new System.Windows.Forms.Panel();
      this.chkNasiGoreng = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.chkMieGoreng = new System.Windows.Forms.CheckBox();
      this.chkBuburAyam = new System.Windows.Forms.CheckBox();
      this.chkNasiUduk = new System.Windows.Forms.CheckBox();
      this.chkMiePangsit = new System.Windows.Forms.CheckBox();
      this.grpMinuman = new System.Windows.Forms.GroupBox();
      this.chkJusMartabe = new System.Windows.Forms.CheckBox();
      this.chkJusJeruk = new System.Windows.Forms.CheckBox();
      this.chkSprite = new System.Windows.Forms.CheckBox();
      this.chkMilo = new System.Windows.Forms.CheckBox();
      this.chkIceTea = new System.Windows.Forms.CheckBox();
      this.btnClearAll = new System.Windows.Forms.Button();
      this.btnTickAll = new System.Windows.Forms.Button();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.btnTickAll2 = new System.Windows.Forms.Button();
      this.pnlMakanan.SuspendLayout();
      this.grpMinuman.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlMakanan
      // 
      this.pnlMakanan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlMakanan.Controls.Add(this.btnTickAll);
      this.pnlMakanan.Controls.Add(this.chkMiePangsit);
      this.pnlMakanan.Controls.Add(this.chkNasiUduk);
      this.pnlMakanan.Controls.Add(this.chkBuburAyam);
      this.pnlMakanan.Controls.Add(this.chkMieGoreng);
      this.pnlMakanan.Controls.Add(this.label1);
      this.pnlMakanan.Controls.Add(this.chkNasiGoreng);
      this.pnlMakanan.Location = new System.Drawing.Point(12, 12);
      this.pnlMakanan.Name = "pnlMakanan";
      this.pnlMakanan.Size = new System.Drawing.Size(160, 180);
      this.pnlMakanan.TabIndex = 0;
      // 
      // chkNasiGoreng
      // 
      this.chkNasiGoreng.AutoSize = true;
      this.chkNasiGoreng.Location = new System.Drawing.Point(16, 55);
      this.chkNasiGoreng.Name = "chkNasiGoreng";
      this.chkNasiGoreng.Size = new System.Drawing.Size(85, 17);
      this.chkNasiGoreng.TabIndex = 0;
      this.chkNasiGoreng.Text = "Nasi Goreng";
      this.chkNasiGoreng.UseVisualStyleBackColor = true;
      this.chkNasiGoreng.CheckedChanged += new System.EventHandler(this.chkNasiGoreng_CheckedChanged);
      this.chkNasiGoreng.MouseEnter += new System.EventHandler(this.chkNasiGoreng_MouseEnter);
      this.chkNasiGoreng.MouseLeave += new System.EventHandler(this.chkNasiGoreng_MouseLeave);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(126, 23);
      this.label1.TabIndex = 1;
      this.label1.Text = "Makanan";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // chkMieGoreng
      // 
      this.chkMieGoreng.AutoSize = true;
      this.chkMieGoreng.Location = new System.Drawing.Point(16, 78);
      this.chkMieGoreng.Name = "chkMieGoreng";
      this.chkMieGoreng.Size = new System.Drawing.Size(81, 17);
      this.chkMieGoreng.TabIndex = 2;
      this.chkMieGoreng.Text = "Mie Goreng";
      this.chkMieGoreng.UseVisualStyleBackColor = true;
      this.chkMieGoreng.CheckedChanged += new System.EventHandler(this.chkNasiGoreng_CheckedChanged);
      this.chkMieGoreng.MouseEnter += new System.EventHandler(this.chkNasiGoreng_MouseEnter);
      this.chkMieGoreng.MouseLeave += new System.EventHandler(this.chkNasiGoreng_MouseLeave);
      // 
      // chkBuburAyam
      // 
      this.chkBuburAyam.AutoSize = true;
      this.chkBuburAyam.Location = new System.Drawing.Point(16, 101);
      this.chkBuburAyam.Name = "chkBuburAyam";
      this.chkBuburAyam.Size = new System.Drawing.Size(83, 17);
      this.chkBuburAyam.TabIndex = 3;
      this.chkBuburAyam.Text = "Bubur Ayam";
      this.chkBuburAyam.UseVisualStyleBackColor = true;
      this.chkBuburAyam.CheckedChanged += new System.EventHandler(this.chkNasiGoreng_CheckedChanged);
      this.chkBuburAyam.MouseEnter += new System.EventHandler(this.chkNasiGoreng_MouseEnter);
      this.chkBuburAyam.MouseLeave += new System.EventHandler(this.chkNasiGoreng_MouseLeave);
      // 
      // chkNasiUduk
      // 
      this.chkNasiUduk.AutoSize = true;
      this.chkNasiUduk.Location = new System.Drawing.Point(16, 124);
      this.chkNasiUduk.Name = "chkNasiUduk";
      this.chkNasiUduk.Size = new System.Drawing.Size(76, 17);
      this.chkNasiUduk.TabIndex = 4;
      this.chkNasiUduk.Text = "Nasi Uduk";
      this.chkNasiUduk.UseVisualStyleBackColor = true;
      this.chkNasiUduk.CheckedChanged += new System.EventHandler(this.chkNasiGoreng_CheckedChanged);
      this.chkNasiUduk.MouseEnter += new System.EventHandler(this.chkNasiGoreng_MouseEnter);
      this.chkNasiUduk.MouseLeave += new System.EventHandler(this.chkNasiGoreng_MouseLeave);
      // 
      // chkMiePangsit
      // 
      this.chkMiePangsit.AutoSize = true;
      this.chkMiePangsit.Location = new System.Drawing.Point(16, 147);
      this.chkMiePangsit.Name = "chkMiePangsit";
      this.chkMiePangsit.Size = new System.Drawing.Size(84, 17);
      this.chkMiePangsit.TabIndex = 5;
      this.chkMiePangsit.Text = "Mie Pangsit ";
      this.chkMiePangsit.UseVisualStyleBackColor = true;
      this.chkMiePangsit.CheckedChanged += new System.EventHandler(this.chkNasiGoreng_CheckedChanged);
      this.chkMiePangsit.MouseEnter += new System.EventHandler(this.chkNasiGoreng_MouseEnter);
      this.chkMiePangsit.MouseLeave += new System.EventHandler(this.chkNasiGoreng_MouseLeave);
      // 
      // grpMinuman
      // 
      this.grpMinuman.Controls.Add(this.btnTickAll2);
      this.grpMinuman.Controls.Add(this.chkJusMartabe);
      this.grpMinuman.Controls.Add(this.chkJusJeruk);
      this.grpMinuman.Controls.Add(this.chkSprite);
      this.grpMinuman.Controls.Add(this.chkMilo);
      this.grpMinuman.Controls.Add(this.chkIceTea);
      this.grpMinuman.Location = new System.Drawing.Point(178, 12);
      this.grpMinuman.Name = "grpMinuman";
      this.grpMinuman.Size = new System.Drawing.Size(200, 180);
      this.grpMinuman.TabIndex = 7;
      this.grpMinuman.TabStop = false;
      this.grpMinuman.Text = "Minuman";
      // 
      // chkJusMartabe
      // 
      this.chkJusMartabe.AutoSize = true;
      this.chkJusMartabe.Location = new System.Drawing.Point(21, 122);
      this.chkJusMartabe.Name = "chkJusMartabe";
      this.chkJusMartabe.Size = new System.Drawing.Size(84, 17);
      this.chkJusMartabe.TabIndex = 11;
      this.chkJusMartabe.Text = "Jus Martabe";
      this.chkJusMartabe.UseVisualStyleBackColor = true;
      this.chkJusMartabe.CheckedChanged += new System.EventHandler(this.chkNasiGoreng_CheckedChanged);
      this.chkJusMartabe.MouseEnter += new System.EventHandler(this.chkNasiGoreng_MouseEnter);
      this.chkJusMartabe.MouseLeave += new System.EventHandler(this.chkNasiGoreng_MouseLeave);
      // 
      // chkJusJeruk
      // 
      this.chkJusJeruk.AutoSize = true;
      this.chkJusJeruk.Location = new System.Drawing.Point(21, 99);
      this.chkJusJeruk.Name = "chkJusJeruk";
      this.chkJusJeruk.Size = new System.Drawing.Size(71, 17);
      this.chkJusJeruk.TabIndex = 10;
      this.chkJusJeruk.Text = "Jus Jeruk";
      this.chkJusJeruk.UseVisualStyleBackColor = true;
      this.chkJusJeruk.CheckedChanged += new System.EventHandler(this.chkNasiGoreng_CheckedChanged);
      this.chkJusJeruk.MouseEnter += new System.EventHandler(this.chkNasiGoreng_MouseEnter);
      this.chkJusJeruk.MouseLeave += new System.EventHandler(this.chkNasiGoreng_MouseLeave);
      // 
      // chkSprite
      // 
      this.chkSprite.AutoSize = true;
      this.chkSprite.Location = new System.Drawing.Point(21, 76);
      this.chkSprite.Name = "chkSprite";
      this.chkSprite.Size = new System.Drawing.Size(53, 17);
      this.chkSprite.TabIndex = 9;
      this.chkSprite.Text = "Sprite";
      this.chkSprite.UseVisualStyleBackColor = true;
      this.chkSprite.CheckedChanged += new System.EventHandler(this.chkNasiGoreng_CheckedChanged);
      this.chkSprite.MouseEnter += new System.EventHandler(this.chkNasiGoreng_MouseEnter);
      this.chkSprite.MouseLeave += new System.EventHandler(this.chkNasiGoreng_MouseLeave);
      // 
      // chkMilo
      // 
      this.chkMilo.AutoSize = true;
      this.chkMilo.Location = new System.Drawing.Point(21, 53);
      this.chkMilo.Name = "chkMilo";
      this.chkMilo.Size = new System.Drawing.Size(45, 17);
      this.chkMilo.TabIndex = 8;
      this.chkMilo.Text = "Milo";
      this.chkMilo.UseVisualStyleBackColor = true;
      this.chkMilo.CheckedChanged += new System.EventHandler(this.chkNasiGoreng_CheckedChanged);
      this.chkMilo.MouseEnter += new System.EventHandler(this.chkNasiGoreng_MouseEnter);
      this.chkMilo.MouseLeave += new System.EventHandler(this.chkNasiGoreng_MouseLeave);
      // 
      // chkIceTea
      // 
      this.chkIceTea.AutoSize = true;
      this.chkIceTea.Location = new System.Drawing.Point(21, 30);
      this.chkIceTea.Name = "chkIceTea";
      this.chkIceTea.Size = new System.Drawing.Size(63, 17);
      this.chkIceTea.TabIndex = 7;
      this.chkIceTea.Text = "Ice Tea";
      this.chkIceTea.UseVisualStyleBackColor = true;
      this.chkIceTea.CheckedChanged += new System.EventHandler(this.chkNasiGoreng_CheckedChanged);
      this.chkIceTea.MouseEnter += new System.EventHandler(this.chkNasiGoreng_MouseEnter);
      this.chkIceTea.MouseLeave += new System.EventHandler(this.chkNasiGoreng_MouseLeave);
      // 
      // btnClearAll
      // 
      this.btnClearAll.Location = new System.Drawing.Point(304, 198);
      this.btnClearAll.Name = "btnClearAll";
      this.btnClearAll.Size = new System.Drawing.Size(75, 23);
      this.btnClearAll.TabIndex = 8;
      this.btnClearAll.Text = "Clear All";
      this.btnClearAll.UseVisualStyleBackColor = true;
      this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
      // 
      // btnTickAll
      // 
      this.btnTickAll.Location = new System.Drawing.Point(118, 15);
      this.btnTickAll.Name = "btnTickAll";
      this.btnTickAll.Size = new System.Drawing.Size(20, 23);
      this.btnTickAll.TabIndex = 7;
      this.btnTickAll.Text = "V";
      this.toolTip1.SetToolTip(this.btnTickAll, "Tick All");
      this.btnTickAll.UseVisualStyleBackColor = true;
      this.btnTickAll.Click += new System.EventHandler(this.btnTickAll_Click);
      // 
      // btnTickAll2
      // 
      this.btnTickAll2.Location = new System.Drawing.Point(160, 26);
      this.btnTickAll2.Name = "btnTickAll2";
      this.btnTickAll2.Size = new System.Drawing.Size(20, 23);
      this.btnTickAll2.TabIndex = 13;
      this.btnTickAll2.Text = "V";
      this.toolTip1.SetToolTip(this.btnTickAll2, "Tick All");
      this.btnTickAll2.UseVisualStyleBackColor = true;
      this.btnTickAll2.Click += new System.EventHandler(this.btnTickAll2_Click);
      // 
      // FrmDemoCheckBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(391, 230);
      this.Controls.Add(this.btnClearAll);
      this.Controls.Add(this.grpMinuman);
      this.Controls.Add(this.pnlMakanan);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoCheckBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo CheckBox";
      this.pnlMakanan.ResumeLayout(false);
      this.pnlMakanan.PerformLayout();
      this.grpMinuman.ResumeLayout(false);
      this.grpMinuman.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlMakanan;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox chkNasiGoreng;
    private System.Windows.Forms.CheckBox chkMiePangsit;
    private System.Windows.Forms.CheckBox chkNasiUduk;
    private System.Windows.Forms.CheckBox chkBuburAyam;
    private System.Windows.Forms.CheckBox chkMieGoreng;
    private System.Windows.Forms.GroupBox grpMinuman;
    private System.Windows.Forms.CheckBox chkJusMartabe;
    private System.Windows.Forms.CheckBox chkJusJeruk;
    private System.Windows.Forms.CheckBox chkSprite;
    private System.Windows.Forms.CheckBox chkMilo;
    private System.Windows.Forms.CheckBox chkIceTea;
    private System.Windows.Forms.Button btnClearAll;
    private System.Windows.Forms.Button btnTickAll;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Button btnTickAll2;
  }
}