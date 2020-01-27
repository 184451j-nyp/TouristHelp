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

    public partial class Hotel : System.Web.UI.Page
    {
        List<HotelBook> hotelList;


       
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!Page.IsPostBack)

            {

                loadRepeater2();

                if (Session["hotelAdded"] != null)
                    {
                    hotelAddedLbl.Text = Session["hotelAdded"].ToString();
                    hotelAddedLbl.Visible = true;
                    hotelAddedLbl.ForeColor = Color.Green;
                }



            }
        }


      

        private void loadRepeater2()
        {
            HotelBook hotel = new HotelBook();
            hotelList = hotel.GetAllHotel();

            RepeatHotel.DataSource = hotelList;
            RepeatHotel.DataBind();
        }


        protected void BtnBuy_Click(object sender, EventArgs e)
        {
          
        }


        protected void checkInCalender_SelectionChanged(object sender, EventArgs e)
        {
            //checkIn_PopupControlExtender.Commit(checkInCalender.SelectedDate.ToString());
        }


        protected void checkOutCalendar_SelectionChanged(object sender, EventArgs e)
        {
            //checkOut_PopupControlExtender.Commit(checkOutCalendar.SelectedDate.ToString());
        }

        protected void RepeatHotel_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            RepeaterItem hotels = e.Item;

            string attName;
            string attDesc = "";
            double price;
            DateTime expDate;
            int code;
            int user_id = 1;
            int quantity;
            decimal totalCost;

            HiddenField getHotelId = (HiddenField)hotels.FindControl("hotelId");
            Session["voucher_id"] = getHotelId.Value;


            Label getHotelName = (Label)hotels.FindControl("hotelName");
            Session["hotelName"] = getHotelName.Text;
            attName = getHotelName.Text;


            Label gethotelPrice = (Label)hotels.FindControl("hotelPrice");
            Session["hotelPrice"] = gethotelPrice.Text;
            price = Convert.ToDouble(gethotelPrice.Text);


            DateTime date = DateTime.Now;
            TimeSpan duration = new TimeSpan(30, 0, 0, 0);

            expDate = date.Add(duration);

            code = new Random().Next(100000, 999999);



            DropDownList hotelQty = (DropDownList)hotels.FindControl("roomQty");
            Session["roomQty"] = hotelQty.SelectedValue;
            quantity = Convert.ToInt32(hotelQty.SelectedValue);



            //DateTime checkInDateTime = Convert.ToDateTime(checkInTB);
            //DateTime checkOutDateTime = Convert.ToDateTime(checkOutTB);


            //TimeSpan difference = checkInDateTime - checkOutDateTime;

            //int stayDuration = Convert.ToInt32(difference.TotalDays);

            int stayDuration = 1;

            totalCost = Convert.ToDecimal(price * quantity * stayDuration);


            Boolean hotelPaid = false;
            //Ticket tkt = new Ticket(attName, attDesc, price, expDate, code, "not paid", user_id);
            //tkt.AddNewTicket();

            HotelTrans hotel = new HotelTrans(code, totalCost, quantity, stayDuration, user_id, attName, code, hotelPaid);
            hotel.AddNewHotel();

            Cart cart = new Cart(attName, attDesc, price, quantity, user_id);
            cart.InsertCartTicket();

            string hotelAdded = getHotelName.Text + " " + "(rooms: " + quantity.ToString() + ")" + "has been added to shop Cart";
            Session["hotelAdded"] = hotelAdded;

            Response.Redirect("HotelPage.aspx");
            return;
        }
    }
}