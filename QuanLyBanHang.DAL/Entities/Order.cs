using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL.Entities
{
    public class Order
    {
        public int OrderID { get; set; } // Mã đơn hàng (khóa chính)
        public string CustomerName { get; set; } // Tên khách hàng
        public DateTime OrderDate { get; set; } // Ngày đặt hàng

        // Liên kết với OrderDetail
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }

}
