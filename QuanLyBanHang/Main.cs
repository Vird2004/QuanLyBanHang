using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHang.BUS;
using QuanLyBanHang.DAL.Entities;
using static Guna.UI2.Native.WinApi;
using System.IO;
using Guna.UI2.WinForms;
using System.Diagnostics;
using StackExchange.Profiling.Internal;

namespace QuanLyBanHang
{
    public partial class Main : Form
    {
        private readonly HangHoaService hangHoaService = new HangHoaService();

        public string Avatar { get; private set; }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try {
                setGridViewStyle(DGV_SqlData);
                var listHangHoa = hangHoaService.GetAllHangHoa();
                BindGrid(listHangHoa);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
        }

        private void BindGrid(List<HangHoa> listHangHoa)
        {
            DGV_SqlData.Rows.Clear();
            foreach (var item in listHangHoa)
            {
                int index = DGV_SqlData.Rows.Add();
                DGV_SqlData.Rows[index].Cells[0].Value = item.MaHH;
                DGV_SqlData.Rows[index].Cells[1].Value = item.TenHH;
                DGV_SqlData.Rows[index].Cells[2].Value = item.SoLuong;
                DGV_SqlData.Rows[index].Cells[3].Value = item.DVT;
                DGV_SqlData.Rows[index].Cells[4].Value = item.GiaBan;
                DGV_SqlData.Rows[index].Cells[5].Value = item.MaKho;
                DGV_SqlData.Rows[index].Cells[6].Value = item.MaNCC;

                // Assuming you want to pass a specific image name for each item
              //  ShowAvatar(PICBOX_PROFILE, item.Avatar);
            }
        }



        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            frm_Login frmLogin = new frm_Login();
            DialogResult dialog = MessageBox.Show("Bạn có muốn quay lại không?", "Thoát", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                this.Close();
                frmLogin.ShowDialog();
                Application.Restart();
            }
        }

        private void BTN_minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
           
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

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

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            QLyHang qLyHang = new QLyHang();
            this.Close();
            qLyHang.ShowDialog();

        }

        private void BTN_find_Click(object sender, EventArgs e)
        {
            string keyword = TXT_find.Text.Trim(); // Lấy từ khóa tìm kiếm từ TextBox

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Tìm kiếm bằng LINQ trong danh sách hàng hóa
                var listHangHoa = hangHoaService.GetAllHangHoa(); // Lấy tất cả dữ liệu từ CSDL
                var filteredList = listHangHoa.Where(hh =>
                    hh.MaHH.ToString().Contains(keyword) || // Tìm theo ID (MaHH)
                    hh.TenHH.Contains(keyword, StringComparison.OrdinalIgnoreCase) // Tìm theo tên (TenHH)
                ).ToList();

                // Bind lại dữ liệu vào DataGridView
                if (filteredList.Count > 0)
                {
                    BindGrid(filteredList); // Cập nhật DataGridView với dữ liệu lọc
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGV_SqlData.Rows.Clear(); // Xóa dữ liệu nếu không có kết quả
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_Order_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_guide_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HDSD_1.html");
            OpenFile(filePath);
        }

        private void OpenFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true // Mở bằng ứng dụng mặc định
                });
            }
            else
            {
                MessageBox.Show($"Không tìm thấy file: {filePath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_SqlData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_bill_Click(object sender, EventArgs e)
        {

        }
    }
}
//Scaffold-DbContext "DESKTOP-F44V7B6\SQLEXPRESS" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities
