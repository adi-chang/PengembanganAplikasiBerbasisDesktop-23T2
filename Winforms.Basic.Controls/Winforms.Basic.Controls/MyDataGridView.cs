using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.Basic.Controls
{
  public class MyDataGridView : DataGridView
  {

    protected override void OnEnter(EventArgs e)
    {
      // Set the current cell to the first cell and enable editing when the control receives focus
      if (RowCount > 0 && ColumnCount > 0)
      {
        CurrentCell = Rows[0].Cells[0];
        BeginEdit(true);
      }
      base.OnEnter(e);
    }

    protected override bool ProcessDialogKey(Keys keyData)
    {
      if (keyData == Keys.Enter)
      {
        // Move the focus to the next column and row when Enter key is pressed
        if (CurrentCell.ColumnIndex == ColumnCount - 1)
        {
          if (CurrentCell.RowIndex == RowCount - 1)
          {
            // Reached the last cell, move focus to the first cell
            CurrentCell = Rows[0].Cells[0];
          }
          else
          {
            // Move to the first cell of the next row
            CurrentCell = Rows[CurrentCell.RowIndex + 1].Cells[0];
          }
        }
        else
        {
          // Move to the next column
          CurrentCell = Rows[CurrentCell.RowIndex].Cells[CurrentCell.ColumnIndex + 1];
        }

        BeginEdit(true);

        return true;
      }
      return base.ProcessDialogKey(keyData);
    }

    protected override bool ProcessDataGridViewKey(KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        base.ProcessTabKey(Keys.Tab);
        return true;
      }
      return base.ProcessDataGridViewKey(e);
    }

  }
}
