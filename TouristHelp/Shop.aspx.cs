using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;
using System.Drawing;
using TouristHelp.DAL;

namespace TouristHelp
{
    public partial class Shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Session["user_id"] = "1";

            string user_id = Session["user_id"].ToString();

            // Retrieve Reward records by account
            Reward td = new Reward();
            td = td.GetRewardById(user_id);

            creditBalance.Text = td.creditBalance.ToString();
            membershipTier.Text = td.membershipTier.ToString();
            totalDiscount.Text = td.totalDiscount.ToString();
            loginCount.Text = td.loginCount.ToString();
            loginStreak.Text = td.loginCount.ToString();
            loyaltyTier.Text = td.loyaltyTier.ToString();
            remainBonusDays.Text = td.remainBonusDays.ToString();
            bonusCredits.Text = td.bonusCredits.ToString();

            Session["voucher_id"] = "1";

            string shop_id = Session["voucher_id"].ToString();
            // Retrieve ShopVoucher records by account
            ShopVoucher ts = new ShopVoucher();

            ts = ts.GetShopById(shop_id);

            voucherName.Text = ts.voucherName.ToString();
            voucherCost.Text = ts.voucherCost.ToString();
            voucherDesc.Text = ts.shopDesc.ToString();





        }

        protected bool validatePurchase()
        {
            Session["user_id"] = "1";

            string user_id = Session["user_id"].ToString();

            // Retrieve Reward records by account
            Reward td = new Reward();
            td = td.GetRewardById(user_id);

            int creditBalance = td.creditBalance;

            Session["voucher_id"] = "1";

            string shop_id = Session["voucher_id"].ToString();
            // Retrieve ShopVoucher records by account
            ShopVoucher ts = new ShopVoucher();

            ts = ts.GetShopById(shop_id);

            int voucherCost = ts.voucherCost;



            bool result;
            if (creditBalance > voucherCost)
            {

                result = true;
            }
            else
            {
                result = false;

            }
            return result;

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {

            Transactions emp = new Transactions();

           if (validatePurchase())
            {
                //emp = new Transactions(vouch);
                //int result = emp.AddEmployee();
                //if (result == 1)
                //{
                //    LblMsg.Text = "Record added successfully!";
                //    LblMsg.ForeColor = Color.Green;
                }
            }

        protected void addCreditBtn_Click(object sender, EventArgs e)
        {
            int credit = 1000;


            Reward emp = new Reward(1,credit);
            int result = emp.UpdateAccount(emp);



        }
    }
    }
