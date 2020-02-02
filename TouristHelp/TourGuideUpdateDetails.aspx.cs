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
            if(!IsPostBack)
            {
                tourguidenameTextBox.Text = (string)Session["SSName"];
                tourguideemailTextBox.Text = (string)Session["SSEmail"];
                tourguidepasswordTextBox.Text = (string)Session["SSPassword"];
                tourguidetourtitleTextBox.Text = (string)Session["SSTours"];
                tourguideuseridTextBox.Text = (string)Session["SSUserId"];
                tourguidetourguideidTextBox.Text = (string)Session["SSTourGuideId"];

                tourguidedescriptionTextBox.Text = (string)Session["SSDescription"];
                tourguidelanguagesTextBox.Text = (string)Session["SSLanguages"];
                tourguidecredentialsTextBox.Text = (string)Session["SSCredentials"];
                tourguidetourdescriptionTextBox.Text = (string)Session["SSTourDescription"];
                tourguidetourdetailsTextBox.Text = (string)Session["SSTourDetails"];
                tourguidetourpriceTextBox.Text = (string)Session["SSTourPrice"];
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            //TourGuide tg = new TourGuide(int.Parse(tourguidetourguideidTextBox.Text), int.Parse(tourguideuseridTextBox.Text),tourguidenameTextBox.Text, tourguideemailTextBox.Text, tourguidepasswordTextBox.Text, tourguidetourtitleTextBox.Text, tourguidedescriptionTextBox.Text,tourguidelanguagesTextBox.Text, tourguidecredentialsTextBox.Text, tourguidetourdescriptionTextBox.Text, tourguidetourdetailsTextBox.Text, decimal.Parse(tourguidetourpriceTextBox.Text));
            //TourGuideDAO.UpdateTourGuide(tg);
        }
    }
}