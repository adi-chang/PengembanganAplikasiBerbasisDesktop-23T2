namespace Winforms.Basic.Controls
{
  partial class FrmDemoComboBox
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
      this.cbo1 = new System.Windows.Forms.ComboBox();
      this.lbl1 = new System.Windows.Forms.Label();
      this.lbl2 = new System.Windows.Forms.Label();
      this.cbo2 = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.lbl3 = new System.Windows.Forms.Label();
      this.cbo3 = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.lbl4 = new System.Windows.Forms.Label();
      this.cbo4 = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(175, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nama Hewan [ DropDownList ]";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cbo1
      // 
      this.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbo1.FormattingEnabled = true;
      this.cbo1.Items.AddRange(new object[] {
            "",
            "Ayam",
            "Beruang",
            "Gajah",
            "Harimau",
            "Ikan",
            "Kura-Kura",
            "Semut",
            "Singa"});
      this.cbo1.Location = new System.Drawing.Point(12, 42);
      this.cbo1.Name = "cbo1";
      this.cbo1.Size = new System.Drawing.Size(175, 21);
      this.cbo1.Sorted = true;
      this.cbo1.TabIndex = 1;
      this.cbo1.SelectedIndexChanged += new System.EventHandler(this.cbo1_SelectedIndexChanged);
      // 
      // lbl1
      // 
      this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbl1.Location = new System.Drawing.Point(193, 40);
      this.lbl1.Name = "lbl1";
      this.lbl1.Size = new System.Drawing.Size(175, 23);
      this.lbl1.TabIndex = 2;
      this.lbl1.Text = "{ item yang dipilih }";
      this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl2
      // 
      this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbl2.Location = new System.Drawing.Point(193, 106);
      this.lbl2.Name = "lbl2";
      this.lbl2.Size = new System.Drawing.Size(175, 23);
      this.lbl2.TabIndex = 5;
      this.lbl2.Text = "{ item yang dipilih }";
      this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cbo2
      // 
      this.cbo2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cbo2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cbo2.FormattingEnabled = true;
      this.cbo2.Items.AddRange(new object[] {
            "",
            "Ayam",
            "Beruang",
            "Gajah",
            "Harimau",
            "Ikan",
            "Kura-Kura",
            "Semut",
            "Singa"});
      this.cbo2.Location = new System.Drawing.Point(12, 108);
      this.cbo2.Name = "cbo2";
      this.cbo2.Size = new System.Drawing.Size(175, 21);
      this.cbo2.Sorted = true;
      this.cbo2.TabIndex = 4;
      this.cbo2.SelectedIndexChanged += new System.EventHandler(this.cbo2_SelectedIndexChanged);
      this.cbo2.Enter += new System.EventHandler(this.cbo2_Enter);
      this.cbo2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo2_KeyDown);
      this.cbo2.Leave += new System.EventHandler(this.cbo2_Leave);
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(12, 82);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(356, 23);
      this.label4.TabIndex = 3;
      this.label4.Text = "Nama Hewan [ DropDown - AutoComplete ]";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl3
      // 
      this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbl3.Location = new System.Drawing.Point(193, 176);
      this.lbl3.Name = "lbl3";
      this.lbl3.Size = new System.Drawing.Size(175, 23);
      this.lbl3.TabIndex = 8;
      this.lbl3.Text = "{ item yang dipilih }";
      this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cbo3
      // 
      this.cbo3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cbo3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cbo3.FormattingEnabled = true;
      this.cbo3.Location = new System.Drawing.Point(12, 178);
      this.cbo3.Name = "cbo3";
      this.cbo3.Size = new System.Drawing.Size(175, 21);
      this.cbo3.Sorted = true;
      this.cbo3.TabIndex = 7;
      this.cbo3.SelectedIndexChanged += new System.EventHandler(this.cbo3_SelectedIndexChanged);
      this.cbo3.Enter += new System.EventHandler(this.cbo2_Enter);
      this.cbo3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo2_KeyDown);
      this.cbo3.Leave += new System.EventHandler(this.cbo2_Leave);
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(12, 152);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(356, 23);
      this.label3.TabIndex = 6;
      this.label3.Text = "Nama Hewan [ AddRange - AutoComplete ]";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl4
      // 
      this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbl4.Location = new System.Drawing.Point(193, 243);
      this.lbl4.Name = "lbl4";
      this.lbl4.Size = new System.Drawing.Size(175, 23);
      this.lbl4.TabIndex = 11;
      this.lbl4.Text = "{ item yang dipilih }";
      this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cbo4
      // 
      this.cbo4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cbo4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cbo4.FormattingEnabled = true;
      this.cbo4.Location = new System.Drawing.Point(12, 245);
      this.cbo4.Name = "cbo4";
      this.cbo4.Size = new System.Drawing.Size(175, 21);
      this.cbo4.Sorted = true;
      this.cbo4.TabIndex = 10;
      this.cbo4.SelectedIndexChanged += new System.EventHandler(this.cbo4_SelectedIndexChanged);
      this.cbo4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo4_KeyDown);
      this.cbo4.Leave += new System.EventHandler(this.cbo4_Leave);
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(12, 219);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(356, 23);
      this.label5.TabIndex = 9;
      this.label5.Text = "Nama Hewan [ AddRange - AutoComplete ]";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // FrmDemoComboBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 281);
      this.Controls.Add(this.lbl4);
      this.Controls.Add(this.cbo4);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.lbl3);
      this.Controls.Add(this.cbo3);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lbl2);
      this.Controls.Add(this.cbo2);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.lbl1);
      this.Controls.Add(this.cbo1);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoComboBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo ComboBox";
      this.Load += new System.EventHandler(this.FrmDemoComboBox_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbo1;
    private System.Windows.Forms.Label lbl1;
    private System.Windows.Forms.Label lbl2;
    private System.Windows.Forms.ComboBox cbo2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lbl3;
    private System.Windows.Forms.ComboBox cbo3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lbl4;
    private System.Windows.Forms.ComboBox cbo4;
    private System.Windows.Forms.Label label5;
  }
}