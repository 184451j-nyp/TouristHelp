using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TouristHelp.BLL;

namespace TouristHelp.DAL
{
    public class Food_ReservationDAO
    {
        public void InsertReservation(string Name, string Time, int Pax, int UserId) //Insert the reservation details into db
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO ReservationFood (reservationName, reservationTime, reservationPax, reservationState, userId)" +
                             "VALUES (@paraName, @paraTime, @paraPax, @paraStatus ,@paraId)";


            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraName", Name);
            sqlCmd.Parameters.AddWithValue("@paraTime", Time);
            sqlCmd.Parameters.AddWithValue("@paraPax", Pax);
            sqlCmd.Parameters.AddWithValue("@paraStatus", "Active");
            sqlCmd.Parameters.AddWithValue("@paraId", UserId);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();
            myConn.Close();
        }


        public List<Food_Reservation> SelectById(int resId) //get all reservations under an id from Reservation db and put into list
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            
            string sqlStmt = "Select * from ReservationFood where userId = @paraId and reservationState = 'Active'";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", resId);

            DataSet ds = new DataSet();

            da.Fill(ds);

            List<Food_Reservation> empList = new List<Food_Reservation>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                int id = int.Parse(row["reservationId"].ToString());
                string name = row["reservationName"].ToString();
                string time = row["reservationTime"].ToString();
                int pax = int.Parse(row["reservationPax"].ToString());
                string state = row["reservationState"].ToString();
                Food_Reservation obj = new Food_Reservation(id, name, time, pax, state);
                empList.Add(obj);
            }
            return empList;
        }

        public void ReservationStatusDisable(int resId) //set status to disabled
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE ReservationFood SET reservationState = 'Inactive' WHERE reservationId = @paraId";

            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraId", resId);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();
            myConn.Close();
        }
    }
}