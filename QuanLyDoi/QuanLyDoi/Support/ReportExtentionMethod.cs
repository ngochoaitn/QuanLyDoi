using Aspose.Words;
using Aspose.Words.Tables;
using System.Diagnostics;
using System.IO;

namespace QuanLyDoi.Support
{
    internal static class ReportExtentionMethod
    {
        public static void PutValue(this Table table, int row, int column, string text)
        {
            Row r = table.Rows[row];
            if (r == null || text == null)
                return;

            Cell cell = r.Cells[column];
            if (cell == null)
                return;

            var paragraph = cell.Paragraphs[0];
            if (paragraph == null)
                cell.Paragraphs.Add(new Paragraph(cell.Document));
            paragraph = cell.Paragraphs[0];

            var run = paragraph.Runs[0];
            if (run == null)
                paragraph.Runs.Add(new Run(paragraph.Document));
            run = paragraph.Runs[0];

            run.Text = text;
        }

        public static void PutValue(this Row r, int column, string text)
        {
            if (r == null)
                return;
            Cell cell = r.Cells[column];
            if (cell == null)
                return;

            var paragraph = cell.Paragraphs[0];
            if (paragraph == null)
                cell.Paragraphs.Add(new Paragraph(cell.Document));
            paragraph = cell.Paragraphs[0];

            var run = paragraph.Runs[0];
            if (run == null)
                paragraph.Runs.Add(new Run(paragraph.Document));
            run = paragraph.Runs[0];

            run.Text = text != null ? text : "";
        }

        public static void ChangeFont(this Row r, int column, string font_name="Time New Roman", float font_size = 14f, bool bold = false, bool italic = false, Underline underline = Underline.None)
        {
            if (r.Cells[column] != null
                && r.Cells[column].FirstParagraph != null
                && r.Cells[column].FirstParagraph.Runs[0] != null
                && r.Cells[column].FirstParagraph.Runs[0].Font != null)
            {
                r.Cells[column].FirstParagraph.Runs[0].Font.Name = font_name;
                r.Cells[column].FirstParagraph.Runs[0].Font.Size = font_size;
                r.Cells[column].FirstParagraph.Runs[0].Font.Bold = bold;
                r.Cells[column].FirstParagraph.Runs[0].Font.Italic = italic;
                r.Cells[column].FirstParagraph.Runs[0].Font.Underline = underline;
            }
        }

        public static void ChangeFont(this Row r, string font_name = "Time New Roman", float font_size = 14f, bool bold=false, bool italic = false, Underline underline = Underline.None)
        {
            if (r == null)
                return;
            for (int i = 0; i < r.Cells.Count; i++)
                r.ChangeFont(i, font_name, font_size, bold, italic, underline);
        }

        public static void InsertRows(this Table table, int index_source_row, int index_insert, int count)
        {
            try
            {
                var sourceRow = table.Rows[index_source_row];
                if (sourceRow != null)
                    for (int i = 1; i <= count; i++)
                        table.Rows.Insert(index_insert, sourceRow.Clone(true));
            }
            catch { }
        }
        public static void InsertRows(this Table table, int index_source_row_1, int index_source_row_2, int index_insert, int count)
        {
            try
            {
                var sourceRow1 = table.Rows[index_source_row_1];
                var sourceRow2 = table.Rows[index_source_row_2];
                if (sourceRow1 != null && sourceRow2 != null)
                    for (int i = 1; i <= count; i++)
                    {
                        table.Rows.Insert(index_insert, sourceRow1.Clone(true));
                        table.Rows.Insert(index_source_row_2, sourceRow2.Clone(true));
                    }
            }
            catch { }
        }
        public static void InsertRows(this Table table, int[] index_source_row, int index_insert, int count)
        {
            //try
            //{
            //    for (int i = 1; i <= count; i++)
            //    {
            //        foreach (int r in index_source_row)
            //        {
            //            var sourceRow = table.Rows[r];
            //            if (sourceRow != null)
            //                table.Rows.Insert(index_insert, sourceRow.Clone(true));
            //        }
            //    }
            //}
            //catch { }
            try
            {
                var sourceRow1 = table.Rows[index_source_row[0]];
                var sourceRow2 = table.Rows[index_source_row[1]];
                var sourceRow3 = table.Rows[index_source_row[2]];
                var sourceRow4 = table.Rows[index_source_row[3]];
                if (sourceRow1 != null && sourceRow2 != null && sourceRow3 != null && sourceRow4 != null)
                    for (int i = 1; i <= count; i++)
                    {
                        table.Rows.Insert(index_source_row[0], sourceRow1.Clone(true));
                        table.Rows.Insert(index_source_row[1], sourceRow2.Clone(true));
                        table.Rows.Insert(index_source_row[2], sourceRow3.Clone(true));
                        table.Rows.Insert(index_source_row[3], sourceRow4.Clone(true));
                    }
            }
            catch { }
        }
    }

    internal static class Ex
    {
        public static void SaveAndOpenFile(this Aspose.Cells.Workbook wb, string filename = "tmp.xlsx")
        {
            int dem = 0;

            while (true)
            {
                string tenTep = dem + filename;
                try
                {
                    wb.Save(tenTep);
                    Process.Start(tenTep);
                    break;
                }
                catch
                {
                    dem++;
                }
            }
        }

        public static void SaveAndOpenFile(this Document doc, string filename = "tmp.doc")
        {
            int dem = 0;
            string thuMuc= "temp";
            if (!Directory.Exists(thuMuc))
                Directory.CreateDirectory(thuMuc);

            while (true)
            {
                string tenTep = $"{thuMuc}\\{dem + filename}";
                try
                {
                    doc.Save(tenTep);
                    Process.Start(tenTep);
                    break;
                }
                catch
                {
                    dem++;
                }
            }
        }
    }
}
