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

            string sqlStmt = "INSERT INTO ReservationFood (reservationName, reservationTime, reservationPax, userId)" +
                             "VALUES (@paraName, @paraTime, @paraPax, @paraId)";


            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraName", Name);
            sqlCmd.Parameters.AddWithValue("@paraTime", Time);
            sqlCmd.Parameters.AddWithValue("@paraPax", Pax);
            sqlCmd.Parameters.AddWithValue("@paraId", UserId);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();
            myConn.Close();
        }


        public List<Food_Reservation> SelectById(int resId) //get all reservations under an id from Reservation db and put into list
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from ReservationFood where userId = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", resId);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<Food_Reservation> empList = new List<Food_Reservation>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                string name = row["reservationName"].ToString();
                string date = row["reservationTime"].ToString();
                int price = int.Parse(row["reservationPax"].ToString());
                Food_Reservation obj = new Food_Reservation(name, date, price);
                empList.Add(obj);
            }
            return empList;
        }
    }
}