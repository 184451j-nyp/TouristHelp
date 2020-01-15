using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TouristHelp
{
    public partial class Guidebook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void BtnAction_Click(object sender, EventArgs e)
        {
            Session["AttractionId"] = "1";
            Response.Redirect("Reservation_Food.aspx");
        }
    }
}