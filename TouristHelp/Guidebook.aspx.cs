﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;

namespace TouristHelp
{
    public partial class Guidebook : System.Web.UI.Page
    {
        List<Attraction> acttList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loadRepeater();
            }
        }

        private void loadRepeater()
        {
            Attraction actt = new Attraction();
            acttList = actt.ListAttraction();

            RepeaterAttraction.DataSource = acttList;
            RepeaterAttraction.DataBind();
        }


        protected void GoNextPage(object source, RepeaterCommandEventArgs e)
        {
            RepeaterItem item1 = e.Item;
            Label attId = (Label)item1.FindControl("LbId");
            Label attTran = (Label)item1.FindControl("LbTran");

            Session["AttractionId"] = attId.Text;

            if (attTran.Text == "Food Reservtion")
            {
                Response.Redirect("Reservation_Food.aspx");
            }
            else if (attTran.Text == "Ticket")
            {
                Response.Redirect("Ticketing.aspx");
            }
            
        }
    }
}