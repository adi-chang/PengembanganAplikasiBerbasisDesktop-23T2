namespace Winforms.Basic.Controls
{
  partial class FrmDemoTextBox
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
      this.lblNama = new System.Windows.Forms.Label();
      this.txtNama = new System.Windows.Forms.TextBox();
      this.lblUmur = new System.Windows.Forms.Label();
      this.txtUmur = new System.Windows.Forms.TextBox();
      this.lblCount = new System.Windows.Forms.Label();
      this.lblKeterangan = new System.Windows.Forms.Label();
      this.txtHobby = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblNama
      // 
      this.lblNama.Location = new System.Drawing.Point(12, 9);
      this.lblNama.Name = "lblNama";
      this.lblNama.Size = new System.Drawing.Size(100, 23);
      this.lblNama.TabIndex = 0;
      this.lblNama.Text = "Nama Anda ? ";
      this.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtNama
      // 
      this.txtNama.Location = new System.Drawing.Point(12, 35);
      this.txtNama.Name = "txtNama";
      this.txtNama.Size = new System.Drawing.Size(244, 20);
      this.txtNama.TabIndex = 0;
      this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
      this.txtNama.Enter += new System.EventHandler(this.txtNama_Enter);
      this.txtNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNama_KeyDown);
      this.txtNama.Leave += new System.EventHandler(this.txtNama_Leave);
      // 
      // lblUmur
      // 
      this.lblUmur.Location = new System.Drawing.Point(12, 76);
      this.lblUmur.Name = "lblUmur";
      this.lblUmur.Size = new System.Drawing.Size(57, 23);
      this.lblUmur.TabIndex = 2;
      this.lblUmur.Text = "Umur ? ";
      this.lblUmur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtUmur
      // 
      this.txtUmur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtUmur.Location = new System.Drawing.Point(12, 102);
      this.txtUmur.MaxLength = 3;
      this.txtUmur.Name = "txtUmur";
      this.txtUmur.Size = new System.Drawing.Size(77, 20);
      this.txtUmur.TabIndex = 1;
      this.txtUmur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtUmur.TextChanged += new System.EventHandler(this.txtUmur_TextChanged);
      this.txtUmur.Enter += new System.EventHandler(this.txtUmur_Enter);
      this.txtUmur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUmur_KeyDown);
      this.txtUmur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUmur_KeyPress);
      this.txtUmur.Leave += new System.EventHandler(this.txtUmur_Leave);
      // 
      // lblCount
      // 
      this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCount.Location = new System.Drawing.Point(199, 9);
      this.lblCount.Name = "lblCount";
      this.lblCount.Size = new System.Drawing.Size(57, 23);
      this.lblCount.TabIndex = 3;
      this.lblCount.Text = "{ count }";
      this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblKeterangan
      // 
      this.lblKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblKeterangan.Location = new System.Drawing.Point(95, 101);
      this.lblKeterangan.Name = "lblKeterangan";
      this.lblKeterangan.Size = new System.Drawing.Size(161, 23);
      this.lblKeterangan.TabIndex = 4;
      this.lblKeterangan.Text = "{ keterangan umur }";
      this.lblKeterangan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtHobby
      // 
      this.txtHobby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtHobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtHobby.ForeColor = System.Drawing.Color.Silver;
      this.txtHobby.Location = new System.Drawing.Point(15, 171);
      this.txtHobby.MaxLength = 100;
      this.txtHobby.Name = "txtHobby";
      this.txtHobby.Size = new System.Drawing.Size(241, 20);
      this.txtHobby.TabIndex = 5;
      this.txtHobby.Text = "hobby anda";
      this.txtHobby.Enter += new System.EventHandler(this.txtHobby_Enter);
      this.txtHobby.Leave += new System.EventHandler(this.txtHobby_Leave);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(15, 145);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 23);
      this.label1.TabIndex = 6;
      this.label1.Text = "Hobby ? ";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // FrmDemoTextBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(270, 205);
      this.Controls.Add(this.txtHobby);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblKeterangan);
      this.Controls.Add(this.lblCount);
      this.Controls.Add(this.txtUmur);
      this.Controls.Add(this.lblUmur);
      this.Controls.Add(this.txtNama);
      this.Controls.Add(this.lblNama);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoTextBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo TextBox";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblNama;
    private System.Windows.Forms.TextBox txtNama;
    private System.Windows.Forms.Label lblUmur;
    private System.Windows.Forms.TextBox txtUmur;
    private System.Windows.Forms.Label lblCount;
    private System.Windows.Forms.Label lblKeterangan;
    private System.Windows.Forms.TextBox txtHobby;
    private System.Windows.Forms.Label label1;
  }
}