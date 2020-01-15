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
            int userId = 1;
            Interest inter = new Interest();
            List<Interest> IntList = inter.checkInterests(userId);
            if(IntList != null)
            {
                for(int i = 0; i < IntList.Count; i++)
                {
                    if(IntList[i].InterestName == "Food")
                    {
                        BtnAddFood.Visible = false;
                        BtnRemFood.Visible = true;
                    }
                    else if (IntList[i].InterestName == "Nature")
                    {
                        BtnAddNature.Visible = false;
                        BtnRemNature.Visible = true;
                    }
                    else if (IntList[i].InterestName == "Amusement Park")
                    {
                        BtnAddAP.Visible = false;
                        BtnRemAP.Visible = true;
                    }
                }
            }
            
		}
        protected void Btn_AddInt(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int userId = 1;
            //assuming the one logged in is userid 1
            if (b.ID == "BtnAddFood")
            {
                string interestName = "Food";

                Interest inter = new Interest(interestName, userId);
                inter.AddInterest();
                BtnAddFood.Visible = false;
                BtnRemFood.Visible = true;
            }

            if(b.ID == "BtnAddNature")
            {
                string interestName = "Nature";

                Interest inter = new Interest(interestName, userId);
                inter.AddInterest();
                BtnAddNature.Visible = false;
                BtnRemNature.Visible = true;
            }

            if (b.ID == "BtnAddAP")
            {
                string interestName = "Amusement Park";

                Interest inter = new Interest(interestName, userId);
                inter.AddInterest();
                BtnAddAP.Visible = false;
                BtnRemAP.Visible = true;
            }
        }
        protected void Btn_RemoveInt(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int userId = 1;
            //assuming the one logged in is userid 1
            if (b.ID == "BtnAddFood")
            {
                string interestName = "Food";

                Interest inter = new Interest();
                inter.RemoveInterest(interestName, userId);
                BtnAddFood.Visible = true;
                BtnRemFood.Visible = false;
            }

            if (b.ID == "BtnAddNature")
            {
                string interestName = "Nature";

                Interest inter = new Interest();
                inter.RemoveInterest(interestName, userId);
                BtnAddNature.Visible = true;
                BtnRemNature.Visible = false;
            }

            if (b.ID == "BtnAddFood")
            {
                string interestName = "Amusement Park";

                Interest inter = new Interest();
                inter.RemoveInterest(interestName, userId);
                BtnAddAP.Visible = true;
                BtnRemAP.Visible = false;
            }
        }
    }
}