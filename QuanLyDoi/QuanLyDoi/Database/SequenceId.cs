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

        internal static int TEP_TIN()
        {
            return Sequence_Int("SEQ_TEP_TIN", _dbStatic);
        }

        internal static int BAO_CAO_DINH_KY()
        {
            return Sequence_Int("SEQ_BAO_CAO_DINH_KY", _dbStatic);
        }

        internal static int BAO_CAO_DINH_KY_NGAY_BAO_CAO()
        {
            return Sequence_Int("SEQ_BAO_CAO_DINH_KY_NGAY_BAO_CAO", _dbStatic);
        }

        internal static int CONG_VAN()
        {
            return Sequence_Int("SEQ_CONG_VAN", _dbStatic);
        }

        internal static int NGUOI()
        {
            return Sequence_Int("SEQ_NGUOI", _dbStatic);
        }

        internal static int XUAT_CANH_TRAI_PHEP()
        {
            return Sequence_Int("SEQ_XUAT_CANH_TRAI_PHEP", _dbStatic);
        }

        internal static int TRUC_TUAN()
        {
            return Sequence_Int("SEQ_TRUC_TUAN", _dbStatic);
        }

        internal static int TRUC_TUAN_CAN_BO()
        {
            return Sequence_Int("SEQ_TRUC_TUAN_CAN_BO", _dbStatic);
        }

        internal static int LICH_TRINH_CONG_TAC()
        {
            return Sequence_Int("SEQ_LICH_TRINH_CONG_TAC", _dbStatic);
        }
    }
}
