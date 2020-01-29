﻿using System;
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


            if (!Page.IsPostBack && region.SelectedItem.Value == "Region")

            {

                regionRepeater();

                if (Session["hotelAdded"] != null)
                {
                    hotelAddedLbl.Text = Session["hotelAdded"].ToString();
                    hotelAddedLbl.Visible = true;
                    hotelAddedLbl.ForeColor = Color.Green;
                }


            }

            else if (Page.IsPostBack && region.SelectedItem.Value == "Region" )

            {

                regionRepeater();


                if (Session["hotelAdded"] != null)
                {
                    hotelAddedLbl.Text = Session["hotelAdded"].ToString();
                    hotelAddedLbl.Visible = true;
                    hotelAddedLbl.ForeColor = Color.Green;
                }

             ;


            }



            else if (region.SelectedItem.Value == "North" && !Page.IsPostBack)
            {

               

                if (Session["hotelAdded"] != null)
                {
                    hotelAddedLbl.Text = Session["hotelAdded"].ToString();
                    hotelAddedLbl.Visible = true;
                    hotelAddedLbl.ForeColor = Color.Green;
                }

            }

            else if (Page.IsPostBack && region.SelectedItem.Value == "North")

            {
                northRepeater();



                if (Session["hotelAdded"] != null)
                {
                    hotelAddedLbl.Text = Session["hotelAdded"].ToString();
                    hotelAddedLbl.Visible = true;
                    hotelAddedLbl.ForeColor = Color.Green;


                
                }
            }






        }




        private void regionRepeater()
        {
            if (region.SelectedItem.Value == "Region")
            {
                HotelBook hotel = new HotelBook();
                hotelList = hotel.GetAllHotel();

                RepeatHotel.DataSource = hotelList;
                RepeatHotel.DataBind();

            }
            
        }

        private void northRepeater()
        {
           
             if (region.SelectedItem.Value == "North")
            {
                HotelBook hotel = new HotelBook();
                hotelList = hotel.getNorthHotels();

                RepeatHotel.DataSource = hotelList;
                RepeatHotel.DataBind();
            }

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
            string attDesc = "Item price cost consists of base price of hotel with the check in duration";
            double price;
            DateTime expDate;
            int code;
            int user_id = 1;
            int quantity;
            decimal totalCost;

            HiddenField getHotelId = (HiddenField)hotels.FindControl("hotelId");
            Session["voucher_id"] = getHotelId.Value;


            


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
            DropDownList getHotelDuration = (DropDownList)hotels.FindControl("durationQty");
            Session["durationQty"] = getHotelDuration.SelectedValue;
            int stayDuration = Convert.ToInt32(getHotelDuration.SelectedValue);


            totalCost = Convert.ToDecimal(price * quantity * stayDuration);


            Boolean hotelPaid = false;
            //Ticket tkt = new Ticket(attName, attDesc, price, expDate, code, "not paid", user_id);
            //tkt.AddNewTicket();

            Label getHotelName = (Label)hotels.FindControl("hotelName");
            Session["hotelName"] = getHotelName.Text;
            string attDuration = stayDuration.ToString();
            attName = getHotelName.Text + " (" + attDuration + " Days" + ")";

            double cartPrice = Convert.ToDouble(price) * Convert.ToDouble(stayDuration);


            HotelTrans hotel = new HotelTrans(code, totalCost, quantity, stayDuration, user_id, attName, code, hotelPaid);
            hotel.AddNewHotel();

            Cart cart = new Cart(attName, attDesc, cartPrice, quantity, user_id);
            cart.InsertCartTicket();

            string hotelAdded = getHotelName.Text + " " + "(rooms: " + quantity.ToString()  + ")" + "(duration: " + stayDuration.ToString() + "days" + ")" + "has been added to shop Cart";
            Session["hotelAdded"] = hotelAdded;

            Response.Redirect("HotelPage.aspx");
            return;
        }

        protected void myListDropDown_Change(object sender, EventArgs e)
        {

        }
    }
}