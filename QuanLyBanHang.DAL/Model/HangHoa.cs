namespace QuanLyBanHang.DAL.Model
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
            KhoHangs = new HashSet<KhoHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaHH { get; set; }

        [StringLength(100)]
        public string TenHH { get; set; }

        [StringLength(10)]
        public string SoLuong { get; set; }

        [StringLength(100)]
        public string DVT { get; set; }

        [StringLength(100)]
        public string GiaBan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhoHang> KhoHangs { get; set; }
    }
}
