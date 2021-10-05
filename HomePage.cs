using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Manament_Final_Project
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void buttonPatientSignUp_Click(object sender, EventArgs e)
        {
            PatientSignUp PSU = new PatientSignUp();
            PSU.Show();
        }

        private void buttonDoctorSignUp_Click(object sender, EventArgs e)
        {
            DoctorSignUp DSU = new DoctorSignUp();
            DSU.Show();
        }

        private void buttonPatientCheckOut_Click(object sender, EventArgs e)
        {
            PatientCheckOut PCO = new PatientCheckOut();
            PCO.Show();
        }

        private void buttonPatientInformation_Click(object sender, EventArgs e)
        {
            PatientInformation PI = new PatientInformation();
            PI.Show();
        }

        private void buttonPatientFindCheckout_Click(object sender, EventArgs e)
        {
            PatientFindCheckOut PFCO = new PatientFindCheckOut();
            PFCO.Show();
        }

        private void buttonDoctorInformation_Click(object sender, EventArgs e)
        {
            DoctorInformation DI = new DoctorInformation();
            DI.Show();
        }
    }
}
