using System;
using System.Collections.Generic;
using TouristHelp.Models;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TouristHelp
{
    public partial class TourGuideListPage : System.Web.UI.Page
    {
        List<TourGuide> tourguideList;

        protected void Page_Load(object sender, EventArgs e)
        {
            loadRepeater();
        }

        private void loadRepeater()
        {
            tourguideList = TourGuide.GetAllTourGuide();

            Repeater1.DataSource = tourguideList;
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            RepeaterItem item1 = e.Item;
            Label theName = (Label)item1.FindControl("LbName");
            Label theEmail = (Label)item1.FindControl("LbEmail");
            Label thePassword = (Label)item1.FindControl("LbPassword");

            Session["SSId"] = theName.Text;
            Session["SSName"] = theEmail.Text;
            Session["SSDept"] = thePassword.Text;
            Response.Redirect("TourGuideUpdateDetails.aspx");
        }

    }
}