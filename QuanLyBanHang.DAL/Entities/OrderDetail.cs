using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL.Entities
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; } // Khóa chính của chi tiết đơn hàng
        public int OrderID { get; set; } // Khóa ngoại liên kết với Order
        public string MaHH { get; set; } // Mã hàng hóa (liên kết với HangHoa)
        public int SoLuong { get; set; } // Số lượng
        public decimal DonGia { get; set; } // Đơn giá
        public decimal ThanhTien { get; set; } // Thành tiền (SoLuong * DonGia)

        // Liên kết với Order
        public virtual Order Order { get; set; }
        // Liên kết với HangHoa
        public virtual HangHoa HangHoa { get; set; }
    }

}
