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
            // TODO: This line of code loads data into the 'qLBHDataSet.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.qLBHDataSet.HangHoa);

        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BTN_minimize_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_resize(object sender, EventArgs e)
        {
            // Ví dụ: Hiển thị kích thước hiện tại của form trong tiêu đề
            this.Text = $"Kích thước: {this.Width} x {this.Height}";
        }
    }
}
