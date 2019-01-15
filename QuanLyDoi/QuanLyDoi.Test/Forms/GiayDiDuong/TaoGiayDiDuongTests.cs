using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyDoi.Database;
using QuanLyDoi.Forms.GiayDiDuong;
using System;
using System.Collections.Generic;
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
                new MA_DIA_BAN_XA(){ID = 1},
                new MA_DIA_BAN_XA(){ID = 2},
                new MA_DIA_BAN_XA(){ID = 3},
                new MA_DIA_BAN_XA(){ID = 4}
            };

            TaoGiayDiDuong taoGiayDiDuong = new TaoGiayDiDuong(lstXa);
            List<CAN_BO> lstCanBo = new List<CAN_BO>();
            NhomNgay nhomNgay = new NhomNgay(1, 2019, new List<int>() { 1, 2 });

            for (int id = 1; id <= 15; id++)
            {
                var cb = new CAN_BO() { IdCanBo = id };
                lstCanBo.Add(new CAN_BO() { IdCanBo = id });
                GiayDiDuong giay = new GiayDiDuong(cb, lstXa);

                taoGiayDiDuong.DienThongTin(giay, nhomNgay);
            }

            Assert.IsTrue(true);
        }
    }
}