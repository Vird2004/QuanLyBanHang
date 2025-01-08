using QuanLyBanHang.DAL.Entities;
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

namespace QuanLyBanHang
{
    public partial class QlyDDH : Form
    {
        public QlyDDH()
        {
            InitializeComponent();
           
        }

        private void QlyDDH_Load(object sender, EventArgs e)
        {
            LoadDonHang();
        }

        private void LoadDonHang()
        {
            string folderPath = Path.Combine(Application.StartupPath, "DonHang");
            dgvOrder.Rows.Clear();

            if (Directory.Exists(folderPath))
            {
                var files = Directory.GetFiles(folderPath, "*.csv");
                foreach (var file in files)
                {
                    using (StreamReader reader = new StreamReader(file))
                    {
                        // Bỏ qua dòng tiêu đề
                        reader.ReadLine();

                        // Đọc dữ liệu từng dòng và thêm vào DataGridView
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var data = line.Split(',');
                            dgvOrder.Rows.Add(data);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Thư mục DonHang không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow != null && dgvOrder.CurrentRow.Index >= 0)
            {
                string orderID = dgvOrder.CurrentRow.Cells[0].Value.ToString();
                string folderPath = Path.Combine(Application.StartupPath, "DonHang");
                string filePath = Path.Combine(folderPath, $"{orderID}.csv");

                if (File.Exists(filePath))
                {
                    string txtFilePath = Path.Combine(folderPath, $"{orderID}.txt");

                    using (StreamReader reader = new StreamReader(filePath))
                    using (StreamWriter writer = new StreamWriter(txtFilePath))
                    {
                        // Tiêu đề
                        writer.WriteLine("HÓA ĐƠN");
                        writer.WriteLine("====================================");

                        // Đọc và ghi thông tin đơn hàng
                        writer.WriteLine($"Mã đơn hàng: {orderID}");
                        string line;
                        bool isFirstLine = true;

                        while ((line = reader.ReadLine()) != null)
                        {
                            if (isFirstLine)
                            {
                                writer.WriteLine("Chi tiết đơn hàng:");
                                writer.WriteLine("Sản phẩm\tSố lượng\tĐơn giá\tThành tiền");
                                isFirstLine = false;
                                continue;
                            }

                            var data = line.Split(',');
                            writer.WriteLine($"{data[2]}\t{data[3]}\t{data[4]}\t{data[5]}");
                        }
                        writer.WriteLine("====================================");
                    }

                    MessageBox.Show($"Hóa đơn đã được lưu tại: {txtFilePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu đơn hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
