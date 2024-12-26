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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            frm_Login frmLogin = new frm_Login();
            DialogResult dialog = MessageBox.Show("Bạn có muốn quay lại không?", "Thoát", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                this.Close();
                frmLogin.ShowDialog();
                
            }
        }

        private void BTN_minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Thu nhỏ lại
                this.WindowState = FormWindowState.Normal;
                BTN_minimize.Text = "Phóng to"; // Cập nhật text của Button
            }
            else
            {
                // Phóng to
                this.WindowState = FormWindowState.Maximized;
                BTN_minimize.Text = "Thu nhỏ"; // Cập nhật text của Button
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
