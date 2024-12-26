namespace QuanLyBanHang.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoHang")]
    public partial class KhoHang
    {
        [Key]
        [StringLength(10)]
        public string MaKho { get; set; }

        public DateTime? NgayNhap { get; set; }

        [StringLength(10)]
        public string SoLuongNhap { get; set; }

        [StringLength(10)]
        public string SoLuongXuat { get; set; }

        [Required]
        [StringLength(10)]
        public string MaHH { get; set; }

        public virtual HangHoa HangHoa { get; set; }
    }
}
