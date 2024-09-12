namespace Winforms.Basic.Controls
{
  partial class FrmDemoTrackBar2
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
      this.tbarCelcius = new System.Windows.Forms.TrackBar();
      this.label1 = new System.Windows.Forms.Label();
      this.lblCelcius = new System.Windows.Forms.Label();
      this.lblReamur = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.tbarReamur = new System.Windows.Forms.TrackBar();
      this.lblFahreinheit = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tbarFahreinheit = new System.Windows.Forms.TrackBar();
      this.lblKelvin = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.tbarKelvin = new System.Windows.Forms.TrackBar();
      ((System.ComponentModel.ISupportInitialize)(this.tbarCelcius)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbarReamur)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbarFahreinheit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbarKelvin)).BeginInit();
      this.SuspendLayout();
      // 
      // tbarCelcius
      // 
      this.tbarCelcius.LargeChange = 1;
      this.tbarCelcius.Location = new System.Drawing.Point(12, 40);
      this.tbarCelcius.Maximum = 100;
      this.tbarCelcius.Name = "tbarCelcius";
      this.tbarCelcius.Orientation = System.Windows.Forms.Orientation.Vertical;
      this.tbarCelcius.Size = new System.Drawing.Size(45, 398);
      this.tbarCelcius.TabIndex = 0;
      this.tbarCelcius.TickStyle = System.Windows.Forms.TickStyle.Both;
      this.tbarCelcius.Scroll += new System.EventHandler(this.tbarCelcius_Scroll);
      this.tbarCelcius.ValueChanged += new System.EventHandler(this.tbarCelcius_ValueChanged);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 23);
      this.label1.TabIndex = 1;
      this.label1.Text = "C";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblCelcius
      // 
      this.lblCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCelcius.Location = new System.Drawing.Point(63, 40);
      this.lblCelcius.Name = "lblCelcius";
      this.lblCelcius.Size = new System.Drawing.Size(60, 23);
      this.lblCelcius.TabIndex = 2;
      this.lblCelcius.Text = "{ value }";
      this.lblCelcius.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblReamur
      // 
      this.lblReamur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblReamur.Location = new System.Drawing.Point(192, 40);
      this.lblReamur.Name = "lblReamur";
      this.lblReamur.Size = new System.Drawing.Size(60, 23);
      this.lblReamur.TabIndex = 5;
      this.lblReamur.Text = "{ value }";
      this.lblReamur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(141, 14);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(45, 23);
      this.label4.TabIndex = 4;
      this.label4.Text = "R";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tbarReamur
      // 
      this.tbarReamur.LargeChange = 1;
      this.tbarReamur.Location = new System.Drawing.Point(141, 40);
      this.tbarReamur.Maximum = 80;
      this.tbarReamur.Name = "tbarReamur";
      this.tbarReamur.Orientation = System.Windows.Forms.Orientation.Vertical;
      this.tbarReamur.Size = new System.Drawing.Size(45, 398);
      this.tbarReamur.TabIndex = 3;
      this.tbarReamur.TickStyle = System.Windows.Forms.TickStyle.Both;
      this.tbarReamur.Scroll += new System.EventHandler(this.tbarReamur_Scroll);
      this.tbarReamur.ValueChanged += new System.EventHandler(this.tbarCelcius_ValueChanged);
      // 
      // lblFahreinheit
      // 
      this.lblFahreinheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFahreinheit.Location = new System.Drawing.Point(323, 40);
      this.lblFahreinheit.Name = "lblFahreinheit";
      this.lblFahreinheit.Size = new System.Drawing.Size(60, 23);
      this.lblFahreinheit.TabIndex = 8;
      this.lblFahreinheit.Text = "{ value }";
      this.lblFahreinheit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(272, 14);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(45, 23);
      this.label6.TabIndex = 7;
      this.label6.Text = "F";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tbarFahreinheit
      // 
      this.tbarFahreinheit.LargeChange = 1;
      this.tbarFahreinheit.Location = new System.Drawing.Point(272, 40);
      this.tbarFahreinheit.Maximum = 212;
      this.tbarFahreinheit.Minimum = 32;
      this.tbarFahreinheit.Name = "tbarFahreinheit";
      this.tbarFahreinheit.Orientation = System.Windows.Forms.Orientation.Vertical;
      this.tbarFahreinheit.Size = new System.Drawing.Size(45, 398);
      this.tbarFahreinheit.TabIndex = 6;
      this.tbarFahreinheit.TickStyle = System.Windows.Forms.TickStyle.Both;
      this.tbarFahreinheit.Value = 32;
      this.tbarFahreinheit.Scroll += new System.EventHandler(this.tbarFahreinheit_Scroll);
      this.tbarFahreinheit.ValueChanged += new System.EventHandler(this.tbarCelcius_ValueChanged);
      // 
      // lblKelvin
      // 
      this.lblKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblKelvin.Location = new System.Drawing.Point(456, 40);
      this.lblKelvin.Name = "lblKelvin";
      this.lblKelvin.Size = new System.Drawing.Size(60, 23);
      this.lblKelvin.TabIndex = 11;
      this.lblKelvin.Text = "{ value }";
      this.lblKelvin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label8
      // 
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(405, 14);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(45, 23);
      this.label8.TabIndex = 10;
      this.label8.Text = "K";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tbarKelvin
      // 
      this.tbarKelvin.LargeChange = 1;
      this.tbarKelvin.Location = new System.Drawing.Point(405, 40);
      this.tbarKelvin.Maximum = 373;
      this.tbarKelvin.Minimum = 273;
      this.tbarKelvin.Name = "tbarKelvin";
      this.tbarKelvin.Orientation = System.Windows.Forms.Orientation.Vertical;
      this.tbarKelvin.Size = new System.Drawing.Size(45, 398);
      this.tbarKelvin.TabIndex = 9;
      this.tbarKelvin.TickStyle = System.Windows.Forms.TickStyle.Both;
      this.tbarKelvin.Value = 273;
      this.tbarKelvin.Scroll += new System.EventHandler(this.tbarKelvin_Scroll);
      this.tbarKelvin.ValueChanged += new System.EventHandler(this.tbarCelcius_ValueChanged);
      // 
      // FrmDemoTrackBar2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(531, 450);
      this.Controls.Add(this.lblKelvin);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.tbarKelvin);
      this.Controls.Add(this.lblFahreinheit);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.tbarFahreinheit);
      this.Controls.Add(this.lblReamur);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.tbarReamur);
      this.Controls.Add(this.lblCelcius);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbarCelcius);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoTrackBar2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo TrackBar - Pemanfaatan - Konversi Suhu";
      this.Load += new System.EventHandler(this.FrmDemoTrackBar2_Load);
      ((System.ComponentModel.ISupportInitialize)(this.tbarCelcius)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbarReamur)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbarFahreinheit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbarKelvin)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TrackBar tbarCelcius;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblCelcius;
    private System.Windows.Forms.Label lblReamur;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TrackBar tbarReamur;
    private System.Windows.Forms.Label lblFahreinheit;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TrackBar tbarFahreinheit;
    private System.Windows.Forms.Label lblKelvin;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TrackBar tbarKelvin;
  }
}