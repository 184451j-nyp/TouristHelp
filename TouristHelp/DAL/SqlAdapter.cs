using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using TouristHelp.Models;

namespace TouristHelp.DAL
{
    public class SqlQuery
    {
        public DataSet Query(string sqlStmt)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }
    }

    public class SqlInsert
    {
        string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        public void insertUser(Tourist user)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);
            string sqlstmt = "Insert into Tourists (password, name, email, nationality) Values (@paraPswd, @paraName, @paraEmail, @paraNation)";
            SqlCommand sqlCmd = new SqlCommand(sqlstmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraPswd", user.password);
            sqlCmd.Parameters.AddWithValue("@paraName", user.name);
            sqlCmd.Parameters.AddWithValue("@paraEmail", user.email);
            sqlCmd.Parameters.AddWithValue("@paraNation", )
        }
        public void insertDirection(Direction direction)
        {

        }
    }
}