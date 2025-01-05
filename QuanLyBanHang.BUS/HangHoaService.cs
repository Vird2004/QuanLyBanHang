using QuanLyBanHang.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class HangHoaService
    {
        //Khởi tạo đối tượng kết nối CSDL
        ModelBanHangDB modelBanHang = new ModelBanHangDB();

        //Phuong thuc lay tat ca hang hoa 
        public List<HangHoa> GetAllHangHoa()
        {
            return modelBanHang.HangHoas.ToList();
        }

        public List<HangHoa> GetAllHangHoa(Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1)
        {
            return modelBanHang.HangHoas.ToList();
        }
        //Lay hang theo id
        public HangHoa GetHangHoaByID(string maHH)
        {
            return modelBanHang.HangHoas.FirstOrDefault(p => p.MaHH == maHH);
        }

        //Phuong thuc tim hang hoa theo ma hang hoa
        public HangHoa FindByID(string maHH)
        {
            
            return modelBanHang.HangHoas.FirstOrDefault(p => p.MaHH == maHH);
        }

        public void InsertUpdate(HangHoa h) {
            ModelBanHangDB context = new ModelBanHangDB();
            context.HangHoas.AddOrUpdate(h);
            context.SaveChanges();
        }

        public void Delete(string maHH)
        {
            ModelBanHangDB context = new ModelBanHangDB();
            HangHoa h = context.HangHoas.FirstOrDefault(p => p.MaHH == maHH);
            context.HangHoas.Remove(h);
            context.SaveChanges();
        }
    }
}
