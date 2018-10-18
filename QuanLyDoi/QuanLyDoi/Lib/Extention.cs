using Aspose.Words;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Lib
{
    public static class Extention
    {
        public static bool IsMSWordFile(this FileInfo f)
        {
            return f?.Extension?.Contains("doc") ?? false;
        }

        public static bool FindWord(this Document doc, string word)
        {
            return doc.GetText().Contains(word);
        }

        public static void ChangeTextAsyc(this DevExpress.XtraEditors.LabelControl lbl, string text, Color force_color)
        {
            if(lbl.InvokeRequired)
            {
                lbl.BeginInvoke((Action)(() =>
                {
                    lbl.Text = text;
                    lbl.ForeColor = force_color;
                }));
            }
            else
            {
                lbl.Text = text;
                lbl.ForeColor = force_color;
            }
        }
    }
}
