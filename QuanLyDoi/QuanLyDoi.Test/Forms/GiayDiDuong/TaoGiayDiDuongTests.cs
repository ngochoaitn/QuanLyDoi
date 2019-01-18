using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyDoi.Database;
using QuanLyDoi.Forms.GiayDiDuong;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Forms.GiayDiDuong.Tests
{
    [TestClass()]
    public class TaoGiayDiDuongTests
    {
        [TestMethod()]
        public void DienThongTinTest()
        {
            List<MA_DIA_BAN_XA> lstXa = new List<MA_DIA_BAN_XA>()
            {
                new MA_DIA_BAN_XA(){ID = 1, ND = "Cốc Đán"},
                new MA_DIA_BAN_XA(){ID = 2, ND = "Thượng Ân"},
                new MA_DIA_BAN_XA(){ID = 3, ND = "Hương Nê"},
                new MA_DIA_BAN_XA(){ID = 4, ND = "Lãng Ngâm"}
            };

            TaoGiayDiDuong taoGiayDiDuong = new TaoGiayDiDuong(lstXa);
            NhomNgay nhomNgay = new NhomNgay(1, 2019, new List<int>() { 1, 2 });

            for (int id = 1; id <= 15; id++)
            {
                var cb = new CAN_BO() { IdCanBo = id };
                GiayDiDuong giay = new GiayDiDuong(cb, lstXa);

                taoGiayDiDuong.DienThongTin(giay, nhomNgay);
            }

            foreach(var xa in lstXa)
            {
                Debug.WriteLine(xa.ND);
                foreach(var d in taoGiayDiDuong.ThongKeDiaBanXa[xa])
                {
                    if(d.Value.Count != 0)
                        Debug.WriteLine($"Ngày {d.Key.ToString().PadLeft(2, '0')}: {d.Value}");
                }
            }

            Assert.IsTrue(true);
        }
    }
}