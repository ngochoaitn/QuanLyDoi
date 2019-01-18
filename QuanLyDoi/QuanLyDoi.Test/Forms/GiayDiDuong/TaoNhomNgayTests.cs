using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyDoi.Forms.GiayDiDuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Forms.GiayDiDuong.Tests
{
    [TestClass()]
    public class TaoNhomNgayTests
    {
        [TestMethod()]
        public void TaoNhomNgayTest()
        {

            NhomNgay taoNhom = new NhomNgay(1, 2019, null);
            taoNhom.TienhanhTao();
            Assert.IsTrue(taoNhom.DanhSachNhomNgay.Count != 0);
        }

        [TestMethod()]
        public void TaoNhomNgay_CoLoaiBoTest()
        {

            NhomNgay taoNhom = new NhomNgay(1, 2019, new List<int>() { 1, 2});
            taoNhom.TienhanhTao();
            Assert.IsTrue(taoNhom.DanhSachNhomNgay.Count != 0);
        }

        [TestMethod()]
        public void TaoNhomNgay_CoLoaiBo_HardTest()
        {

            NhomNgay taoNhom = new NhomNgay(1, 2019, new List<int>() { 1, 2, 16 });
            taoNhom.TienhanhTao();
            Assert.IsTrue(taoNhom.DanhSachNhomNgay.Count != 0);
        }
    }
}