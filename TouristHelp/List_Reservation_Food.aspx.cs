using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;

namespace TouristHelp
{
    public partial class List_Reservation_Food : System.Web.UI.Page
    {
        List<Food_Reservation> resList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["tourist_id"] == null && Session["tourguide_id"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                else
                {

                    try
                    {
                        Label1.Text = Session["tourist_id"].ToString();
                    }
                    catch (NullReferenceException)
                    {
                        Label1.Text = Session["tourguide_id"].ToString();
                    }

                }
                loadRepeater();
            }
        }

        private void loadRepeater()
        {
            Food_Reservation actt = new Food_Reservation();
            resList = actt.GetReservationById(int.Parse(Session["tourist_id"].ToString()));
            
            RepeaterReserves.DataSource = resList;
            RepeaterReserves.DataBind();
        }
    }
}