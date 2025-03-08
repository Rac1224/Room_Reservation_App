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
using System.Configuration;

namespace IOOP_ASSIGNMENT
{
    public partial class frmMonthlyReport : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["systemDB"].ToString());

        //create librarianName and ID variables that are accessible in this current form
        public static string librarianName;
        public static string librarianID;

        public frmMonthlyReport(string ID, string name)
        {
            InitializeComponent();
            librarianID = ID;
            librarianName = name;
        }

        private void frmMonthlyReport_Load(object sender, EventArgs e)
        {
            dgvReservation.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);  //change font size && style in datagridview header
            dgvReservation.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;     //change font color in datagridview header
            dgvReservation.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;    //change backcolor in datagridview header
            dgvReservation.EnableHeadersVisualStyles = false;

            //to display Start Time and End Time in HH:mm format
            dgvReservation.Columns[3].DefaultCellStyle.Format = "HH:mm tt";
            dgvReservation.Columns[4].DefaultCellStyle.Format = "HH:mm tt";
            //display report analysis layout
            lblReportAnalysis.Text = "Total Number of Reservations Approved: \nTotal Number of Reservations Cancelled/Rejected: " +
                "\nTotal Number of Reservations Pending: ";

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //to make sure that combo box has a selected room
            if (cmbOption.SelectedItem != null)
            {
                //if the selected item is "All Rooms"
                if (cmbOption.SelectedIndex == 0)
                {
                    con.Open();
                    string date = dateTimePicker1.Value.ToString("yyyy/MM"); //convert date time picker value to format yyyy/MM
                    DataTable dt = new DataTable();
                    report obj1 = new report(date);
                    //call view monthly all rooms report method from report class
                    obj1.viewMonthlyAllReport(dt, date);
                    dgvReservation.DataSource = dt;
                    string analysis= "";
                    //To analyse and calculate total number of reservations                    
                    lblReportAnalysis.Text = obj1.analyzeMonthlyAllReport(analysis, date); //display analysis
                    con.Close();
                }
                //if user selected specific room to display monthly report
                else
                {
                    con.Open();
                    string date = dateTimePicker1.Value.ToString("yyyy/MM");
                    DataTable dt = new DataTable();
                    string room = cmbOption.SelectedItem.ToString();
                    report obj1 = new report(room, date);
                    //call view monthly specific room report method from report class
                    obj1.viewMonthlySpecificReport(dt, date, room);
                    dgvReservation.DataSource = dt;
                    string analysis = "";
                    //To analyse and calculate total number of reservations                   
                    lblReportAnalysis.Text = obj1.analyzeMonthlySpecificReport(analysis, obj1.Date, obj1.RoomName); ; //display analysis
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a room to display monthly room utilization report!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPending_Click(object sender, EventArgs e)
        {

        }
        //go back to Librarian Functionality form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //go back to Librarian Functionality form
        private void frmMonthlyReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmLibrarianFunctionality FormLibrarianFunctionality = new frmLibrarianFunctionality(librarianID, librarianName);
            FormLibrarianFunctionality.ShowDialog();
            this.Close();
        }
    }
}
