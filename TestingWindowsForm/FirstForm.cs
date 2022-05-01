using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TestingWindowsForm
{
    public partial class FirstForm : Form
    {

        SecondForm userModal;

        public FirstForm()
        {
            InitializeComponent();
            userModal = new SecondForm(this);
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            
            LoadAndDisplayUserData();
        }

        public void LoadAndDisplayUserData()
        {
            DBUser.DisplayAndSearch("Select id, first_name, last_name from users", dgv_users);
        }

        private void btn_add_new_Click(object sender, EventArgs e)
        {
            userModal.ClearForm();
            userModal.ResetButtonToSave();
            userModal.ShowDialog();
            
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            DBUser.DisplayAndSearch("Select id, first_name, last_name from users where first_name LIKE '%"+ text_search.Text +"%'", dgv_users);
        }

        private void dgv_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                userModal.id = dgv_users.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModal.first_name = dgv_users.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModal.last_name = dgv_users.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModal.PopulateDataToFormUpdate();
                userModal.ShowDialog();
                return;
            }

            if(e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                if(MessageBox.Show("Are you sure you want to delete this user?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBUser.Delete(dgv_users.Rows[e.RowIndex].Cells[2].Value.ToString());
                    LoadAndDisplayUserData();

                }
                return;
                
            }
            return;
        }
    }
}
