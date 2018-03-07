namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAN_BO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCanBo { get; set; }

        [StringLength(50)]
        public string HoVaTen { get; set; }

        public int? IdCapBac { get; set; }

        public int? IdChucVu { get; set; }
    }
}
