using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;
using System.Drawing;
using TouristHelp.DAL;
using System.Data.SqlClient;

namespace TouristHelp
{
    public partial class Shop : System.Web.UI.Page
    {
        int voucherCost;

        List<ShopVoucher> shopList;

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




















            if (!Page.IsPostBack)

            {

                loadRepeater();

                if (Session["labelSuccess"] != null)
                {
                    notifyLabel.Text = Session["labelSuccess"].ToString();
                    notifyLabel.Visible = true;
                    notifyLabel.ForeColor = Color.Green;
                }



                if (Session["labelFail"] != null)
                {
                    notifyLabel.Text = Session["labelFail"].ToString();
                    notifyLabel.Visible = true;
                    notifyLabel.ForeColor = Color.Red;
                }



            }



            Session["user_id"] = Label1.Text;

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




        }




        private void loadRepeater()
        {
            ShopVoucher shop = new ShopVoucher();
            shopList = shop.GetAllShop();

            Repeat1.DataSource = shopList;
            Repeat1.DataBind();
        }


        protected void NextPage(object sender, EventArgs e)
        {
            Session["user_id"] = "7"; // change to name we have the actual name here arady
        }



        protected void NextPage(object source, RepeaterCommandEventArgs e)
        {
            RepeaterItem item1 = e.Item;
            Label voucherQuantity = (Label)item1.FindControl("voucher_Qty");

            Session["voucher_Qty"] = voucherQuantity.Text;
            Response.Redirect("Reservation_Food.aspx");
        }

        protected bool validatePurchase()
        {
            Session["user_id"] = Session["tourist_id"];


            string user_id = Session["user_id"].ToString();

            // Retrieve Reward records by account
            Reward td = new Reward();
            td = td.GetRewardById(user_id);

            int creditBalance = td.creditBalance;

       

            // Retrieve ShopVoucher records by account
            ShopVoucher ts = new ShopVoucher();





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

            //string ProductSelected;


            //Session["user_id"] = "1";
            //string user_id = Session["user_id"].ToString();
            //// Retrieve ShopVoucher records by account

            //Reward td = new Reward();
            //td = td.GetRewardById(user_id);

            //int creditBalance = Convert.ToInt32(td.creditBalance);



            //Session["voucher_id"] = "1";

            //string shop_id = Session["voucher_id"].ToString();
            //// Retrieve ShopVoucher records by account
            //ShopVoucher ts = new ShopVoucher();

            //ts = ts.GetShopById(shop_id);

            //string voucherName = ts.voucherName;
            //int cost = Convert.ToInt32(ts.voucherCost);





            ////int quantity = Convert.ToInt32(DDLquantity);

            ////int quantity = Convert.ToInt32(voucherQty.SelectedValue);

            //int quantity;

            //if (validatePurchase() == true)
            //{
            //    foreach (RepeaterItem dataItem in Repeat1.Items)
            //    {
            //        ProductSelected = ((DropDownList)dataItem.FindControl("voucher_Qty")).SelectedItem.Text; //No error

            //        quantity = Convert.ToInt32(ProductSelected);


            //        int totalcost = cost * quantity;


            //        int credit = creditBalance - totalcost;



            //        Reward emp = new Reward(1, credit);
            //        int result = emp.UpdateAccount(emp);


            //        //Insert transaction into Transation Table





            //        int genId = new Random().Next(100000, 999999);

            //        string stats = "Available";

            //        DateTime date = DateTime.Now;
            //        TimeSpan duration = new TimeSpan(30, 0, 0, 0);
            //        DateTime expiry = date.Add(duration);

            //        int confirmcode = new Random().Next(100000, 999999);

            //        int userId = Convert.ToInt32(user_id);

            //        string name = voucherName;

            //        Transactions trans = new Transactions(genId, stats, expiry, confirmcode, userId, date, totalcost, quantity, name);


            //        trans.insertTrans();


            //        Response.Redirect("Shop.aspx");
            //        return;
            //    }






            //    Response.Redirect("Shop.aspx");
            //    notifyLabel.Text = "Purchase successful";
            //    notifyLabel.Visible = true;
            //    notifyLabel.ForeColor = Color.Green;
            //}

            //else
            //{
            //    notifyLabel.Text = "Insufficent credits";
            //    notifyLabel.Visible = true;
            //    notifyLabel.ForeColor = Color.Red;
            //}
        }

