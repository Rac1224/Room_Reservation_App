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
    public partial class frmStudentReservationChange : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["systemDB"].ToString());

        public static string studentID;
        public string oriReservationID;
        public string studentName;
        public frmStudentReservationChange(string rID, string stuID, string stuName)
        {
            InitializeComponent();
            oriReservationID = rID;
            studentID = stuID;
            studentName = stuName;

        }

        //Method to display Approved reservation records according to rooms selected in lstRoom
        private void viewReservationRecords(string roomName)
        {
           
            SqlCommand cmd = new SqlCommand("select * from reservation where roomName ='" + roomName + "' " +
                "and status='Approved' order by date desc;", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvReservation.DataSource = dt;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //display approved reservation records according to selected rooms
        private void lstRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string roomName;
            if (lstRoom.SelectedIndex == 0)
            {
                lblRoomDescription.Text = "Room: Amber 1 \nCapacity: 10 person \nLocation: Block A Level 1";
                roomName = "Amber 1";
                viewReservationRecords(roomName);

            }
            else if (lstRoom.SelectedIndex == 1)
            {
                lblRoomDescription.Text = "Room: Amber 2 \nCapacity: 10 person \nLocation: Block A Level 1";
                roomName = "Amber 2";
                viewReservationRecords(roomName);

            }
            else if (lstRoom.SelectedIndex == 2)
            {
                lblRoomDescription.Text = "Room: Amber 3 \nCapacity: 10 person \nLocation: Block A Level 1";
                roomName = "Amber 3";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 3)
            {
                lblRoomDescription.Text = "Room: Amber 4 \nCapacity: 10 person \nLocation: Block A Level 1";
                roomName = "Amber 4";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 4)
            {
                lblRoomDescription.Text = "Room: Amber 5 \nCapacity: 10 person \nLocation: Block A Level 1";
                roomName = "Amber 5";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 5)
            {
                lblRoomDescription.Text = "Room: BlackThorn 1 \nCapacity: 8 person \nLocation: Block B Level 1";
                roomName = "BlackThorn 1";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 6)
            {
                lblRoomDescription.Text = "Room: BlackThorn 2 \nCapacity: 8 person \nLocation: Block B Level 1";
                roomName = "BlackThorn 2";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 7)
            {
                lblRoomDescription.Text = "Room: BlackThorn 3 \nCapacity: 8 person \nLocation: Block B Level 1";
                roomName = "BlackThorn 3";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 8)
            {
                lblRoomDescription.Text = "Room: BlackThorn 4 \nCapacity: 8 person \nLocation: Block B Level 1";
                roomName = "BlackThorn 4";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 9)
            {
                lblRoomDescription.Text = "Room: Cedar 1 \nCapacity: 4 person \nLocation: Block A Level 3";
                roomName = "Cedar 1";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 10)
            {
                lblRoomDescription.Text = "Room: Cedar 2 \nCapacity: 4 person \nLocation: Block A Level 3";
                roomName = "Cedar 2";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 11)
            {
                lblRoomDescription.Text = "Room: Cedar 3 \nCapacity: 4 person \nLocation: Block A Level 3";
                roomName = "Cedar 3";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 12)
            {
                lblRoomDescription.Text = "Room: Cedar 4 \nCapacity: 4 person \nLocation: Block A Level 3";
                roomName = "Cedar 4";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 13)
            {
                lblRoomDescription.Text = "Room: Cedar 5 \nCapacity: 4 person \nLocation: Block A Level 3";
                roomName = "Cedar 5";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 14)
            {
                lblRoomDescription.Text = "Room: Cedar 6 \nCapacity: 4 person \nLocation: Block A Level 3";
                roomName = "Cedar 6";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 15)
            {
                lblRoomDescription.Text = "Room: Daphne 1 \nCapacity: 2 person \nLocation: Block B Level 2";
                roomName = "Daphne 1";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 16)
            {
                lblRoomDescription.Text = "Room: Daphne 2 \nCapacity: 2 person \nLocation: Block B Level 2";
                roomName = "Daphne 2";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 17)
            {
                lblRoomDescription.Text = "Room: Daphne 3 \nCapacity: 2 person \nLocation: Block B Level 2";
                roomName = "Daphne 3";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 18)
            {
                lblRoomDescription.Text = "Room: Daphne 4 \nCapacity: 2 person \nLocation: Block B Level 2";
                roomName = "Daphne 4";
                viewReservationRecords(roomName);
            }
            else if (lstRoom.SelectedIndex == 19)
            {
                lblRoomDescription.Text = "Room: Daphne 5 \nCapacity: 2 person \nLocation: Block B Level 2";
                roomName = "Daphne 5";
                viewReservationRecords(roomName);
            }
            else
            {
                lblRoomDescription.Text = "";
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            bool changeSuccess = false;
            //make sure user selects options for reservation, try code
            try
            {
                //get the room selected for the new reservation
                string selectedRoom = lstRoom.SelectedItem.ToString();

                //get the date for the new reservation
                string date = dtpDate.Value.ToString("dd/MM/yyyy");

                //get the start and end time of the session for the new reservation
                string selectedStartTime = date + " " + cmbStart.SelectedItem.ToString();
                string selectedEndTime = date + " " + cmbEnd.SelectedItem.ToString();
                DateTime startTime = Convert.ToDateTime(selectedStartTime);
                DateTime endTime = Convert.ToDateTime(selectedEndTime);
                
                //give status as Pending for the request to change reservation
                string status = "Pending";
                //create new object
                reservation changeReservation = new reservation(selectedRoom, date, startTime, endTime, oriReservationID, 
                    studentName, status);
                //call Student Request Change Reservation Method
                changeSuccess = changeReservation.studentRequestChangeReservation(changeSuccess, changeReservation.Room, changeReservation.Date, 
                    changeReservation.StartTime, changeReservation.EndTime, changeReservation.StudentID, changeReservation.StudentName, changeReservation.Status);
                if (changeSuccess == true) 
                    this.Close(); //if change request is successful, close the form
            }

            //catches any exception, for e.g: nullreferenceexception if user did not select a particular option
            catch (Exception)
            {
                MessageBox.Show("Error Occured!\nPlease select valid date and time for your reservation details!",
                                    "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmStudentReservationChange_Load(object sender, EventArgs e)
        {
            dgvReservation.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);  //change font size && style in datagridview header
            dgvReservation.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;     //change font color in datagridview header
            dgvReservation.ColumnHeadersDefaultCellStyle.BackColor = Color.LightYellow;    //change backcolor in datagridview header
            dgvReservation.EnableHeadersVisualStyles = false;

            //to display Start Time and End Time in HH:mm format
            dgvReservation.Columns[3].DefaultCellStyle.Format = "HH:mm tt";
            dgvReservation.Columns[4].DefaultCellStyle.Format = "HH:mm tt";

            //display current reservation record
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from reservation where reservationID='" + oriReservationID + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                
                lblCurrentReservation.Text = "Reservation ID: " + rd.GetInt32(0).ToString() + "\nRoom: " + rd.GetString(1) + "\nDate: "
                + rd.GetDateTime(2).ToString("dd/MM/yyyy") + "\nTime: " + rd.GetDateTime(3).ToString("HH:mm tt") + " - " + rd.GetDateTime(4).ToString("HH:mm tt")
                + "\nStatus: " + rd.GetString(7);
            }
      
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go back to student functionality form
            this.Close();
        }

        private void frmStudentReservationChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            //go back to student functionality form
            this.Close();
        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvReservation.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dgvReservation.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReservation.ColumnHeadersDefaultCellStyle.BackColor = Color.LightYellow;
        }
    }
}
