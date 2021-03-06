﻿using QuanLyDoi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Forms.GiayDiDuong
{
    [Serializable]
    public class GiayDiDuong
    {
        public List<Cuoc> Cuocs { get; set; }
        public CAN_BO CanBo { get; set; }
        public GiayDiDuong(CAN_BO can_bo, List<MA_DIA_BAN_XA> danh_sach_xa)
        {
            this.Cuocs = new List<Cuoc>();
            foreach(var xa in danh_sach_xa)
                this.Cuocs.Add(new Cuoc() { Xa = xa });
            this.CanBo = can_bo;
        }
    }
}
