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
            HangHoa h = new HangHoa()
            { 
                
            
            };

        }

        private void BTN_find_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Order_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
