namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA_DIA_BAN_THON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MA_DIA_BAN_THON()
        {
            NGUOI = new HashSet<NGUOI>();
        }

        [StringLength(4)]
        public string ID { get; set; }

        [StringLength(50)]
        public string ND { get; set; }

        [StringLength(2)]
        public string ID_DIA_BAN_XA { get; set; }

        public virtual MA_DIA_BAN_XA MA_DIA_BAN_XA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOI> NGUOI { get; set; }
    }
}
