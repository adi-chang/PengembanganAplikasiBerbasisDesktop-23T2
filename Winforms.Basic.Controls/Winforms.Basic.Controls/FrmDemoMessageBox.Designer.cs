namespace Winforms.Basic.Controls
{
  partial class FrmDemoMessageBox
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtNama = new System.Windows.Forms.TextBox();
      this.button5 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(374, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "MessageBox - With OK button - Information Icon";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(12, 41);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(374, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "MessageBox - With OK button - Error Icon";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(12, 70);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(374, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "MessageBox - With YES/NO button - Question Icon";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(12, 99);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(374, 23);
      this.button4.TabIndex = 3;
      this.button4.Text = "MessageBox - With YES/NO button - Question Icon - And Response";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 148);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 23);
      this.label1.TabIndex = 4;
      this.label1.Text = "Nama ? ";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtNama
      // 
      this.txtNama.Location = new System.Drawing.Point(12, 174);
      this.txtNama.Name = "txtNama";
      this.txtNama.Size = new System.Drawing.Size(215, 20);
      this.txtNama.TabIndex = 5;
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(12, 200);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(75, 23);
      this.button5.TabIndex = 6;
      this.button5.Text = "OK";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // FrmDemoMessageBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(398, 376);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.txtNama);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoMessageBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo MessageBox";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNama;
    private System.Windows.Forms.Button button5;
  }
}