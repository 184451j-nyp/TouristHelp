using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.DAL;
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
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            Tourist tourist = TouristDAO.SelectTouristByEmail(email);
            if (tourist != null)
            {
                lblErr.Text = tourist.Nationality;
            }
        }
    }
}