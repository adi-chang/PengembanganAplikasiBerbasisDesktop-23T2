using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.Basic.Controls
{
  public partial class FrmDemoDataGridView : Form
  {

    IEnumerable<Mahasiswa> listData = new List<Mahasiswa>
    {
      new Mahasiswa { Nim = "0001", Nama = "Andi" },
      new Mahasiswa { Nim = "0002", Nama = "Budi" },
      new Mahasiswa { Nim = "0003", Nama = "Charles" },
      new Mahasiswa { Nim = "0004", Nama = "Deni" },
      new Mahasiswa { Nim = "0005", Nama = "Emon" },
    };


    public FrmDemoDataGridView()
    {
      InitializeComponent();
      this.dgv1.AutoGenerateColumns = false;
      this.dgv2.AutoGenerateColumns = false;
      this.dgv3.AutoGenerateColumns = false;
      this.lblCount1.Text = $"{this.dgv1.Rows.Count:n0} item";
      this.lblCount2.Text = $"{this.dgv2.Rows.Count:n0} item";
      this.lblCount3.Text = $"{this.dgv3.Rows.Count-1:n0} item";
      this.lblCount4.Text = $"{this.dgv4.Rows.Count:n0} item";
      this.lblCount5.Text = $"{this.dgv5.Rows.Count-1:n0} item";
    }

    private void FrmDemoDataGridView_Load(object sender, EventArgs e)
    {

      // loading data to dgv1 via looping

      foreach (var item in listData)
      {
        this.dgv1.Rows.Add(new string[] { item.Nim, item.Nama });
      }
      this.lblCount1.Text = $"{this.dgv1.Rows.Count:n0} item";

      // loading data to dgv2 via data binding

      this.dgv2.DataSource = listData;
      this.dgv2.Columns[0].DataPropertyName = nameof(Mahasiswa.Nim);
      this.dgv2.Columns[1].DataPropertyName = nameof(Mahasiswa.Nama);
      this.lblCount2.Text = $"{this.dgv2.RowCount:n0} item";

      // loading data to dgv4 via addrange method

      List<DataGridViewRow> rows = new List<DataGridViewRow>();

      foreach (var item in listData)
      {
        DataGridViewRow row = new DataGridViewRow();
        row.CreateCells(this.dgv4, new string[] { item.Nim, item.Nama });
        rows.Add(row);
      }

      this.dgv4.Rows.AddRange(rows.ToArray());
      this.lblCount4.Text = $"{this.dgv4.Rows.Count:n0} item";

    }

    private void dgv3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
      // untuk controlling data yang bisa diinput ke dalam setiap kolom
      // mis. kolom nim wajib angka
      // mis. kolom nama dalam huruf kapital semua
      int colIndex = this.dgv3.CurrentCell.ColumnIndex;
      e.Control.KeyPress -= AcceptNumericKeyOnly;
      e.Control.KeyPress -= ToCapitalCase;
      if (colIndex == 0)
      {
        // kolom nim
        e.Control.KeyPress += AcceptNumericKeyOnly;
      }
      else if (colIndex == 1)
      {
        // kolom nama
        e.Control.KeyPress += ToCapitalCase;
      }
    }

    private void ToCapitalCase(object sender, KeyPressEventArgs e)
    {
      e.KeyChar = char.ToUpperInvariant(e.KeyChar);
    }

    private void AcceptNumericKeyOnly(object sender, KeyPressEventArgs e)
    {
      e.Handled = true;
      if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) e.Handled = false;
    }

    private void dgv3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      int rowIndex = e.RowIndex;
      int colIndex = e.ColumnIndex;
      if (colIndex == 0)
      {
        string isian = this.dgv3.Rows[rowIndex].Cells[colIndex].Value?.ToString().Trim() ?? "";
        if (isian != "")
        {
          if (isian.Length != 4)
          {
            MessageBox.Show("Sorry, nim wajib 4 karakter ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.dgv3.Rows[rowIndex].Cells[colIndex].Value = "";
          }
        }
      }
    }

    private void dgv3_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      this.lblCount3.Text = $"{this.dgv3.Rows.Count-1:n0} item";
    }

    private void dgv3_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      this.lblCount3.Text = $"{this.dgv3.Rows.Count - 1:n0} item";
    }

    private void dgv5_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
      // untuk controlling data yang bisa diinput ke dalam setiap kolom
      // mis. kolom nim wajib angka
      // mis. kolom nama dalam huruf kapital semua
      int colIndex = this.dgv5.CurrentCell.ColumnIndex;
      e.Control.KeyPress -= AcceptNumericKeyOnly;
      e.Control.KeyPress -= ToCapitalCase;
      if (colIndex == 0)
      {
        // kolom nim
        e.Control.KeyPress += AcceptNumericKeyOnly;
      }
      else if (colIndex == 1)
      {
        // kolom nama
        e.Control.KeyPress += ToCapitalCase;
      }
    }

    private void dgv5_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      int rowIndex = e.RowIndex;
      int colIndex = e.ColumnIndex;
      if (colIndex == 0)
      {
        string isian = this.dgv5.Rows[rowIndex].Cells[colIndex].Value?.ToString().Trim() ?? "";
        if (isian != "")
        {
          if (isian.Length != 4)
          {
            MessageBox.Show("Sorry, nim wajib 4 karakter ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.dgv5.Rows[rowIndex].Cells[colIndex].Value = "";
          }
        }
      }
    }

    private void dgv5_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      this.lblCount5.Text = $"{this.dgv5.Rows.Count - 1:n0} item";
    }

    private void dgv5_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      this.lblCount5.Text = $"{this.dgv5.Rows.Count - 1:n0} item";
    }
  }

  class Mahasiswa
  {
    public string Nim { get; set; }
    public string Nama { get; set; }
  }


}
