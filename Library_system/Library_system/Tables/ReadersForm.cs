using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Library_system
{
    public partial class ReadersForm : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source = DELL; Initial Catalog = lib_sys; Integrated Security = True";
        //string sql = "SELECT id_Readers as ID, full_name as ФИО, age as Возраст, address_reader as Адрес, phone_number as Номер_телефона, email FROM Readers";
        string sql = "SELECT * FROM Readers";

        public ReadersForm()
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
                dataGridView1.Columns["id_Readers"].ReadOnly = true;
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
                adapter.InsertCommand = new SqlCommand("AddReaders", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Full_name", SqlDbType.NVarChar, 70, "full_name"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Age", SqlDbType.Int, 0, "age"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Address_reader", SqlDbType.NVarChar, 70, "address_reader"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Phone_number", SqlDbType.NVarChar, 50, "phone_number"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 70, "email"));

                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");
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

        private void ReadersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
