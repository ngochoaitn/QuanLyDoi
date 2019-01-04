using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyDoi.Forms.GiayDiDuong;

namespace QuanLyDoi.Test
{
    [TestClass]
    public class TestTaoBoSo
    {
        [TestMethod]
        public void TaoBo4So()
        {
            //List<int> maxVal = new List<int>() { 4, 5, 5, 5 };
            List<int> maxVal = new List<int>() { 2, 5, 5, 5, 4 };
            BoSo boSo = new BoSo(maxVal);
            Assert.IsTrue(boSo.DanhSachKetQua.Count != 0);
        }

        [TestMethod]
        public void TaoBo4So_WithValidate()
        {
            //List<int> maxVal = new List<int>() { 2, 5, 5, 5, 4 };
            List<int> maxVal = new List<int>() { 3, 2 , 2, 5, 4 };
            BoSo boSo = new BoSo(maxVal, validate);
            Assert.IsTrue(boSo.DanhSachKetQua.Count != 0);
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
