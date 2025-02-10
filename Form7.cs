using Microsoft.Reporting.WinForms;
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

namespace Griffindo_toys
{
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1HJGN96\\SQLEXPRESS;Initial Catalog=Grifindo_Toys_1;Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            fillCombo();
        }
        private void fillCombo()
        {
            string sqlEmpID = "select Employee_No from Employee";
            SqlDataAdapter da = new SqlDataAdapter(sqlEmpID, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Employee_No";
            comboBox2.ValueMember = "Employee_No";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;

            SqlCommand command = new SqlCommand("SELECT * FROM Salary WHERE Employee_No = @EmployeeNo AND MONTH(Month) = @SelectedMonth", con);
            command.Parameters.AddWithValue("@EmployeeNo", comboBox2.Text);
            command.Parameters.AddWithValue("@SelectedMonth", selectedDate.Month);


            // Set the SqlCommand as the SelectCommand for the SqlDataAdapter
            SqlDataAdapter d = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            d.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportEmbeddedResource = "Griffindo_toys.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dateTimePicker3.Value;
            DateTime endDate = dateTimePicker4.Value;

            SqlCommand command = new SqlCommand("SELECT * FROM Salary WHERE Employee_No = @EmployeeNo AND Month BETWEEN @BeginDate AND @EndDate", con);
            command.Parameters.AddWithValue("@EmployeeNo", comboBox2.Text);
            command.Parameters.AddWithValue("@BeginDate", beginDate);
            command.Parameters.AddWithValue("@EndDate", endDate);

            // Set the SqlCommand as the SelectCommand for the SqlDataAdapter
            SqlDataAdapter d = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            d.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportEmbeddedResource = "Griffindo_toys.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime beginDate = dateTimePicker3.Value;
            DateTime endDate = dateTimePicker4.Value;

            SqlCommand command = new SqlCommand("SELECT * FROM Salary WHERE Month BETWEEN @BeginDate AND @EndDate", con);
            command.Parameters.AddWithValue("@BeginDate", beginDate);
            command.Parameters.AddWithValue("@EndDate", endDate);

            // Set the SqlCommand as the SelectCommand for the SqlDataAdapter
            SqlDataAdapter d = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            d.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportEmbeddedResource = "Griffindo_toys.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }

}
