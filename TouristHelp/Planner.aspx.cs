using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.DAL;
using TouristHelp.Models;
using TouristHelp.BLL;

namespace TouristHelp
{
    public partial class Planner : System.Web.UI.Page
    {
        private List<Direction> places;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tourist_id"] != null)
            {
                LoadData(int.Parse(Session["tourist_id"].ToString()));
                if (!Page.IsPostBack)
                {
                    AttractionDAO attractions = new AttractionDAO();
                    foreach (var i in attractions.SelectAll().OrderBy(a => a.Name).ToList())
                    {
                        DropDownListAttractions.Items.Add(new ListItem(i.Name, i.Id.ToString()));
                    }
                    DropDownListAttractions.DataBind();
                }
            }
            else if (Session["tourguide_id"] != null)
            {
                Response.Redirect("Index.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }







            //Michaels daily reward check, remove if causing error

            Session["user_id"] = Session["tourist_id"];

            string user_id = Session["user_id"].ToString();

            int userId = Convert.ToInt32(user_id);
            // Retrieve TDMaster records by account
            Reward td = new Reward();
            td = td.GetRewardById(user_id);



            DateTime dateNow = DateTime.Now;



            //DateTime NextDayDate = dateNow.AddHours(24);

            if (td.loggedInLog == true && td.loggedInDate.Date != DateTime.Now.Date)
            {

                int loginCount = td.loginCount;
                int loginStreak = td.loginStreak;
                int creditBalance = td.creditBalance;
                bool renewLogIn = false;
                DateTime loggedInDate = td.loggedInDate;
                bool newDateCheck = false;
                int remainBonusDays = td.remainBonusDays;

                td.updateLoggedIn(userId, loginCount, loginStreak, creditBalance, remainBonusDays, renewLogIn, loggedInDate, newDateCheck);

            }


            if (td.loggedInLog == false)
            {

                int timeDifference = DateTime.Compare(td.loggedInDate, dateNow);

                if (dateNow.Subtract(td.loggedInDate) <= TimeSpan.FromHours(24))
                {
                    int loginCount = td.loginCount + 1;
                    int loginStreak = td.loginStreak + 1;
                    int creditBalance = td.creditBalance + 5;
                    bool loggedInLog = true;
                    DateTime loggedInDate = DateTime.Now;
                    bool newDateCheck = true;
                    int remainBonusDays = td.remainBonusDays - 1;

                    td.updateLoggedIn(userId, loginCount, loginStreak, creditBalance, remainBonusDays, loggedInLog, loggedInDate, newDateCheck);

                    if (loginStreak % 10 == 0)
                    {
                        creditBalance = td.creditBalance + td.bonusCredits + 5;
                        remainBonusDays = td.remainBonusDays + 9;


                        td.updateBonus(userId, loginStreak, creditBalance, remainBonusDays);
                    }

                }

                else if (dateNow.Subtract(td.loggedInDate) > TimeSpan.FromHours(24))
                {
                    int loginCount = td.loginCount + 1;
                    int loginStreak = 0;
                    int creditBalance = td.creditBalance + 5;
                    bool loggedInLog = true;
                    DateTime loggedInDate = DateTime.Now;
                    bool newDateCheck = true;
                    int remainBonusDays = 10;

                    td.updateLoggedIn(userId, loginCount, loginStreak, creditBalance, remainBonusDays, loggedInLog, loggedInDate, newDateCheck);

                }


            }

            if (td.loginCount == 100)
            {
                string loyaltyTier = "Gold";
                int bonuscredits = 15;

                td.updateLoyaltyBonus(userId, loyaltyTier, bonuscredits);
            }



            if (td.loginCount == 200)
            {
                string loyaltyTier = "Diamond";
                int bonuscredits = 20;

                td.updateLoyaltyBonus(userId, loyaltyTier, bonuscredits);
            }




            //Michaels daily reward check, remove if causing error
        }

        protected void BtnAddAttraction_Click(object sender, EventArgs e)
        {
            DirectionDAO.AddDirToUser(int.Parse(DropDownListAttractions.SelectedValue), int.Parse(Session["tourist_id"].ToString()));
            LoadData(int.Parse(Session["tourist_id"].ToString()));
        }

        private void LoadData(int tourist_id)
        {
            places = DirectionDAO.GetDirByUser(tourist_id);

            if (places.Count == 0)
            {
                lblNoEntry.Visible = true;
                List<Direction> random = DirectionDAO.GetRandomPoI();
                gvDirections.DataSource = random;
                gvDirections.DataBind();
                GeoJsonHidden.Value = JsonConvert.SerializeObject(DirectionDAO.ParseGeoJsonFromList(random));
            }
            else
            {
                GeoJsonHidden.Value = JsonConvert.SerializeObject(DirectionDAO.GetGeoJsonsByUser(tourist_id));
                gvDirections.DataSource = places;
                gvDirections.DataBind();
                DropDownListSaved.Items.Clear();
                foreach (Direction i in places)
                {
                    DropDownListSaved.Items.Add(i.Name);
                }
                DropDownListSaved.DataBind();
            }
            gvDirections.Visible = true;
        }

        protected void gvDirections_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvDirections.SelectedRow;
            int attraction = int.Parse(row.Cells[0].Text);
            DirectionDAO.RemoveOneDirByUser(attraction, int.Parse(Session["tourist_id"].ToString()));
            LoadData(int.Parse(Session["tourist_id"].ToString()));
        }
    }
}