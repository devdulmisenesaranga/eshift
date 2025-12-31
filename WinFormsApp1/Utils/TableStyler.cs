using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Utils
{
    public static class TableStyler
    {
        public static void ApplyStyle(DataGridView dgv, bool selectable = false)
        {
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = System.Drawing.Color.White;
            if (selectable)
            {
                dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
                dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            }
            else
            {
                dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
                dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            }
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
        }
    }

}
