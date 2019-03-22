namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class XUAT_CANH_TRAI_PHEP
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ID_NGUOI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_DI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_VE { get; set; }

        public bool? BI_LLCNTQ_BAT { get; set; }

        public bool? CO_GIAY_THONG_HANH { get; set; }

        [StringLength(500)]
        public string GHI_CHU { get; set; }

        public virtual NGUOI NGUOI { get; set; }
    }
}
