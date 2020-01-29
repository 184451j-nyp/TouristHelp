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
    public partial class Transaction : System.Web.UI.Page
    {
        List<Transactions> eList;

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

            //Session["user_id"] = "2";

            //string user_id = Session["user_id"].ToString();


            //int userId = 1;
            //Transactions inter = new Transactions();
            //List<Transactions> IntList = inter.getTransaction(userId);


            RefreshGridView();


            // Retrieve Reward records by account
            //Reward td = new Reward();
            //td = td.GetRewardById(user_id);


            Session["voucher_id"] = "1";

            string shop_id = Session["voucher_id"].ToString();
            // Retrieve ShopVoucher records by account
            ShopVoucher ts = new ShopVoucher();

            ts = ts.GetShopById(shop_id);


            Session["voucherGen_id"] = "123";

            string trans_id = Session["voucherGen_id"].ToString();
            // Retrieve Transaction records by account

            Transactions trans = new Transactions();

            trans = trans.GetTransactionByid(trans_id);


            //voucherGen_id.Text = trans.voucherGen_id.ToString();

            //voucherStats.Text = trans.voucherStats.ToString();

            //voucherExpiry.Text = trans.voucherExpiry.ToString();

            //confirmCode.Text = trans.confirmCode.ToString();

            //voucherDate.Text = trans.voucherDate.ToString();

            //voucherTotalCost.Text = trans.voucherTotalCost.ToString();




        }

        private void RefreshGridView()
        {

            int userId = 1;
            Transactions emp = new Transactions();
            List<Transactions> eList = emp.getTransaction(userId);



            // using gridview to bind to the list of employee objects
            GvEmployee.Visible = true;
            GvEmployee.DataSource = eList;
            GvEmployee.DataBind();

            Repeater1.DataSource = eList;
            Repeater1.DataBind();
        }
    }
}