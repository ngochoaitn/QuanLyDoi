using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            new Lib.TaoBoSo(maxVal).TienHanhTao();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TaoBo4So_WithValidate()
        {
            //List<int> maxVal = new List<int>() { 2, 5, 5, 5, 4 };
            List<int> maxVal = new List<int>() { 3, 2 , 2, 5, 4 };
            new Lib.TaoBoSo(maxVal).TienHanhTao(validate);
            Assert.IsTrue(true);
        }

        private bool validate(List<int> arg)
        {
            //Chỉ lấy cái nào 4 số khác 0
            if (arg.Count(p => p != 0) != 4)
                return false;
            //Tổng khác 13 thì loại
            if (arg.Sum() != 13)
                return false;
            //Loại 4 số khác không không liên tiếp
            //for (int i = 0; i < arg.Count - 4 + 1; i++)
            //    if (arg[i] != 0
            //        && arg[i + 1] != 0
            //        && arg[i + 2] != 0
            //        && arg[i + 3] != 0)
            //        return true;
            return true;
        }
    }
}
