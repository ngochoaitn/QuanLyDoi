using QuanLyDoi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Forms.GiayDiDuong
{
    public class TaoGiayDiDuong
    {
        Dictionary<MA_DIA_BAN_XA, Dictionary<DateTime, int>> _demDiDiaBan = new Dictionary<MA_DIA_BAN_XA, Dictionary<DateTime, int>>();//Xã nào, ngày nào đến bao nhiêu người => để chọn ngày có ít người đến nhất

        public void DienThongTin(GiayDiDuong giay, NhomNgay nhom_ngay)
        {
            foreach(Cuoc c in giay.Cuocs)
            {
                BoSo boSo = new BoSo(nhom_ngay, validate);
                foreach(var so in boSo.DanhSachKetQua)
                {

                }
            }
        }

        private bool validate(List<int> arg)
        {
            //Chỉ lấy cái nào 4 số khác 0
            if (arg.Count(p => p != 0) != 4)
                return false;
            //Tổng khác 13 thì loại
            if (arg.Sum() != 13)
                return false;
            return true;
        }
    }
}
