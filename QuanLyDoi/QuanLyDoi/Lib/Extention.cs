using Aspose.Words;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
            return doc.GetText().ToLower().Contains(word.ToLower());
        }

        public static void ChangeTextAsync(this DevExpress.XtraEditors.LabelControl lbl, string text, Color force_color)
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

        public static byte[] ObjectToByteArray(this object obj)
        {
            if (obj == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);

            return ms.ToArray();
        }

        public static T ByteArrayToObject<T>(this byte[] arrBytes) where T:class
        {
            if (arrBytes == null || arrBytes.Count() == 0)
                return null;
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            T obj = (T)binForm.Deserialize(memStream);

            return obj;
        }

        public static T GetRandomElement<T>(this List<T> list)
        {
            Random ran = new Random();
            return list.ElementAt(ran.Next(0, list.Count));
        }

        public static T GetRandomElement<T>(this List<T> list, int max_position)
        {
            Random ran = new Random();
            return list.ElementAt(ran.Next(0, max_position));
        }

        public static int? TryConvertToInt32(this string s)
        {
            try
            {
                return Convert.ToInt32(s);
            }
            catch
            {
                return null;
            }
        }
    }
}
