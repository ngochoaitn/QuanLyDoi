namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRUC_TUAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRUC_TUAN()
        {
            TRUC_TUAN_CAN_BO = new HashSet<TRUC_TUAN_CAN_BO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTrucTuan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TuNgay { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DenNgay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRUC_TUAN_CAN_BO> TRUC_TUAN_CAN_BO { get; set; }
    }
}
