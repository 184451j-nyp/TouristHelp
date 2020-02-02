using System;
using TouristHelp.Models;
using TouristHelp.BLL;
using TouristHelp.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TouristHelp
{
    public partial class TourGuideUpdateDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tourguidenameTextBox.Text = Session["name"].ToString();
                tourguidedescriptionTextBox.Text = Session["description"].ToString();
                tourguidelanguagesTextBox.Text = Session["languages"].ToString();
                tourguidecredentialsTextBox.Text = Session["credentials"].ToString();
                tourguideemailLabel.Text = Session["email"].ToString();
                tourguidepasswordLabel.Text = Session["password"].ToString();
                tourguideidLabel.Text = Session["tourguide_id"].ToString();
                tourguideuseridLabel.Text = Session["user_id"].ToString();
              
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            TourGuide tg = new TourGuide(int.Parse(tourguideidLabel.Text), int.Parse(tourguideuseridLabel.Text), tourguidenameTextBox.Text, tourguideemailLabel.Text, tourguidepasswordLabel.Text, tourguidedescriptionTextBox.Text, tourguidelanguagesTextBox.Text, tourguidecredentialsTextBox.Text);
            TourGuide.UpdateTourGuide(tg);
        }
    }
}