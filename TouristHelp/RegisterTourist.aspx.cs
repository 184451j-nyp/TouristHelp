using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TouristHelp.DAL;
using TouristHelp.Models;

namespace TouristHelp
{
    public partial class Register : System.Web.UI.Page
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
            string name = tbNameTourist.Text;
            string email = tbEmailTourist.Text;
            string pass1 = tbPasswordTourist.Text;
            string pass2 = tbRepeatPassTourist.Text;
            string nation = ddlNation.SelectedValue;
            if (pass1 == pass2 && name != "" && email != "" && pass1 != "" && nation != "-- Select --")
            {
                Tourist obj = new Tourist(name, email, pass1, nation);
                TouristDAO.InsertTourist(obj);

                Response.Redirect("Login.aspx");
            }
        }

        protected void CustomValidatorEmailExists_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            if (UserDAO.UserWithEmailExists(args.Value))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
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