namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEP_TIN
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string TenTep { get; set; }

        [Column(TypeName = "image")]
        public byte[] NoiDungTep { get; set; }
    }
}
