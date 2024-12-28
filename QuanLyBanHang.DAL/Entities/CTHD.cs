namespace QuanLyBanHang.DAL.Entities
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
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaHH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaHD { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(50)]
        public string DVT { get; set; }

        [StringLength(100)]
        public string GiaBan { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual HangHoa HangHoa { get; set; }
    }
}
