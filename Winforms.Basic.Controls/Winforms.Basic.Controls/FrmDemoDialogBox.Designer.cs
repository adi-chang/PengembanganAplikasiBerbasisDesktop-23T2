namespace Winforms.Basic.Controls
{
  partial class FrmDemoDialogBox
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
      this.btnOpen = new System.Windows.Forms.Button();
      this.lstData = new System.Windows.Forms.ListBox();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.btnChooseColor = new System.Windows.Forms.Button();
      this.lblColor = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnOpen
      // 
      this.btnOpen.Location = new System.Drawing.Point(12, 12);
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(103, 23);
      this.btnOpen.TabIndex = 0;
      this.btnOpen.Text = "Open File Dialog ";
      this.btnOpen.UseVisualStyleBackColor = true;
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // lstData
      // 
      this.lstData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lstData.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstData.FormattingEnabled = true;
      this.lstData.ItemHeight = 15;
      this.lstData.Location = new System.Drawing.Point(12, 38);
      this.lstData.Name = "lstData";
      this.lstData.Size = new System.Drawing.Size(515, 212);
      this.lstData.TabIndex = 1;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Filter = "PDF File (*.pdf)|*.pdf";
      this.openFileDialog1.Multiselect = true;
      // 
      // btnChooseColor
      // 
      this.btnChooseColor.Location = new System.Drawing.Point(12, 272);
      this.btnChooseColor.Name = "btnChooseColor";
      this.btnChooseColor.Size = new System.Drawing.Size(103, 23);
      this.btnChooseColor.TabIndex = 2;
      this.btnChooseColor.Text = "Choose Color";
      this.btnChooseColor.UseVisualStyleBackColor = true;
      this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
      // 
      // lblColor
      // 
      this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblColor.Location = new System.Drawing.Point(12, 298);
      this.lblColor.Name = "lblColor";
      this.lblColor.Size = new System.Drawing.Size(178, 136);
      this.lblColor.TabIndex = 3;
      this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // FrmDemoDialogBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(539, 443);
      this.Controls.Add(this.lblColor);
      this.Controls.Add(this.btnChooseColor);
      this.Controls.Add(this.lstData);
      this.Controls.Add(this.btnOpen);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoDialogBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo DialogBox";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnOpen;
    private System.Windows.Forms.ListBox lstData;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Button btnChooseColor;
    private System.Windows.Forms.Label lblColor;
  }
}