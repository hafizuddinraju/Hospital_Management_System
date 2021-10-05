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
    public partial class PatientFindCheckOut : Form
    {
        public PatientFindCheckOut()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = DESKTOP-3Q7REGN; Database = Hospital_Management_System; Integrated Security = True ";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM CheckOutR WHERE PhoneNumber = '" + textBoxPhoneNumber.Text + " ' ";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                textBoxName.Text = reader["Name"].ToString();
                textBoxBloodGroup.Text = reader["BloodGroup"].ToString();

                textBoxAge.Text = reader["Age"].ToString();
                textBoxGender.Text = reader["Gender"].ToString();
                textBoxDisease.Text = reader["Disease"].ToString();
                textBoxCheckOutDate.Text = reader["CheckOutDate"].ToString();
                textBoxPayment.Text = reader["Payment"].ToString();
                textBoxAddress.Text = reader["Address"].ToString();

            }
            else
            {
                MessageBox.Show("Patient Record not found with this Database");
            }
            connection.Close();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void ResetPage()
        {
            textBoxName.Clear();
            textBoxAge.Clear();
            textBoxGender.Clear();
            textBoxBloodGroup.Clear();
            textBoxDisease.Clear();
            textBoxAddress.Clear();
            textBoxPayment.Clear();
            textBoxCheckOutDate.Clear();
            textBoxPhoneNumber.Clear();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
        }
    }
}
