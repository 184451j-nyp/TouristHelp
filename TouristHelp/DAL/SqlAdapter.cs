﻿using System;
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
        public void insertUser(User user)
        {

        }
        public void insertDirection(Direction direction)
        {

        }
    }
}