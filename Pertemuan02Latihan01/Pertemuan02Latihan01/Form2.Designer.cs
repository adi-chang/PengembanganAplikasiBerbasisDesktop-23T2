namespace Pertemuan02Latihan01
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
      this.label1 = new System.Windows.Forms.Label();
      this.btnTutup = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(275, 143);
      this.label1.TabIndex = 0;
      this.label1.Text = "Selamat Datang\r\ndi\r\nAplikasi Visual C# \r\nPertama Anda !!!";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnTutup
      // 
      this.btnTutup.Location = new System.Drawing.Point(112, 157);
      this.btnTutup.Name = "btnTutup";
      this.btnTutup.Size = new System.Drawing.Size(75, 23);
      this.btnTutup.TabIndex = 1;
      this.btnTutup.Text = "Tutup";
      this.btnTutup.UseVisualStyleBackColor = true;
      this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(299, 192);
      this.ControlBox = false;
      this.Controls.Add(this.btnTutup);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "Form2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Welcome";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnTutup;
  }
}