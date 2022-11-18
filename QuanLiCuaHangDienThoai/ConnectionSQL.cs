using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangDienThoai
{
    internal class ConnectionSQL
    {
        string username;
        string password;
        public ConnectionSQL(string username,string pass)
        {
            this.username = username;
            this.password = pass;
        }
        
        public string ConnString()
        {
            string connectionString = "Data Source =.; Initial Catalog = QuanLiCuaHangDienThoai;";
            string security = "user id=" + username + ";password=" + password + ";" + "Integrated Security = False";
            return connectionString+security;
        }

    }
}
