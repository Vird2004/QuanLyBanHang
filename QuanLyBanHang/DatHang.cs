using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.BUS;
using QuanLyBanHang.DAL.Entities;

namespace QuanLyBanHang
{
    public partial class DatHang : Form
    {
        private readonly HangHoaService hangHoaService = new HangHoaService();
        private readonly OrderService orderService = new OrderService();
        private readonly HoaDonService hoaDonService = new HoaDonService();
        public DatHang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DatHang_Load(object sender, EventArgs e)
        {
            // Kiểm tra và tạo thư mục nếu chưa tồn tại
            string folderPath = Path.Combine(Application.StartupPath, "HoaDon"); // Thư mục "HoaDon" trong thư mục ứng dụng
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath); // Tạo thư mục
            }

            // Đường dẫn file CSV
            string filePath = Path.Combine(folderPath, "hoa_don.csv");

            try
            {
                setGridViewStyle(dgvHH);
                var listHangHoa = hangHoaService.GetAllHangHoa();
                BindGrid(listHangHoa);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
            UpdateProductComboBox();
        }
        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle =
DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void BindGrid(List<HangHoa> listHangHoa)
        {
            dgvHH.Rows.Clear();
            foreach (var item in listHangHoa)
            {
                int index = dgvHH.Rows.Add();
                dgvHH.Rows[index].Cells[0].Value = item.MaHH;
                dgvHH.Rows[index].Cells[1].Value = item.TenHH;
                dgvHH.Rows[index].Cells[2].Value = item.SoLuong;
                dgvHH.Rows[index].Cells[3].Value = item.DVT;
                dgvHH.Rows[index].Cells[4].Value = item.GiaBan;
                

                // Assuming you want to pass a specific image name for each item
                //  ShowAvatar(PICBOX_PROFILE, item.Avatar);
            }
        }
        private void UpdateProductComboBox()
        {
            // Lấy danh sách sản phẩm từ dịch vụ
            var products = hangHoaService.GetAllHangHoa(); // Giả định hàm này trả về danh sách sản phẩm

            // Xóa các mục cũ trong ComboBox
            cbSanPham.Items.Clear();

            // Thêm các sản phẩm mới vào ComboBox
            foreach (var product in products)
            {
                cbSanPham.Items.Add(product.TenHH);
            }

            // Chọn mục đầu tiên mặc định
            if (cbSanPham.Items.Count > 0)
            {
                cbSanPham.SelectedIndex = 0;
            }
        }

        private void dgvHH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDDH.Rows[e.RowIndex];

