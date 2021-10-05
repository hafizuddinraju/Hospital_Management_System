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
    public partial class PatientCheckOut : Form
    {
        public PatientCheckOut()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3Q7REGN;Initial Catalog=Hospital_Management_System;Integrated Security=True");

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into CheckOutR values('" + textBoxName.Text + "','" + comboBoxBloodGroup.Text + "','" + comboBoxGender.Text + "','" + textBoxAge.Text + "','" + textBoxDisease.Text + "','" + textBoxPhoneNumber.Text + "','" + textBoxCheckOutDate.Text + "','" + textBoxPayment.Text + "','" + textBoxAddress.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Save Successfully!");

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void ResetPage()
        {
            textBoxName.Clear();
            textBoxAddress.Clear();
            textBoxAge.Clear();
            textBoxDisease.Clear();
            textBoxPhoneNumber.Clear();
            textBoxCheckOutDate.Clear();
            textBoxPayment.Clear();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
        }
    }
}
