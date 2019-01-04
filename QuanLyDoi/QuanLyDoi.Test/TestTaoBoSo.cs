using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuanLyDoi.Test
{
    [TestClass]
    public class TestTaoBoSo
    {
        [TestMethod]
        public void TaoBo4So()
        {
            List<int> maxVal = new List<int>() { 4, 5, 5, 5 };
            new Lib.TaoBoSo(maxVal).TienHanhTao();
            Assert.IsTrue(true);
        }
    }
}
