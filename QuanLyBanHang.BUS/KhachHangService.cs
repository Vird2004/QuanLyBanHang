using QuanLyBanHang.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class KhachHangService
    {
        ModelBanHangDB modelBanHang = new ModelBanHangDB();
        //lay tat ca khach hang
        public List<KhachHang> GetAllKhachHang()
        {
            return new ModelBanHangDB().KhachHangs.ToList();
        }

        //them sua khach hang
        public void InsertUpdate(KhachHang kh)
        {
            ModelBanHangDB context = new ModelBanHangDB();
            context.KhachHangs.Add(kh);
            context.SaveChanges();
        }

        //xoa khach hang
        public void Delete(string maKH)
        {
            ModelBanHangDB context = new ModelBanHangDB();
            var kh = context.KhachHangs.FirstOrDefault(x => x.MaKH == maKH);
            if (kh != null)
            {
                context.KhachHangs.Remove(kh);
                context.SaveChanges();
            }
        }
    }
}
