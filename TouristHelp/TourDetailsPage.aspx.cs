using System;
using System.Collections.Generic;
using System.Linq;
using TouristHelp.Models;
using TouristHelp.DAL;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TouristHelp
{
    public partial class TourDetailsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Tours smth = ToursDAO.SelectTourByTourGuideId(int.Parse(Session["SSTourGuideId"].ToString()));
            tourguidetitleLabel.Text = smth.Title;
        }

        protected void BtnConfirm_Click(object sender, EventArgs e)
        {
           // TouristDAO.InsertBooking(tourguidetitleLabel.Text, int.Parse(tourguideidLabel.Text), int.Parse(useridLabel.Text));
        }
    }
}