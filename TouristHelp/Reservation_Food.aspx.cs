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
            if (Session["AttractionId"] != null)
            {
                string attractId = Session["AttractionId"].ToString();

                // Retrieve TDMaster records by Id
                Attraction td = new Attraction();
                td = td.GetAttractionDataById(attractId);

                lbName.Text = td.Name;
                lbDesc.Text = td.Description;
                lbPlace.Text = td.Location;
            }
            else
            {
                Response.Redirect("Guidebook.aspx");
            }
            if (Session["tourist_id"] == null && Session["tourguide_id"] == null)
            {
                BtnConfirm.Text = "Login to reserve";
            }
        }

        protected void BtnConfirm_Click(object sender, EventArgs e)
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
                Session["ResName"] = lbName.Text.ToString();
                Session["ResLoc"] = lbPlace.Text.ToString();
                Session["ResTime"] = TbTime.Text.ToString();
                Session["ResPax"] = TbPax.Text.ToString();
                Food_Reservation td = new Food_Reservation();
                td.InsertReservation(lbName.Text, TbTime.Text, int.Parse(TbPax.Text), int.Parse(Session["tourist_id"].ToString()));
                Cart cr = new Cart(lbName.Text, "Reservation at " + lbName.Text, 0, 1, 1);
                cr.InsertCartReservation();
                Response.Redirect("Reservation_Food_Confirmed.aspx");
            }
            
        }
    }
}