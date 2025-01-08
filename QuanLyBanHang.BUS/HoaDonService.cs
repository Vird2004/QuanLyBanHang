using QuanLyBanHang.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class HoaDonService
    {
        ModelBanHangDB modelBH = new ModelBanHangDB();
        //lay danh sach hoa don
        public List<HoaDon> GetAllHoaDon()
        {
            return modelBH.HoaDons.ToList();
        }

        //Them hoa don
        public void InsertUpdate(HoaDon hoaDon)
        {
            if (string.IsNullOrEmpty(hoaDon.MaHD))
            {
                modelBH.HoaDons.Add(hoaDon);
            }
            else
            {
                var hoaDonIndex = modelBH.HoaDons.FirstOrDefault(hd => hd.MaHD == hoaDon.MaHD);
                hoaDonIndex.MaKH = hoaDon.MaKH;
                hoaDonIndex.MaNV = hoaDon.MaNV;
                hoaDonIndex.NgayLap = hoaDon.NgayLap;
                hoaDonIndex.TongTien = hoaDon.TongTien;
            }
            modelBH.SaveChanges();
        }

        //Xoa hoa don
        public void Delete(string maHD)
        {
            var hoaDonIndex = modelBH.HoaDons.FirstOrDefault(hd => hd.MaHD == maHD);
            modelBH.HoaDons.Remove(hoaDonIndex);
            modelBH.SaveChanges();
        }

        //Tim kiem hoa don
        public List<HoaDon> Search(string maHD)
        {
            return modelBH.HoaDons.Where(hd => hd.MaHD.Contains(maHD)).ToList();
        }

        //Lay hoa don theo ma hoa don
        public HoaDon GetHoaDonByMaHD(string maHD)
        {
            return modelBH.HoaDons.FirstOrDefault(hd => hd.MaHD == maHD);
        }

        //luu hoa don
        public void Save()
        {
            modelBH.SaveChanges();
        }

    }
}
