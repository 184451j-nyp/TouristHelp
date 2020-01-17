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
            lbName.Text = Session["AttractionName"].ToString();
            lbPlace.Text = "placeholderPlace";
            lbDateTime.Text = "placeholderTime";
            lbPax.Text = "placeholderText";
        }
    }
}