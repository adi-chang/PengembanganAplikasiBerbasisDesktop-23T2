namespace Pertemuan_07
{
  partial class FrmColoring
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
      this.lblColor = new System.Windows.Forms.Label();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.pickColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cboKnownColor = new System.Windows.Forms.ComboBox();
      this.hsbRed = new System.Windows.Forms.HScrollBar();
      this.lblRedValue = new System.Windows.Forms.Label();
      this.lblGreenValue = new System.Windows.Forms.Label();
      this.hsbGreen = new System.Windows.Forms.HScrollBar();
      this.label6 = new System.Windows.Forms.Label();
      this.lblBlueValue = new System.Windows.Forms.Label();
      this.hsbBlue = new System.Windows.Forms.HScrollBar();
      this.label8 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cboMyColor = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnAdd = new System.Windows.Forms.Button();
      this.txtColorName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.contextMenuStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblColor
      // 
      this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblColor.ContextMenuStrip = this.contextMenuStrip1;
      this.lblColor.Location = new System.Drawing.Point(12, 16);
      this.lblColor.Name = "lblColor";
      this.lblColor.Size = new System.Drawing.Size(560, 113);
      this.lblColor.TabIndex = 0;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickColorToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(129, 26);
      // 
      // pickColorToolStripMenuItem
      // 
      this.pickColorToolStripMenuItem.Name = "pickColorToolStripMenuItem";
      this.pickColorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
      this.pickColorToolStripMenuItem.Text = "Pick Color";
      this.pickColorToolStripMenuItem.Click += new System.EventHandler(this.pickColorToolStripMenuItem_Click);
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.Location = new System.Drawing.Point(12, 187);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 23);
      this.label2.TabIndex = 1;
      this.label2.Text = "RED";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(12, 142);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(117, 23);
      this.label3.TabIndex = 2;
      this.label3.Text = "System - Known Color";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cboKnownColor
      // 
      this.cboKnownColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboKnownColor.FormattingEnabled = true;
      this.cboKnownColor.Location = new System.Drawing.Point(135, 143);
      this.cboKnownColor.Name = "cboKnownColor";
      this.cboKnownColor.Size = new System.Drawing.Size(250, 21);
      this.cboKnownColor.TabIndex = 5;
      this.cboKnownColor.SelectedIndexChanged += new System.EventHandler(this.cboKnownColor_SelectedIndexChanged);
      // 
      // hsbRed
      // 
      this.hsbRed.Location = new System.Drawing.Point(9, 210);
      this.hsbRed.Maximum = 264;
      this.hsbRed.Name = "hsbRed";
      this.hsbRed.Size = new System.Drawing.Size(490, 23);
      this.hsbRed.TabIndex = 4;
      this.hsbRed.ValueChanged += new System.EventHandler(this.hsbRed_ValueChanged);
      // 
      // lblRedValue
      // 
      this.lblRedValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblRedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRedValue.Location = new System.Drawing.Point(513, 210);
      this.lblRedValue.Name = "lblRedValue";
      this.lblRedValue.Size = new System.Drawing.Size(59, 23);
      this.lblRedValue.TabIndex = 5;
      this.lblRedValue.Text = "0";
      this.lblRedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblGreenValue
      // 
      this.lblGreenValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblGreenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblGreenValue.Location = new System.Drawing.Point(513, 270);
      this.lblGreenValue.Name = "lblGreenValue";
      this.lblGreenValue.Size = new System.Drawing.Size(59, 23);
      this.lblGreenValue.TabIndex = 8;
      this.lblGreenValue.Text = "0";
      this.lblGreenValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // hsbGreen
      // 
      this.hsbGreen.Location = new System.Drawing.Point(9, 270);
      this.hsbGreen.Maximum = 264;
      this.hsbGreen.Name = "hsbGreen";
      this.hsbGreen.Size = new System.Drawing.Size(490, 23);
      this.hsbGreen.TabIndex = 7;
      this.hsbGreen.ValueChanged += new System.EventHandler(this.hsbRed_ValueChanged);
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.Color.Green;
      this.label6.Location = new System.Drawing.Point(12, 247);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(100, 23);
      this.label6.TabIndex = 6;
      this.label6.Text = "GREEN";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblBlueValue
      // 
      this.lblBlueValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblBlueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblBlueValue.Location = new System.Drawing.Point(513, 331);
      this.lblBlueValue.Name = "lblBlueValue";
      this.lblBlueValue.Size = new System.Drawing.Size(59, 23);
      this.lblBlueValue.TabIndex = 11;
      this.lblBlueValue.Text = "0";
      this.lblBlueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // hsbBlue
      // 
      this.hsbBlue.Location = new System.Drawing.Point(9, 331);
      this.hsbBlue.Maximum = 264;
      this.hsbBlue.Name = "hsbBlue";
      this.hsbBlue.Size = new System.Drawing.Size(490, 23);
      this.hsbBlue.TabIndex = 10;
      this.hsbBlue.ValueChanged += new System.EventHandler(this.hsbRed_ValueChanged);
      // 
      // label8
      // 
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.ForeColor = System.Drawing.Color.Blue;
      this.label8.Location = new System.Drawing.Point(12, 308);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(100, 23);
      this.label8.TabIndex = 9;
      this.label8.Text = "BLUE";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.cboMyColor);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.btnAdd);
      this.groupBox1.Controls.Add(this.txtColorName);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(9, 380);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(563, 89);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Save As";
      // 
      // cboMyColor
      // 
      this.cboMyColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboMyColor.FormattingEnabled = true;
      this.cboMyColor.Location = new System.Drawing.Point(84, 55);
      this.cboMyColor.Name = "cboMyColor";
      this.cboMyColor.Size = new System.Drawing.Size(185, 21);
      this.cboMyColor.TabIndex = 7;
      this.cboMyColor.SelectedIndexChanged += new System.EventHandler(this.cboMyColor_SelectedIndexChanged);
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(18, 54);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 23);
      this.label4.TabIndex = 6;
      this.label4.Text = "My Color";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(275, 28);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 23);
      this.btnAdd.TabIndex = 5;
      this.btnAdd.Text = "&Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // txtColorName
      // 
      this.txtColorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtColorName.Location = new System.Drawing.Point(84, 29);
      this.txtColorName.Name = "txtColorName";
      this.txtColorName.Size = new System.Drawing.Size(185, 20);
      this.txtColorName.TabIndex = 4;
      this.txtColorName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtColorName_KeyDown);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(18, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 23);
      this.label1.TabIndex = 3;
      this.label1.Text = "Save As";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // FrmColoring
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(584, 478);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.lblBlueValue);
      this.Controls.Add(this.hsbBlue);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.lblGreenValue);
      this.Controls.Add(this.hsbGreen);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.lblRedValue);
      this.Controls.Add(this.hsbRed);
      this.Controls.Add(this.cboKnownColor);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblColor);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmColoring";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Coloring";
      this.Load += new System.EventHandler(this.FrmColoring_Load);
      this.contextMenuStrip1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblColor;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cboKnownColor;
    private System.Windows.Forms.HScrollBar hsbRed;
    private System.Windows.Forms.Label lblRedValue;
    private System.Windows.Forms.Label lblGreenValue;
    private System.Windows.Forms.HScrollBar hsbGreen;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label lblBlueValue;
    private System.Windows.Forms.HScrollBar hsbBlue;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem pickColorToolStripMenuItem;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtColorName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.ComboBox cboMyColor;
    private System.Windows.Forms.Label label4;
  }
}