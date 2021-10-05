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

namespace Hospital_Manament_Final_Project
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3Q7REGN;Initial Catalog=Hospital_Management_System;Integrated Security=True");

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO AdminTb VALUES(@ID, @Password)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", textBoxAdminID.Text);
                cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Record successfull save", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool IsValid()
        {
            if (textBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("Admin Record is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = DESKTOP-3Q7REGN; Database = Hospital_Management_System; Integrated Security = True ";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM  AdminTb WHERE ID = '" + textBoxAdminID.Text + "' and Password = '" + textBoxPassword.Text + " ' ";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                textBoxAdminID.Text = reader["ID"].ToString();
                textBoxPassword.Text = reader["Password"].ToString();

                HomePage HP = new HomePage();
                HP.Show();
               

            }
            else
            {
                MessageBox.Show("Admin not found with this Database");
            }
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resetpage();
        }

        private void Resetpage()
        {
            textBoxAdminID.Clear();
            textBoxPassword.Clear();
        }
    }
}
