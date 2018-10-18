using QuanLyDoi.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Lib
{
    public class Global
    {
        public static QuanLyDoiModel DbBangMa { set; get; }

        static Global()
        {
            DbBangMa = new QuanLyDoiModel();
        }

        public static async Task LoadBangMaAsync(QuanLyDoiModel db)
        {
            await db.MA_CHUC_VU.LoadAsync();
            await db.MA_CAP_BAC.LoadAsync();
            await db.MA_DIA_BAN_XA.LoadAsync();
            await db.MA_LOAI_CONG_VAN.LoadAsync();
        }
    }
}
