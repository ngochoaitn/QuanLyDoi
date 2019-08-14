namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LICH_CONG_TAC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdLichCongTac { get; set; }

        public DateTime? ThoiGian { get; set; }

        public DateTime? DenNgay { get; set; }

        [StringLength(255)]
        public string DiaDiem { get; set; }

        [StringLength(500)]
        public string ThanhPhan { get; set; }

        [StringLength(500)]
        public string NoiDung { get; set; }
    }
}
