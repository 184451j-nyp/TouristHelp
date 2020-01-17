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
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user_id"] = "1";

            string user_id = Session["user_id"].ToString();

            // Retrieve Reward records by account
            Reward td = new Reward();
            td = td.GetRewardById(user_id);


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



            voucherExpiry.Text = trans.voucherExpiry.ToString();

        }
    }
}