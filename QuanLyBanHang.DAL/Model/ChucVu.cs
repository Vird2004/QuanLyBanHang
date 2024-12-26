namespace QuanLyBanHang.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChucVu")]
    public partial class ChucVu
    {
        [Key]
        [StringLength(10)]
        public string MaCV { get; set; }

        [StringLength(100)]
        public string TenCV { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
