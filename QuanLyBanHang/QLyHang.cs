using QuanLyBanHang.DAL.Entities;
using QuanLyBanHang.BUS;
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
    public partial class QLyHang : Form
    {
        //Khởi tạo đối tượng kết nối CSDL
        ModelBanHangDB modelBanHang = new ModelBanHangDB();
        private readonly HangHoaService hangHoaService = new HangHoaService();
        public QLyHang()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.ShowDialog();
        }

        private void BTN_add_fix_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_MMH.Text.Trim() == "" || TXT_TMH.Text.Trim() == "" || TXT_SL.Text.Trim() == "" 
                    || TXT_DVT.Text.Trim() == "" || TXT_GiaBan.Text.Trim() == "" || TXT_MaKho.Text.Trim() == "" 
                    || TXT_MaNCC.Text.Trim() == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                //Kiem tra xem MaHH da ton tai chua
                var hanghoaIndex = modelBanHang.HangHoas.FirstOrDefault(hh => hh.MaHH == TXT_MMH.Text.Trim());

                if (hanghoaIndex != null)
                {
                    //Cap nhat hang hoa
                    hanghoaIndex.TenHH = TXT_TMH.Text.Trim();
                    hanghoaIndex.SoLuong = int.Parse(TXT_SL.Text.Trim());
                    hanghoaIndex.DVT = TXT_DVT.Text.Trim();
                    hanghoaIndex.GiaBan = int.Parse(TXT_GiaBan.Text.Trim());
                    hanghoaIndex.MaKho = TXT_MaKho.Text.Trim();
                    hanghoaIndex.MaNCC = guna2TextBox7.Text.Trim();



                    hangHoaService.InsertUpdate(hanghoaIndex); // Gọi hàm cập nhật

                    List<HangHoa> listHangHoa = hangHoaService.GetAllHangHoa(); // Lấy lại danh sách
                    BindGrid(listHangHoa); // Hiển thị lại
                    MessageBox.Show($"Cập nhật hàng hóa {TXT_TMH.Text} thành công");
                }
                else
                {
                    //Them hang hoa
                    HangHoa hangHoa = new HangHoa()
                    {
                        MaHH = TXT_MMH.Text.Trim(),
                        TenHH = TXT_TMH.Text.Trim(),
                        SoLuong = int.Parse(TXT_SL.Text.Trim()),
                        DVT = TXT_DVT.Text.Trim(),
                        GiaBan = int.Parse(TXT_GiaBan.Text.Trim()),
                        MaKho = TXT_MaKho.Text.Trim(),
                        MaNCC = guna2TextBox7.Text.Trim()
                    };

                    hangHoaService.InsertUpdate(hangHoa); // Gọi hàm thêm

                    List<HangHoa> listHangHoa = hangHoaService.GetAllHangHoa(); // Lấy lại danh sách
                    BindGrid(listHangHoa); // Hiển thị lại
                    MessageBox.Show($"Thêm hàng hóa {TXT_TMH.Text} thành công");
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Kiem tra xem hang hoa co ton tai khong
            var hangHoaDel = modelBanHang.HangHoas.FirstOrDefault(hh => hh.MaHH == TXT_MMH.Text.Trim());
            if (hangHoaDel != null)
            {
                hangHoaService.Delete(TXT_MMH.Text.Trim());
                List<HangHoa> listHangHoa = hangHoaService.GetAllHangHoa();
                BindGrid(listHangHoa);
                MessageBox.Show($"Xóa hàng hóa {TXT_TMH.Text} thành công");
            }
            else
            {
                MessageBox.Show($"Không tìm thấy hàng hóa {TXT_TMH.Text} để xóa");
            }
        }

        private void TXT_MaNCC_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void QLyHang_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(guna2DataGridView1);
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
            guna2DataGridView1.Rows.Clear();
            foreach (var item in listHangHoa)
            {
                int index = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[index].Cells[0].Value = item.MaHH;
                guna2DataGridView1.Rows[index].Cells[1].Value = item.TenHH;
                guna2DataGridView1.Rows[index].Cells[2].Value = item.SoLuong;
                guna2DataGridView1.Rows[index].Cells[3].Value = item.DVT;
                guna2DataGridView1.Rows[index].Cells[4].Value = item.GiaBan;
                guna2DataGridView1.Rows[index].Cells[5].Value = item.MaKho;
                guna2DataGridView1.Rows[index].Cells[6].Value = item.MaNCC;

                // Assuming you want to pass a specific image name for each item
                //  ShowAvatar(PICBOX_PROFILE, item.Avatar);
            }
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

        private void dgv_QlyHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu không có dòng nào được chọn
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                // Gán giá trị từ dòng được chọn vào các TextBox
                TXT_MMH.Text = row.Cells[0].Value?.ToString();
                TXT_TMH.Text = row.Cells[1].Value?.ToString();
                TXT_SL.Text = row.Cells[2].Value?.ToString();
                TXT_DVT.Text = row.Cells[3].Value?.ToString();
                TXT_GiaBan.Text = row.Cells[4].Value?.ToString();
                TXT_MaKho.Text = row.Cells[5].Value?.ToString();
                guna2TextBox7.Text = row.Cells[6].Value?.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
