using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Database
{
    internal class SequenceId
    {
        private static QuanLyDoiModel _dbStatic = new QuanLyDoiModel();
        internal static int Sequence_Dec(string Seq_name, DbContext db)
        {
            int seq = (int)(db.Database.SqlQuery<decimal>("SELECT NEXT VALUE FOR " + Seq_name).FirstOrDefault());
            return seq;
        }
    }
}
