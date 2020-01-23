using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouristHelp.DAL;

namespace TouristHelp.BLL
{
    public class Cart
    {
        public string productName { get; set; }
        public string productDesc { get; set; }
        public double productPrice { get; set; }
        public int productQuantity { get; set; }
        public double productTotalPrice { get; set; }
        public Cart()
        {

        }

        public Cart(string productname, string productdesc, double productprice, int productquantity, double producttotalprice)
        {
            productName = productname;
            productDesc = productdesc;
            productPrice = productprice;
            productQuantity = productquantity;
            productTotalPrice = producttotalprice;
        }

        public List<Cart> GetAllItems(int userid)
        {
            CartDAO dao = new CartDAO();
            return dao.SelectCartById(userid);
        }

        public void UpdateCart(int quantity)
        {
            CartDAO dao = new CartDAO();
            dao.UpdateItem(quantity);
        }
    }
}