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


            if (Session["tourist_id"] == null && Session["tourguide_id"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            else
            {

                try
                {
                    Label1.Text = Session["tourist_id"].ToString();
                }
                catch (NullReferenceException)
                {
                    Label1.Text = Session["tourguide_id"].ToString();
                }

            }

            Session["user_id"] = Session["tourist_id"];

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