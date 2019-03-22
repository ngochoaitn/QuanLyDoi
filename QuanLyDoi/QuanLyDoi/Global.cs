using QuanLyDoi.Database;
using System.Data.Entity;
using System.Threading.Tasks;

namespace QuanLyDoi
{
    public class Global
    {
        public static QuanLyDoiModel DbBangMa { set; get; }
        public static Forms.Main Main { get; set; }

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
            await db.MA_DIA_BAN_XA.LoadAsync();
            await db.MA_DIA_BAN_THON.LoadAsync();
            await db.MA_DOI.LoadAsync();
            await db.MA_LOAI_CONG_VAN.LoadAsync();
            await db.MA_DAN_TOC.LoadAsync();
        }
    }
}
