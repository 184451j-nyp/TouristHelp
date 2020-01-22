﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TouristHelp.BLL;

namespace TouristHelp.DAL
{
    public class ShopVoucherDAO
    {

        public ShopVoucher SelectByShop(string shopId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from ShopVoucher where voucher_id = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", shopId);

            DataSet ds = new DataSet();
            da.Fill(ds);
            int rec_cnt = ds.Tables[0].Rows.Count;

            ShopVoucher td = null;
            if (rec_cnt > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int voucher_id = Convert.ToInt32(row["voucher_id"]);
                int user_id = Convert.ToInt32(row["user_id"]);
                int voucherQty = Convert.ToInt32(row["voucherQty"]);
                string voucherType = row["voucherType"].ToString();
                string voucherStatus = row["voucherStatus"].ToString();
                bool membershipCategory = Convert.ToBoolean(row["membershipCategory"]);
                bool foodCategory = Convert.ToBoolean(row["foodCategory"]);
                bool categoryFilter = Convert.ToBoolean(row["categoryFilter"]);
                string nameFilter = row["nameFilter"].ToString();
                int voucherCost = Convert.ToInt32(row["voucherCost"]);
                string shopImage = row["shopImage"].ToString();
                string shopDesc = row["shopDesc"].ToString();
                string voucherName = row["voucherName"].ToString();


                td = new ShopVoucher(voucher_id, user_id, voucherQty, voucherType, voucherStatus, membershipCategory, foodCategory, categoryFilter, nameFilter, voucherCost, shopImage, shopDesc, voucherName);
            }
            return td;
        }



        public List<ShopVoucher> SelectAll()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from ShopVoucher";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<ShopVoucher> empList = new List<ShopVoucher>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                int voucher_id = Convert.ToInt32(row["voucher_id"]);
                int user_id = Convert.ToInt32(row["user_id"]);
                int voucherQty = Convert.ToInt32(row["voucherQty"]);
                string voucherType = row["voucherType"].ToString();
                string voucherStatus = row["voucherStatus"].ToString();
                bool membershipCategory = Convert.ToBoolean(row["membershipCategory"]);
                bool foodCategory = Convert.ToBoolean(row["foodCategory"]);
                bool categoryFilter = Convert.ToBoolean(row["categoryFilter"]);
                string nameFilter = row["nameFilter"].ToString();
                int voucherCost = Convert.ToInt32(row["voucherCost"]);
                string shopImage = row["shopImage"].ToString();
                string shopDesc = row["shopDesc"].ToString();
                string voucherName = row["voucherName"].ToString();
                ShopVoucher obj = new ShopVoucher(voucher_id, user_id, voucherQty, voucherType, voucherStatus, membershipCategory, foodCategory, categoryFilter, nameFilter, voucherCost, shopImage, shopDesc, voucherName);
                empList.Add(obj);
            }

            return empList;
        }



    }
}