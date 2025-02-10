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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1HJGN96\\SQLEXPRESS;Initial Catalog=Grifindo_Toys_1;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            txtEmpNo.Clear();
            txtName.Clear();
            txtAddress.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Text = "";
            cmdEmpNo.Text = "";
            txtTelNo.Clear();
            txtEmail.Clear();
            txtSalary.Clear();
            txtAllowances.Clear();
            txtOTRate.Clear();
            txtEmpNo.Focus();

        }

        private void fillCombo()
        {
            string sqlEmpID = "select Employee_No from Employee";
            SqlDataAdapter da = new SqlDataAdapter(sqlEmpID, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmdEmpNo.DataSource = dt;
            cmdEmpNo.DisplayMember = "Employee_No";
            cmdEmpNo.ValueMember = "Employee_No";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sqlDelete;
                sqlDelete = "delete from Employee where Employee_No ='" + txtEmpNo.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlDelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted", "Grifindo Toys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                con.Close();
            }


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            fillCombo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Using combo box to search for records
            try
            {
                string sqlSearch;
                sqlSearch = "select * from Employee where Employee_No='" + cmdEmpNo.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlSearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtEmpNo.Text = dr["Employee_No"].ToString();
                    txtName.Text = dr["Employee_Name"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                    if (dr["Gender"].Equals("M"))
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;

                    dateTimePicker1.Text = dr["DOB"].ToString();
                    txtTelNo.Text = dr["Telephone_No"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    txtSalary.Text = dr["Salary"].ToString();
                    txtAllowances.Text = dr["Allowances"].ToString();
                    txtOTRate.Text = dr["OT_Rate"].ToString();
                }
                else
                {
                    MessageBox.Show("Employee not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clear();
                }
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //using the textbox to insert records
            try
            {
                string gen;
                if (radioButton1.Checked == true)
                    gen = "M";
                else
                    gen = "F";
                string sqlInsert;
                sqlInsert = "insert into Employee (Employee_No, Employee_Name, Address, Gender, DOB, Telephone_No, Email, Salary, Allowances, OT_Rate) values ('" + txtEmpNo.Text + "', '" + txtName.Text + "', '" + txtAddress.Text + "', '" + gen + "','" + dateTimePicker1.Value + "','" + txtTelNo.Text + "','" + txtEmail.Text + "','" + txtSalary.Text + "','" + txtAllowances.Text + "','" + txtOTRate.Text + "')";
                SqlCommand cmd = new SqlCommand(sqlInsert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted", "Grifindo Toys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();  
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Using the textbox to update records
            try
            {
                string gen;
                if (radioButton1.Checked == true)
                    gen = "M";
                else
                    gen = "F";
                string sqlUpdate;
                sqlUpdate = "update Employee SET Employee_Name = '" + txtName.Text + "', Address = '" + txtAddress.Text + "', Gender = '" + gen + "', DOB ='" + dateTimePicker1.Value + "', Telephone_No ='" + txtTelNo.Text + "', Email ='" + txtEmail.Text + "', Salary = '" + txtSalary.Text + "', Allowances = '" + txtAllowances.Text + "', OT_Rate='" + txtOTRate.Text + "' where Employee_No = '" + txtEmpNo.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlUpdate, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated", "Grifindo Toys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }
    }
}
