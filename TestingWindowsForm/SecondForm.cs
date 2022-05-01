using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingWindowsForm
{
    public partial class SecondForm : Form
    {

        private readonly FirstForm _mainForm;
        public string id, first_name, last_name;

        public SecondForm(FirstForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;
        }

        public void PopulateDataToFormUpdate()
        {
            btn_save.Text = "Update";
            text_first_name.Text = first_name;
            text_last_name.Text = last_name;
        }

        public void ResetButtonToSave()
        {
            btn_save.Text = "Save";
        }

        public void ClearForm()
        {
            text_first_name.Text = text_last_name.Text = string.Empty;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (btn_save.Text.ToLower() == "save")
            {
                User user = new User(text_first_name.Text.Trim(), text_last_name.Text.Trim());
                DBUser.Create(user);
                ClearForm();
                _mainForm.LoadAndDisplayUserData();
            }

            if (btn_save.Text.ToLower() == "update")
            {
                User user = new User(text_first_name.Text.Trim(), text_last_name.Text.Trim());
                DBUser.Update(user, id);
                ClearForm();
                _mainForm.LoadAndDisplayUserData();
                this.Close();
            }
        }
    }
}
