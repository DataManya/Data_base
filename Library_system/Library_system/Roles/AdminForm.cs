using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_system
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

         private void readerBtn_Click(object sender, EventArgs e)
        {
            Form readersForm = new ReadersForm();
            readersForm.Show();
        }

        private void bookreadersBtn_Click(object sender, EventArgs e)
        {
            Form bookreadersForm = new BookreadersForm();
            bookreadersForm.Show();
        }

        private void debtorBtn_Click(object sender, EventArgs e)
        {
            Form debtorsForm = new DebtorsForm();
            debtorsForm.Show();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            Form booksForm = new BooksForm();
            booksForm.Show();
        }

         private void bookinstancesBtn_Click(object sender, EventArgs e)
        {
            Form booksinstancesForm = new BooksinstancesForm();
            booksinstancesForm.Show();
        }

        private void publishinghouseBtn_Click(object sender, EventArgs e)
        {
            Form publishinghouseForm = new PublishinghouseForm();
            publishinghouseForm.Show();
        }

        private void editionBtn_Click(object sender, EventArgs e)
        {
            Form editionForm = new EditionForm();
            editionForm.Show();
        }

        private void languagebookBtn_Click(object sender, EventArgs e)
        {
            Form languagebookForm = new LanguagebookForm();
            languagebookForm.Show();
        }      

        private void gunrebookBtn_Click(object sender, EventArgs e)
        {
            Form bookgenreForm = new BookgenreForm();
            bookgenreForm.Show();
        }

        private void gunresBtn_Click(object sender, EventArgs e)
        {
            Form genresForm = new GenresForm();
            genresForm.Show();
        }

        private void authorsBtn_Click(object sender, EventArgs e)
        {
            Form authorsForm = new AuthorsForm();
            authorsForm.Show();
        }

        private void authorsbookBtn_Click(object sender, EventArgs e)
        {
            Form bookauthorForm = new BookauthorForm();
            bookauthorForm.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void readersBookBtn_Click(object sender, EventArgs e)
        {
            


        }
    }
}
