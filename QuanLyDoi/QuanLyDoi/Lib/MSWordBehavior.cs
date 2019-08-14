using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;

namespace QuanLyDoi.Lib
{
    public class MSWordBehavior
    {
        public MSWordBehavior()
        {
        }

        public string ReadAllText(string file_path)
        {
            var document = WordprocessingDocument.Open(file_path, false);

            string res = document.MainDocumentPart.Document.Body.InnerText;

            document.Close();

            return res;
        }

        public void Dispose()
        {
        }
    }
}
