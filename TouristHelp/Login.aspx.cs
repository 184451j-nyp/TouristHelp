﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.DAL;
using TouristHelp.BLL;
using TouristHelp.Models;

namespace TouristHelp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    TourGuide user = TourGuideDAO.SelectTourGuideByEmail(tbEmail.Text);
                    Session["tourguide_id"] = user.TourGuideId.ToString();
                }
                catch(Exception)
                {
                    Tourist user = TouristDAO.SelectTouristByEmail(tbEmail.Text);
                    Session["tourist_id"] = user.TouristId.ToString();
                }
                finally
                {
                    Response.Redirect("blank.aspx");
                }
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string email = tbEmail.Text.ToLower();
            string password = tbPassword.Text;
            if(SHA256Hash.GenerateSHA256(password) == UserDAO.GetLoginCredentials(email))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }


            System.Diagnostics.Debug.WriteLine(email);

        }
    }
}