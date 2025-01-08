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

        //lay danh sach hang hoa theo ten
        public List<HangHoa> Search(string tenHH)
        {
            return modelBanHang.HangHoas.Where(p => p.TenHH.Contains(tenHH)).ToList();
        }
        //Lay hang hoa theo ten
        public HangHoa GetHangHoaByName(string tenHH)
        {
            return modelBanHang.HangHoas.FirstOrDefault(p => p.TenHH == tenHH);
        }

        //luu hang hoa
        public void Save(HangHoa h)
        {
            modelBanHang.HangHoas.Add(h);
            modelBanHang.SaveChanges();
        }

        private List<Order> orderList = new List<Order>();

        // Save order
        public bool SaveOrder(string customerName, List<OrderDetail> orderDetails)
        {
            try
            {
                // Tạo đơn hàng mới
                var newOrder = new Order
                {
                    CustomerName = customerName,
                    OrderDate = DateTime.Now,
                    OrderDetails = orderDetails
                };

                // Lưu đơn hàng vào cơ sở dữ liệu
                modelBanHang.Orders.Add(newOrder);
                modelBanHang.SaveChanges();

                return true; // Lưu thành công
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                Console.WriteLine(ex.Message);
                return false; // Lưu thất bại
            }
        }

        // Method to retrieve all orders
        public List<Order> GetAllOrders()
        {
            return orderList;
        }

    }
}
