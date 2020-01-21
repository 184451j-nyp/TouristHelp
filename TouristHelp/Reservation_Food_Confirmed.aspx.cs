using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TouristHelp
{
    public partial class Reservation_Food_Confirmed1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AttractionName"] != null)
            {
                lbName.Text = Session["AttractionName"].ToString();
                lbPlace.Text = "placeholderPlace";
                lbDateTime.Text = "placeholderTime";
                lbPax.Text = "placeholderText";
            }
            else
            {
                Response.Redirect("Guidebook.aspx");
            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Guidebook.aspx");
        }
    }
}