                // Hiển thị thông tin lên các ô nhập liệu
                txtName.Text = selectedRow.Cells[0].Value?.ToString();
                cbSanPham.SelectedItem = selectedRow.Cells[1].Value?.ToString();
                numSL.Value = Convert.ToInt32(selectedRow.Cells[2].Value ?? 0);
            }

        }

        private void btnSaveDH_Click(object sender, EventArgs e)
        {
            if (dgvDDH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kiểm tra và tạo folder nếu chưa tồn tại
                string folderPath = Path.Combine(Application.StartupPath, "DonHang");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Tạo tên file CSV (dùng mã đơn hàng làm tên file)
                string orderID = GenerateOrderID();
                string filePath = Path.Combine(folderPath, $"{orderID}.csv");

                // Mở file CSV để ghi dữ liệu
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Ghi dòng đầu tiên: tiêu đề cột
                    writer.WriteLine("MaDonHang,TenKhachHang,SanPham,SoLuong,DonGia,ThanhTien");

                    // Ghi dữ liệu từ DataGridView
                    foreach (DataGridViewRow row in dgvDDH.Rows)
                    {
                        if (row.Cells[0].Value != null) // Chỉ ghi các dòng có dữ liệu
                        {
                            writer.WriteLine($"{orderID}," +
                                $"{row.Cells[0].Value}," +
                                $"{row.Cells[1].Value}," +
                                $"{row.Cells[2].Value}," +
                                $"{row.Cells[3].Value}," +
                                $"{row.Cells[4].Value}");
                        }
                    }
                }

                MessageBox.Show("Lưu đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu đơn hàng: {ex.Message}\nChi tiết: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private decimal CalculateTotal()
        {
            decimal total = 0;

            // Duyệt qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dgvDDH.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    // Cộng dồn giá trị cột "Tổng giá" (cột thứ 4)
                    total += Convert.ToDecimal(row.Cells[4].Value);
                }
            }

            return total;
        }


        private void SaveDataToCSV(string orderId)
        {
            // Đường dẫn thư mục lưu hóa đơn
            string folderPath = Path.Combine(Application.StartupPath, "HoaDon");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Tên file CSV dựa trên mã hóa đơn
            string filePath = Path.Combine(folderPath, $"{orderId}.csv");

            // Ghi dữ liệu từ dgvDDH vào file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Ghi tiêu đề cột
                sw.WriteLine("Tên khách hàng,Tên sản phẩm,Số lượng,Đơn giá,Tổng giá");

                // Ghi dữ liệu từng dòng
                foreach (DataGridViewRow row in dgvDDH.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        sw.WriteLine($"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value},{row.Cells[3].Value},{row.Cells[4].Value}");
                    }
                }
            }
        }

        private decimal GetProductPrice(string productName)
        {
            var product = hangHoaService.GetHangHoaByName(productName);
            return (decimal)(product?.GiaBan ?? 0); // Giả định `Gia` là trường giá của sản phẩm
        }
        private void ClearInputFields()
        {
            txtName.Clear();
            cbSanPham.SelectedIndex = -1;
            numSL.Value = 0;
        }

        private void dgvDDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Change_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem dữ liệu đầu vào có hợp lệ không
            if (string.IsNullOrEmpty(txtName.Text) || cbSanPham.SelectedItem == null || numSL.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem sản phẩm đã có trong danh sách chưa
            var existingRow = dgvDDH.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.Cells[0].Value?.ToString() == txtName.Text
                                       && row.Cells[1].Value?.ToString() == cbSanPham.SelectedItem.ToString());

            if (existingRow != null)
            {
                // Nếu sản phẩm đã có, chỉ cập nhật số lượng và tổng giá
                existingRow.Cells[2].Value = (int)existingRow.Cells[2].Value + (int)numSL.Value; // Update quantity
                existingRow.Cells[4].Value = (int)existingRow.Cells[2].Value * Convert.ToDecimal(existingRow.Cells[3].Value); // Update total price
            }
            else
            {
                // Thêm dòng mới nếu sản phẩm chưa có trong danh sách
                dgvDDH.Rows.Add(
                    txtName.Text,                                 // Tên khách hàng
                    cbSanPham.SelectedItem.ToString(),           // Tên sản phẩm
                    (int)numSL.Value,                            // Số lượng
                    GetProductPrice(cbSanPham.SelectedItem.ToString()), // Giá sản phẩm
                    (int)numSL.Value * GetProductPrice(cbSanPham.SelectedItem.ToString()) // Tổng giá
                );
            }

            // Cập nhật tổng tiền trong lblTotal
            UpdateTotalAmount();

            // Làm sạch các ô nhập liệu
            ClearInputFields();
        }

        private void UpdateTotalAmount()
        {
            decimal totalAmount = 0;

            // Duyệt qua các dòng trong dgvDDH và tính tổng giá
            foreach (DataGridViewRow row in dgvDDH.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    totalAmount += Convert.ToDecimal(row.Cells[4].Value); // Cộng dồn tổng giá trị
                }
            }

            // Cập nhật tổng tiền vào lblTotal
            lblTotal.Text = "Tổng tiền: " + totalAmount.ToString("C");
        }
        private void numSL_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgvDDH.CurrentRow != null && dgvDDH.CurrentRow.Index >= 0)
            {
                dgvDDH.Rows.RemoveAt(dgvDDH.CurrentRow.Index);
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.ShowDialog();
        }
        private void UpdateOrderGridView()
        {
            var orders = hangHoaService.GetAllOrders();
            dgvDDH.Rows.Clear();

            foreach (var order in orders)
            {
                foreach (var detail in order.OrderDetails)
                {
                    dgvDDH.Rows.Add(order.OrderID, order.CustomerName, detail.MaHH, detail.SoLuong, detail.DonGia, detail.ThanhTien);
                }
            }
        }

        private string GenerateOrderID()
        {
            // Kết nối cơ sở dữ liệu để lấy danh sách đơn hàng
            using (var context = new ModelBanHangDB())
            {
                var lastOrder = context.HoaDons.OrderByDescending(o => o.MaHD).FirstOrDefault();

                if (lastOrder != null)
                {
                    // Lấy phần số trong mã đơn hàng cuối cùng
                    string lastNumber = lastOrder.MaHD.ToString().Substring(2);
                    int newNumber = int.Parse(lastNumber) + 1;
                    return "HD" + newNumber.ToString("D4"); // Format thành 4 chữ số
                }
            }
            return "HD0001"; // Nếu chưa có đơn hàng
        }


    }
}
