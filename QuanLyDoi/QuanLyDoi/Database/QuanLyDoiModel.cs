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

        public virtual DbSet<BAO_CAO_DINH_KY> BAO_CAO_DINH_KY { get; set; }
        public virtual DbSet<BAO_CAO_DINH_KY_NGAY_BAO_CAO> BAO_CAO_DINH_KY_NGAY_BAO_CAO { get; set; }
        public virtual DbSet<CAN_BO> CAN_BO { get; set; }
        public virtual DbSet<CONG_VAN> CONG_VAN { get; set; }
        public virtual DbSet<GIAY_DI_DUONG> GIAY_DI_DUONG { get; set; }
        public virtual DbSet<LOG> LOG { get; set; }
        public virtual DbSet<MA_CAP_BAC> MA_CAP_BAC { get; set; }
        public virtual DbSet<MA_CHUC_VU> MA_CHUC_VU { get; set; }
        public virtual DbSet<MA_DIA_BAN_XA> MA_DIA_BAN_XA { get; set; }
        public virtual DbSet<MA_DOI> MA_DOI { get; set; }
        public virtual DbSet<MA_LOAI_CONG_VAN> MA_LOAI_CONG_VAN { get; set; }
        public virtual DbSet<TEP_TIN> TEP_TIN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MA_CAP_BAC>()
                .HasMany(e => e.CAN_BO)
                .WithOptional(e => e.MA_CAP_BAC)
                .HasForeignKey(e => e.IdCapBac);

            modelBuilder.Entity<MA_CHUC_VU>()
                .HasMany(e => e.CAN_BO)
                .WithOptional(e => e.MA_CHUC_VU)
                .HasForeignKey(e => e.IdChucVu);

            modelBuilder.Entity<MA_DOI>()
                .HasMany(e => e.CAN_BO)
                .WithOptional(e => e.MA_DOI)
                .HasForeignKey(e => e.IdDoi);

            modelBuilder.Entity<TEP_TIN>()
                .HasMany(e => e.CAN_BO)
                .WithOptional(e => e.TEP_TIN)
                .HasForeignKey(e => e.IdAnhDaiDien);
        }
    }
}
