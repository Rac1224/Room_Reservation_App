using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace IOOP_ASSIGNMENT
{
    class reservation
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["systemDB"].ToString());


        //member fields for reservation class
        private string reservationID;
        private string room;
        private string date;
        private DateTime startTime;
        private DateTime endTime;
        private string studentID;
        private string studentName;
        private string status;
        
        //get and set method for all member fields in this class
        public string ReservationID { get => reservationID; set => reservationID = value; }
        public string Room { get => room; set => room = value; }
        public string Date { get => date; set => date = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string Status { get => status; set => status = value; }

        
        //constructor of reservation class
        public reservation(string r, string d, DateTime st, DateTime et, string stuID, string stuName, string s)
        {
            ReservationID = "";
            Room = r;            
            Date = d;
            StartTime = st; 
            EndTime = et;
            StudentID = stuID;
            StudentName = stuName;
            Status = s;
        }
        //constructor of reservation class
        public reservation(string rID, string stuID)
        {
            ReservationID = rID;
            StudentID = stuID;
        }
        //constructor of reservation class
        public reservation(string rID)
        {
            ReservationID = rID;
        }

        //Method for student to create new reservation 
        public bool studentCreateNewReservation(bool reservationSuccess, string selectedRoom, string date, DateTime startTime, DateTime endTime, string id, string name, string status)
        {
            //to calculate the duration of the time slot selected
            TimeSpan duration = endTime - startTime;

            bool booldate = false; //to validate date
            bool booltime = false; //to validate time
            bool boolmorethan6hrs = false; //to check if the duration is > 6 hrs
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

                //to check whether selected reservation details coincides with any of the approved bookings
                if (checkRoom == selectedRoom && checkDate2 == date)
                {
                    if (checkStartTime < endTime && startTime < checkEndTime)
                    {
                        boolOverlap = true;
                        break;
                    }
                }
            }
            con.Close();
            DateTime selectedDate = Convert.ToDateTime(startTime);
            //check if date is valid
            if (selectedDate <= DateTime.Today.AddDays(2))
            {
                booldate = false;
            }
            else if (selectedDate > DateTime.Today.AddDays(2))
            {
                booldate = true;
            }
            //check if duration is valid
            if (duration.TotalMinutes <= 0)
            {
                booltime = false;
            }
            else if (duration.TotalMinutes > 360)
            {
                boolmorethan6hrs = true;
                booltime = true;
            }
            else
            {
                booltime = true;
            }
            if (booldate == true && booltime == true && boolmorethan6hrs == false && boolOverlap == false)
            {

                DialogResult room = MessageBox.Show("Reservation Slot Available! \n\nHere are your reservation details: \nRoom: "
                                   + selectedRoom + "\nDate: " + date +
                                   "\nTime: " + startTime.ToString("HH:mm tt") + " till " + endTime.ToString("HH:mm tt") + "\n\nDo you want to confirm this reservation?",
                                   "Reservation Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //confirmation of reservation request
                if (room == DialogResult.OK)
                {
                    reservation obj1 = new reservation(selectedRoom, date, startTime, endTime, id, name, status);
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("insert into reservation(roomName, date, startTime, endTime, studentID, " +
                                    "studentName, status) values (@rn, (convert(date, @d,103)) , @st, @et, @stID, @stName, @s) ", con);
                    //convert date @d 103 allows sql query to insert date in dd/mm/yyyy format

                    cmd2.Parameters.AddWithValue("@rn", obj1.Room);
                    cmd2.Parameters.AddWithValue("@d", obj1.Date);
                    cmd2.Parameters.AddWithValue("@st", obj1.StartTime);
                    cmd2.Parameters.AddWithValue("@et", obj1.EndTime);
                    cmd2.Parameters.AddWithValue("@stID", obj1.StudentID);
                    cmd2.Parameters.AddWithValue("@stName", obj1.StudentName);
                    cmd2.Parameters.AddWithValue("@s", obj1.Status);

                    int cnt = cmd2.ExecuteNonQuery();
                    //if reservation is added into database table successfully
                    if (cnt != 0)
                    {
                        MessageBox.Show("Reservation Successful!", "Reservation Details");
                        reservationSuccess = true;
                    }
                    //if reservation is not added into database table
                    else
                    {
                        MessageBox.Show("Reservation Unsuccessful! \nPlease try again later!", "Reservation Details");
                    }
                    con.Close();
                }
                //Cancel reservation request
                else
                {
                    MessageBox.Show("Reservation Attempt Cancelled!", "Reservation Details");
                }
            }
            //if user select more than 6 hours
            else if (booldate == true && booltime == true && boolmorethan6hrs == true && boolOverlap == false)
            {
                MessageBox.Show("Reservation Unavailable!\n\nError Occured!\nPlease select duration for less than 6 hours only!",
                                "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if user select less than 2 days in advance
            else if (booldate == false && booltime == true && boolmorethan6hrs == false && boolOverlap == false)
            {
                MessageBox.Show("Reservation Unavailable!\n\nError Occured!\nPlease select date at least 2 days in advance!",
                                "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if user select invalid information
            else
            {
                MessageBox.Show("Reservation Unavailable!\n\nError Occured!\nPlease select valid room, date, " +
                    "and time for your reservation details!",
                                "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return reservationSuccess;
        }
        

        //Method to change student existing room reservation
        public bool studentRequestChangeReservation(bool changeSuccess, string selectedRoom, string date, DateTime startTime, DateTime endTime, string oriReservationID, string name, string status)
        {
            TimeSpan duration = endTime - startTime; //calculate duration of new reservation session
            bool booldate = false; //to validate date
            bool booltime = false; //to validate time
            bool boolmorethan6hrs = false; //to check if the duration is > 6 hrs
            bool boolOverlap = false; //to validate from reservation database
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from reservation where status = 'Approved' and reservationID !='" + oriReservationID + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string checkRoom = rd.GetString(1);
                DateTime checkDate = rd.GetDateTime(2);
                string checkDate2 = checkDate.ToString("dd/MM/yyyy");
                DateTime checkStartTime = rd.GetDateTime(3);
                DateTime checkEndTime = rd.GetDateTime(4);

                //to check whether selected reservation details coincides with any of the approved bookings
                if (checkRoom == selectedRoom && checkDate2 == date)
                {
                    if (checkStartTime < endTime && startTime < checkEndTime)
                    {
                        boolOverlap = true;
                        break;
                    }
                }
            }
            con.Close();
            DateTime selectedDate = Convert.ToDateTime(startTime);
            //check if date is valid
            if (selectedDate > DateTime.Today.AddDays(2))
            {
                booldate = true;
            }
            else if (selectedDate <= DateTime.Today.AddDays(2))
            {
                booldate = false;
            }
            //check if duration is valid
            if (duration.TotalMinutes <= 0)
            {
                booltime = false;
            }
            else if (duration.TotalMinutes > 360)
            {
                boolmorethan6hrs = true;
                booltime = true;
            }
            else
            {
                booltime = true;
            }
            if (booldate == true && booltime == true && boolmorethan6hrs == false && boolOverlap == false)
            {

                DialogResult change = MessageBox.Show("Reservation Slot Available! \n\nHere are your new reservation details: \nRoom: "
                                   + selectedRoom + "\nDate: " + date +
                                   "\nTime: " + startTime.ToString("HH:mm tt") + " till " + endTime.ToString("HH:mm tt") 
                                   + "\n\nDo you want to confirm the changes above?",
                                   "Reservation Change Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //confirmation of reservation change request
                if (change == DialogResult.OK)
                {
                    con.Open();
                    reservation obj1 = new reservation(selectedRoom, date, startTime, endTime, oriReservationID, studentName, status);
                    SqlCommand cmd2 = new SqlCommand("update reservation set roomName = @rn, date= (convert(date, @d, 103)), " +
                            "startTime = @st, endTime = @et, status = @s where reservationID=' " + oriReservationID + "'", con);
                    //convert date @d 103 allows sql query to insert date in dd/mm/yyyy format
                    cmd2.Parameters.AddWithValue("@rn", obj1.Room);
                    cmd2.Parameters.AddWithValue("@d", obj1.Date);
                    cmd2.Parameters.AddWithValue("@st", obj1.StartTime);
                    cmd2.Parameters.AddWithValue("@et", obj1.EndTime);
                    cmd2.Parameters.AddWithValue("@stID", obj1.StudentID);
                    cmd2.Parameters.AddWithValue("@s", obj1.Status);
                    int cnt = cmd2.ExecuteNonQuery();
                    if (cnt != 0)
                    {
                        MessageBox.Show("Reservation Details Changed!\nPlease wait 1-2 days for the " +
                            "approval from librarian.", "Reservation Details");
                        changeSuccess = true;
                    }
                    else
                    {
                        MessageBox.Show("Reservation Change Unsuccessful! \nPlease try again later!", "Reservation Details");
                    }
                    con.Close();
                }
                //Cancel reservation change request
                else
                {
                    MessageBox.Show("Reservation Change Attempt Cancelled!", "Reservation Details");
                }
            }
            //if user select more than 6 hours
            else if (booldate == true && booltime == true && boolmorethan6hrs == true && boolOverlap == false)
            {
                MessageBox.Show("Reservation Unavailable!\n\nError Occured!\nPlease select duration for less than 6 hours only!",
                                "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if user select less than 2 days in advance
            else if (booldate == false && booltime == true && boolmorethan6hrs == false && boolOverlap == false)
            {

                MessageBox.Show("Reservation Unavailable!\n\nError Occured!\nPlease select date at least 2 days in advance!",
                                "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if user select any other invalid information
            else
            {
                MessageBox.Show("Reservation Unavailable!\n\nError Occured!\nPlease select valid date and time for your reservation details!",
                                "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return changeSuccess;
        }
        
        //Method for Student Cancel Reservation 
        public void studentCancelReservation(string reservationID)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update reservation set status ='Cancelled' where reservationID ='" + reservationID 
                + "';", con);
            int cnt = cmd.ExecuteNonQuery();
            if (cnt != 0)
            {
                MessageBox.Show("Reservation is cancelled sucessfully!", "Reservation Cancellation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Cancellation is unsuccessful due to system error! Please try again later",
                    "Reservation Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }
        //Method for Librarian to Reject Reservation Change Request
        public void librarianRejectReservation(string rID)
        {
            con.Open();
            DataTable obj1 = new DataTable();
            SqlCommand cmd = new SqlCommand("update reservation set status ='Rejected' where reservationID ='" + rID + "';", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The reservation change request has been rejected!", 
                "Rejection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Method for Lirbraian to Approve Reservation Change Request
        public void librarianApproveReservation(string rID)
        {
            con.Open();
            DataTable obj1 = new DataTable();
            SqlCommand cmd2 = new SqlCommand("update reservation set status ='Approved' where reservationID ='" + rID + "';", con);
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The reservation change request has been approved!", "Request Approved", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Method for Librarian to Search Reservation Records according to Student ID
        public DataTable librarianSearchStudentID(DataTable dt, string search)
        {
            SqlCommand cmd = new SqlCommand("select * from reservation where studentID = '" + search 
                + "' order by date desc;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //Method for Librarian to Search Reservation Records according to integer values for Reservation and Student ID
        public DataTable librarianSearchIntegerID(DataTable dt, int searchID)
        {
            SqlCommand cmd = new SqlCommand("select * from reservation where studentID = '" + searchID.ToString() 
                + "' or reservationID = " + searchID + " order by date desc;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //Method for Students to Search Reservation Records according to Reservation ID
        public DataTable studentSearchReservation(DataTable dt, string bookingID, string id)
        {
            SqlCommand cmd = new SqlCommand("select * from reservation where studentID = '" + id + "' and reservationID = '" 
                + Convert.ToInt32(bookingID) + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
