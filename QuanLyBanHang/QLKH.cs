using QuanLyBanHang.BUS;
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
    public partial class QLKH : Form
    {
        private readonly KhachHangService khachHangService = new KhachHangService();
        public QLKH()
        {
            InitializeComponent();
        }

        private void QLKH_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvKH);
                var listHangHoa = khachHangService.GetAllKhachHang();
                BindGrid(listHangHoa);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
        }

        private void BindGrid(List<KhachHang> listHangHoa)
        {
            dgvKH.Rows.Clear();
            foreach(var item in listHangHoa)
            {
                int index = dgvKH.Rows.Add();
                dgvKH.Rows[index].Cells[0].Value = item.MaKH;
                dgvKH.Rows[index].Cells[1].Value = item.TenKH;
                dgvKH.Rows[index].Cells[2].Value = item.SDT;
                dgvKH.Rows[index].Cells[3].Value = item.DiaChi;
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            //kiem tra xem khach hang co ton tai khong
            var kh = khachHangService.GetAllKhachHang().FirstOrDefault(x => x.MaKH == txtMaKH.Text);
            if (kh != null)
            {
                khachHangService.Delete(txtMaKH.Text.Trim());
                MessageBox.Show("Xóa khách hàng thành công");
                BindGrid(khachHangService.GetAllKhachHang());
            }
            else
            {
                MessageBox.Show($"Không tìm thấy khách hàng {txtMaKH.Text} để xóa");
            }
        }

        private void btnAdd_Change_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text.Trim() == "" || txtTenKH.Text.Trim() == "" || txtSDT.Text.Trim() == "" || txtAddress.Text.Trim() == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                //kiem tra xem khach hang co ton tai khong
                var kh = khachHangService.GetAllKhachHang().FirstOrDefault(x => x.MaKH == txtMaKH.Text);

                if (kh != null)
                {
                    //cap nhat khach hang
                    kh.MaKH = txtMaKH.Text.Trim();
                    kh.TenKH = txtTenKH.Text.Trim();
                    kh.SDT = txtSDT.Text.Trim();
                    kh.DiaChi = txtAddress.Text.Trim();

                    //goi ham cap nhat
                    khachHangService.InsertUpdate(kh);

                    List<KhachHang> listKH = khachHangService.GetAllKhachHang();
                    BindGrid(listKH);
                    MessageBox.Show($"Cập nhật khách hàng {txtMaKH.Text} thành công");

                }
                else { }

                {
                    //them moi khach hang
                    KhachHang khachHang = new KhachHang()
                    {
                        MaKH = txtMaKH.Text.Trim(),
                        TenKH = txtTenKH.Text.Trim(),
                        SDT = txtSDT.Text.Trim(),
                        DiaChi = txtAddress.Text.Trim()
                    };
                    //goi ham them moi
                    khachHangService.InsertUpdate(khachHang);
                    List<KhachHang> listKH = khachHangService.GetAllKhachHang();
                    BindGrid(listKH);
                    MessageBox.Show($"Thêm khách hàng {txtMaKH.Text} thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
        }
    }
}
