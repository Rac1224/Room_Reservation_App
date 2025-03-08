using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace IOOP_ASSIGNMENT
{
    class users
    {

        private string name;
        private string id;
        private string password;


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["systemDB"].ToString());

        //Constructor to assign text input from user into ALL user member fields (for Sign Up form)
        public users(string n, string i, string p)
        {
            name = n;
            id = i;
            password = p;
        }

        //Constructor to assign text input from user into 2 user member fields (for Log In)
        public users(string i, string p)
        {
            id = i;
            password = p;
        }

        //Constructor to assign text input from user into 1 user member fields (ID only)
        public users(string i)
        {
            id = i;
        }

        //get set method for all member fields
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }

        //Librarian user login method
        public void LibrarianLogin(string id)
        {
            users obj1 = new users(id);
            con.Open();
            SqlCommand cmd = new SqlCommand("select role from users where id='" + obj1.Id + "';", con);
            string userRole = cmd.ExecuteScalar().ToString();
            //validate is user is a Librarian
            if (userRole == "Librarian")
            {
                SqlCommand cmd2 = new SqlCommand("select name from users where id='" + obj1.Id + "';", con);
                obj1.Name = cmd2.ExecuteScalar().ToString();
                //Call Librarian Functionality Form
                frmLibrarianFunctionality FormLibrarian = new frmLibrarianFunctionality(obj1.Id, obj1.Name);
                FormLibrarian.ShowDialog();                             
            }
            //user selected wrong user type
            else
            {
                MessageBox.Show("Please select correct user type!", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            con.Close();            
        }

        //Student User Login Method
        public void StudentLogin(string id)
        {
            users obj1 = new users(id);
            con.Open();
            SqlCommand cmd = new SqlCommand("select role from users where id='" + obj1.Id + "';", con);
            string userRole = cmd.ExecuteScalar().ToString();
            //validate is user is a student
            if (userRole == "Student")
            {
                SqlCommand cmd2 = new SqlCommand("select name from users where id='" + obj1.Id + "';", con);
                obj1.Name = cmd2.ExecuteScalar().ToString();
                //Call student functionality form
                frmStudentFunctionality FormStudent = new frmStudentFunctionality(obj1.Id, obj1.Name);
                FormStudent.ShowDialog();
            }
            //user selected wrong user type
            else
            {
                MessageBox.Show("Please select correct user type!", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            con.Close();
        }


        //sign up new student account method
        public void signup(string nm, string ID, string pw)
        {
            SqlCommand cmd2 = new SqlCommand("insert into users (id, name, password, role) values(@id,@name,@password,@role)", con);
            cmd2.Parameters.AddWithValue("@name", nm);
            cmd2.Parameters.AddWithValue("@id", ID);
            cmd2.Parameters.AddWithValue("@password", pw);
            cmd2.Parameters.AddWithValue("@role", "Student");
            con.Open();
            int cnt = cmd2.ExecuteNonQuery(); //execute the queries and store in table
            con.Close();
            if (cnt != 0)
            {
                MessageBox.Show("Successfully registered, please log in to access the system.", 
                    "Sign Up Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registration unsuccessful, please try again later.", 
                    "Sign Up Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
