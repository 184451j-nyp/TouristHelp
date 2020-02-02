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
            tourguidetitleLabel.Text = (string)Session["SSTours"];
            tourguideidLabel.Text = (string)Session["SSTourGuideId"];
            useridLabel.Text = (string)Session["SSUserId"];
            tourdescriptionLabel.Text = (string)Session["SSTourDescription"];
            tourdetailsLabel.Text = (string)Session["SSTourDetails"];
            tourpriceLabel.Text = (string)Session["SSTourPrice"];
        }

        protected void BtnConfirm_Click(object sender, EventArgs e)
        {
           // TouristDAO.InsertBooking(tourguidetitleLabel.Text, int.Parse(tourguideidLabel.Text), int.Parse(useridLabel.Text));
        }
    }
}