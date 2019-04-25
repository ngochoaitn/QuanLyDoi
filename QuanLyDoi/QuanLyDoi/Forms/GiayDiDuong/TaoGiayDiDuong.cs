using QuanLyDoi.Database;
using QuanLyDoi.Lib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Forms.GiayDiDuong
{
    public class TaoGiayDiDuong
    {
        public Dictionary<MA_DIA_BAN_XA, Dictionary<int, List<CAN_BO>>> ThongKeDiaBanXa { set; get; }// = new Dictionary<MA_DIA_BAN_XA, Dictionary<int, int>>();//Xã nào, ngày nào đến bao nhiêu người => để chọn ngày có ít người đến nhất
        public TaoGiayDiDuong(List<MA_DIA_BAN_XA> danh_sach_cac_xa)
        {
            ThongKeDiaBanXa = new Dictionary<MA_DIA_BAN_XA, Dictionary<int, List<CAN_BO>>>();
            foreach (var xa in danh_sach_cac_xa)
            {
                ThongKeDiaBanXa.Add(xa, new Dictionary<int, List<CAN_BO>>());
                for (int n = 1; n <= 31; n++)
                    ThongKeDiaBanXa[xa].Add(n, new List<CAN_BO>());
            }
        }
        MA_DIA_BAN_XA tempXa = new MA_DIA_BAN_XA();

        public void DienThongTin(GiayDiDuong giay, NhomNgay nhom_ngay)
        {
            //Mỗi tờ giấy đi đường là một bộ số vì nhóm ngày mỗi người là khác nhau
            BoSo nhomBoSo = new BoSo(nhom_ngay, validate);
            //Chọn ngẫu nhiên 1 bộ số trong các bộ số đã tạo
            List<int> boSo = nhomBoSo.DanhSachKetQua.GetRandomElement();
            Debug.WriteLine(string.Join(", ", boSo));
            int cuocHienTai = 0;
            for(int i = 0; i < boSo.Count; i++)
            {
                int soNgayCanLay = boSo[i];
                if (soNgayCanLay != 0)
                {
                    if (giay.Cuocs.Count == 0 || giay.Cuocs.Count <= cuocHienTai)
                        break;

                    Cuoc cuoc = giay.Cuocs[cuocHienTai];
                    //Chọn ngày
                    List<int> danhSachNgay = nhom_ngay[i];//Lấy nhóm ngày
                    if (soNgayCanLay < danhSachNgay.Count)
                    {
                        //Chọn ngày có lượt đến xã này ít nhất
                        int indexNgay = 0, luongNguoiDenItNhat = ThongKeDiaBanXa[cuoc.Xa][danhSachNgay[0]].Count;
                        for (int t = danhSachNgay.Count - soNgayCanLay; t >= 1; t--)
                        {
                            if (luongNguoiDenItNhat > ThongKeDiaBanXa[cuoc.Xa][danhSachNgay[t]].Count)
                            {
                                indexNgay = t;
                                luongNguoiDenItNhat = ThongKeDiaBanXa[cuoc.Xa][danhSachNgay[t]].Count;
                            }
                        }

                        cuoc.TuNgay = danhSachNgay[indexNgay];
                        cuoc.DenNgay = danhSachNgay[indexNgay + soNgayCanLay - 1];
                    }
                    else
                    {
                        cuoc.TuNgay = danhSachNgay.First();
                        cuoc.DenNgay = danhSachNgay.Last();
                    }
                    for (int n = cuoc.TuNgay; n <= cuoc.DenNgay; n++)
                        ThongKeDiaBanXa[cuoc.Xa][n].Add(giay.CanBo);
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
