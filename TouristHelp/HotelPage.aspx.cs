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



            }
        }


        protected void RepeatHotel_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
        }

        private void loadRepeater2()
        {
            HotelBook hotel = new HotelBook();
            hotelList = hotel.GetAllHotel();

            RepeatHotel.DataSource = hotelList;
            RepeatHotel.DataBind();
        }


        protected void buy_Click(object sender, EventArgs e)
        {

            
        }


    }
}