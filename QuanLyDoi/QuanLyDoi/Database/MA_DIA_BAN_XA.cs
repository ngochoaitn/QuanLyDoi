namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Serializable]
    public partial class MA_DIA_BAN_XA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MA_DIA_BAN_XA()
        {
            MA_DIA_BAN_THON = new HashSet<MA_DIA_BAN_THON>();
        }

        [StringLength(2)]
        public string ID { get; set; }

        [StringLength(50)]
        public string ND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MA_DIA_BAN_THON> MA_DIA_BAN_THON { get; set; }
    }
}
