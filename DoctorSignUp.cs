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
    public partial class DoctorSignUp : Form
    {
        public DoctorSignUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3Q7REGN;Initial Catalog=Hospital_Management_System;Integrated Security=True");

        private void buttonSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into DoctorInformation values('" + textBoxName.Text + "','" + textBoxSpecialist.Text + "','" + textBoxFloorNumber.Text + "','" + textBoxRoomNumber.Text + "','" + textBoxPhoneNumber.Text + "','" + textBoxFee.Text + "')";
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
            textBoxSpecialist.Clear();
            textBoxFloorNumber.Clear();
            textBoxRoomNumber.Clear();
            textBoxPhoneNumber.Clear();
            textBoxFee.Clear();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
        }
    }
}
