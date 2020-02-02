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
using Newtonsoft.Json;

namespace TouristHelp
{
    public partial class Planner : System.Web.UI.Page
    {
        List<Direction> places;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["tourist_id"] != null)
            {
                int tourist_id = int.Parse(Session["tourist_id"].ToString());
                places = DirectionDAO.GetDirByUser(tourist_id);
                geojsonHidden.Value = JsonConvert.SerializeObject(DirectionDAO.GetGeoJsonsByUser(tourist_id));
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