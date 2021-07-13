using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseProject
{
    class WordOt
    {
        Microsoft.Office.Interop.Word.Application msWord = new Microsoft.Office.Interop.Word.Application();
        public Microsoft.Office.Interop.Word.Document doc;
        object objMiss = System.Reflection.Missing.Value;
        object endofdoc = "\\endofdoc";
        public void CreateW(DataGridView _dgv)
        {
            try
            {
                msWord.Visible = true;
                doc = msWord.Documents.Add(ref objMiss, ref objMiss, ref objMiss, ref objMiss);

                int rows = _dgv.RowCount + 1;
                int columns = _dgv.ColumnCount;
                //create table

                Microsoft.Office.Interop.Word.Table tbl1;
                Microsoft.Office.Interop.Word.Range wordRange = doc.Bookmarks.get_Item(ref endofdoc).Range;
                tbl1 = doc.Content.Tables.Add(wordRange, rows, columns, ref objMiss, ref objMiss);
                tbl1.Borders.Enable = 1;

                for (int c = 1; c <= columns; c++)
                {
                    tbl1.Cell(1, c).Range.Text = _dgv.Columns[c - 1].HeaderText;
                }
                for (int r = 2; r <= rows; r++)
                {
                    for (int c = 1; c <= columns; c++)
                    {
                        tbl1.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                        if (_dgv[c - 1, r - 2].Value != null)
                            tbl1.Cell(r, c).Range.Text = _dgv[c - 1, r - 2].Value.ToString();
                        else
                            tbl1.Cell(r, c).Range.Text = " - ";
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
