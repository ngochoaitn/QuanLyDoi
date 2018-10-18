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
        internal static int Sequence_Int(string Seq_name, DbContext db)
        {
            int seq = db.Database.SqlQuery<int>("SELECT NEXT VALUE FOR " + Seq_name).FirstOrDefault();
            return seq;
        }

        internal static int CAN_BO()
        {
            return Sequence_Int("SEQ_CAN_BO", _dbStatic);
        }
    }
}
