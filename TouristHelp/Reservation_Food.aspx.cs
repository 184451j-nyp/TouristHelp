using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;

namespace TouristHelp
{
    public partial class Reservation_Food : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string attractId = Session["AttractionId"].ToString();

            // Retrieve TDMaster records by account
            Attraction td = new Attraction();
            td = td.GetAttractionDataById(attractId);

            lbName.Text = td.Name;
        }

        protected void BtnConfirm_Click(object sender, EventArgs e)
        {
            Session["AttractionName"] = lbName.Text.ToString();
            Response.Redirect("Reservation_Food_Confirmed.aspx");
        }
    }
}