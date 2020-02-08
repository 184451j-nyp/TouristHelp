using System;

namespace TouristHelp
{
    public partial class blank : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tourist_id"] != null || Session["tourguide_id"] != null)
            {
                try
                {
                    Label1.Text = Session["tourist_id"].ToString();
                }
                catch (NullReferenceException)
                {
                    Label1.Text = Session["tourguide_id"].ToString();
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }




        }
    }
}