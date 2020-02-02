using System;
using System.Collections.Generic;
using System.Linq;
using TouristHelp.Models;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TouristHelp
{
    public partial class TouristBookingsPage : System.Web.UI.Page
    {
        List<Tours> touristbookingList;

        protected void Page_Load(object sender, EventArgs e)
        {
            loadRepeater();
        }
        private void loadRepeater()
        {
            //touristbookingList = Tours.GetAllTouristBooking();

            RepeaterBookings.DataSource = touristbookingList;
            RepeaterBookings.DataBind();
        }

    }
}