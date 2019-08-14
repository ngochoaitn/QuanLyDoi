namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Serializable]
    public partial class TRUC_TUAN_CAN_BO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTrucTuan_CanBo { get; set; }

        public int IdTrucTuan { get; set; }

        public int? IdCanBo { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public virtual CAN_BO CAN_BO { get; set; }

        public virtual TRUC_TUAN TRUC_TUAN { get; set; }
    }
}
