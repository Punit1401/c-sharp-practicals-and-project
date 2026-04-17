using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Eletronic
{
    class Tabledesign
    {
        public static void tabledesign(Guna2DataGridView grid)
        {

            if (!grid.Columns.Contains("SrNo"))
            {
                DataGridViewTextBoxColumn srNo = new DataGridViewTextBoxColumn();
                srNo.Name = "SrNo";
                srNo.HeaderText = "Sr. No.";
                srNo.ReadOnly = true;
                grid.Columns.Insert(0, srNo); // Insert at the first position
                grid.Columns["SrNo"].Width = 50; // Set a fixed width for the index
            }
            // ✅ AUTO SERIAL NUMBER (GLOBAL - WORKS EVERYWHERE)
            grid.RowPostPaint -= Grid_RowPostPaint; // avoid duplicate event
            grid.RowPostPaint += Grid_RowPostPaint;

            grid.EnableHeadersVisualStyles = false;
            grid.AllowUserToAddRows = false;

            // HEADER STYLE
            grid.ColumnHeadersHeight = 45;
           grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 70, 141);
           grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
           grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // ROW STYLE
           grid.DefaultCellStyle.BackColor = Color.FromArgb(77, 126, 175);
           grid.DefaultCellStyle.ForeColor = Color.Black;
           grid.DefaultCellStyle.SelectionBackColor = Color.White;
           grid.DefaultCellStyle.SelectionForeColor = Color.Black;

            // GRID LINES (IMPORTANT FIX)
           grid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
           grid.GridColor = Color.Gray;
           grid.ThemeStyle.GridColor = Color.Gray;

            // REMOVE EXTRA BORDER
           grid.BorderStyle = BorderStyle.None;

            // AUTO SIZE (IMPORTANT)
           grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ROW HEIGHT
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //read only
            grid.ReadOnly = true;
            grid.ScrollBars = ScrollBars.Vertical;
            
            
        }

        private static void Grid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            grid.Rows[e.RowIndex].Cells["SrNo"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
