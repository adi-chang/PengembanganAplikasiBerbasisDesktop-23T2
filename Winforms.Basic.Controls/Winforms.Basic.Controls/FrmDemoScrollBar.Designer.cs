namespace Winforms.Basic.Controls
{
  partial class FrmDemoScrollBar
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
      this.hsb1 = new System.Windows.Forms.HScrollBar();
      this.vsb1 = new System.Windows.Forms.VScrollBar();
      this.lbl1 = new System.Windows.Forms.Label();
      this.lbl2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // hsb1
      // 
      this.hsb1.LargeChange = 1;
      this.hsb1.Location = new System.Drawing.Point(9, 9);
      this.hsb1.Name = "hsb1";
      this.hsb1.Size = new System.Drawing.Size(539, 17);
      this.hsb1.TabIndex = 0;
      this.hsb1.ValueChanged += new System.EventHandler(this.hsb1_ValueChanged);
      // 
      // vsb1
      // 
      this.vsb1.LargeChange = 1;
      this.vsb1.Location = new System.Drawing.Point(531, 35);
      this.vsb1.Name = "vsb1";
      this.vsb1.Size = new System.Drawing.Size(17, 328);
      this.vsb1.TabIndex = 1;
      this.vsb1.ValueChanged += new System.EventHandler(this.vsb1_ValueChanged);
      // 
      // lbl1
      // 
      this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl1.Location = new System.Drawing.Point(12, 35);
      this.lbl1.Name = "lbl1";
      this.lbl1.Size = new System.Drawing.Size(100, 23);
      this.lbl1.TabIndex = 2;
      this.lbl1.Text = "label1";
      this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl2
      // 
      this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl2.Location = new System.Drawing.Point(428, 35);
      this.lbl2.Name = "lbl2";
      this.lbl2.Size = new System.Drawing.Size(100, 23);
      this.lbl2.TabIndex = 3;
      this.lbl2.Text = "label2";
      this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // FrmDemoScrollBar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(557, 372);
      this.Controls.Add(this.lbl2);
      this.Controls.Add(this.lbl1);
      this.Controls.Add(this.vsb1);
      this.Controls.Add(this.hsb1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoScrollBar";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo ScrollBar";
      this.Load += new System.EventHandler(this.FrmDemoScrollBar_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.HScrollBar hsb1;
    private System.Windows.Forms.VScrollBar vsb1;
    private System.Windows.Forms.Label lbl1;
    private System.Windows.Forms.Label lbl2;
  }
}