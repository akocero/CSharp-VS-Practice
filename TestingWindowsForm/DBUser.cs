using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TestingWindowsForm
{
    class DBUser
    {

        public static void Create(User user)
        {
            string sql = "Insert Into users values (NULL, @first_name, @last_name)";

            MySqlConnection conn = DB.InitConnection();

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = user.firstName;
            cmd.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = user.lastName;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Succesfully");

            }catch(Exception ex)
            {
                MessageBox.Show("Student Not Added: "+ ex.Message);

            }

            conn.Close();
        }


        public static void Update(User user, string id)
        {
            string sql = "Update users Set first_name = @first_name, last_name = @last_name Where id = @id";
            MySqlConnection conn = DB.InitConnection();

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = user.firstName;
            cmd.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = user.lastName;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Succesfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Student Not Updated: " + ex.Message);

            }

            conn.Close();
        }

        public static void Delete(string id)
        {
            string sql = "Delete from users where id = @id";
            MySqlConnection conn = DB.InitConnection();

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Succesfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("User Not Deleted: " + ex.Message);

            }

        }


        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = DB.InitConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            try
            {
                adp.Fill(tbl);
                dgv.DataSource = tbl;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fetching Data Error: " + ex.Message);
            }
            


            conn.Close();

        }
    }
}
