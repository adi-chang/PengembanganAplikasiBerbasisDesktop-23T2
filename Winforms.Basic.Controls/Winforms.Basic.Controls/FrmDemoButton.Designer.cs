namespace Winforms.Basic.Controls
{
  partial class FrmDemoButton
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
      this.btnClickMe = new System.Windows.Forms.Button();
      this.lblCount = new System.Windows.Forms.Label();
      this.txtNama = new System.Windows.Forms.TextBox();
      this.lblNama = new System.Windows.Forms.Label();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.SuspendLayout();
      // 
      // btnClickMe
      // 
      this.btnClickMe.Location = new System.Drawing.Point(181, 74);
      this.btnClickMe.Name = "btnClickMe";
      this.btnClickMe.Size = new System.Drawing.Size(75, 23);
      this.btnClickMe.TabIndex = 1;
      this.btnClickMe.Text = "Click Me !!!";
      this.toolTip1.SetToolTip(this.btnClickMe, "Click Me !!!");
      this.btnClickMe.UseVisualStyleBackColor = true;
      this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
      this.btnClickMe.MouseEnter += new System.EventHandler(this.btnClickMe_MouseEnter);
      this.btnClickMe.MouseLeave += new System.EventHandler(this.btnClickMe_MouseLeave);
      // 
      // lblCount
      // 
      this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCount.Location = new System.Drawing.Point(199, 18);
      this.lblCount.Name = "lblCount";
      this.lblCount.Size = new System.Drawing.Size(57, 23);
      this.lblCount.TabIndex = 6;
      this.lblCount.Text = "{ count }";
      this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.toolTip1.SetToolTip(this.lblCount, "Banyak Karakter Nama Anda");
      // 
      // txtNama
      // 
      this.txtNama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNama.Location = new System.Drawing.Point(12, 44);
      this.txtNama.Name = "txtNama";
      this.txtNama.Size = new System.Drawing.Size(244, 20);
      this.txtNama.TabIndex = 0;
      this.toolTip1.SetToolTip(this.txtNama, "Input Nama Anda ");
      this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
      this.txtNama.Enter += new System.EventHandler(this.txtNama_Enter);
      this.txtNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNama_KeyDown);
      this.txtNama.Leave += new System.EventHandler(this.txtNama_Leave);
      // 
      // lblNama
      // 
      this.lblNama.Location = new System.Drawing.Point(12, 18);
      this.lblNama.Name = "lblNama";
      this.lblNama.Size = new System.Drawing.Size(100, 23);
      this.lblNama.TabIndex = 5;
      this.lblNama.Text = "Nama Anda ? ";
      this.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // toolTip1
      // 
      this.toolTip1.IsBalloon = true;
      // 
      // FrmDemoButton
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(267, 109);
      this.Controls.Add(this.lblCount);
      this.Controls.Add(this.txtNama);
      this.Controls.Add(this.lblNama);
      this.Controls.Add(this.btnClickMe);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoButton";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo Button";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnClickMe;
    private System.Windows.Forms.Label lblCount;
    private System.Windows.Forms.TextBox txtNama;
    private System.Windows.Forms.Label lblNama;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}