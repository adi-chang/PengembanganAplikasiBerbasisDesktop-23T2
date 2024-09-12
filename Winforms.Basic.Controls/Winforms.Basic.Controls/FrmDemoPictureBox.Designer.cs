namespace Winforms.Basic.Controls
{
  partial class FrmDemoPictureBox
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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.cboSizeMode = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox1.Image = global::Winforms.Basic.Controls.Properties.Resources.No_image_available_svg;
      this.pictureBox1.InitialImage = null;
      this.pictureBox1.Location = new System.Drawing.Point(12, 41);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(600, 388);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(100, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Choose Picture";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.Location = new System.Drawing.Point(388, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 23);
      this.label1.TabIndex = 2;
      this.label1.Text = "Picture Size Mode";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cboSizeMode
      // 
      this.cboSizeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cboSizeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboSizeMode.FormattingEnabled = true;
      this.cboSizeMode.Items.AddRange(new object[] {
            "Normal",
            "StretchImage",
            "CenterImage",
            "Zoom"});
      this.cboSizeMode.Location = new System.Drawing.Point(491, 12);
      this.cboSizeMode.Name = "cboSizeMode";
      this.cboSizeMode.Size = new System.Drawing.Size(121, 21);
      this.cboSizeMode.TabIndex = 3;
      this.cboSizeMode.SelectedIndexChanged += new System.EventHandler(this.cboSizeMode_SelectedIndexChanged);
      // 
      // FrmDemoPictureBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(624, 441);
      this.Controls.Add(this.cboSizeMode);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pictureBox1);
      this.KeyPreview = true;
      this.Name = "FrmDemoPictureBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo PictureBox";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cboSizeMode;
  }
}