using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_system
{
    public partial class AdminOrUserForm : Form
    {
        public AdminOrUserForm()
        {
            InitializeComponent();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Form userForm = new UserForm();
            userForm.Show();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
              Form adminLoginForm = new AdminLoginForm();
              adminLoginForm.Show();
        }

        private void AdminOrUserForm_Load(object sender, EventArgs e)
        {
        }

    }
}






