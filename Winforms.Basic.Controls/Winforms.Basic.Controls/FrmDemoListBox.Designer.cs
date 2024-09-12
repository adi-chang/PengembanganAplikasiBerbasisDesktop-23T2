namespace Winforms.Basic.Controls
{
  partial class FrmDemoListBox
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
      this.grpPilihan = new System.Windows.Forms.GroupBox();
      this.lstData = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.checkBox5 = new System.Windows.Forms.CheckBox();
      this.checkBox6 = new System.Windows.Forms.CheckBox();
      this.checkBox7 = new System.Windows.Forms.CheckBox();
      this.checkBox8 = new System.Windows.Forms.CheckBox();
      this.checkBox9 = new System.Windows.Forms.CheckBox();
      this.checkBox10 = new System.Windows.Forms.CheckBox();
      this.btnMove = new System.Windows.Forms.Button();
      this.btnInfo = new System.Windows.Forms.Button();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.btnCheckAll = new System.Windows.Forms.Button();
      this.lblItemCount = new System.Windows.Forms.Label();
      this.grpPilihan.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpPilihan
      // 
      this.grpPilihan.ContextMenuStrip = this.contextMenuStrip1;
      this.grpPilihan.Controls.Add(this.btnCheckAll);
      this.grpPilihan.Controls.Add(this.checkBox10);
      this.grpPilihan.Controls.Add(this.checkBox9);
      this.grpPilihan.Controls.Add(this.checkBox8);
      this.grpPilihan.Controls.Add(this.checkBox7);
      this.grpPilihan.Controls.Add(this.checkBox6);
      this.grpPilihan.Controls.Add(this.checkBox5);
      this.grpPilihan.Controls.Add(this.checkBox4);
      this.grpPilihan.Controls.Add(this.checkBox3);
      this.grpPilihan.Controls.Add(this.checkBox2);
      this.grpPilihan.Controls.Add(this.checkBox1);
      this.grpPilihan.Location = new System.Drawing.Point(12, 12);
      this.grpPilihan.Name = "grpPilihan";
      this.grpPilihan.Size = new System.Drawing.Size(138, 270);
      this.grpPilihan.TabIndex = 0;
      this.grpPilihan.TabStop = false;
      this.grpPilihan.Text = "Pilihan";
      // 
      // lstData
      // 
      this.lstData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lstData.ContextMenuStrip = this.contextMenuStrip1;
      this.lstData.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstData.FormattingEnabled = true;
      this.lstData.ItemHeight = 16;
      this.lstData.Location = new System.Drawing.Point(237, 38);
      this.lstData.Name = "lstData";
      this.lstData.Size = new System.Drawing.Size(189, 242);
      this.lstData.Sorted = true;
      this.lstData.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(234, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 23);
      this.label1.TabIndex = 2;
      this.label1.Text = "List Data";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(16, 31);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(49, 17);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "Jane";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      this.checkBox1.MouseEnter += new System.EventHandler(this.checkBox1_MouseEnter);
      this.checkBox1.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new System.Drawing.Point(16, 55);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(54, 17);
      this.checkBox2.TabIndex = 1;
      this.checkBox2.Text = "Robin";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      this.checkBox2.MouseEnter += new System.EventHandler(this.checkBox1_MouseEnter);
      this.checkBox2.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Location = new System.Drawing.Point(16, 78);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(52, 17);
      this.checkBox3.TabIndex = 2;
      this.checkBox3.Text = "Linda";
      this.checkBox3.UseVisualStyleBackColor = true;
      this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      this.checkBox3.MouseEnter += new System.EventHandler(this.checkBox1_MouseEnter);
      this.checkBox3.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);
      // 
      // checkBox4
      // 
      this.checkBox4.AutoSize = true;
      this.checkBox4.Location = new System.Drawing.Point(16, 101);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new System.Drawing.Size(60, 17);
      this.checkBox4.TabIndex = 3;
      this.checkBox4.Text = "Candra";
      this.checkBox4.UseVisualStyleBackColor = true;
      this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      this.checkBox4.MouseEnter += new System.EventHandler(this.checkBox1_MouseEnter);
      this.checkBox4.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);
      // 
      // checkBox5
      // 
      this.checkBox5.AutoSize = true;
      this.checkBox5.Location = new System.Drawing.Point(16, 124);
      this.checkBox5.Name = "checkBox5";
      this.checkBox5.Size = new System.Drawing.Size(67, 17);
      this.checkBox5.TabIndex = 4;
      this.checkBox5.Text = "Budiman";
      this.checkBox5.UseVisualStyleBackColor = true;
      this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      this.checkBox5.MouseEnter += new System.EventHandler(this.checkBox1_MouseEnter);
      this.checkBox5.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);
      // 
      // checkBox6
      // 
      this.checkBox6.AutoSize = true;
      this.checkBox6.Location = new System.Drawing.Point(16, 147);
      this.checkBox6.Name = "checkBox6";
      this.checkBox6.Size = new System.Drawing.Size(56, 17);
      this.checkBox6.TabIndex = 5;
      this.checkBox6.Text = "Daniel";
      this.checkBox6.UseVisualStyleBackColor = true;
      this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      this.checkBox6.MouseEnter += new System.EventHandler(this.checkBox1_MouseEnter);
      this.checkBox6.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);
      // 
      // checkBox7
      // 
      this.checkBox7.AutoSize = true;
      this.checkBox7.Location = new System.Drawing.Point(16, 170);
      this.checkBox7.Name = "checkBox7";
      this.checkBox7.Size = new System.Drawing.Size(48, 17);
      this.checkBox7.TabIndex = 6;
      this.checkBox7.Text = "Kelly";
      this.checkBox7.UseVisualStyleBackColor = true;
      this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      this.checkBox7.MouseEnter += new System.EventHandler(this.checkBox1_MouseEnter);
      this.checkBox7.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);
      // 
      // checkBox8
      // 
      this.checkBox8.AutoSize = true;
      this.checkBox8.Location = new System.Drawing.Point(16, 193);
      this.checkBox8.Name = "checkBox8";
      this.checkBox8.Size = new System.Drawing.Size(51, 17);
      this.checkBox8.TabIndex = 7;
      this.checkBox8.Text = "Peter";
      this.checkBox8.UseVisualStyleBackColor = true;
      this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      this.checkBox8.MouseEnter += new System.EventHandler(this.checkBox1_MouseEnter);
      this.checkBox8.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);
      // 
      // checkBox9
      // 
      this.checkBox9.AutoSize = true;
      this.checkBox9.Location = new System.Drawing.Point(16, 216);
      this.checkBox9.Name = "checkBox9";
      this.checkBox9.Size = new System.Drawing.Size(47, 17);
      this.checkBox9.TabIndex = 8;
      this.checkBox9.Text = "Tina";
      this.checkBox9.UseVisualStyleBackColor = true;
      this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      this.checkBox9.MouseEnter += new System.EventHandler(this.checkBox1_MouseEnter);
      this.checkBox9.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);
      // 
      // checkBox10
      // 
      this.checkBox10.AutoSize = true;
      this.checkBox10.Location = new System.Drawing.Point(16, 239);
      this.checkBox10.Name = "checkBox10";
      this.checkBox10.Size = new System.Drawing.Size(56, 17);
      this.checkBox10.TabIndex = 9;
      this.checkBox10.Text = "Susan";
      this.checkBox10.UseVisualStyleBackColor = true;
      this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      this.checkBox10.MouseEnter += new System.EventHandler(this.checkBox1_MouseEnter);
      this.checkBox10.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);
      // 
      // btnMove
      // 
      this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMove.Location = new System.Drawing.Point(156, 39);
      this.btnMove.Name = "btnMove";
      this.btnMove.Size = new System.Drawing.Size(75, 23);
      this.btnMove.TabIndex = 3;
      this.btnMove.Text = ">>>";
      this.btnMove.UseVisualStyleBackColor = true;
      this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
      // 
      // btnInfo
      // 
      this.btnInfo.Location = new System.Drawing.Point(432, 37);
      this.btnInfo.Name = "btnInfo";
      this.btnInfo.Size = new System.Drawing.Size(75, 23);
      this.btnInfo.TabIndex = 4;
      this.btnInfo.Text = "&Info";
      this.btnInfo.UseVisualStyleBackColor = true;
      this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
      // 
      // clearAllToolStripMenuItem
      // 
      this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
      this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
      this.clearAllToolStripMenuItem.Text = "Clear All";
      this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
      // 
      // btnCheckAll
      // 
      this.btnCheckAll.Location = new System.Drawing.Point(111, 19);
      this.btnCheckAll.Name = "btnCheckAll";
      this.btnCheckAll.Size = new System.Drawing.Size(21, 23);
      this.btnCheckAll.TabIndex = 10;
      this.btnCheckAll.Text = "V";
      this.btnCheckAll.UseVisualStyleBackColor = true;
      this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
      // 
      // lblItemCount
      // 
      this.lblItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblItemCount.Location = new System.Drawing.Point(326, 12);
      this.lblItemCount.Name = "lblItemCount";
      this.lblItemCount.Size = new System.Drawing.Size(100, 23);
      this.lblItemCount.TabIndex = 6;
      this.lblItemCount.Text = "{ item count }";
      this.lblItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // FrmDemoListBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(520, 295);
      this.Controls.Add(this.lblItemCount);
      this.Controls.Add(this.btnInfo);
      this.Controls.Add(this.btnMove);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lstData);
      this.Controls.Add(this.grpPilihan);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoListBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo ListBox";
      this.grpPilihan.ResumeLayout(false);
      this.grpPilihan.PerformLayout();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox grpPilihan;
    private System.Windows.Forms.CheckBox checkBox10;
    private System.Windows.Forms.CheckBox checkBox9;
    private System.Windows.Forms.CheckBox checkBox8;
    private System.Windows.Forms.CheckBox checkBox7;
    private System.Windows.Forms.CheckBox checkBox6;
    private System.Windows.Forms.CheckBox checkBox5;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.ListBox lstData;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnMove;
    private System.Windows.Forms.Button btnInfo;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
    private System.Windows.Forms.Button btnCheckAll;
    private System.Windows.Forms.Label lblItemCount;
  }
}