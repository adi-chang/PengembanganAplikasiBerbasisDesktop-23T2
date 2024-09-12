namespace Winforms.Basic.Controls
{
  partial class FrmDemoNumericUpDown
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
      this.numCelcius = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblReamur = new System.Windows.Forms.Label();
      this.lblFahreinheit = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblKelvin = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numCelcius)).BeginInit();
      this.SuspendLayout();
      // 
      // numCelcius
      // 
      this.numCelcius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.numCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numCelcius.Location = new System.Drawing.Point(12, 42);
      this.numCelcius.Name = "numCelcius";
      this.numCelcius.ReadOnly = true;
      this.numCelcius.Size = new System.Drawing.Size(120, 26);
      this.numCelcius.TabIndex = 0;
      this.numCelcius.ValueChanged += new System.EventHandler(this.numCelcius_ValueChanged);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 23);
      this.label1.TabIndex = 1;
      this.label1.Text = "Celcius";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 86);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 23);
      this.label2.TabIndex = 2;
      this.label2.Text = "Reamur";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblReamur
      // 
      this.lblReamur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblReamur.Location = new System.Drawing.Point(12, 109);
      this.lblReamur.Name = "lblReamur";
      this.lblReamur.Size = new System.Drawing.Size(120, 23);
      this.lblReamur.TabIndex = 3;
      this.lblReamur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblFahreinheit
      // 
      this.lblFahreinheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblFahreinheit.Location = new System.Drawing.Point(169, 109);
      this.lblFahreinheit.Name = "lblFahreinheit";
      this.lblFahreinheit.Size = new System.Drawing.Size(120, 23);
      this.lblFahreinheit.TabIndex = 5;
      this.lblFahreinheit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(166, 86);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(100, 23);
      this.label5.TabIndex = 4;
      this.label5.Text = "Fahreinheit";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblKelvin
      // 
      this.lblKelvin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblKelvin.Location = new System.Drawing.Point(326, 109);
      this.lblKelvin.Name = "lblKelvin";
      this.lblKelvin.Size = new System.Drawing.Size(121, 23);
      this.lblKelvin.TabIndex = 7;
      this.lblKelvin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label7
      // 
      this.label7.Location = new System.Drawing.Point(323, 86);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(100, 23);
      this.label7.TabIndex = 6;
      this.label7.Text = "Kelvin";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // domainUpDown1
      // 
      this.domainUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.domainUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.domainUpDown1.Items.Add("A");
      this.domainUpDown1.Items.Add("B");
      this.domainUpDown1.Items.Add("C");
      this.domainUpDown1.Items.Add("D");
      this.domainUpDown1.Items.Add("E");
      this.domainUpDown1.Location = new System.Drawing.Point(326, 42);
      this.domainUpDown1.Name = "domainUpDown1";
      this.domainUpDown1.ReadOnly = true;
      this.domainUpDown1.Size = new System.Drawing.Size(121, 26);
      this.domainUpDown1.TabIndex = 8;
      this.domainUpDown1.Text = "A";
      this.domainUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.domainUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
      this.domainUpDown1.Wrap = true;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(326, 16);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(121, 23);
      this.label3.TabIndex = 9;
      this.label3.Text = "DomainUpDown";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // FrmDemoNumericUpDown
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(459, 147);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.domainUpDown1);
      this.Controls.Add(this.lblKelvin);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.lblFahreinheit);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.lblReamur);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.numCelcius);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoNumericUpDown";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo NumericUpDown & DomainUpDown";
      this.Load += new System.EventHandler(this.FrmDemoNumericUpDown_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numCelcius)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.NumericUpDown numCelcius;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblReamur;
    private System.Windows.Forms.Label lblFahreinheit;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblKelvin;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.DomainUpDown domainUpDown1;
    private System.Windows.Forms.Label label3;
  }
}