using Aspose.Words;
using System;
using System.Collections.Generic;
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
    }
}
