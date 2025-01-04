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

        public User GetUser(string username)
        {
            return modelBanHang.Users.FirstOrDefault(p => p.Username == username);
        }

        public bool ChangePassword(string username, string password)
        {
            User user = modelBanHang.Users.FirstOrDefault(p => p.Username == username);
            if (user != null)
            {
                user.Password = password;
                modelBanHang.SaveChanges();
                return true;
            }
            return false;
        }

        public bool AddUser(User user)
        {
            User user1 = modelBanHang.Users.FirstOrDefault(p => p.Username == user.Username);
            if (user1 == null)
            {
                modelBanHang.Users.Add(user);
                modelBanHang.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteUser(string username)
        {
            User user = modelBanHang.Users.FirstOrDefault(p => p.Username == username);
            if (user != null)
            {
                modelBanHang.Users.Remove(user);
                modelBanHang.SaveChanges();
                return true;
            }
            return false;

        }

        public bool UpdateUser(User user)
        {
            User user1 = modelBanHang.Users.FirstOrDefault(p => p.Username == user.Username);
            if (user1 != null)
            {
                user1.Password = user.Password;
                user1.Role = user.Role;
                modelBanHang.SaveChanges();
                return true;
            }
            return false;
        }
    }
}