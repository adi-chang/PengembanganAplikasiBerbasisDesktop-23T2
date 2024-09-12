namespace Winforms.Basic.Controls
{
  partial class FrmDemoButton2
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
      this.btnClickMe = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnClickMe
      // 
      this.btnClickMe.Location = new System.Drawing.Point(218, 209);
      this.btnClickMe.Name = "btnClickMe";
      this.btnClickMe.Size = new System.Drawing.Size(48, 42);
      this.btnClickMe.TabIndex = 0;
      this.btnClickMe.TabStop = false;
      this.btnClickMe.Text = "Click Me";
      this.btnClickMe.UseVisualStyleBackColor = true;
      this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
      this.btnClickMe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnClickMe_MouseMove);
      // 
      // FrmDemoButton2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 461);
      this.Controls.Add(this.btnClickMe);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoButton2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo Button 2";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnClickMe;
  }
}