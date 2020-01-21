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
        public static string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        public static List<Direction> SelectAll()
        {
            SqlConnection myConn = new SqlConnection(DBConnect);
            string sqlStmt = "Select * from Directions";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            return convertToObj(ds);
        } 

        public static List<Direction> GetDirectionsByGrp(int grp)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);
            string sqlStmt = "Select * From Directions Where group = @paraGrp Order By group";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraGrp", grp.ToString());

            DataSet ds = new DataSet();
            da.Fill(ds);

            return convertToObj(ds);
        }

        public static List<int> GetDirGrpByUser(int user_id)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);
            string sqlStmt = "Select Distinct group As DistinctGrps From (Select * From Directions Where user = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", user_id.ToString());

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<int> list = new List<int>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                int id = int.Parse(row["DistinctGrps"].ToString());
                list.Add(id);
            }

            return list;
        }

        private static List<Direction> convertToObj(DataSet ds)
        {
            List<Direction> dirList = new List<Direction>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                int id = int.Parse(row["id"].ToString());
                int user = int.Parse(row["user"].ToString());
                string nodeCoord = row["nodeCoord"].ToString();
                int group = int.Parse(row["group"].ToString());
                int order = int.Parse(row["order"].ToString());
                Direction obj = new Direction(id, user, nodeCoord, group, order);
                dirList.Add(obj);
            }

            return dirList;
        }
    }
}