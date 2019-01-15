using QuanLyDoi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Forms.GiayDiDuong
{
    //Cuốc
    public class Cuoc
    {
        public int TuNgay { get; set; }
        public int DenNgay { get; set; }
        public MA_DIA_BAN_XA Xa { get; set; }
        public CAN_BO CanBo { get; set; }
    }
}
