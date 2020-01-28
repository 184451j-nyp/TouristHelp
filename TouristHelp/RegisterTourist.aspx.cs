﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.UI.WebControls;
using TouristHelp.DAL;
using TouristHelp.BLL;
using TouristHelp.Models;

namespace TouristHelp
{
    public partial class RegisterTourist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlNation.DataSource = CountryList();
                ddlNation.DataBind();
                ddlNation.Items.Insert(0, "-- Select --");
            }
        }

        protected void btnSignupTourist_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string name = tbNameTourist.Text;
                string email = tbEmailTourist.Text.ToLower();
                string pass1 = tbPasswordTourist.Text;
                string pass2 = tbRepeatPassTourist.Text;
                string nation = ddlNation.SelectedValue;
                if (pass1 == pass2 && name != "" && email != "" && pass1 != "" && nation != "-- Select --")
                {
                    string hash = SHA256Hash.GenerateSHA256(pass1);
                    Tourist obj = new Tourist(name, email, hash, nation);
                    TouristDAO.InsertTourist(obj);

                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void CustomValidatorEmailExists_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (UserDAO.UserWithEmailExists(args.Value))
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        private static List<string> CountryList()
        {
            List<string> list = new List<string>();

            CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo getCulture in getCultureInfo)
            {
                RegionInfo regionInfo = new RegionInfo(getCulture.LCID);
                if (!(list.Contains(regionInfo.EnglishName)))
                {
                    list.Add(regionInfo.EnglishName);
                }
            }

            list.Sort();
            return list;
        }
    }
}