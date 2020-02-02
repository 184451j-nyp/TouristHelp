using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;

namespace TouristHelp
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        List<Cart> prodList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int user_id = Convert.ToInt32(Session["tourist_id"]);
                Cart cart = new Cart();
                prodList = cart.GetAllItems(user_id);

                Repeater1.DataSource = prodList;
                Repeater1.DataBind();
            }
                
        }



        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }


        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            //update your cart items active to not active and your own stuff "paid" from not paid to paid
            int user_id = Convert.ToInt32(Session["tourist_id"]);
            Cart cart = new Cart();
            cart.ItemPay(user_id);
            Response.Redirect("ShoppingCart.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                Label prodId = (Label)ri.FindControl("lbProdId");
                TextBox prodQuantity = (TextBox)ri.FindControl("tbQuantity");

                int productId = Convert.ToInt32(prodId.Text);
                int productQuantity = Convert.ToInt32(prodQuantity.Text);
                Cart cart = new Cart();
                cart.UpdateCart(productId, productQuantity);
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}