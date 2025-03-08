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
    public partial class frmDailyReport : Form
    {
        //create librarianName and ID variables that are accessible in this current form
        public static string librarianName;
        public static string librarianID;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["systemDB"].ToString());
        public frmDailyReport(string ID, string name)
        {
            InitializeComponent();
            librarianID = ID;
            librarianName = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDailyReport_Load(object sender, EventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go back to Librarian Functionality form
            this.Close();
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //to make sure that the combo box has a selected room
            if (cmbOption.SelectedItem != null)
            {
                //if the selected item is "All Rooms"
                if (cmbOption.SelectedIndex == 0)
                {
                    con.Open();
                    string date = dateTimePicker1.Value.ToString("yyyyMMdd");
                    DataTable dt = new DataTable();
                    report obj1 = new report(date);
                    //call view all rooms report method from report class
                    obj1.viewDailyAllReport(dt, date);                   
                    dgvReservation.DataSource = dt;

                    //To analyse and calculate total number of reservations                
                    string analysis = "";
                    lblReportAnalysis.Text = obj1.analyzeDailyAllReport(analysis, obj1.Date);
                    con.Close();
                }
                //user select specific rooms to generate report
                else
                {
                    con.Open();
                    string date = dateTimePicker1.Value.ToString("yyyyMMdd");
                    DataTable dt = new DataTable();
                    string room = cmbOption.SelectedItem.ToString();
                    report obj1 = new report(room, date);
                    //call view specific room report method from report class
                    obj1.viewDailySpecificReport(dt, date, room);
                    dgvReservation.DataSource = dt;

                    //To analyse and calculate total number of reservations
                    string analysis = "";
                    lblReportAnalysis.Text = obj1.analyzeDailySpecificReport(analysis, obj1.Date, obj1.RoomName);
                    con.Close();
                }
            }
            //display messagebox if user did not select a room option
            else
            {
                MessageBox.Show("Please select a room to generate daily room reservation report!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //go back to Librarian Functionality form
        private void frmDailyReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Close();
            frmLibrarianFunctionality FormLibrarian = new frmLibrarianFunctionality(librarianID, librarianName);
            FormLibrarian.ShowDialog();
            
        }

        private void frmDailyReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void gbReport_Enter(object sender, EventArgs e)
        {

        }
    }
}
