using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDoi
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void giayDiDuongBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Forms.GiayDiDuong.frmNhapThongTinKhoiTao().ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TaoBoSo();
        }

        List<List<int>> _boSo6Tuan = new List<List<int>>();

        int _thang = 3, _nam = 2018;

        private void timKiemTepBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Forms.TimKiem.frmTimKiemFileWord().ShowDialog();
        }

        private void TaoBoSo()
        {
            #region Lấy các ngày có thể lấy của các tuần
            List<List<int>> Tuan = new List<List<int>>();
            DateTime ngayThang = new DateTime(_nam, _thang, 1);
            int ngayCuoiThang = ngayThang.AddMonths(1).AddDays(-1).Day;

            while (ngayThang.Month == _thang)
            {
                if (ngayThang.DayOfWeek == DayOfWeek.Saturday || ngayThang.DayOfWeek == DayOfWeek.Sunday)
                {
                    if (ngayThang.DayOfWeek == DayOfWeek.Saturday)
                        ngayThang = ngayThang.AddDays(2);//để sang thứ 2

                    if (ngayThang.DayOfWeek == DayOfWeek.Sunday)
                        ngayThang = ngayThang.AddDays(1);//để sang thứ 2
                    if (ngayThang.Month != _thang)
                        break;
                    Tuan.Add(new List<int>());
                }

                if (Tuan.Count == 0)
                    Tuan.Add(new List<int>());

                //if (ngayThang.DayOfWeek != DayOfWeek.Saturday && ngayThang.DayOfWeek != DayOfWeek.Sunday)
                Tuan.LastOrDefault().Add(ngayThang.Day);

                ngayThang = ngayThang.AddDays(1);
            }

            //Thêm cho đủ 6 tuần
            while (Tuan.Count < 6)
                Tuan.Add(new List<int>());
            #endregion

            #region Tạo các trường hợp có thể (phân tích 13 thành 6 số nhỏ hơn bằng 5 (6 tuần, mỗi tuần 5 ngày))
            for (int i6 = 0; i6 <= 5; i6++)
            {
                for (int i5 = 0; i5 <= 5; i5++)
                {
                    for (int i4 = 0; i4 <= 5; i4++)
                    {
                        for (int i3 = 0; i3 <= 5; i3++)
                        {
                            for (int i2 = 0; i2 <= 5; i2++)
                            {
                                for (int i1 = 0; i1 <= 5; i1++)
                                {
                                    if (i1 + i2 + i3 + i4 + i5 + i6 == 13)
                                        _boSo6Tuan.Add(new List<int>() { i1, i2, i3, i4, i5, i6 });
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region Loại bỏ các trường hợp không thỏa mãn
            _boSo6Tuan = _boSo6Tuan.Where(p => p.Where(p2 => p2 == 0).Count() == 2).ToList();//Chỉ lấy 4 tuần
            _boSo6Tuan = _boSo6Tuan.Where(p => (p[0] == 0 && p[1] == 0) || (p[4] == 0 && p[5] == 0) || (p[0] == 0 && p[5] == 0)).ToList();//Chỉ lấy 4 tuần => nên 2 tuần phải bằng 0
            //Lấy các số thỏa mãn cho tháng này
            _boSo6Tuan = _boSo6Tuan.Where(p => p[0] <= Tuan[0].Count
                                            && p[1] <= Tuan[1].Count
                                            && p[2] <= Tuan[2].Count
                                            && p[3] <= Tuan[3].Count
                                            && p[4] <= Tuan[4].Count
                                            && p[5] <= Tuan[5].Count
                                            ).ToList();
            #endregion
        }
    }
}
