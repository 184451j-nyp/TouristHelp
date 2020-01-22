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
    public class AttractionDAO
    {
        public string Name { get; set; }

        public Attraction SelectById(string attId) //get the attraction info by Id
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from Attraction where attractionId = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", attId);

            DataSet ds = new DataSet();
            da.Fill(ds);
            int rec_cnt = ds.Tables[0].Rows.Count;

            Attraction td = null;
            if (rec_cnt > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int id = int.Parse(row["attractionId"].ToString());
                string name = row["attractionName"].ToString();
                float price = float.Parse(row["attractionPrice"].ToString());
                string date = row["DateTime"].ToString();
                string desc = row["attractionDesc"].ToString();
                string loc = row["attractionLocation"].ToString();

                td = new Attraction(id, name, price, date, desc, loc);
            }
            return td;
        }

        public List<Attraction> SelectAll() //get all from attraction db and put into list
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from Attraction";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<Attraction> empList = new List<Attraction>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                int id = int.Parse(row["attractionId"].ToString());
                string name = row["attractionName"].ToString();
                float price = float.Parse(row["attractionPrice"].ToString());
                string date = row["DateTime"].ToString();
                string desc = row["attractionDesc"].ToString();
                string loc = row["attractionLocation"].ToString();
                Attraction obj = new Attraction(id, name, price, date, desc, loc);
                empList.Add(obj);
            }
            return empList;
        }

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
            sqlCmd.Parameters.AddWithValue("@paraPax", UserId);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();
            myConn.Close();
        }
    }
}