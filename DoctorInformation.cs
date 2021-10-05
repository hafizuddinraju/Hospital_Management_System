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
    public partial class DoctorInformation : Form
    {
        public DoctorInformation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3Q7REGN;Initial Catalog=Hospital_Management_System;Integrated Security=True");
        private void DoctorInformation_Load(object sender, EventArgs e)
        {
            GetView();
        }
        public int DoctorID;

        private void GetView()
        {

            SqlCommand cmd = new SqlCommand("Select * From DoctorInformation", con);
            DataTable dt = new DataTable();
            con.Open();
           SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridViewDoctorInformation.DataSource = dt;
        }

        private void dataGridViewDoctorInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoctorID = Convert.ToInt32(dataGridViewDoctorInformation.Rows[0].Cells[0].Value);
            textBoxName.Text = dataGridViewDoctorInformation.SelectedRows[0].Cells[1].Value.ToString();
            textBoxSpecialist.Text = dataGridViewDoctorInformation.SelectedRows[0].Cells[2].Value.ToString();
            textBoxFloorNumber.Text = dataGridViewDoctorInformation.SelectedRows[0].Cells[3].Value.ToString();
            textBoxRoomNumber.Text = dataGridViewDoctorInformation.SelectedRows[0].Cells[4].Value.ToString();
            textBoxPhoneNumber.Text = dataGridViewDoctorInformation.SelectedRows[0].Cells[5].Value.ToString();
            textBoxFee.Text = dataGridViewDoctorInformation.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = DESKTOP-3Q7REGN; Database = Hospital_Management_System; Integrated Security = True ";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM DoctorInformation WHERE Name = '" + textBoxName.Text + "' or PhoneNumber = '" + textBoxPhoneNumber.Text + " ' ";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                textBoxName.Text = reader["Name"].ToString();
                textBoxSpecialist.Text = reader["Specialist"].ToString();
                textBoxFloorNumber.Text = reader["FloorNumber"].ToString();
                textBoxRoomNumber.Text = reader["RoomNumber"].ToString();
                textBoxPhoneNumber.Text = reader["PhoneNumber"].ToString();
                textBoxFee.Text = reader["Fee"].ToString();


            }
            else
            {
                MessageBox.Show("Doctor Record not found with this Database");
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
            textBoxSpecialist.Clear();
            textBoxFloorNumber.Clear();
            textBoxRoomNumber.Clear();
            textBoxPhoneNumber.Clear();
            textBoxFee.Clear();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (DoctorID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE DoctorInformation SET Name = @Name, Specialist = @Specialist, FloorNumber = @FloorNumber, RoomNumber = @RoomNumber, PhoneNumber = @PhoneNumber, Fee = @Fee WHERE DoctorID = @iD", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@Specialist", textBoxSpecialist.Text);
                cmd.Parameters.AddWithValue("@FloorNumber", textBoxFloorNumber.Text);
                cmd.Parameters.AddWithValue("@RoomNumber", textBoxRoomNumber.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", textBoxPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Fee", textBoxFee.Text);
                cmd.Parameters.AddWithValue("@ID", this.DoctorID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Doctor Information upDated", "UpDated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetView();
            }
            else
            {
                MessageBox.Show("Please Select Doctor Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
        }

        private void dataGridViewDoctorInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
