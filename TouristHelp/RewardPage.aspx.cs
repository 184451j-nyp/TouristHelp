using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;


namespace TouristHelp
{
    public partial class RewardPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Session["user_id"] = "2";

            string user_id = Session["user_id"].ToString();

            // Retrieve TDMaster records by account
            Reward td = new Reward();
            td = td.GetRewardById(user_id);

            creditBalance.Text = td.creditBalance.ToString();
            membershipTier.Text = td.membershipTier.ToString();
            totalDiscount.Text = td.totalDiscount.ToString();
            loginCount.Text = td.loginCount.ToString();
            loginStreak.Text = td.loginCount.ToString();
            remainBonusDays.Text = td.remainBonusDays.ToString();
            bonusCredits.Text = td.bonusCredits.ToString();

            

        }

       
    }
}