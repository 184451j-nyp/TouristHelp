using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TouristHelp
{
    public partial class blank : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = Session["tourist_id"].ToString();
            }
            catch(NullReferenceException)
            {
                Label1.Text = Session["tourguide_id"].ToString();
            }

            string[] arr = { "Hello world!", "This is a test array"};
            for(int i=0; i<arr.Length; i++)
            {
                Page.ClientScript.RegisterArrayDeclaration("array", arr[i]);
            }
        }
    }
}