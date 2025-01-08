using QuanLyBanHang.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class QlyDDH : Form
    {
        public QlyDDH()
        {
            InitializeComponent();
            LoadOrderData();
        }

        private void QlyDDH_Load(object sender, EventArgs e)
        {

        }

        private void LoadOrderData()
        {
            using (var context = new ModelBanHangDB())
            {
                var orders = context.Orders.Select(o => new
                {
                    o.OrderID,
                    o.CustomerName,
                    o.OrderDate,
                    TongSoLuong = o.OrderDetails.Sum(c => c.SoLuong),
                    TongTien = o.OrderDetails.Sum(c => c.SoLuong * c.DonGia),
                  //  o.TrangThai,
                //    o.GhiChu
                }).ToList();

                dgvOrder.DataSource = orders;
            }
        }

    }
}
