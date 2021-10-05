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
    public partial class PatientSignUp : Form
    {
        public PatientSignUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3Q7REGN;Initial Catalog=Hospital_Management_System;Integrated Security=True");

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Record values('" + textBoxName.Text + "','" + comboBoxGender.Text + "','" + textBoxAge.Text + "','" + comboBoxBloodGroup.Text + "','" + textBoxDisease.Text + "','" + textBoxBuilding.Text + "','" + textBoxBedNumber.Text + "','" + comboBoxBlock.Text + "','" + comboBoxBedQuality.Text + "','" + textBoxAdmitDate.Text + "','" + textBoxTotalCost.Text + "','" + textBoxPhoneNumber.Text + "','" + textBoxAddress.Text + "')";
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
            textBoxDisease.Clear();
            textBoxPhoneNumber.Clear();
            textBoxAddress.Clear();
            textBoxAge.Clear();
            textBoxBedNumber.Clear();
            textBoxAdmitDate.Clear();
            textBoxTotalCost.Clear();
            textBoxBuilding.Clear();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
        }
    }
}
