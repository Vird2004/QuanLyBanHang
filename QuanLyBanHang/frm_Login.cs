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
using Umbraco.Core.Runtime;



namespace QuanLyBanHang
{
    public partial class frm_Login : Form
    {
        private BUS.UserService userService = new UserService();
        public static User CurrentUser;

        bool isPasswordVisible = false;
        public frm_Login()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void gbLogin_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            // Loại bỏ khoảng trắng dư thừa trong tên người dùng và mật khẩu
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            CurrentUser = userService.Login(username, password);
            /*/ Kiểm tra thông tin đăng nhập
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thông tin đăng nhập với cơ sở dữ liệu hoặc cấu hình
            if (username == "admin" && password == "123456")
            {
                // Chuyển hướng đến form Main
                Main mainForm = new Main();
                mainForm.Show();
                this.Hide(); // Ẩn Form1
            }
            else
            {
                // Hiển thị thông báo khi thông tin không chính xác
                MessageBox.Show("Sai mật khẩu hoặc tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } */

            if (CurrentUser != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                Main mainForm = new Main();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private void BTN_GUIDE_Click(object sender, EventArgs e)
        {

        }

        private void BTN_ViewPass_Click(object sender, EventArgs e)
        {

            if(isPasswordVisible)
    {
                txtPassword.PasswordChar = '*';
            }
    else
            {
                txtPassword.PasswordChar = '\0';
            }
            isPasswordVisible = !isPasswordVisible; // Đảo trạng thái
        }
    }
}

