using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;

namespace TouristHelp
{
	public partial class InterestSelect : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (Session["tourist_id"] == null && Session["tourguide_id"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            int userId = int.Parse(Session["tourist_id"].ToString());
            Interest inter = new Interest();
            Interest IntList = inter.checkInterests(userId);
            if(IntList != null)
            {
                
                    if(IntList.InterestName == "Food")
                    {
                        BtnAddFood.Visible = false;
                        BtnRemFood.Visible = true;
                    }
                    else if (IntList.InterestName == "Nature")
                    {
                        BtnAddNature.Visible = false;
                        BtnRemNature.Visible = true;
                    }
                    else if (IntList.InterestName == "Amusement Park")
                    {
                        BtnAddAP.Visible = false;
                        BtnRemAP.Visible = true;
                    }
                
            }
            
		}
        protected void Btn_AddInt(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int userId = int.Parse(Session["tourist_id"].ToString());
            if (b.ID == "BtnAddFood")
            {
                string interestName = "Food";

                Interest inter = new Interest(interestName, userId);
                inter.AddInterest();
                BtnAddFood.Visible = false;
                BtnRemFood.Visible = true;
                BtnAddNature.Visible = true;
                BtnRemNature.Visible = false;
                BtnAddAP.Visible = true;
                BtnRemAP.Visible = false;
            }

            if(b.ID == "BtnAddNature")
            {
                string interestName = "Nature";

                Interest inter = new Interest(interestName, userId);
                inter.AddInterest();
                BtnAddNature.Visible = false;
                BtnRemNature.Visible = true;
                BtnAddFood.Visible = true;
                BtnRemFood.Visible = false;
                BtnAddAP.Visible = true;
                BtnRemAP.Visible = false;
            }

            if (b.ID == "BtnAddAP")
            {
                string interestName = "Amusement";

                Interest inter = new Interest(interestName, userId);
                inter.AddInterest();
                BtnAddAP.Visible = false;
                BtnRemAP.Visible = true;
                BtnAddNature.Visible = true;
                BtnRemNature.Visible = false;
                BtnAddFood.Visible = true;
                BtnRemFood.Visible = false;
            }
        }
        protected void Btn_RemoveInt(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int userId = int.Parse(Session["tourist_id"].ToString());
            if (b.ID == "BtnRemFood")
            {
                string interestName = "Food";

                Interest inter = new Interest();
                inter.RemoveInterest(interestName, userId);
                BtnAddFood.Visible = true;
                BtnRemFood.Visible = false;
            }

            if (b.ID == "BtnRemNature")
            {
                string interestName = "Nature";

                Interest inter = new Interest();
                inter.RemoveInterest(interestName, userId);
                BtnAddNature.Visible = true;
                BtnRemNature.Visible = false;
            }

            if (b.ID == "BtnRemFood")
            {
                string interestName = "Amusement";

                Interest inter = new Interest();
                inter.RemoveInterest(interestName, userId);
                BtnAddAP.Visible = true;
                BtnRemAP.Visible = false;
            }
        }
    }
}