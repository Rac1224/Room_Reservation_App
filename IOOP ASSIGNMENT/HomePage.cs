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
    public partial class frmStart : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["systemDB"].ToString());


        public frmStart() 
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void btnSignIn_Click(object sender, EventArgs e)
        {


            if (txtUserID.Text != string.Empty && txtPassword.Text != string.Empty) //to make sure user input is not null
            {
                bool loginValid = false;
                users obj1 = new users(txtUserID.Text, txtPassword.Text);
                con.Open();

                
                //to check whether there is a match of ID and Password in the database
                SqlCommand cmdCheck = new SqlCommand("select * from users",con);
                SqlDataReader rdCheck = cmdCheck.ExecuteReader();
                while(rdCheck.Read())
                {
                    string idCheck = rdCheck.GetString(0);
                    string pwCheck = rdCheck.GetString(2);
                    if(idCheck == obj1.Id && pwCheck == obj1.Password)
                    {
                        loginValid = true;
                    }
                }

                //execute if there is a match of ID and Password
                if (loginValid == true)
                {
                    //Authenticate Login for Librarians
                    if (rdnLibrarian.Checked)
                    {
                        //Call Librarian Login Class method
                        obj1.LibrarianLogin(obj1.Id);
                        txtPassword.Clear();
                        txtUserID.Focus();
                        
                    }
                    //Authenticate login for Students
                    else if (rdnStudent.Checked)
                    {
                        //Call Student Login Class method
                        obj1.StudentLogin(obj1.Id);
                        txtPassword.Clear();
                        txtUserID.Focus();                       
                    }
                }
                //if there is no match in the database
                else
                {
                    MessageBox.Show("Invalid Login Information! Please try again!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    txtPassword.Clear();
                    txtUserID.Focus();
                }
                con.Close();

            }

            //user enter null value
            else
            {
                MessageBox.Show("Please enter valid login information to proceed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Clear();
                txtPassword.Clear();
                txtUserID.Focus();
            }
 
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //User select to create new student account by signing up
        private void lblSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignUp FormSignUp = new frmSignUp();
            FormSignUp.ShowDialog();
            this.Close();
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
