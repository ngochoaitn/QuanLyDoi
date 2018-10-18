namespace QuanLyDoi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAN_BO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCanBo { get; set; }

        [StringLength(50)]
        public string HoVaTen { get; set; }

        public int? IdCapBac { get; set; }

        public int? IdChucVu { get; set; }

        public int? IdAnhDaiDien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThangNamSinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetNapDang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayChuyenDangChinhThuc { get; set; }

        [StringLength(50)]
        public string TrinhDoNgoaiNgu { get; set; }

        [StringLength(50)]
        public string TrinhDoTinHoc { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        [StringLength(50)]
        public string TrinhDoLyLuanChinhTri { get; set; }

        [StringLength(50)]
        public string SoCMND { get; set; }

        [StringLength(50)]
        public string SoCMCA { get; set; }
    }
}
