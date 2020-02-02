using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;

namespace TouristHelp
{
    public partial class AdminPageAddAttraction_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Attraction att = new Attraction(TbName.Text, float.Parse(TbPrice.Text), TbDate.Text, TbDesc.Text, TbLocation.Text, decimal.Parse(TbLat.Text), decimal.Parse(TbLong.Text), DdlInterest.SelectedValue, DdlType.SelectedValue, DdlTran.SelectedValue);
            att.AddAttraction(att);
            Response.Redirect("AdminPageAddAttraction.aspx");
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPageAddAttraction.aspx");
        }
    }
}