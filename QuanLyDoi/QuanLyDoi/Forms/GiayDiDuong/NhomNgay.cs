using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Forms.GiayDiDuong
{
    public class NhomNgay
    {
        public int Thang { get; set; }
        public int Nam { get; set; }
        public List<List<int>> DanhSachKetQua { get; set; }
        public List<int> NgayLoaiBo { get; set; }

        public NhomNgay(int thang, int nam, List<int> ngay_loai_bo = null)
        {
            this.Thang = thang;
            this.Nam = nam;
            NgayLoaiBo = ngay_loai_bo ?? new List<int>();
            this.TienhanhTao();
        }

        public List<List<int>> TienhanhTao()
        {
            this.DanhSachKetQua = new List<List<int>>();

            DateTime ngayDauThang = new DateTime(Nam, Thang, 1);
            DateTime ngayHienTai = ngayDauThang;
            DanhSachKetQua.Add(new List<int>());
            while (ngayHienTai.Month == this.Thang)
            {
                if(Validate(ngayHienTai))
                    DanhSachKetQua.Last().Add(ngayHienTai.Day);
                else
                    DanhSachKetQua.Add(new List<int>());
                ngayHienTai = ngayHienTai.AddDays(1);
            }

            DanhSachKetQua = DanhSachKetQua.Where(p => p.Count != 0).ToList();

            return DanhSachKetQua;
        }

        private bool Validate(DateTime ngay)
        {
            return !(ngay.DayOfWeek == DayOfWeek.Sunday || ngay.DayOfWeek == DayOfWeek.Saturday || NgayLoaiBo.Contains(ngay.Day));
        }

        public List<int> this[int index] => DanhSachKetQua[index];
    }
}
