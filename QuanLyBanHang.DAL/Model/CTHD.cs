namespace QuanLyBanHang.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHD")]
    public partial class CTHD
    {
        [Key]
        [StringLength(10)]
        public string MaCTHD { get; set; }

        [StringLength(10)]
        public string SoLuong { get; set; }

        [StringLength(100)]
        public string GiaBan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Required]
        [StringLength(10)]
        public string MaHH { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual HangHoa HangHoa { get; set; }
    }
}
