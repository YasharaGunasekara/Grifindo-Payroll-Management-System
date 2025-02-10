using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Griffindo_toys
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1HJGN96\\SQLEXPRESS;Initial Catalog=Grifindo_Toys_1;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    con.Open();
                    string query = "SELECT * FROM Login WHERE UserName = @Username AND Password = @Password";
                    // Declare and assign values to UserName and password
                    string UserName = txtUserName.Text;
                    string Password = txtPassword.Text;
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@Username", UserName);
                        command.Parameters.AddWithValue("@Password", Password);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Correct credentials, navigate to the home page (Form3)
                            Form2 homePage = new Form2();
                            homePage.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }


    }

}