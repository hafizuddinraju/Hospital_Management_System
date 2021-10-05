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
    public partial class PatientInformation : Form
    {
        public PatientInformation()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            string connectionString = "Server = DESKTOP-3Q7REGN; Database = Hospital_Management_System; Integrated Security = True ";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Record WHERE Name = '" + textBoxName.Text + "' or PhoneNumber = '" + textBoxPhoneNumber.Text + " ' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                textBoxName.Text = reader["Name"].ToString();
                textBoxGender.Text = reader["Gender"].ToString();
                textBoxAge.Text = reader["Age"].ToString();
                textBoxBloodGroup.Text = reader["BloodGroup"].ToString();
                textBoxDisease.Text = reader["Disease"].ToString();
                textBoxBuilding.Text = reader["Building"].ToString();
                textBoxBedNumber.Text = reader["BedNumber"].ToString();
                textBoxBlock.Text = reader["Block"].ToString();
                textBoxBedQuality.Text = reader["BedQuality"].ToString();
                textBoxAdmitDate.Text = reader["AdmitDate"].ToString();
                textBoxTotalCost.Text = reader["TotalCost"].ToString();
                textBoxPhoneNumber.Text = reader["PhoneNumber"].ToString();
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
            textBoxGender.Clear();
            textBoxAge.Clear();
            textBoxBloodGroup.Clear();
            textBoxDisease.Clear();
            textBoxBuilding.Clear();
            textBoxBedNumber.Clear();
            textBoxBlock.Clear();
            textBoxBedQuality.Clear();
            textBoxAdmitDate.Clear();
            textBoxTotalCost.Clear();
            textBoxAddress.Clear();
            textBoxPhoneNumber.Clear();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
        }
    }
}
