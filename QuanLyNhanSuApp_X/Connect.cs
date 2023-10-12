using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSuApp
{
    public class Connect
    {

        private string connectionString;

        public Connect()
        {
            connectionString = "Server=localhost;Database=employeems;Uid=root;Pwd=123;";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
