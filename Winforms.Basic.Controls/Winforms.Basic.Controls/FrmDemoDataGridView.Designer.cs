namespace Winforms.Basic.Controls
{
  partial class FrmDemoDataGridView
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dgv1 = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.dgv2 = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label3 = new System.Windows.Forms.Label();
      this.dgv3 = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblCount1 = new System.Windows.Forms.Label();
      this.lblCount2 = new System.Windows.Forms.Label();
      this.lblCount3 = new System.Windows.Forms.Label();
      this.lblCount4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.dgv4 = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dgv5 = new Winforms.Basic.Controls.MyDataGridView();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label6 = new System.Windows.Forms.Label();
      this.lblCount5 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv5)).BeginInit();
      this.SuspendLayout();
      // 
      // dgv1
      // 
      this.dgv1.AllowUserToAddRows = false;
      this.dgv1.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
      this.dgv1.Location = new System.Drawing.Point(12, 42);
      this.dgv1.MultiSelect = false;
      this.dgv1.Name = "dgv1";
      this.dgv1.ReadOnly = true;
      this.dgv1.Size = new System.Drawing.Size(391, 160);
      this.dgv1.TabIndex = 0;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Nim";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Nama";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 200;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(320, 23);
      this.label1.TabIndex = 1;
      this.label1.Text = "Tambah Item Via Looping - UnBound";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(409, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(320, 23);
      this.label2.TabIndex = 3;
      this.label2.Text = "Data Binding";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // dgv2
      // 
      this.dgv2.AllowUserToAddRows = false;
      this.dgv2.AllowUserToDeleteRows = false;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.dgv2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
      this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.dgv2.Location = new System.Drawing.Point(409, 42);
      this.dgv2.MultiSelect = false;
      this.dgv2.Name = "dgv2";
      this.dgv2.ReadOnly = true;
      this.dgv2.Size = new System.Drawing.Size(391, 160);
      this.dgv2.TabIndex = 2;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "Nim";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.HeaderText = "Nama";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Width = 200;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(15, 229);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(320, 23);
      this.label3.TabIndex = 5;
      this.label3.Text = "Manual - UnBound";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // dgv3
      // 
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.dgv3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
      this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
      this.dgv3.Location = new System.Drawing.Point(15, 255);
      this.dgv3.MultiSelect = false;
      this.dgv3.Name = "dgv3";
      this.dgv3.Size = new System.Drawing.Size(391, 160);
      this.dgv3.TabIndex = 4;
      this.dgv3.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv3_CellEndEdit);
      this.dgv3.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv3_EditingControlShowing);
      this.dgv3.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv3_RowsAdded);
      this.dgv3.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv3_RowsRemoved);
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.HeaderText = "Nim";
      this.dataGridViewTextBoxColumn3.MaxInputLength = 4;
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.HeaderText = "Nama";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.Width = 200;
      // 
      // lblCount1
      // 
      this.lblCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCount1.Location = new System.Drawing.Point(324, 16);
      this.lblCount1.Name = "lblCount1";
      this.lblCount1.Size = new System.Drawing.Size(79, 23);
      this.lblCount1.TabIndex = 6;
      this.lblCount1.Text = "{ count }";
      this.lblCount1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblCount2
      // 
      this.lblCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCount2.Location = new System.Drawing.Point(721, 16);
      this.lblCount2.Name = "lblCount2";
      this.lblCount2.Size = new System.Drawing.Size(79, 23);
      this.lblCount2.TabIndex = 7;
      this.lblCount2.Text = "{ count }";
      this.lblCount2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblCount3
      // 
      this.lblCount3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCount3.Location = new System.Drawing.Point(327, 229);
      this.lblCount3.Name = "lblCount3";
      this.lblCount3.Size = new System.Drawing.Size(79, 23);
      this.lblCount3.TabIndex = 8;
      this.lblCount3.Text = "{ count }";
      this.lblCount3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblCount4
      // 
      this.lblCount4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCount4.Location = new System.Drawing.Point(724, 229);
      this.lblCount4.Name = "lblCount4";
      this.lblCount4.Size = new System.Drawing.Size(79, 23);
      this.lblCount4.TabIndex = 11;
      this.lblCount4.Text = "{ count }";
      this.lblCount4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(412, 229);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(320, 23);
      this.label5.TabIndex = 10;
      this.label5.Text = "Tambah Item Via AddRange Method - UnBound";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // dgv4
      // 
      this.dgv4.AllowUserToAddRows = false;
      this.dgv4.AllowUserToDeleteRows = false;
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.dgv4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
      this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
      this.dgv4.Location = new System.Drawing.Point(412, 255);
      this.dgv4.MultiSelect = false;
      this.dgv4.Name = "dgv4";
      this.dgv4.ReadOnly = true;
      this.dgv4.Size = new System.Drawing.Size(391, 160);
      this.dgv4.TabIndex = 9;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.HeaderText = "Nim";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.HeaderText = "Nama";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      this.dataGridViewTextBoxColumn6.Width = 200;
      // 
      // dgv5
      // 
      dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.dgv5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
      this.dgv5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
      this.dgv5.Location = new System.Drawing.Point(15, 454);
      this.dgv5.MultiSelect = false;
      this.dgv5.Name = "dgv5";
      this.dgv5.Size = new System.Drawing.Size(476, 150);
      this.dgv5.TabIndex = 12;
      this.dgv5.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv5_CellEndEdit);
      this.dgv5.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv5_EditingControlShowing);
      this.dgv5.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv5_RowsAdded);
      this.dgv5.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv5_RowsRemoved);
      // 
      // Column3
      // 
      this.Column3.HeaderText = "Nim";
      this.Column3.MaxInputLength = 4;
      this.Column3.Name = "Column3";
      // 
      // Column4
      // 
      this.Column4.HeaderText = "Nama";
      this.Column4.Name = "Column4";
      this.Column4.Width = 200;
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(15, 428);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(391, 23);
      this.label6.TabIndex = 13;
      this.label6.Text = "Custom - Manual - UnBound - Simulate Enter Key As Tab Key";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblCount5
      // 
      this.lblCount5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCount5.Location = new System.Drawing.Point(412, 428);
      this.lblCount5.Name = "lblCount5";
      this.lblCount5.Size = new System.Drawing.Size(79, 23);
      this.lblCount5.TabIndex = 14;
      this.lblCount5.Text = "{ count }";
      this.lblCount5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // FrmDemoDataGridView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(815, 616);
      this.Controls.Add(this.lblCount5);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.dgv5);
      this.Controls.Add(this.lblCount4);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.dgv4);
      this.Controls.Add(this.lblCount3);
      this.Controls.Add(this.lblCount2);
      this.Controls.Add(this.lblCount1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dgv3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dgv2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgv1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDemoDataGridView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo DataGridView";
      this.Load += new System.EventHandler(this.FrmDemoDataGridView_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv5)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgv1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dgv2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridView dgv3;
    private System.Windows.Forms.Label lblCount1;
    private System.Windows.Forms.Label lblCount2;
    private System.Windows.Forms.Label lblCount3;
    private System.Windows.Forms.Label lblCount4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DataGridView dgv4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private MyDataGridView dgv5;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label lblCount5;
  }
}