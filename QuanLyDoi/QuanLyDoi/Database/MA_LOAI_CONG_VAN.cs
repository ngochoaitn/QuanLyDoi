namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA_LOAI_CONG_VAN
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Mã")]
        public int ID { get; set; }

        [StringLength(50)]
        [Display(Name ="Loại công văn")]
        public string ND { get; set; }
    }
}
