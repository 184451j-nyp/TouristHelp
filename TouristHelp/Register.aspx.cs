using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
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
            }
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string pass1 = tbPassword.Text;
            string pass2 = tbRepeatPass.Text;
            string nation = ddlNation.SelectedValue;
            Tourist obj = new Tourist(name, email, pass1, nation);
            TouristDAO touristDAO = new TouristDAO();
            touristDAO.InsertTourist(obj);
        }

        private static List<string> CountryList()
        {
            List<string> list = new List<String>();

            CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach(CultureInfo getCulture in getCultureInfo)
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