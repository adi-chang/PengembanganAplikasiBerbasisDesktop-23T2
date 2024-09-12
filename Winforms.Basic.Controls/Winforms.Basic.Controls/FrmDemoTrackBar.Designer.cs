namespace Winforms.Basic.Controls
{
  partial class FrmDemoTrackBar
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
      this.tbar1 = new System.Windows.Forms.TrackBar();
      this.tbar2 = new System.Windows.Forms.TrackBar();
      this.tbar3 = new System.Windows.Forms.TrackBar();
      this.tbar4 = new System.Windows.Forms.TrackBar();
      this.tbar5 = new System.Windows.Forms.TrackBar();
      this.lbl1 = new System.Windows.Forms.Label();
      this.lbl2 = new System.Windows.Forms.Label();
      this.lbl3 = new System.Windows.Forms.Label();
      this.lbl4 = new System.Windows.Forms.Label();
      this.lbl5 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.tbar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbar2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbar3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbar4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbar5)).BeginInit();
      this.SuspendLayout();
      // 
      // tbar1
      // 
      this.tbar1.Location = new System.Drawing.Point(12, 12);
      this.tbar1.Maximum = 100;
      this.tbar1.Name = "tbar1";
      this.tbar1.Size = new System.Drawing.Size(527, 45);
      this.tbar1.TabIndex = 0;
      this.tbar1.TickStyle = System.Windows.Forms.TickStyle.None;
      this.tbar1.ValueChanged += new System.EventHandler(this.tbar1_ValueChanged);
      // 
      // tbar2
      // 
      this.tbar2.Location = new System.Drawing.Point(12, 79);
      this.tbar2.Maximum = 100;
      this.tbar2.Name = "tbar2";
      this.tbar2.Size = new System.Drawing.Size(527, 45);
      this.tbar2.TabIndex = 1;
      this.tbar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
      this.tbar2.ValueChanged += new System.EventHandler(this.tbar1_ValueChanged);
      // 
      // tbar3
      // 
      this.tbar3.Location = new System.Drawing.Point(12, 146);
      this.tbar3.Maximum = 100;
      this.tbar3.Name = "tbar3";
      this.tbar3.Size = new System.Drawing.Size(527, 45);
      this.tbar3.TabIndex = 2;
      this.tbar3.ValueChanged += new System.EventHandler(this.tbar1_ValueChanged);
      // 
      // tbar4
      // 
      this.tbar4.Location = new System.Drawing.Point(12, 213);
      this.tbar4.Maximum = 100;
      this.tbar4.Name = "tbar4";
      this.tbar4.Size = new System.Drawing.Size(527, 45);
      this.tbar4.TabIndex = 3;
      this.tbar4.TickStyle = System.Windows.Forms.TickStyle.Both;
      this.tbar4.ValueChanged += new System.EventHandler(this.tbar1_ValueChanged);
      // 
      // tbar5
      // 
      this.tbar5.Location = new System.Drawing.Point(649, 12);
      this.tbar5.Maximum = 100;
      this.tbar5.Name = "tbar5";
      this.tbar5.Orientation = System.Windows.Forms.Orientation.Vertical;
      this.tbar5.Size = new System.Drawing.Size(45, 362);
      this.tbar5.TabIndex = 4;
      this.tbar5.TickStyle = System.Windows.Forms.TickStyle.Both;
      this.tbar5.ValueChanged += new System.EventHandler(this.tbar1_ValueChanged);
      // 
      // lbl1
      // 
      this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl1.Location = new System.Drawing.Point(545, 12);
      this.lbl1.Name = "lbl1";
      this.lbl1.Size = new System.Drawing.Size(59, 23);
      this.lbl1.TabIndex = 5;
      this.lbl1.Text = "label1";
      this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbl2
      // 
      this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl2.Location = new System.Drawing.Point(545, 79);
      this.lbl2.Name = "lbl2";
      this.lbl2.Size = new System.Drawing.Size(59, 23);
      this.lbl2.TabIndex = 6;
      this.lbl2.Text = "label2";
      this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbl3
      // 
      this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl3.Location = new System.Drawing.Point(545, 146);
      this.lbl3.Name = "lbl3";
      this.lbl3.Size = new System.Drawing.Size(59, 23);
      this.lbl3.TabIndex = 7;
      this.lbl3.Text = "label3";
      this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbl4
      // 
      this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl4.Location = new System.Drawing.Point(545, 213);
      this.lbl4.Name = "lbl4";
      this.lbl4.Size = new System.Drawing.Size(59, 23);
      this.lbl4.TabIndex = 8;
      this.lbl4.Text = "label4";
      this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbl5
      // 
      this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl5.Location = new System.Drawing.Point(700, 12);
      this.lbl5.Name = "lbl5";
      this.lbl5.Size = new System.Drawing.Size(59, 23);
      this.lbl5.TabIndex = 9;
      this.lbl5.Text = "label5";
      this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // FrmDemoTrackBar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(775, 386);
      this.Controls.Add(this.lbl5);
      this.Controls.Add(this.lbl4);
      this.Controls.Add(this.lbl3);
      this.Controls.Add(this.lbl2);
      this.Controls.Add(this.lbl1);
      this.Controls.Add(this.tbar5);
      this.Controls.Add(this.tbar4);
      this.Controls.Add(this.tbar3);
      this.Controls.Add(this.tbar2);
      this.Controls.Add(this.tbar1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoTrackBar";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo TrackBar";
      this.Load += new System.EventHandler(this.FrmDemoTrackBar_Load);
      ((System.ComponentModel.ISupportInitialize)(this.tbar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbar2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbar3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbar4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbar5)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TrackBar tbar1;
    private System.Windows.Forms.TrackBar tbar2;
    private System.Windows.Forms.TrackBar tbar3;
    private System.Windows.Forms.TrackBar tbar4;
    private System.Windows.Forms.TrackBar tbar5;
    private System.Windows.Forms.Label lbl1;
    private System.Windows.Forms.Label lbl2;
    private System.Windows.Forms.Label lbl3;
    private System.Windows.Forms.Label lbl4;
    private System.Windows.Forms.Label lbl5;
  }
}