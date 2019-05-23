using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_system
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }

        private bool IsCorrect(string input)
        {
            if (input == "Daria")
            {
                return true;
            }

            return false;
        }

        private void loginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (IsCorrect(loginBox.Text))
                {
                    this.Close();
                    Form adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (IsCorrect(loginBox.Text))
            {
                this.Close();
                Form adminForm = new AdminForm();
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }
    }
}

