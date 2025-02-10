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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1HJGN96\\SQLEXPRESS;Initial Catalog=Grifindo_Toys_1;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        private void view()
        {
            string sqlSearch;
            sqlSearch = "select * from Settings";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtDateRange.Text = dr["Date_Range"].ToString();
                txtBeginDate.Text = dr["Cycle_Begin_Date"].ToString();
                txtEndDate.Text = dr["Cycle_End_Date"].ToString();
                txtLeaves.Text = dr["No_of_Leaves_Per_Year"].ToString();
                txtGovTax.Text = dr["Government_Tax_Rate"].ToString();
            }
            else
            {
                MessageBox.Show("Settings not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlUpdate;
            sqlUpdate = "update Settings SET Date_Range ='" + txtDateRange.Text + "', Cycle_Begin_Date = '" + txtBeginDate.Text + "',Cycle_End_Date = '" + txtEndDate.Text + "', No_of_Leaves_Per_Year = '" + txtLeaves.Text + "', Government_Tax_Rate = '" + txtGovTax.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlUpdate, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data updated", "Grifindo Toys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void Form5_Load_1(object sender, EventArgs e)
        {
            view();
        }

        private void txtBeginDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
