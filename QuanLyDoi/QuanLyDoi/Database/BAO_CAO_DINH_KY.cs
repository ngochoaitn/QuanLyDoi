namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BAO_CAO_DINH_KY
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdBaoCaoDinhKy { get; set; }

        [StringLength(50)]
        public string SoCongVanYeuCau { get; set; }

        [StringLength(50)]
        public string DonViNhanBaoCao { get; set; }

        public string NoiDung { get; set; }
    }
}
