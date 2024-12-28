namespace QuanLyBanHang.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HangHoa")]
    public partial class HangHoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangHoa()
        {
            CTHDs = new HashSet<CTHD>();
        }

        [Key]
        [StringLength(50)]
        public string MaHH { get; set; }

        [StringLength(100)]
        public string TenHH { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(100)]
        public string DVT { get; set; }

        public double? GiaBan { get; set; }

        [Required]
        [StringLength(100)]
        public string MaKho { get; set; }

        [Required]
        [StringLength(100)]
        public string MaNCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }

        public virtual KhoHang KhoHang { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
