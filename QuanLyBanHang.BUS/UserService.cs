using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAL.Model;
using System.Security.Cryptography;

namespace QuanLyBanHang.BUS
{
    internal class UserService
    {
        public bool Login(string username, string password)
        {
            // Loại bỏ khoảng trắng dư thừa trong tên người dùng và mật khẩu
            username = username.Trim();
            password = password.Trim();
            // Kiểm tra thông tin đăng nhập
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            // Kiểm tra tên người dùng và mật khẩu
            using (var db = new QuanLyBanHang.DAL.Model.QLBHDB())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == password);
                return user != null;
            }
        }

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
