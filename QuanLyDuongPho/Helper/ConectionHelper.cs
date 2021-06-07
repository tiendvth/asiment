using System.Data;
using MySql.Data.MySqlClient;
namespace QuanLyDuongPho.Helper
{
    public class ConectionHelper
    {
        private static string server = "localhost";
        private static string database = "connectcsharptomysql";
        private static string uid = "root";
        private static string password = "";
        private static MySqlConnection _Connection;

        public static MySqlConnection GetConnection()
        {
            if (_Connection == null || _Connection.State == ConnectionState.Closed )
            {
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
                                   database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";  
            }

            return _Connection;
        }
    }
}