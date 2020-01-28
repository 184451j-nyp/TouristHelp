﻿using System;
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
            Label theuserId = (Label)item1.FindControl("LbuserId");
            Label thetourguideId = (Label)item1.FindControl("LbtourguideId");

            Label theEmail = (Label)item1.FindControl("LbEmail");
            Label thePassword = (Label)item1.FindControl("LbPassword");
            Label theTours = (Label)item1.FindControl("LbTours");
            Label theDescription = (Label)item1.FindControl("LbDescription");
            Label theLanguages = (Label)item1.FindControl("LbLanguages");
            Label theCredentials = (Label)item1.FindControl("LbCredentials");
            Label theTourDescription = (Label)item1.FindControl("Lbtourdescription");
            Label theTourDetails = (Label)item1.FindControl("Lbtourdetails");
            Label theTourPrice = (Label)item1.FindControl("Lbtourprice");






            Session["SSName"] = theName.Text;
            Session["SSEmail"] = theEmail.Text;
            Session["SSUserId"] = theuserId.Text;
            Session["SSTourGuideId"] = thetourguideId.Text;

            Session["SSPassword"] = thePassword.Text;
            Session["SSTours"] = theTours.Text;
            Session["SSDescription"] = theDescription.Text;
            Session["SSLanguages"] = theLanguages.Text;
            Session["SSCredentials"] = theCredentials.Text;
            Session["SSTourDescription"] = theTourDescription.Text;
            Session["SSTourDetails"] = theTourDetails.Text;
            Session["SSTourPrice"] = theTourPrice.Text;



            Response.Redirect("TourGuideDetails.aspx");
        }

    }
}