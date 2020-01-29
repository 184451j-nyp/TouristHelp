using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.DAL;
using TouristHelp.Models;

namespace TouristHelp
{
    public partial class Planner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["tourist_id"] != null)
            {
                List<Direction> places = DirectionDAO.GetDirByUser(int.Parse(Session["tourist_id"].ToString()));
                gvDirections.Visible = true;
                gvDirections.DataSource = places;
                gvDirections.DataBind();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            
        }
    }
}