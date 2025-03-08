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
    public partial class frmLibrarianSearch : Form
    {
        //create librarianName and ID variables that are accessible in this current form
        public static string librarianName;
        public static string librarianID;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["systemDB"].ToString());

        public frmLibrarianSearch(string ID, string name)
        {
            InitializeComponent();
            librarianID = ID;
            librarianName = name;
            
        }

        private void frmLibrarianSearch_Load(object sender, EventArgs e)
        {
            txtSearch.Select();

            dgvSearch.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);  //change font size && style in datagridview header
            dgvSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;     //change font color in datagridview header
            dgvSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.LightYellow;    //change backcolor in datagridview header
            dgvSearch.EnableHeadersVisualStyles = false;

            //to display Start Time and End Time in HH:mm format
            dgvSearch.Columns[3].DefaultCellStyle.Format = "HH:mm tt";
            dgvSearch.Columns[4].DefaultCellStyle.Format = "HH:mm tt";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblResults.Text = "";
            if (txtSearch.Text != string.Empty)
            {
                int searchID;
                string search = txtSearch.Text;
                bool stringSearch = true; //to detect whether user input alphabets in search bar
                if (int.TryParse(txtSearch.Text, out searchID))
                {
                    //txtSearch value is an integer
                    stringSearch = false;
                }

                con.Open();
                DataTable dt = new DataTable();
                //user is searching via studentID
                if(stringSearch == true)
                {
                    reservation searchObj1 = new reservation(search, search);
                    //call Librarian Search Student ID
                    searchObj1.librarianSearchStudentID(dt, searchObj1.StudentID);
                    dgvSearch.DataSource = dt;
                    //to count the number of results found for the search
                    SqlCommand cmdresults = new SqlCommand("select count(*) from reservation where studentID = '" + search + "';", con);
                    string resultCount = cmdresults.ExecuteScalar().ToString();
                    if (resultCount == "0")
                    {
                        lblResults.Text = "No results found";
                    }
                    else
                    {
                        lblResults.Text = resultCount + " results found!";
                    }
                }
                //user is searching via studentID or reservationID fully in integer values
                else if(stringSearch == false)
                {
                    reservation searchObj1 = new reservation(searchID.ToString(), searchID.ToString()) ;
                    //call Librarian Search Integer IDs method
                    searchObj1.librarianSearchIntegerID(dt, searchID);
                    dgvSearch.DataSource = dt;
                    //to count the number of results found for the search
                    SqlCommand cmdresults = new SqlCommand("select count(*) from reservation where studentID = '" + searchID.ToString() 
                        + "' or reservationID = " + searchID + ";", con);
                    string resultCount = cmdresults.ExecuteScalar().ToString();
                    if (resultCount == "0")
                    {
                        lblResults.Text = "No results found";
                    }
                    else
                    {
                        lblResults.Text = resultCount + " results found!";
                    }
                }
                
                con.Close();
                
            }
            else
            {
                MessageBox.Show("Search bar is empty!\nPlease enter valid details to search for reservation record", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLibrarianSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Close();
            frmLibrarianFunctionality FormLibrarian = new frmLibrarianFunctionality(librarianID, librarianName);
            FormLibrarian.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
