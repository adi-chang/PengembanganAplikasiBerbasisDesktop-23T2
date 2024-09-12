namespace Winforms.Basic.Controls
{
  partial class FrmDemoProgressBar
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
      this.pbar = new System.Windows.Forms.ProgressBar();
      this.label1 = new System.Windows.Forms.Label();
      this.lblMinimum = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblMaximum = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblValue = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // pbar
      // 
      this.pbar.Location = new System.Drawing.Point(12, 129);
      this.pbar.Name = "pbar";
      this.pbar.Size = new System.Drawing.Size(776, 23);
      this.pbar.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 23);
      this.label1.TabIndex = 1;
      this.label1.Text = "Minimum";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblMinimum
      // 
      this.lblMinimum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblMinimum.Location = new System.Drawing.Point(118, 16);
      this.lblMinimum.Name = "lblMinimum";
      this.lblMinimum.Size = new System.Drawing.Size(62, 23);
      this.lblMinimum.TabIndex = 2;
      this.lblMinimum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(12, 51);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 23);
      this.label3.TabIndex = 3;
      this.label3.Text = "Maximum";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblMaximum
      // 
      this.lblMaximum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblMaximum.Location = new System.Drawing.Point(118, 51);
      this.lblMaximum.Name = "lblMaximum";
      this.lblMaximum.Size = new System.Drawing.Size(62, 23);
      this.lblMaximum.TabIndex = 4;
      this.lblMaximum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(12, 103);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(100, 23);
      this.label5.TabIndex = 5;
      this.label5.Text = "Progress Bar";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblValue
      // 
      this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblValue.Location = new System.Drawing.Point(688, 103);
      this.lblValue.Name = "lblValue";
      this.lblValue.Size = new System.Drawing.Size(100, 23);
      this.lblValue.TabIndex = 6;
      this.lblValue.Text = "{ value }";
      this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // FrmDemoProgressBar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 164);
      this.Controls.Add(this.lblValue);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.lblMaximum);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lblMinimum);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pbar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoProgressBar";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo ProgressBar";
      this.Load += new System.EventHandler(this.FrmDemoProgressBar_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ProgressBar pbar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblMinimum;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblMaximum;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblValue;
    private System.Windows.Forms.Timer timer1;
  }
}