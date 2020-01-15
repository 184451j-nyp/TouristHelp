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
    public class InterestDAO
    {
        public void Insert(Interest inter)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Interest (InterestName, user_id) " +
                             "VALUES (@paraInterestName,@paraUserId)";


            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraInterestName", inter.InterestName);
            sqlCmd.Parameters.AddWithValue("@paraUserId", inter.userId);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();

            myConn.Close();
        }

        public List<Interest> SelectInterestById(int userId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * From Interest " +
                             "where user_id = @paraUserId";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraUserId", userId);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Interest> intList = new List<Interest>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                intList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string interestName = row["InterestName"].ToString();
                    Interest objRate = new Interest(interestName, userId);
                    intList.Add(objRate);
                }
            }
            return intList;
        }

        public void RemoveInterest(string InterestName, int userId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "DELETE FROM Interest where InterestName = @paraInterestName AND user_id = @paraUserId";


            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraInterestName", InterestName);
            sqlCmd.Parameters.AddWithValue("@paraUserId", userId);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();

            myConn.Close();
        }
    }
}