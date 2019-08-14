using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Lib
{
    class Log
    {
        public static void WriteLog(string content)
        {
            try
            {
                File.AppendAllText("Log.txt", $"{DateTime.Now.ToString("HH:mm dd/MM/yyyy")}: {content}\r\n");
            }
            catch
            {

            }
        }
    }
}
