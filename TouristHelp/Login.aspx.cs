﻿using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;
using TouristHelp.DAL;
using TouristHelp.Models;

namespace TouristHelp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if(tbEmail.Text == "admin@touristhelp.com")
                {
                    Session["admin"] = true;
                    Response.Redirect("IndexAdmin.aspx");
                    return;
                }

                try
                {
                    TourGuide user = TourGuideDAO.SelectTourGuideByEmail(tbEmail.Text);
                    Session["tourguide_id"] = user.TourGuideId.ToString();
                }
                catch (Exception)
                {
                    Tourist user = TouristDAO.SelectTouristByEmail(tbEmail.Text);
                    Session["tourist_id"] = user.TouristId.ToString();
                }
                finally
                {
                    if (Session["tourguide_id"] != null)
                    {
                        Response.Redirect("TourGuideRequestsPage.aspx");
                    }
                    else if (Session["tourist_id"] != null)
                    {
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
                        Response.Redirect("Index.aspx");











                    }
                }
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string email = tbEmail.Text.ToLower();
            string password = tbPassword.Text;
            if (SHA256Hash.GenerateSHA256(password) == UserDAO.GetLoginCredentials(email))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}