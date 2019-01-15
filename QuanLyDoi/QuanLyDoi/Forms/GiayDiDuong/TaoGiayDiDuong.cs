using QuanLyDoi.Database;
using QuanLyDoi.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Forms.GiayDiDuong
{
    public class TaoGiayDiDuong
    {
        Dictionary<MA_DIA_BAN_XA, Dictionary<int, int>> _demDiDiaBan;// = new Dictionary<MA_DIA_BAN_XA, Dictionary<int, int>>();//Xã nào, ngày nào đến bao nhiêu người => để chọn ngày có ít người đến nhất

        public TaoGiayDiDuong(List<MA_DIA_BAN_XA> danh_sach_cac_xa)
        {
            _demDiDiaBan = new Dictionary<MA_DIA_BAN_XA, Dictionary<int, int>>();
            foreach (var xa in danh_sach_cac_xa)
            {
                _demDiDiaBan.Add(xa, new Dictionary<int, int>());
                for (int n = 1; n <= 31; n++)
                    _demDiDiaBan[xa].Add(n, 0);
            }
        }

        public void DienThongTin(GiayDiDuong giay, NhomNgay nhom_ngay)
        {
            //Mỗi tờ giấy đi đường là một bộ số vì nhóm ngày mỗi người là khác nhau
            BoSo nhomBoSo = new BoSo(nhom_ngay, validate);
            //Chọn ngẫu nhiên 1 bộ số trong các bộ số đã tạo
            List<int> boSo = nhomBoSo.DanhSachKetQua.GetRandomElement();

            int cuocHienTai = 0;
            for(int i = 0; i < boSo.Count; i++)
            {
                int soNgayCanLay = boSo[i];
                if (soNgayCanLay != 0)
                {
                    Cuoc cuoc = giay.Cuocs[cuocHienTai];
                    //Chọn ngày
                    List<int> danhSachNgay = nhom_ngay[i];
                    if (soNgayCanLay < danhSachNgay.Count)
                    {
                        //Chọn ngày có lượt đến xã này ít nhất
                        int indexNgay = 0, luongNguoiDenItNhat = _demDiDiaBan[cuoc.Xa][danhSachNgay[0]];
                        for (int t = 1; t <= danhSachNgay.Count - soNgayCanLay; t++)
                        {
                            if (luongNguoiDenItNhat > _demDiDiaBan[cuoc.Xa][danhSachNgay[t]])
                            {
                                indexNgay = t;
                                luongNguoiDenItNhat = _demDiDiaBan[cuoc.Xa][danhSachNgay[t]];
                            }
                        }

                        //index_ran = new Random().Next(0, danhSachNgay.Count - soNgayCanLay + 1);

                        cuoc.TuNgay = danhSachNgay[indexNgay];
                        cuoc.DenNgay = danhSachNgay[indexNgay + soNgayCanLay - 1];
                    }
                    else
                    {
                        cuoc.TuNgay = danhSachNgay.First();
                        cuoc.DenNgay = danhSachNgay.Last();
                    }
                    for (int n = cuoc.TuNgay; n <= cuoc.DenNgay; n++)
                        _demDiDiaBan[cuoc.Xa][n]++;
                    cuocHienTai++;
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