        protected void addCreditBtn_Click(object sender, EventArgs e)
        {
            Session["user_id"] = Session["tourist_id"].ToString();

            string user_id = Session["user_id"].ToString();

            int user_idInt = Convert.ToInt32(user_id);
            // Retrieve Reward records by account
            Reward td = new Reward();
            td = td.GetRewardById(user_id);

            int creditBalance = Convert.ToInt32(td.creditBalance);

            int credit = creditBalance + 1000;


            Reward emp = new Reward(user_idInt, credit);
            int result = emp.UpdateAccount(emp);



            Response.Redirect("Shop.Aspx", false);


        }


        protected void GvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList quantity = (DropDownList)sender;
            quantity.DataSource = shopList;
            quantity.DataBind();
        }

        protected void Repeat1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            RepeaterItem item1 = e.Item;

            int voucher_id;

            int quantity;

            int voucherStock;

            string voucherStatus;


            string voucherName;

            int genId;


            Session["user_id"] = Session["tourist_id"].ToString();
            string user_id = Session["user_id"].ToString();
            int user_idInt = Convert.ToInt32(user_id);

            // Retrieve ShopVoucher records by account

            Reward td = new Reward();
            td = td.GetRewardById(user_id);

            int creditBalance = Convert.ToInt32(td.creditBalance);

            HiddenField getId = (HiddenField)item1.FindControl("shop_Id");
            Session["voucher_id"] = getId.Value;
            voucher_id = Convert.ToInt32(getId.Value);

            DropDownList getDropDown = (DropDownList)item1.FindControl("voucherQuantity");
            Session["voucherQuantity"] = getDropDown.SelectedValue;
            quantity = Convert.ToInt32(getDropDown.SelectedValue);

            Label getVoucherCost = (Label)item1.FindControl("voucherCost");
            Session["voucherCost"] = getVoucherCost.Text;
            voucherCost = Convert.ToInt32(getVoucherCost.Text);

            Label getVoucherName = (Label)item1.FindControl("voucherName");
            Session["voucherName"] = getVoucherName.Text;
            voucherName = getVoucherName.Text;



            HiddenField getVoucherStock = (HiddenField)item1.FindControl("voucherQty");
            Session["voucherName"] = getVoucherStock.Value;
            voucherStock = Convert.ToInt32(getVoucherStock.Value);

            Label getVoucherStatus = (Label)item1.FindControl("voucherStatus");
            Session["voucherStatus"] = getVoucherStatus.Text;
            voucherStatus = getVoucherStatus.Text;


            if (validatePurchase() == true && voucherStatus == "Available" || voucherStatus == "Active")
            {





                int totalcost = voucherCost * quantity;


                int credit = creditBalance - totalcost;



                Reward emp = new Reward(user_idInt, credit);
                int result = emp.UpdateAccount(emp);


                //Insert transaction into Transation Table




              
                genId = new Random().Next(100000, 999999);

                



                string stats = "Available";

                DateTime date = DateTime.Now;
                TimeSpan duration = new TimeSpan(30, 0, 0, 0);
                DateTime expiry = date.Add(duration);

                int confirmcode = new Random().Next(100000, 999999);

                int userId = Convert.ToInt32(user_id);

                string name = voucherName;

                Transactions trans = new Transactions(genId, stats, expiry, confirmcode, userId, date, totalcost, quantity, name);


                trans.insertTrans();

                string labelS = "Purchase successful";
                Session["labelSuccess"] = labelS;
               
                Response.Redirect("Shop.aspx");
                return;








            }

            else
            {
                string labelF = "Purchase Failed";
                Session["labelFail"] = labelF;

                Response.Redirect("Shop.aspx");
            }







            Response.Redirect("Shop.aspx");
        }
    }
}
