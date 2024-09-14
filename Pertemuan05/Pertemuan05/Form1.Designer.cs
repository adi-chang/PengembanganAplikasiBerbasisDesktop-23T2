namespace Pertemuan05
{
  partial class Form1
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
      this.chkMonitor = new System.Windows.Forms.CheckBox();
      this.chkPrinter = new System.Windows.Forms.CheckBox();
      this.chkProcessor = new System.Windows.Forms.CheckBox();
      this.chkMouse = new System.Windows.Forms.CheckBox();
      this.chkKeyboard = new System.Windows.Forms.CheckBox();
      this.chkSpeaker = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lblTotal = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // chkMonitor
      // 
      this.chkMonitor.AutoSize = true;
      this.chkMonitor.Location = new System.Drawing.Point(12, 16);
      this.chkMonitor.Name = "chkMonitor";
      this.chkMonitor.Size = new System.Drawing.Size(135, 17);
      this.chkMonitor.TabIndex = 0;
      this.chkMonitor.Text = "Monitor (Rp 1.000.000)";
      this.chkMonitor.UseVisualStyleBackColor = true;
      this.chkMonitor.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
      // 
      // chkPrinter
      // 
      this.chkPrinter.AutoSize = true;
      this.chkPrinter.Location = new System.Drawing.Point(12, 47);
      this.chkPrinter.Name = "chkPrinter";
      this.chkPrinter.Size = new System.Drawing.Size(121, 17);
      this.chkPrinter.TabIndex = 1;
      this.chkPrinter.Text = "Printer (Rp 650.000)";
      this.chkPrinter.UseVisualStyleBackColor = true;
      this.chkPrinter.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
      // 
      // chkProcessor
      // 
      this.chkProcessor.AutoSize = true;
      this.chkProcessor.Location = new System.Drawing.Point(12, 78);
      this.chkProcessor.Name = "chkProcessor";
      this.chkProcessor.Size = new System.Drawing.Size(138, 17);
      this.chkProcessor.TabIndex = 2;
      this.chkProcessor.Text = "Processor (Rp 800.000)";
      this.chkProcessor.UseVisualStyleBackColor = true;
      this.chkProcessor.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
      // 
      // chkMouse
      // 
      this.chkMouse.AutoSize = true;
      this.chkMouse.Location = new System.Drawing.Point(12, 109);
      this.chkMouse.Name = "chkMouse";
      this.chkMouse.Size = new System.Drawing.Size(117, 17);
      this.chkMouse.TabIndex = 3;
      this.chkMouse.Text = "Mouse (Rp 70.000)";
      this.chkMouse.UseVisualStyleBackColor = true;
      this.chkMouse.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
      // 
      // chkKeyboard
      // 
      this.chkKeyboard.AutoSize = true;
      this.chkKeyboard.Location = new System.Drawing.Point(12, 140);
      this.chkKeyboard.Name = "chkKeyboard";
      this.chkKeyboard.Size = new System.Drawing.Size(130, 17);
      this.chkKeyboard.TabIndex = 4;
      this.chkKeyboard.Text = "Keyboard (Rp 80.000)";
      this.chkKeyboard.UseVisualStyleBackColor = true;
      this.chkKeyboard.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
      // 
      // chkSpeaker
      // 
      this.chkSpeaker.AutoSize = true;
      this.chkSpeaker.Location = new System.Drawing.Point(12, 171);
      this.chkSpeaker.Name = "chkSpeaker";
      this.chkSpeaker.Size = new System.Drawing.Size(125, 17);
      this.chkSpeaker.TabIndex = 5;
      this.chkSpeaker.Text = "Speaker (Rp 50.000)";
      this.chkSpeaker.UseVisualStyleBackColor = true;
      this.chkSpeaker.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 203);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(181, 23);
      this.label1.TabIndex = 6;
      this.label1.Text = "Total Pemesanan Paket Komputer : ";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblTotal
      // 
      this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblTotal.Location = new System.Drawing.Point(199, 203);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size(122, 23);
      this.lblTotal.TabIndex = 7;
      this.lblTotal.Text = "{ total }";
      this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(331, 235);
      this.Controls.Add(this.lblTotal);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.chkSpeaker);
      this.Controls.Add(this.chkKeyboard);
      this.Controls.Add(this.chkMouse);
      this.Controls.Add(this.chkProcessor);
      this.Controls.Add(this.chkPrinter);
      this.Controls.Add(this.chkMonitor);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Daftar Paket Komputer";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox chkMonitor;
    private System.Windows.Forms.CheckBox chkPrinter;
    private System.Windows.Forms.CheckBox chkProcessor;
    private System.Windows.Forms.CheckBox chkMouse;
    private System.Windows.Forms.CheckBox chkKeyboard;
    private System.Windows.Forms.CheckBox chkSpeaker;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblTotal;
  }
}

