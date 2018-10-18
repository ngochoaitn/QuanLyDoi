namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONG_VAN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCongVan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhan { get; set; }

        [StringLength(50)]
        public string SoKyHieu { get; set; }

        [StringLength(50)]
        public string NoiGui { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCongVan { get; set; }

        public string TrichYeu { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public int? IdLoaiCongVan { get; set; }
    }
}
