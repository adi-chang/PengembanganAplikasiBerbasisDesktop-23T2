﻿namespace Winforms.Basic.Controls
{
  partial class FrmDemoLabel
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(238, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Label digunakan untuk menampilkan keterangan";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 46);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(422, 23);
      this.label2.TabIndex = 1;
      this.label2.Text = "Label digunakan untuk menampilkan keterangan. Click Me !!!";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label2.Click += new System.EventHandler(this.label2_Click);
      this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
      this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
      // 
      // label3
      // 
      this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label3.Location = new System.Drawing.Point(12, 84);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(422, 23);
      this.label3.TabIndex = 2;
      this.label3.Text = "Label digunakan untuk menampilkan keterangan";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
      this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
      // 
      // FrmDemoLabel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(446, 124);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoLabel";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo Label";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
  }
}