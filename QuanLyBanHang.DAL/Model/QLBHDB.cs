using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyBanHang.DAL.Model
{
    public partial class QLBHDB : DbContext
    {
        public QLBHDB()
            : base("name=QLBHDB")
        {
        }

        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }
        public virtual DbSet<CuaHang> CuaHangs { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhoHang> KhoHangs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>()
                .Property(e => e.MaCV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaCTHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.SoLuong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.GiaBan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaHH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CuaHang>()
                .Property(e => e.MaCH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CuaHang>()
                .HasMany(e => e.NhanViens)
                .WithRequired(e => e.CuaHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaHH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.SoLuong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.GiaBan)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.HangHoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HangHoa>()
                .HasMany(e => e.KhoHangs)
                .WithRequired(e => e.HangHoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhoHang>()
                .Property(e => e.MaKho)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhoHang>()
                .Property(e => e.SoLuongNhap)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhoHang>()
                .Property(e => e.SoLuongXuat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhoHang>()
                .Property(e => e.MaHH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.HangHoas)
                .WithRequired(e => e.NhaCungCap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Phai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaCH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.ChucVus)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
