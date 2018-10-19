namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BAO_CAO_DINH_KY_NGAY_BAO_CAO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? IdBaoCaoDinhKy { get; set; }

        public int? Ngay { get; set; }

        public int? Thang { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }
    }
}
