using System;
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
                if (Session["AttractionType"] == null) //filter codes
                {
                    loadRepeater("All");
                }
                else
                {
                    loadRepeater(Session["AttractionType"].ToString());
                }
                    
            }
        }

        private void loadRepeater(string type)
        {
            Attraction actt = new Attraction();
            
            if (type == "All")
            {
                acttList = actt.ListAttractionAll();
            }
            else
            {
                acttList = actt.ListAttraction(type);
            }



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

        protected void ButtonFilterAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("Guidebook.aspx");
        }

        protected void ButtonFilterPlaces_Click(object sender, EventArgs e)
        {
            Session["AttractionType"] = "Place";
            Response.Redirect("Guidebook.aspx");
        }

        protected void ButtonFilterEvents_Click(object sender, EventArgs e)
        {
            Session["AttractionType"] = "Event";
            Response.Redirect("Guidebook.aspx");
        }

        protected void ButtonFilterDeals_Click(object sender, EventArgs e)
        {
            Session["AttractionType"] = "Deal";
            Response.Redirect("Guidebook.aspx");
        }
    }
}