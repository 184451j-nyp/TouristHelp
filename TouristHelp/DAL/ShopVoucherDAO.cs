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


    }
}