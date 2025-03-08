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
    public partial class frmLibrarianFunctionality : Form
    {
       //create librarianName and ID variables that are accessible in this current form
        public static string librarianName;
        public static string librarianID;
        public frmLibrarianFunctionality(string ID, string name)
        {
            InitializeComponent();
            librarianID = ID;
            librarianName = name;
            lblWelcomeLibrarian.Text = "Welcome back, " + librarianName+"!";
        }

        private void frmLibrarianFunctionality_Load(object sender, EventArgs e)
        {

        }

        private void btnReservationChanges_Click(object sender, EventArgs e)
        {
            this.Hide();
            //call reservation changes approval/rejection form
            frmLibrarianChangesApproval LCA = new frmLibrarianChangesApproval(librarianID, librarianName);
            LCA.ShowDialog();
            this.Close();
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            //call daily report form
            frmDailyReport DR = new frmDailyReport(librarianID, librarianName);
            DR.ShowDialog();
            this.Close();
        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            //call monthly report form
            frmMonthlyReport MR = new frmMonthlyReport(librarianID, librarianName);
            MR.ShowDialog();
            this.Close();
        }
        //Go back to Login Page
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            //call  Librarian Search form
            frmLibrarianSearch FormSearch = new frmLibrarianSearch(librarianID, librarianName);
            FormSearch.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
