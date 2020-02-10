using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;


namespace TouristHelp
{
    public partial class AdminPageRewardSystem : System.Web.UI.Page
    {
        List<ShopVoucher> shopList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                shopRepeater();
            }
            DateTime dateTime = DateTime.Now;
            this.Label1.Text = dateTime.ToString();


        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPageShop.aspx");
        }

        private void shopRepeater()
        {
            ShopVoucher shop = new ShopVoucher();
            shopList = shop.GetAllShop();

            repeatShop.DataSource = shopList;
            repeatShop.DataBind();
        }

        protected void dailyReward_Click(object sender, EventArgs e)
        {

            Session["user_id"] = Session["tourist_id"];

            string user_id = Session["user_id"].ToString();

            int userId = Convert.ToInt32(user_id);
            // Retrieve TDMaster records by account
            Reward td = new Reward();
            td = td.GetRewardById(user_id);

            int loginCount = td.loginCount + 1;
            int loginStreak = td.loginStreak + 1;
            int creditBalance = td.creditBalance + 5;
            bool loggedInLog = true;
            DateTime loggedInDate = DateTime.Now;
            bool newDateCheck = true;
            int remainBonusDays = td.remainBonusDays - 1;

            td.updateLoggedIn(userId, loginCount, loginStreak, creditBalance, remainBonusDays, loggedInLog, loggedInDate, newDateCheck);

            if (loginStreak % 10 == 0)
            {
                creditBalance = td.creditBalance + td.bonusCredits + 5;
                remainBonusDays = td.remainBonusDays + 9;


                td.updateBonus(userId, loginStreak, creditBalance, remainBonusDays);
            }

            if (td.loginCount == 100)
            {
                string loyaltyTier = "Gold";
                int bonuscredits = 15;

                td.updateLoyaltyBonus(userId, loyaltyTier, bonuscredits);
            }



            if (td.loginCount == 200)
            {
                string loyaltyTier = "Diamond";
                int bonuscredits = 20;

                td.updateLoyaltyBonus(userId, loyaltyTier, bonuscredits);
            }


        }
    }
}