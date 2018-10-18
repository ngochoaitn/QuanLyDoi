namespace QuanLyDoi.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyDoiModel : DbContext
    {
        public QuanLyDoiModel()
            : base("name=QuanLyDoiModel")
        {
        }

        public virtual DbSet<CAN_BO> CAN_BO { get; set; }
        public virtual DbSet<CONG_VAN> CONG_VAN { get; set; }
        public virtual DbSet<GIAY_DI_DUONG> GIAY_DI_DUONG { get; set; }
        public virtual DbSet<MA_CAP_BAC> MA_CAP_BAC { get; set; }
        public virtual DbSet<MA_CHUC_VU> MA_CHUC_VU { get; set; }
        public virtual DbSet<MA_DIA_BAN_XA> MA_DIA_BAN_XA { get; set; }
        public virtual DbSet<MA_LOAI_CONG_VAN> MA_LOAI_CONG_VAN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
