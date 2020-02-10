using System;
using TouristHelp.DAL;

namespace TouristHelp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tourguide_id"] != null || Session["tourist_id"] != null)
            {
                string name = "";
                int id = int.Parse(Session["tourist_id"].ToString());
                //int tourguideId = int.Parse(Session["tourguide_id"].ToString());
                try
                {
                    name = TouristDAO.SelectTouristById(id).Name;
                }
                catch
                {
                  //  name = TourGuideDAO.SelectTourGuideById(tourguideId).Name;
                }
                finally
                {
                    LblName.Text = name;
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}