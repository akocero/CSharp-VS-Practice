using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace TestingWindowsForm
{
    class DB
    {
        public static MySqlConnection InitConnection()
        {
            string connString = "server=127.0.0.1;uid=root;pwd=root;database=testvs";

            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Mysql Connection Error: " + ex.Message);
            }
            return conn;

        }
    }
}
