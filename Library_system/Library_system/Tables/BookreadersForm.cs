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
    public partial class BookreadersForm : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source = DELL; Initial Catalog = lib_sys; Integrated Security = True";
        string sql = "SELECT * FROM Book_readers";

        public BookreadersForm()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                // делаем недоступным столбец id для изменения
                dataGridView1.Columns["id_Book_readers"].ReadOnly = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("AddBook_readers", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@IdReader", SqlDbType.Int, 0, "idReader"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Book", SqlDbType.Int, 0, "book"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Date_of_issue", SqlDbType.Date, 0, "date_of_issue"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Number_of_days", SqlDbType.Int, 0, "number_of_days"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Date_of_delivery", SqlDbType.Date, 0, "date_of_delivery"));

                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "id_Book_readers");
                parameter.Direction = ParameterDirection.Output;

                adapter.Update(ds);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void BookreadersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
