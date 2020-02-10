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
    public partial class HotelReservation : System.Web.UI.Page
    {

        List<HotelTrans> hotelTrans;

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

            Session["user_id"] = Session["tourist_id"];


            string user_id = Session["user_id"].ToString();


            HotelTrans getHotel = new HotelTrans();
            hotelTrans = getHotel.getAllHotel(int.Parse(Session["tourist_id"].ToString()));

            for (int i = 0; i < hotelTrans.Count; i++)
            {
                DateTime currDate = DateTime.Today;
                if (hotelTrans[i].stayDuration < currDate.Date)
                {
                    getHotel.hotelInactive(hotelTrans[i].hotelGen_Id);
                }
            }

            

            paidFilter();
            // Retrieve Reward records by account
            //Reward td = new Reward();
            //td = td.GetRewardById(user_id);





            //voucherGen_id.Text = trans.voucherGen_id.ToString();

            //voucherStats.Text = trans.voucherStats.ToString();

            //voucherExpiry.Text = trans.voucherExpiry.ToString();

            //confirmCode.Text = trans.confirmCode.ToString();

            //voucherDate.Text = trans.voucherDate.ToString();

            //voucherTotalCost.Text = trans.voucherTotalCost.ToString();





        }



        private void paidFilter()
        {

            int userId = Convert.ToInt32(Session["tourist_id"]);
            HotelTrans emp = new HotelTrans();
            List<HotelTrans> eList = emp.showPaidHotel(userId);



            // using gridview to bind to the list of employee objects
            repeatHotelTrans.Visible = true;
            repeatHotelTrans.DataSource = eList;
            repeatHotelTrans.DataBind();

            repeatHotelTrans.DataSource = eList;
            repeatHotelTrans.DataBind();
        }





        protected void repeatHotelTrans_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            RepeaterItem hotelTrans = e.Item;

            HiddenField getCode = (HiddenField)hotelTrans.FindControl("getCode");
            Session["code"] = getCode.Value;
            int code = Convert.ToInt32(getCode.Value);

            Label getHotelStatus = (Label)hotelTrans.FindControl("hotelStatus");
            Session["hotelStatus"] = getHotelStatus.Text;
            string hotelStatus = getHotelStatus.Text;

            Button getButton = (Button)hotelTrans.FindControl("getQRcode");
            Session["getButton"] = getButton;

            if (hotelStatus == "Inactive"  || hotelStatus.ToString() == "Verified")
            {
                Label2.Visible = true;
                Label2.Text = "This hotel reservation has been active or used";
                Response.Redirect("hotelReservation.aspx");
            }

            else
            {
                Response.Redirect("/HotelDetail.aspx?code=" + code);
            }

            //if (hotelStatus)


            //String redirectToQR;

            //redirectToQR = "<script> window.open('https://touristhelp20200209023102.azurewebsites.net/TicketDetail.aspx?code=" + code + "'); </script>";

            //Response.Write(redirectToQR);





        }
    }
}