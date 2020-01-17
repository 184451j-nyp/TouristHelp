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
    public class TransactionDAO
    {

        public Transactions SelectByAccount(string transId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from [Transaction] where voucherGen_id = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", transId);

            DataSet ds = new DataSet();
            da.Fill(ds);
            int rec_cnt = ds.Tables[0].Rows.Count;

            Transactions td = null;
            if (rec_cnt > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int voucherGen_id = Convert.ToInt32(row["voucherGen_id"]);
                string voucherStats = row["voucherStats"].ToString();
                DateTime voucherExpiry = Convert.ToDateTime(row["voucherExpiry"].ToString());
                bool filterTransaction = Convert.ToBoolean(row["filterTransaction"]);
                int confirmCode = Convert.ToInt32(row["confirmCode"]);
                int user_id = Convert.ToInt32(row["user_id"]);
                DateTime voucherDate = Convert.ToDateTime(row["voucherDate"].ToString());
                int voucherTotalCost = Convert.ToInt32(row["voucherTotalCost"]);



                td = new Transactions(voucherGen_id, voucherStats, voucherExpiry,filterTransaction,confirmCode,user_id, voucherDate, voucherTotalCost);
            }
            return td;
        }


        public void insertTransaction(String transId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Transaction (voucher_id), (voucherStatus), (voucherExpiry), (filterTransaction), (confirmCode), (user_id)" +
                "VALUES (@paraVoucherId), (@paraVoucherStatus), (@paraVoucherExpiry), (@paraFilterTransaction), (@paraConfirmCode), (@paraUserId)";

            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            //sqlCmd.Parameters.AddWithValue("@paraVoucherId")
        }
    }
}