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

                // to check for any expired reservationd
                Food_Reservation res = new Food_Reservation();
                resList = res.GetReservationById(int.Parse(Session["tourist_id"].ToString()));

                for (int i = 0; i < resList.Count; i++)
                {
                    DateTime currDate = DateTime.Today;
                    if (DateTime.Parse(resList[i].Date) < currDate.Date)
                    {
                        res.CancelReservation(resList[i].Id);
                    }
                }
                loadRepeater();
            }
        }

        void testcel()
        {

        }

        private void loadRepeater()
        {
            Food_Reservation res = new Food_Reservation();
            resList = res.GetReservationById(int.Parse(Session["tourist_id"].ToString()));
            
            RepeaterReserves.DataSource = resList;
            RepeaterReserves.DataBind();
        }

        protected void DetailsRes(object source, RepeaterCommandEventArgs e)
        {
            RepeaterItem item1 = e.Item;
            Label resId = (Label)item1.FindControl("LbId");

            Food_Reservation res = new Food_Reservation();
            Session["ResId"] = resId.Text;

            Response.Redirect("Reservation_Food_QR.aspx");
        }
    }
}