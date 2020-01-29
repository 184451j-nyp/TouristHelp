using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TouristHelp.Models;

namespace TouristHelp.DAL
{
    public static class DirectionDAO
    {
        private static string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        public static List<Direction> GetDirByUser(int tourist)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);
            string sqlStmt = "Select Attraction.attractionId, Attraction.attractionName, Attraction.attractionLatitude, Attraction.attractionLongitude, Attraction.attractionType " +
                "From Directions Inner Join Attraction On Attraction.attractionId = Directions.attraction_id " +
                "Where tourist_id = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", tourist);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Direction> list = new List<Direction>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                int id = int.Parse(row["attractionId"].ToString());
                string name = row["attractionName"].ToString();
                double lat = double.Parse(row["attractionLatitude"].ToString());
                double log = double.Parse(row["attractionLongitude"].ToString());
                string type = row["attractionType"].ToString();
                Direction obj = new Direction(id, name, lat, log, type);
                list.Add(obj);
            }

            return list;
        }

        public static void RemoveOneDirByUser(int attraction, int tourist)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);
            string sqlstmt = "Delete From Directions Where attraction_id = @paraAttraction And tourist_id = @paraTourist";
            SqlCommand cmd = new SqlCommand(sqlstmt, myConn);
            cmd.Parameters.AddWithValue("@paraAttraction", attraction);
            cmd.Parameters.AddWithValue("@paraTourist", tourist);

            try
            {
                myConn.Open();
                cmd.ExecuteNonQuery();
                myConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void RemovAllDirByUser(int tourist)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);
            string sqlstmt = "Delete From Directions Where tourist_id = @paraTourist";
            SqlCommand cmd = new SqlCommand(sqlstmt, myConn);
            cmd.Parameters.AddWithValue("@paraTourist", tourist);

            try
            {
                myConn.Open();
                cmd.ExecuteNonQuery();
                myConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}