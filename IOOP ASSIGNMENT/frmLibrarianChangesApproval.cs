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
    public partial class frmLibrarianChangesApproval : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["systemDB"].ToString());

        public string librarianID; //Librarian ID of the current user
        public string librarianName; //Name of the current user
        bool selectedChangeRequest = false; //to ensure user has selected a change request
        public string reservationID; //to capture reservationID of the reservation user selected
        public string roomName; //to capture room of the reservation user selected
        public string date; //to capture date of the reservation user selected
        public DateTime dt;
        public string startTime; //to capture the start time of the reservation user selected
        public DateTime st;
        public string endTime; //to capture the end time of the reservation user selected 
        public DateTime et;
        public string studentID; // to capture the student ID of the reservation user selected
        public string studentName; //to capture the student name of the reservation user selected
        public string status; //to capture reservation status of the reservation user selected

        //Method to display approved reservation of each selected room from lstroom
        public void reservationRecords(string roomName) 
        {
            SqlCommand cmd = new SqlCommand("select * from reservation where roomName ='" + roomName + "' and status='Approved' order by date desc;", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvReservedSlot.DataSource = dt;
        }

        public frmLibrarianChangesApproval(string ID, string nm)
        {
            InitializeComponent();
            librarianID = ID;
            librarianName = nm;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void frmLibrarianChangesApproval_Load(object sender, EventArgs e)
        {
            dgvReservedSlot.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);  //change font size && style in datagridview header
            dgvReservedSlot.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;     //change font color in datagridview header
            dgvReservedSlot.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;    //change backcolor in datagridview header
            dgvReservedSlot.EnableHeadersVisualStyles = false;

            dgvSelectStudent.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);  //change font size && style in datagridview header
            dgvSelectStudent.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;     //change font color in datagridview header
            dgvSelectStudent.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;    //change backcolor in datagridview header
            dgvSelectStudent.EnableHeadersVisualStyles = false;

            //to display Start Time and End Time in HH:mm format
            dgvSelectStudent.Columns[3].DefaultCellStyle.Format = "HH:mm tt";
            dgvSelectStudent.Columns[4].DefaultCellStyle.Format = "HH:mm tt";
            dgvReservedSlot.Columns[3].DefaultCellStyle.Format = "HH:mm tt";
            dgvReservedSlot.Columns[4].DefaultCellStyle.Format = "HH:mm tt";

            //To load the pending requests into the data grid view of the form
            SqlCommand cmd = new SqlCommand("select * from reservation where status='Pending';", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvSelectStudent.DataSource = dt;
            btnApprove.Focus();
        }

        private void lstRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string roomName;
            if (lstRoom.SelectedIndex == 0) 
            {
                roomName = "Amber 1";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 1) 
            {
                roomName = "Amber 2";
                reservationRecords(roomName);

            }

            else if (lstRoom.SelectedIndex == 2)
            {
                roomName = "Amber 3";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 3)
            {
                roomName = "Amber 4";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 4)
            {
                roomName = "Amber 5";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 5)
            {
                roomName = "BlackThorn 1";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 6)
            {
                roomName = "BlackThorn 2";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 7)
            {
                roomName = "BlackThorn 3";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 8)
            {
                roomName = "BlackThorn 4";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 9)
            {
                roomName = "Cedar 1";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 10)
            {
                roomName = "Cedar 2";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 11)
            {
                roomName = "Cedar 3";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 12)
            {
                roomName = "Cedar 4";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 13)
            {
                roomName = "Cedar 5";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 14)
            {
                roomName = "Cedar 6";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 15)
            {
                roomName = "Daphne 1";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 16)
            {
                roomName = "Daphne 2";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 17)
            {
                roomName = "Daphne 3";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 18)

            {
                roomName = "Daphne 4";
                reservationRecords(roomName);
            }

            else if (lstRoom.SelectedIndex == 19)
            {
                roomName = "Daphne 5";
                reservationRecords(roomName);
            }

            else
            {
                roomName = "";
                reservationRecords(roomName);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if(selectedChangeRequest == true)
            {
                //Reconfirm with user whether he/she wants to reject the change request
                DialogResult rejectConfirm = MessageBox.Show("Do you want to reject the reservation change request selected?\n" + "Reservation ID: "
                        + reservationID + "\nRoom: " + roomName + "\nDate: " + date + "\nTime: " + startTime + " - " + endTime 
                        + "\nStudent Name: " + studentName + "\nStudent ID: " + studentID+"\nStatus: "+status, "Rejection Confirmation", 
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rejectConfirm == DialogResult.OK)
                {
                    reservation obj1 = new reservation(reservationID);
                    //call librarian reject reservation change request method in reservation class
                    obj1.librarianRejectReservation(obj1.ReservationID);
                }
                else
                {
                    MessageBox.Show("Operation Cancelled!", "Change Request Rejection",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
            else
            {
                MessageBox.Show("Please select a record to proceed with rejection operation!",
                    "No Record Chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvSelectStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //capture details of record selected
            reservationID = dgvSelectStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            roomName = dgvSelectStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
            dt = Convert.ToDateTime(dgvSelectStudent.Rows[e.RowIndex].Cells[2].Value.ToString());
            st = Convert.ToDateTime(dgvSelectStudent.Rows[e.RowIndex].Cells[3].Value.ToString());
            startTime = st.ToString("HH:mm tt");
            et = Convert.ToDateTime(dgvSelectStudent.Rows[e.RowIndex].Cells[4].Value.ToString());
            endTime = et.ToString("HH:mm tt");
            studentID = dgvSelectStudent.Rows[e.RowIndex].Cells[5].Value.ToString();
            studentName = dgvSelectStudent.Rows[e.RowIndex].Cells[6].Value.ToString();
            status = dgvSelectStudent.Rows[e.RowIndex].Cells[7].Value.ToString();

            selectedChangeRequest = true; //user has selected a reservation to approve/reject
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if(selectedChangeRequest == true)
            {
                //Reconfirm with user whether he/she wants to approve the change request
                DialogResult approveConfirm = MessageBox.Show("Do you want to approve the reservation change request selected?\n" + "Reservation ID: "
                        + reservationID + "\nRoom: " + roomName + "\nDate: " + date + "\nTime: " + startTime + " - " + endTime
                        + "\nStudent Name: " + studentName + "\nStudent ID: " + studentID + "\nStatus: " + status, "Approval Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(approveConfirm == DialogResult.OK)
                {
                    bool boolExpired = false; //to check whether reservation change request date is still valid or has passed
                    bool boolOverlap = false; //to validate from reservation database

                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from reservation where status = 'Approved';", con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        string checkRoom = rd.GetString(1);
                        DateTime checkDate = rd.GetDateTime(2);
                        string checkDate2 = checkDate.ToString("dd/MM/yyyy");
                        DateTime checkStartTime = rd.GetDateTime(3);
                        DateTime checkEndTime = rd.GetDateTime(4);
                        //to check whether reservation change request details coincides with any of the approved bookings
                        if (checkRoom == roomName && checkDate2 == date)
                        {
                            if (checkStartTime < et && st < checkEndTime)
                            {
                                boolOverlap = true;
                                break;
                            }
                        }
                    }

                    con.Close();
                    //to verify whether the date of the change request is still valid
                    if (dt < DateTime.Today)
                    {
                        boolExpired = true; //date of change request has passed, it is invalid
                    }
                    con.Close();
                    //if there is no overlapping or clashing for the change request
                    if (boolOverlap == false)
                    {
                        if(boolExpired == false)
                        {
                            reservation obj1 = new reservation(reservationID);
                            //call Librarian Approve reservation change request method in reservation class
                            obj1.librarianApproveReservation(obj1.ReservationID);
                        }
                        else if(boolExpired == true)
                        {
                            MessageBox.Show("The reservation change request date has already passed.\n" +
                           "Please proceed to reject this reservation change request.", "Request Approval Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //if there is an overlapping for the change request
                    else if(boolOverlap == true)
                    {
                        MessageBox.Show("There is an existing reservation that prevents the approval of the current reservation change request.\n" +
                            "Please proceed to reject this reservation change request.", "Request Approval Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Operation Cancelled!", "Change Request Approval",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            //no record was selected by user to approve
            else
            {
                MessageBox.Show("Please select a record to proceed with approval operation!",
                   "No Record Chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //go back to the librarian functionality form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLibrarianChangesApproval_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Close();
            frmLibrarianFunctionality FormLibrarianFunctionality = new frmLibrarianFunctionality(librarianID, librarianName);
            FormLibrarianFunctionality.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
