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
            RepeaterItem selItem = e.Item;

            int user_id = Convert.ToInt32(Session["tourist_id"]);
            Label prodId = (Label)selItem.FindControl("lbProdId");
            int productId = Convert.ToInt32(prodId.Text);
            Cart cart = new Cart();
            cart.DeleteItem(productId, user_id);
            Response.Redirect("ShoppingCart.aspx");
        }


        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            
            int user_id = Convert.ToInt32(Session["tourist_id"]);

            //update your paid = paid before ItemPay();

            foreach (RepeaterItem ri in Repeater1.Items)
            {
                Label prodId = (Label)ri.FindControl("lbProdId");
                Label prodName = (Label)ri.FindControl("lbProdName");
                TextBox prodQuantity = (TextBox)ri.FindControl("tbQuantity");

                Random random = new Random();
                int productId = Convert.ToInt32(prodId.Text);
                string productName = prodName.Text.ToString();
                int productQuantity = Convert.ToInt32(prodQuantity.Text);
                Ticket updateItem = new Ticket();
                updateItem.TicketPay(productId, user_id);

                Cart newItem = new Cart();
                int cart_id = newItem.GetCartId(productName, user_id);
                if(cart_id != 0)
                {
                    int Count = productQuantity - 1;
                    int i = 0;
                    while(i < Count)
                    {
                        Ticket dupeTix = new Ticket();
                        dupeTix = dupeTix.getTicketDetail(productId, user_id);

                        string itemName = dupeTix.attractionName;
                        string itemDesc = dupeTix.attractionDesc;
                        double itemPrice = dupeTix.price;
                        DateTime itemExp = dupeTix.dateExpire;
                        //string itemImg = dupeTix.AttImg;

                        string code = random.Next(1000000, 9999999).ToString();
                        Ticket ticket = new Ticket();
                        List<String> codeList = ticket.GetCodes();
                        while (true && codeList != null)
                        {
                            if (codeList.Contains(code))
                            {
                                code = random.Next(1000000, 9999999).ToString();
                            }
                            else
                            {
                                break;
                            }
                        }

                        Ticket newTix = new Ticket(itemName, itemDesc, itemPrice, itemExp, code, "paid", user_id, cart_id);
                        newTix.AddNewTicket();

                        i++;
                    }
                    
                }

            }

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