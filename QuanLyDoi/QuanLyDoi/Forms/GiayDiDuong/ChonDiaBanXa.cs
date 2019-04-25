using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Forms.GiayDiDuong
{
    //Phục vụ chọn địa bàn xã nhanh hơn => cần khi xuất kế hoạch công tác
    [Serializable]
    public class ChonDiaBanXa
    {
        public ChonDiaBanXa()
        {
            this.THU_TU_CHON_XA = new List<string>();
            CHON_XA_1 = CHON_XA_2 = CHON_XA_3 = CHON_XA_4 = CHON_XA_5 = CHON_XA_6 = CHON_XA_7 = CHON_XA_8 = false;
        }
        public int ID_CAN_BO { set; get; }
        public bool CHON_XA_1 { set; get; }
        public bool CHON_XA_2 { set; get; }
        public bool CHON_XA_3 { set; get; }
        public bool CHON_XA_4 { set; get; }
        public bool CHON_XA_5 { set; get; }
        public bool CHON_XA_6 { set; get; }
        public bool CHON_XA_7 { set; get; }
        public bool CHON_XA_8 { set; get; }
        public string TEN_CAC_XA_DUOC_CHON { set; get; }
        public List<string> THU_TU_CHON_XA { private set; get; }
        public string NGAY_LOAI_BO { get; set; }
        public GiayDiDuong GiayDiDuong { get; set; }
    }
}
