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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Linq;


namespace Griffindo_toys
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1HJGN96\\SQLEXPRESS;Initial Catalog=Grifindo_Toys_1;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtName.Clear();
            dateTimePicker1.Text = "";
            txtSalary.Clear();
            txtAllowance.Clear();
            txtOTRate.Clear();
            cmdEmpNo.Focus();

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            fillCombo();
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
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calculating base pay, gross pay, no pay
            double Base_pay, OT, No_pay, Gross_pay;
            double Monthly_Salary = Convert.ToDouble(txtSalary.Text);
            double Allowance = Convert.ToDouble(txtAllowance.Text);
            double Over_time_hours = Convert.ToDouble(txtAdd_hrs.Text);
            double Over_time_rate = Convert.ToDouble(txtOTRate.Text);
            double No_of_absent_days = Convert.ToDouble(txtNo_of_absent.Text);
            double Government_tax_rate = Convert.ToDouble(txtGovTax.Text);
            double Salary_cycle_Range = Convert.ToDouble(txtCycleDays.Text);

            OT = Over_time_hours * Over_time_rate;
            Base_pay = Monthly_Salary + Allowance + OT;
            No_pay = Monthly_Salary / Salary_cycle_Range * No_of_absent_days;
            Gross_pay = Base_pay - (No_pay + Base_pay * Government_tax_rate);

            txtBase_Pay.Text = Base_pay.ToString();
            txtGross_Pay.Text = Gross_pay.ToString();
            txtNo_Pay.Text = No_pay.ToString();


        }
        private void txtNo_of_leaves_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Searching for Employee details
            try
            {
                string sqlSearch;
                sqlSearch = "select * from Employee where Employee_No='" + cmdEmpNo.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlSearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtName.Text = dr["Employee_Name"].ToString();
                    txtSalary.Text = dr["Salary"].ToString();
                    txtAllowance.Text = dr["Allowances"].ToString();
                    txtOTRate.Text = dr["OT_Rate"].ToString();
                }
                else
                {
                    MessageBox.Show("Employee not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clear();
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            con.Close();
        }


        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            //Adding the calcualted values to the database into the payment table
            string Name = txtName.Text;
            DateTime Month = dateTimePicker5.Value;
            int Employee_No = int.Parse(cmdEmpNo.Text);
            float No_Pay = float.Parse(txtNo_Pay.Text);
            float Gross_Pay = float.Parse(txtGross_Pay.Text);
            float Base_Pay = float.Parse(txtBase_Pay.Text);


            try
            {
                string sqlInsert;
                sqlInsert = "insert into Salary (Employee_No, Name, Month,No_Pay, Base_Pay, Gross_Pay ) values ('" + cmdEmpNo.Text + "', '" + txtName.Text + "', '" + dateTimePicker5.Value + "', '" + txtNo_Pay.Text + "','" + txtBase_Pay.Text + "','" + txtGross_Pay.Text + "')";
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
            con.Close();
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker5.Format = DateTimePickerFormat.Custom;
            dateTimePicker5.CustomFormat = "MMMM";
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            //Validating data entered to form with the values in settings form

            try
            {
                string start = Convert.ToString(dateTimePicker1.Value.Date);
                string end = Convert.ToString(dateTimePicker2.Value.Date);

                string sqlSearch = "Select* from Settings";
                SqlCommand cmd = new SqlCommand(sqlSearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["Cycle_Begin_date"].ToString() == start && dr["Cycle_End_Date"].ToString() == end)
                    {
                        MessageBox.Show("Entered salary cycle dates are correct", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCycleDays.Text = dr["Date_Range"].ToString();
                        txtLeavesPerYear.Text = dr["No_of_Leaves_Per_year"].ToString();
                        txtGovTax.Text = dr["Government_Tax_Rate"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Salary cycle data.Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {

                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            con.Close();
        }
        private void cmdEmpNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Create an instance of Form7
            Form7 form7 = new Form7();
            // Show Form7
            form7.Show();


        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form7 report = new Form7();
            report.Show();
            this.Hide();
        }
    }
}
