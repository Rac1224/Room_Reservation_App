using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_ASSIGNMENT
{
    public partial class frmStudentFunctionality : Form
    {
        //create variable id and name to be used in this form
        public static string id;
        public static string name;
        public frmStudentFunctionality(string studentID, string studentName)
        {
            InitializeComponent();
            //accept and assign id and name value from previous form to this current form
            id = studentID;
            name = studentName;
            //Display Welcome Message
            lblWelcomeStudent.Text = "Welcome back, " + studentName+"!";
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Call New Reservation Form
            frmStudentNewReservation FormReserve = new frmStudentNewReservation(id, name);
            FormReserve.ShowDialog();
            this.Close();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            //call view/change/cancel reservation records form
            frmStudentReservationRecords FormRecords = new frmStudentReservationRecords(id, name);
            FormRecords.ShowDialog();
            this.Close();
        }

        private void frmStudentFunctionality_Load(object sender, EventArgs e)
        {
            
        }

        private void lblWelcomeStudent_Click(object sender, EventArgs e)
        {

        }
        //go back to Home Login page
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();            
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
