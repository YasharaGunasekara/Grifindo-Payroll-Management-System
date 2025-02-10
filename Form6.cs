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

namespace Griffindo_toys
{
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1HJGN96\\SQLEXPRESS;Initial Catalog=Grifindo_Toys_1;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // DataTable to hold data
            DataTable employeeData = new DataTable();
            string query = "SELECT * FROM Employee";

            try
            {
                con.Open();

                // Fetch data from the database
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(employeeData);

                // Bind data to the DataGridView
                dataGridView1.DataSource = employeeData;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}


