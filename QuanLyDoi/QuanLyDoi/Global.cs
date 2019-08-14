using QuanLyDoi.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDoi
{
    public class Global
    {
        public static QuanLyDoiModel DbBangMa { set; get; }
        public static Forms.FormMain Main { get; set; }

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

        public static async Task<List<LICH_CONG_TAC>> LichCongTacNhungNgayToiAsync(int so_nga_toi = 14)
        {
            QuanLyDoiModel _db = new QuanLyDoiModel();
            List<LICH_CONG_TAC> res = new List<LICH_CONG_TAC>();
            var moc14Ngay = DateTime.Now.AddDays(so_nga_toi);
            var ngayHomNay = DateTime.Now.Date;
            //tải dữ liệu lịch trình
            var lichTrinh = await _db.LICH_CONG_TAC.Where(p => (p.ThoiGian >= ngayHomNay && p.ThoiGian <= moc14Ngay)
            || (p.DenNgay >= ngayHomNay && p.DenNgay <= moc14Ngay)).ToListAsync();
            res.AddRange(lichTrinh);

            //Thêm báo cáo định kỳ vào lịch trình công tác
            int namNay = DateTime.Now.Year;
            var baoCaoDinhKy = (await _db.BAO_CAO_DINH_KY_NGAY_BAO_CAO.ToListAsync()).Where(p => p.NgayBaoCaoNamNay >= ngayHomNay
             && p.NgayBaoCaoNamNay <= moc14Ngay);
            foreach (var bcdk in baoCaoDinhKy)
            {
                res.Add(new LICH_CONG_TAC()
                {
                    NoiDung = $"Báo cáo định kỳ {bcdk.BAO_CAO_DINH_KY.NoiDung} ({bcdk.GhiChu}) gửi {bcdk.BAO_CAO_DINH_KY.DonViNhanBaoCao}",
                    ThoiGian = new DateTime(namNay, bcdk.Thang, bcdk.Ngay),
                });
            }

            //Thêm sinh nhật vào lịch trình công tác
            var sinhNhat = await _db.CAN_BO.Where(p => p.NgayThangNamSinh.HasValue
            && p.NgayThangNamSinh.Value.Month == DateTime.Now.Month
            && p.NgayThangNamSinh.Value.Day >= ngayHomNay.Day).ToListAsync();
            foreach (var cb in sinhNhat)
            {
                res.Add(new LICH_CONG_TAC()
                {
                    NoiDung = $"Sinh nhật đồng chí {cb.HoVaTen}",
                    ThoiGian = cb.NgayThangNamSinh
                });
            }

            return res;
        }
    }
}
