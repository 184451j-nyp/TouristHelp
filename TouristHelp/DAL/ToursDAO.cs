using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using TouristHelp.Models;

namespace TouristHelp.DAL
{
    public static class ToursDAO
    {
        private static string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        public static List<Tours> SelectAllTours()
        {
            SqlConnection myConn = new SqlConnection(DBConnect);
            string sqlStmt = "Select * From Tours";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Tours> arr = new List<Tours>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i=0; i< rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                int id = int.Parse(row["id"].ToString());
                int tg = int.Parse(row["tourguide_id"].ToString());
                string title = row["title"].ToString();
                string desc = row["description"].ToString();
                string details = row["details"].ToString();
                decimal price = decimal.Parse(row["price"].ToString());
                Tours obj = new Tours(id, tg, title, desc, details, price);
                arr.Add(obj);
            }
            return arr;
        }
    }

    public static class TouristBookingDAO
    {
        private static string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        public static List<TouristBookings> SelectAllTouristBooking()
        {
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Select * From TouristBooking";

            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<TouristBookings> userList = new List<TouristBookings>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                int id = int.Parse(row["id"].ToString());
                int tourist = int.Parse(row["tourist_id"].ToString());
                string bookings = row["bookings"].ToString();
                TouristBookings obj = new TouristBookings(id, tourist, bookings);
                userList.Add(obj);
            }
            return userList;
        }

        public static void InsertBooking(string Booking, int TouristId, int UserId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO TouristBooking (bookings, tourist_id)" +
                             "VALUES (@paraBooking, @paraTouristId)";

            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraBooking", Booking);
            sqlCmd.Parameters.AddWithValue("@paraTouristId", TouristId);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();
            myConn.Close();
        }
    }
}