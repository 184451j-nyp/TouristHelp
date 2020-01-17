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
                string name = row["attractionName"].ToString();

                td = new Attraction(name);
            }
            return td;
        }

        public void InsertReservation(String Name) //Insert the reservation details into db
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO ReservationFood (reservationName)" +
                             "VALUES (@paraName)";

            
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraName", Name);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();
            myConn.Close();
        }
    }
}