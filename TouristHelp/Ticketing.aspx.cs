using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;

namespace TouristHelp
{
    public partial class Ticketing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btn_TypeSel(object sender, EventArgs e)
        {
          
        }
        protected void Btn_DecreaseQ(object sender, EventArgs e)
        {

        }
        protected void Btn_IncreaseQ(object sender, EventArgs e)
        {

        }
        protected void Btn_Buy(object sender, EventArgs e)
        {

        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Package_Click(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged2(object sender, EventArgs e)
        {
            tbDate_PopupControlExtender.Commit(Calendar1.SelectedDate.ToShortDateString());
        }

        protected void Btn_MinQ(object sender, EventArgs e)
        {
            int current = Convert.ToInt32(tbQuantity.Text.ToString());
            if(current > 0)
            {
                string newQ = (current - 1).ToString();
                tbQuantity.Text = newQ;
            }
            
        }

        protected void Btn_AddQ(object sender, EventArgs e)
        {
            int current = Convert.ToInt32(tbQuantity.Text.ToString());
            string newQ = (current + 1).ToString();
            tbQuantity.Text = newQ;
        }

        protected void BtnBuy_Click(object sender, EventArgs e)
        {
            string attName = lbTicketName.Text;
            string attDesc = lbTicketDesc.Text;
            double price = Convert.ToDouble(lblPrice.Text);
            DateTime expDate = Convert.ToDateTime(tbDate.Text);
            string code = "somethingnew";
            int user_id = 1;
            int quantity = Convert.ToInt32(tbQuantity.Text);

            Ticket tkt = new Ticket(attName, attDesc, price, expDate, code, "not paid", user_id);
            tkt.AddNewTicket();

            Cart cart = new Cart(attName, attDesc, price, quantity, user_id);
            cart.InsertCartTicket();
        }
    }
}