using System;
using System.Collections.Generic;
using System.Linq;
using TouristHelp.Models;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TouristHelp
{
    public partial class TourGuideRequestsPage : System.Web.UI.Page
    {
        List<TouristBooking> touristbookingList;

        protected void Page_Load(object sender, EventArgs e)
        {
            loadRepeater();
        }
        private void loadRepeater()
        {
            touristbookingList = TouristBooking.GetAllTourBookingsOfTourGuide(int.Parse(Session["tourguide_id"].ToString()));

            RepeaterBookings.DataSource = touristbookingList;
            RepeaterBookings.DataBind();
        }
    }
}