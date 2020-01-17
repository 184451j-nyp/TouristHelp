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
    public class SqlHelper
    {
        public string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        public DataSet Query(string sqlStmt)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);

            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        public SqlCommand Insert(string sqlStmt)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);

            return new SqlCommand(sqlStmt, myConn);
        }
    }
}