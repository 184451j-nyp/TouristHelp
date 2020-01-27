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
        }

        protected void BtnConfirm_Click(object sender, EventArgs e)
        {
            Session["BookingName"] = tourguidetitleLabel.Text.ToString();
            TouristDAO.InsertBooking(tourguidetitleLabel.Text.ToString());
        }
    }
}