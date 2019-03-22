namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOI")]
    public partial class NGUOI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUOI()
        {
            XUAT_CANH_TRAI_PHEP = new HashSet<XUAT_CANH_TRAI_PHEP>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string HO_VA_TEN { get; set; }

        [StringLength(5)]
        public string GIOI_TINH { get; set; }

        public byte? NGAY_SINH { get; set; }

        public byte? THANG_SNH { get; set; }

        public int? NAM_SINH { get; set; }

        public int? MA_DAN_TOC { get; set; }

        [StringLength(4)]
        public string MA_DIA_BAN_THON { get; set; }

        [StringLength(10)]
        public string SO_CMND { get; set; }

        [StringLength(500)]
        public string GHI_CHU { get; set; }

        public virtual MA_DAN_TOC MA_DAN_TOC1 { get; set; }

        public virtual MA_DIA_BAN_THON MA_DIA_BAN_THON1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XUAT_CANH_TRAI_PHEP> XUAT_CANH_TRAI_PHEP { get; set; }
    }
}
