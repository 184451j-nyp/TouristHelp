﻿using System;
using TouristHelp.Models;
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
                tourguidedescriptionTextBox.Text = (string)Session["SSDept"];
                tourguidelanguagesTextBox.Text = (string)Session["SSId"];
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            //User emp = new TourGuide();
            //emp = new User(tourguidenameTextBox.Text, tourguidedescriptionTextBox.Text, tourguidelanguagesTextBox.Text);


        }
    }
}