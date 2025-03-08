using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace IOOP_ASSIGNMENT
{
    class report
    {
        //member fields for report class
        private string roomName;
        private string date;
        

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["systemDB"].ToString());

        //constructor of report class
        public report(string rn, string d)
        {
            RoomName = rn;
            Date = d;
        }

        public report(string da)
        {
            Date = da;
        }

        
        public string RoomName { get => roomName; set => roomName = value; }
        public string Date { get => date; set => date = value; }
        
        //Method to view ALL ROOMS daily report
        public DataTable viewDailyAllReport(DataTable dt, string date)
        {
            
            report obj1 = new report(date);
            //select specific date of reservation for all rooms
            SqlCommand cmd = new SqlCommand("select * from reservation where date = '" + obj1.Date + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);           
            return dt;
        }
        //Method to analyze daily report for all rooms
        public string analyzeDailyAllReport(string analysis, string date)
        {
            con.Open();
            SqlCommand cmdApproved = new SqlCommand("select count(*) from reservation where " + "format (date, 'yyyyMMdd') ='" + date + "' and status = 'Approved';", con);
            SqlCommand cmdInvalid = new SqlCommand("select count(*) from reservation where format " + "(date, 'yyyyMMdd') ='" + date + "' and (status = 'Cancelled' or status = 'Rejected');", con);
            SqlCommand cmdPending = new SqlCommand("select count(*) from reservation where format" + "(date, 'yyyyMMdd')='" + date + "'and status = 'Pending';", con);
            string reportTotalApproved = cmdApproved.ExecuteScalar().ToString();
            string reportTotalInvalid = cmdInvalid.ExecuteScalar().ToString();
            string reportTotalPending = cmdPending.ExecuteScalar().ToString();
            con.Close();
            analysis = "Total Number of Reservations Approved: " + reportTotalApproved + "\nTotal Number of Reservations Cancelled/Rejected: " + reportTotalInvalid
                + "\nTotal Number of Reservations Pending: " + reportTotalPending;
            return analysis;
        }
        //Method to view SPECIFIC ROOMS daily report
        public DataTable viewDailySpecificReport(DataTable dt, string date, string room)
        {
            report obj1 = new report(room, date);
            //select specific date of reservation for a specific room
            SqlCommand cmd = new SqlCommand("select * from reservation where date = '" + obj1.Date + "'and roomName = '" + obj1.RoomName + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);         
            return dt;
        }
        //Method to analyze daily report for specific rooms
        public string analyzeDailySpecificReport(string analysis, string date, string roomName)
        {
            con.Open();
            SqlCommand cmdApproved = new SqlCommand("select count(*) from reservation where format (date, 'yyyyMMdd') ='" + date + "'and roomName = '" + roomName + "' and status = 'Approved';", con);
            SqlCommand cmdInvalid = new SqlCommand("select count(*) from reservation where format (date, 'yyyyMMdd') ='" + date + "'and roomName = '" + roomName + "' and (status = 'Cancelled' or status = 'Rejected');", con);
            SqlCommand cmdPending = new SqlCommand("select count(*) from reservation where format (date, 'yyyyMMdd') ='" + date + "'and roomName = '" + roomName + "' and status = 'Pending';", con);
            string reportTotalApproved = cmdApproved.ExecuteScalar().ToString();
            string reportTotalInvalid = cmdInvalid.ExecuteScalar().ToString();
            string reportTotalPending = cmdPending.ExecuteScalar().ToString();
            con.Close();
            analysis = "Total Number of Reservations Approved: " + reportTotalApproved + "\nTotal Number of Reservations Cancelled/Rejected: " + reportTotalInvalid
                + "\nTotal Number of Reservations Pending: " + reportTotalPending;
            return analysis;
        }

        //Method to view ALL ROOMS monthly report
        public DataTable viewMonthlyAllReport(DataTable dt, string date)
        {
            report obj1 = new report(date);
            //select specific month of reservation for all rooms
            SqlCommand cmd = new SqlCommand("select * from reservation where format (date, 'yyyy/MM') ='" + obj1.Date
                + "'order by date", con); //order by date
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //Method to analyze monthly report for all rooms
        public string analyzeMonthlyAllReport(string analysis, string date)
        {
            con.Open();
            SqlCommand cmdApproved = new SqlCommand("select count(*) from reservation where " + "format (date, 'yyyy/MM') ='" + date + "' and status = 'Approved';", con);
            SqlCommand cmdInvalid = new SqlCommand("select count(*) from reservation where format " + "(date, 'yyyy/MM') ='" + date + "' and (status = 'Cancelled' or status = 'Rejected');", con);
            SqlCommand cmdPending = new SqlCommand("select count(*) from reservation where format" + "(date, 'yyyy/MM')='" + date + "'and status = 'Pending';", con);
            string reportTotalApproved = cmdApproved.ExecuteScalar().ToString();
            string reportTotalInvalid = cmdInvalid.ExecuteScalar().ToString();
            string reportTotalPending = cmdPending.ExecuteScalar().ToString();
            con.Close();
            analysis = "Total Number of Reservations Approved: " + reportTotalApproved + "\nTotal Number of Reservations Cancelled/Rejected: " + reportTotalInvalid
                + "\nTotal Number of Reservations Pending: " + reportTotalPending;
            return analysis;
        }

        //Method to view SPECIFIC ROOMS monthly report
        public DataTable viewMonthlySpecificReport(DataTable dt, string date, string room)
        {
            report obj1 = new report(room, date);
            //select specific date of reservation for a specific room
            SqlCommand cmd = new SqlCommand("select * from reservation where format (date, 'yyyy/MM') ='" + obj1.Date 
                + "'and roomName = '" + obj1.RoomName + "'order by date", con); //order by date
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //Method to analyze monthly report for specific rooms
        public string analyzeMonthlySpecificReport(string analysis, string date, string roomName)
        {
            con.Open();
            SqlCommand cmdApproved = new SqlCommand("select count(*) from reservation where format (date, 'yyyy/MM') ='" + date + "'and roomName = '" + roomName + "' and status = 'Approved';", con);
            SqlCommand cmdInvalid = new SqlCommand("select count(*) from reservation where format (date, 'yyyy/MM') ='" + date + "'and roomName = '" + roomName + "' and (status = 'Cancelled' or status = 'Rejected');", con);
            SqlCommand cmdPending = new SqlCommand("select count(*) from reservation where format (date, 'yyyy/MM') ='" + date + "'and roomName = '" + roomName + "' and status = 'Pending';", con);
            string reportTotalApproved = cmdApproved.ExecuteScalar().ToString();
            string reportTotalInvalid = cmdInvalid.ExecuteScalar().ToString();
            string reportTotalPending = cmdPending.ExecuteScalar().ToString();
            con.Close();
            analysis = "Total Number of Reservations Approved: " + reportTotalApproved + "\nTotal Number of Reservations Cancelled/Rejected: " + reportTotalInvalid
                + "\nTotal Number of Reservations Pending: " + reportTotalPending;
            return analysis;
        }

    }


}
