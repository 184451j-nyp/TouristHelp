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
            Label theTours = (Label)item1.FindControl("LbTours");
            Label theDescription = (Label)item1.FindControl("LbDescription");
            Label theLanguages = (Label)item1.FindControl("LbLanguages");
            Label theCredentials = (Label)item1.FindControl("LbCredentials");



            Session["SSName"] = theName.Text;
            Session["SSTours"] = theTours.Text;
            Session["SSDescription"] = theDescription.Text;
            Session["SSLanguages"] = theLanguages.Text;
            Session["SSCredentials"] = theCredentials.Text;

            Response.Redirect("TourGuideUpdateDetails.aspx");
        }

    }
}