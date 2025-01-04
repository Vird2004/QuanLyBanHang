using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyBanHang.DAL
{
    internal class ConnectionStringHelper
    {
        public static string GetConnectionString()
        {
            // Lấy connection string gốc từ app.config
            string connectionString = ConfigurationManager.ConnectionStrings["ModelBanHangDB"].ConnectionString;

            // Lấy tên server từ máy tính hiện tại
            string serverName = Environment.MachineName + "\\SQLEXPRESS";

            // Thay thế {SERVER_NAME} bằng tên server thực tế
            connectionString = connectionString.Replace("{SERVER_NAME}", serverName);

            return connectionString;
        }
    }
}

