namespace Pertemuan05
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
      this.grpPaket = new System.Windows.Forms.GroupBox();
      this.chkReading = new System.Windows.Forms.CheckBox();
      this.chkWriting = new System.Windows.Forms.CheckBox();
      this.chkListening = new System.Windows.Forms.CheckBox();
      this.chkSpeaking = new System.Windows.Forms.CheckBox();
      this.lblReading = new System.Windows.Forms.Label();
      this.lblWriting = new System.Windows.Forms.Label();
      this.lblListening = new System.Windows.Forms.Label();
      this.lblSpeaking = new System.Windows.Forms.Label();
      this.lblTotal = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.grpPaket.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpPaket
      // 
      this.grpPaket.Controls.Add(this.lblSpeaking);
      this.grpPaket.Controls.Add(this.lblListening);
      this.grpPaket.Controls.Add(this.lblWriting);
      this.grpPaket.Controls.Add(this.lblReading);
      this.grpPaket.Controls.Add(this.chkSpeaking);
      this.grpPaket.Controls.Add(this.chkListening);
      this.grpPaket.Controls.Add(this.chkWriting);
      this.grpPaket.Controls.Add(this.chkReading);
      this.grpPaket.Location = new System.Drawing.Point(12, 12);
      this.grpPaket.Name = "grpPaket";
      this.grpPaket.Size = new System.Drawing.Size(335, 161);
      this.grpPaket.TabIndex = 0;
      this.grpPaket.TabStop = false;
      this.grpPaket.Text = "Paket";
      // 
      // chkReading
      // 
      this.chkReading.AutoSize = true;
      this.chkReading.Location = new System.Drawing.Point(21, 30);
      this.chkReading.Name = "chkReading";
      this.chkReading.Size = new System.Drawing.Size(131, 17);
      this.chkReading.TabIndex = 0;
      this.chkReading.Text = "Reading (Rp 125.000)";
      this.chkReading.UseVisualStyleBackColor = true;
      this.chkReading.CheckedChanged += new System.EventHandler(this.Tick_UnTick_CheckBox);
      // 
      // chkWriting
      // 
      this.chkWriting.AutoSize = true;
      this.chkWriting.Location = new System.Drawing.Point(21, 61);
      this.chkWriting.Name = "chkWriting";
      this.chkWriting.Size = new System.Drawing.Size(124, 17);
      this.chkWriting.TabIndex = 1;
      this.chkWriting.Text = "Writing (Rp 150.000)";
      this.chkWriting.UseVisualStyleBackColor = true;
      this.chkWriting.CheckedChanged += new System.EventHandler(this.Tick_UnTick_CheckBox);
      // 
      // chkListening
      // 
      this.chkListening.AutoSize = true;
      this.chkListening.Location = new System.Drawing.Point(21, 92);
      this.chkListening.Name = "chkListening";
      this.chkListening.Size = new System.Drawing.Size(133, 17);
      this.chkListening.TabIndex = 2;
      this.chkListening.Text = "Listening (Rp 175.000)";
      this.chkListening.UseVisualStyleBackColor = true;
      this.chkListening.CheckedChanged += new System.EventHandler(this.Tick_UnTick_CheckBox);
      // 
      // chkSpeaking
      // 
      this.chkSpeaking.AutoSize = true;
      this.chkSpeaking.Location = new System.Drawing.Point(21, 123);
      this.chkSpeaking.Name = "chkSpeaking";
      this.chkSpeaking.Size = new System.Drawing.Size(136, 17);
      this.chkSpeaking.TabIndex = 3;
      this.chkSpeaking.Text = "Speaking (Rp 200.000)";
      this.chkSpeaking.UseVisualStyleBackColor = true;
      this.chkSpeaking.CheckedChanged += new System.EventHandler(this.Tick_UnTick_CheckBox);
      // 
      // lblReading
      // 
      this.lblReading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblReading.Location = new System.Drawing.Point(196, 26);
      this.lblReading.Name = "lblReading";
      this.lblReading.Size = new System.Drawing.Size(122, 23);
      this.lblReading.TabIndex = 8;
      this.lblReading.Text = "Rp 0";
      this.lblReading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblWriting
      // 
      this.lblWriting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblWriting.Location = new System.Drawing.Point(196, 57);
      this.lblWriting.Name = "lblWriting";
      this.lblWriting.Size = new System.Drawing.Size(122, 23);
      this.lblWriting.TabIndex = 9;
      this.lblWriting.Text = "Rp 0";
      this.lblWriting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblListening
      // 
      this.lblListening.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblListening.Location = new System.Drawing.Point(196, 88);
      this.lblListening.Name = "lblListening";
      this.lblListening.Size = new System.Drawing.Size(122, 23);
      this.lblListening.TabIndex = 10;
      this.lblListening.Text = "Rp 0";
      this.lblListening.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblSpeaking
      // 
      this.lblSpeaking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblSpeaking.Location = new System.Drawing.Point(196, 119);
      this.lblSpeaking.Name = "lblSpeaking";
      this.lblSpeaking.Size = new System.Drawing.Size(122, 23);
      this.lblSpeaking.TabIndex = 11;
      this.lblSpeaking.Text = "Rp 0";
      this.lblSpeaking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblTotal
      // 
      this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTotal.Location = new System.Drawing.Point(208, 186);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size(122, 23);
      this.lblTotal.TabIndex = 9;
      this.lblTotal.Text = "Rp 0";
      this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(21, 186);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(181, 23);
      this.label5.TabIndex = 8;
      this.label5.Text = "Total";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(361, 223);
      this.Controls.Add(this.lblTotal);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.grpPaket);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Kursus Inggris";
      this.grpPaket.ResumeLayout(false);
      this.grpPaket.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox grpPaket;
    private System.Windows.Forms.CheckBox chkSpeaking;
    private System.Windows.Forms.CheckBox chkListening;
    private System.Windows.Forms.CheckBox chkWriting;
    private System.Windows.Forms.CheckBox chkReading;
    private System.Windows.Forms.Label lblSpeaking;
    private System.Windows.Forms.Label lblListening;
    private System.Windows.Forms.Label lblWriting;
    private System.Windows.Forms.Label lblReading;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.Label label5;
  }
}