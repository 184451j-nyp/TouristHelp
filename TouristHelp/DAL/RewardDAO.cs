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
    public class RewardDAO
    {


        public Reward SelectByAccount(string rewardId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from Reward where user_id = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", rewardId);

            DataSet ds = new DataSet();
            da.Fill(ds);
            int rec_cnt = ds.Tables[0].Rows.Count;

            Reward td = null;
            if (rec_cnt > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int user_id = Convert.ToInt32(row["user_id"]);
                int loginCount  = Convert.ToInt32(row["loginCount"]);
                int loginStreak = Convert.ToInt32(row["loginStreak"]);
                string loyaltyTier = row["loyaltyTier"].ToString();
                int totalDiscount = Convert.ToInt32(row["totalDiscount"]);
                int bonusCredits = Convert.ToInt32(row["bonusCredits"]);
                string membershipTier = row["membershipTier"].ToString();
                int creditBalance = Convert.ToInt32(row["creditBalance"]);
                int remainBonusDays = Convert.ToInt32(row["remainBonusDays"]);

                td = new Reward(user_id, loginCount, loginStreak, loyaltyTier,totalDiscount,bonusCredits, membershipTier, creditBalance, remainBonusDays);
            }
            return td;
        }
    }
}