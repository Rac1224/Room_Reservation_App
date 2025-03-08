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
    public partial class frmSignUp : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["systemDB"].ToString());

        public frmSignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            //to ensure input is not empty
            if (txtStudentName.Text != string.Empty && txtStudentID.Text != string.Empty && txtNewPassword.Text != string.Empty && txtRepeatPassword.Text != string.Empty)
            {
                //to check whether the passwords entered are the same 
                if (txtNewPassword.Text == txtRepeatPassword.Text)
                {
                    users obj1 = new users(txtStudentName.Text, txtStudentID.Text, txtNewPassword.Text);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from users where id ='" + obj1.Id + "'", con);
                    SqlDataReader rd = cmd.ExecuteReader(); //read through table data

                    //id already exists in table
                    if (rd.Read())
                    {
                        rd.Close();
                        con.Close();
                        MessageBox.Show("Student ID already exist, please try another unique ID!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtStudentID.Clear();
                        txtNewPassword.Clear();
                        txtRepeatPassword.Clear();
                        txtStudentID.Focus();
                    }
                    //sign up credentials are valid
                    else
                    {
                        //call method signup
                        obj1.signup(txtStudentName.Text, txtStudentID.Text, txtNewPassword.Text);                        
                        this.Close();
                    }
                }
                //passwords entered are not the same
                else
                {
                    con.Close();
                    MessageBox.Show("Passwords do not match, please try again", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Clear();
                    txtRepeatPassword.Clear();
                    txtNewPassword.Focus();
                }
            }
            //user did not fill in all textbox
            else
            {
                MessageBox.Show("Please fill in all fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentName.Clear();
                txtStudentID.Clear();
                txtNewPassword.Clear();
                txtRepeatPassword.Clear();
                txtStudentName.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void frmSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmStart FormStart = new frmStart();
            FormStart.ShowDialog();
        }

        //to ensure user only inputs alphabets for txtStudentName, no numeric, symbols etc.
        private void txtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //to ensure no space is keyed in for username
        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)  && !char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }
    }
}
