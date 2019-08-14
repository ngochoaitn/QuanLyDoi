namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Serializable]
    public partial class GIAY_DI_DUONG
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? THANG { get; set; }

        public int? NAM { get; set; }

        public int? ID_CAN_BO { get; set; }

        public int? ID_DIA_BAN_XA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_DI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_VE { get; set; }
    }
}
