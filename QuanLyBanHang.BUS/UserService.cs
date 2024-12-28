using QuanLyBanHang.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class UserService
    {
        ModelBanHangDB modelBanHang = new ModelBanHangDB();

        public User Login(string username, string password)
        {
            return modelBanHang.Users.FirstOrDefault(p => p.Username == username && p.Password == password);
        }


    }
}
