using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.DAL;
using TouristHelp.Models;

namespace TouristHelp
{
    public partial class Planner : System.Web.UI.Page
    {
        List<Direction> places;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["tourist_id"] != null)
            {
                places = DirectionDAO.GetDirByUser(int.Parse(Session["tourist_id"].ToString()));
                if (places.Count == 0)
                {
                    lblNoEntry.Visible = true;
                }
                else
                {
                    gvDirections.Visible = true;
                    gvDirections.DataSource = places;
                    gvDirections.DataBind();
                }


            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            
        }
    }
}