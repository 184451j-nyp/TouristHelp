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

        protected void GoNextPage(object sender, EventArgs e)
        {
            Session["AttractionId"] = "7"; // change to name we have the actual name here arady
            Response.Redirect("Reservation_Food.aspx");
        }

        protected void GoNextPage(object source, RepeaterCommandEventArgs e)
        {
            RepeaterItem item1 = e.Item;
            Label attId = (Label)item1.FindControl("LbId");

            Session["AttractionId"] = attId.Text; 
            Response.Redirect("Reservation_Food.aspx");
        }
    }
}