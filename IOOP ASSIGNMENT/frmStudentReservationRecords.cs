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
    public partial class frmStudentReservationRecords : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["systemDB"].ToString());
        public static string id; //Student ID of user
        public static string name; //studdent name of user
        public string reservationID; //to capture reservationID of the reservation user selected
        public string roomName; //to capture room of the reservation user selected
        public string date; //to capture date of the reservation user selected
        public string startTime; //to capture the start time of the reservation user selected
        public string endTime; //to capture the end time of the reservation user selected 
        public string status; //to capture reservation status of the reservation user selected
        bool recordClicked = false; //to make sure a record is choosed to proceed change/cancellation
        public frmStudentReservationRecords(string studentID, string studentName)
        {
            InitializeComponent();
            id = studentID;
            name = studentName;
        }



        private void btnChange_Click(object sender, EventArgs e)
        {
            //user selected a record to change
            if (recordClicked == true)
            {
                //call Change reservation form if status is approved/pending
                if (status == "Approved" || status == "Pending")
                {
                    this.Hide();
                    frmStudentReservationChange formChangeReservation = new frmStudentReservationChange(reservationID, id, name);
                    formChangeReservation.ShowDialog();
                    this.Close();
                }
                //display error message if status is rejected or cancelled
                else if (status == "Rejected" || status == "Cancelled")
                {
                    MessageBox.Show("You cannot change a reservation with rejected or cancelled status!", "Invalid Operation",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            //display error message if user did not select any records
            else
            {
                MessageBox.Show("Please select a record to proceed making changes!",
                    "No Record Chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmStudentReservationRecords_Load(object sender, EventArgs e)
        {
            dgvReservation.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);  //change font size && style in datagridview header
            dgvReservation.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;     //change font color in datagridview header
            dgvReservation.ColumnHeadersDefaultCellStyle.BackColor = Color.LightYellow;    //change backcolor in datagridview header
            dgvReservation.EnableHeadersVisualStyles = false;

            //to display Start Time and End Time in HH:mm format
            dgvReservation.Columns[3].DefaultCellStyle.Format = "HH:mm tt";
            dgvReservation.Columns[4].DefaultCellStyle.Format = "HH:mm tt";

            txtSearch.Select(); //to highlight and select all the values of instructions in the textbox

            //to display all records of the student's reservation when the form loads
            SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' order by roomName;", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvReservation.DataSource = dt;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (recordClicked == true)
            {
                if (status == "Approved" || status == "Pending")
                {
                    //Confirm with user on the cancellation of the reservation record
                    DialogResult cancel = MessageBox.Show("Are you sure you want to cancel this record?\n" + "Reservation ID: " + reservationID
                        + "\nRoom: " + roomName + "\nDate: " + date + "\nTime: " + startTime + " - " + endTime, "Record Cancellation Confirmation",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    //user confirms cancellation
                    if (cancel == DialogResult.OK)
                    {
                        reservation obj1 = new reservation(reservationID);
                        //call Student Cancel Reservation method
                        obj1.studentCancelReservation(obj1.ReservationID);
                    }
                    //user cancels cancellation operation
                    else
                    {
                        MessageBox.Show("Operation Cancelled!", "Reservation Cancellation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                //display error message if status is rejected or cancelled
                else if (status == "Rejected" || status == "Cancelled")
                {
                    MessageBox.Show("You cannot cancel a reservation with rejected or cancelled status!", "Invalid Operation",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please select a record to proceed with cancellation operation!",
                    "No Record Chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //Event that allows Reservation Change Form to capture the Reservation Record needed to change
        private void dgvReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            recordClicked = true; //change bool to validate user has clicked on a record

            //capture details of record selected

            reservationID = dgvReservation.Rows[e.RowIndex].Cells[0].Value.ToString();
            roomName = dgvReservation.Rows[e.RowIndex].Cells[1].Value.ToString();
            DateTime dt = Convert.ToDateTime(dgvReservation.Rows[e.RowIndex].Cells[2].Value.ToString());
            date = dt.ToString("dd/MM/yyyy");
            DateTime st = Convert.ToDateTime(dgvReservation.Rows[e.RowIndex].Cells[3].Value.ToString());
            startTime = st.ToString("HH:mm tt");
            DateTime et = Convert.ToDateTime(dgvReservation.Rows[e.RowIndex].Cells[4].Value.ToString());
            endTime = et.ToString("HH:mm tt");
            status = dgvReservation.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //go back to student functionality form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //go back to student functionality form
        private void frmStudentReservationRecords_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmStudentFunctionality FormStudent = new frmStudentFunctionality(id, name);
            FormStudent.ShowDialog();
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblResults.Text = "";
            //display records with ALL status 
            if (cmbFilter.SelectedIndex == 0)
            {

                //no sort order
                if (cmbOrder.SelectedIndex == -1)
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "';", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;

                }
                //sort by dates for all status record
                else if (cmbOrder.SelectedIndex == 0)
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' order by date desc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by reservation ID for all status record
                else if (cmbOrder.SelectedIndex == 1)
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' order by reservationID desc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by Room Name for all status record
                else if (cmbOrder.SelectedIndex == 2)
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' order by roomName;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }


            }
            //to display PENDING reservation records of student
            else if (cmbFilter.SelectedIndex == 1)
            {


                //no sort order for Pending status record
                if (cmbOrder.SelectedIndex == -1)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Pending';", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by dates for Pending status record
                else if (cmbOrder.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Pending' order by date desc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by reservation ID for Pending status record
                else if (cmbOrder.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Pending'order by reservationID desc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by Room Name for Pending status record
                else if (cmbOrder.SelectedIndex == 2)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Pending' order by roomName asc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }

            }
            //to display APPROVED reservation records of student
            else if (cmbFilter.SelectedIndex == 2)
            {

                //no sort order for APPROVED status record
                if (cmbOrder.SelectedIndex == -1)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Approved';", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by dates for APPROVED status record
                else if (cmbOrder.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Approved' order by date desc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by reservation ID for APPROVED status record
                else if (cmbOrder.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Approved'order by reservationID desc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by Room Name for APPROVED status record
                else if (cmbOrder.SelectedIndex == 2)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Approved' order by roomName asc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }

            }
            //to display REJECTED reservation records of student
            else if (cmbFilter.SelectedIndex == 3)
            {

                //no sort order for REJECTED status record
                if (cmbOrder.SelectedIndex == -1)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Rejected';", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by dates for REJECTED status record
                else if (cmbOrder.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Rejected' order by date desc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by reservation ID for REJECTED status record
                else if (cmbOrder.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Rejected' order by reservationID desc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by Room Name for REJECTED status record
                else if (cmbOrder.SelectedIndex == 2)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Rejected' order by roomName asc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }

            }
            //to display CANCELLED reservation records of student
            else if (cmbFilter.SelectedIndex == 4)
            {

                //no sort order for CANCELLED status record
                if (cmbOrder.SelectedIndex == -1)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Cancelled';", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by dates for CANCELLED status record
                else if (cmbOrder.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Cancelled' order by date desc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by reservation ID for CANCELLED status record
                else if (cmbOrder.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Cancelled' order by reservationID desc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by Room Name for CANCELLED status record
                else if (cmbOrder.SelectedIndex == 2)
                {
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' and status='Cancelled' order by roomName asc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }

            }
            //no option is selected for reservation status, by default display all records
            else if (cmbFilter.SelectedIndex == -1)
            {
                //no sort order
                if (cmbOrder.SelectedIndex == -1)
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "';", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;

                }
                //sort by dates for all status record
                else if (cmbOrder.SelectedIndex == 0)
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' order by date desc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by reservation ID for all status record
                else if (cmbOrder.SelectedIndex == 1)
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' order by reservationID desc;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
                //sort by Room Name for all status record
                else if (cmbOrder.SelectedIndex == 2)
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("select * from reservation where studentID ='" + id + "' order by roomName;", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    dgvReservation.DataSource = dt;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblResults.Text = "";
            //to ensure that user inputted a value in the textbox
            if (txtSearch.Text != string.Empty)
            {
                int bookingID;
                string search = txtSearch.Text;
                if (int.TryParse(txtSearch.Text, out bookingID))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    reservation studentSearch = new reservation(bookingID.ToString(), id);
                    //call Student Search Reservation Method in reservation class
                    studentSearch.studentSearchReservation(dt, studentSearch.ReservationID, studentSearch.StudentID);
                    dgvReservation.DataSource = dt;
                    //calculate how many results are found
                    SqlCommand cmdresults = new SqlCommand("select count(*) from reservation where studentID = '" 
                        + id + "' and reservationID = '" + bookingID + "'", con);
                    string resultCount = cmdresults.ExecuteScalar().ToString();
                    if (resultCount == "0")
                    {
                        lblResults.Text = "No results found";
                    }
                    else
                    {
                        lblResults.Text = resultCount + " result found!";
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Reservation ID only contains numbers!", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                lblResults.Text = "";
                MessageBox.Show("Search bar is empty!\nPlease enter valid details to search for reservation record", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lblResults_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
