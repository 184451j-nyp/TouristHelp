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
        }

        protected void BtnConfirm_Click(object sender, EventArgs e)
        {

            Session["ResName"] = lbName.Text.ToString();
            Session["ResLoc"] = lbPlace.Text.ToString();
            Session["ResTime"] = TbTime.Text.ToString();
            Session["ResPax"] = TbPax.Text.ToString();
            Attraction td = new Attraction();
            td.InsertReservation(lbName.Text, TbTime.Text, int.Parse(TbPax.Text), 1);
            Response.Redirect("Reservation_Food_Confirmed.aspx");

        }
    }
}