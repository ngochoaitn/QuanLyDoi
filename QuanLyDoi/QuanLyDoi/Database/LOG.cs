namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOG")]
    public partial class LOG
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Bang { get; set; }

        [StringLength(50)]
        public string ThaoTac { get; set; }

        public DateTime? ThoiGian { get; set; }

        [StringLength(4000)]
        public string NoiDung { get; set; }

        [StringLength(50)]
        public string NguoiDung { get; set; }
    }
}
