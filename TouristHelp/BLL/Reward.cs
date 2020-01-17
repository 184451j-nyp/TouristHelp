using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouristHelp.DAL;

namespace TouristHelp.BLL
{
    public class Reward
    {

        public int Id { get; set; }
        public int loginCount { get; set; }
        public int loginStreak { get; set; }
        public string loyaltyTier { get; set; }
        public int totalDiscount { get; set; }
        public int bonusCredits { get; set; }
        public string membershipTier { get; set; }
        public int creditBalance { get; set; }
        public int remainBonusDays { get; set; }
        public Reward()
        {
        }

        public Reward(int id, int creditbalance)
        {
            this.Id = id;
            this.creditBalance = creditbalance;
        }

        public Reward(int id, int logincount, int loginstreak, string loyaltytier, int totaldiscount, int bonuscredits, string membershiptier, int creditbalance, int remainbonusdays)
        {
            this.Id = id;
            this.loginCount = logincount;
            this.loginStreak = loginstreak;
            this.loyaltyTier = loyaltytier;
            this.totalDiscount = totaldiscount;
            this.bonusCredits = bonuscredits;
            this.membershipTier = membershiptier;
            this.creditBalance = creditbalance;
            this.remainBonusDays = remainbonusdays;
        }

        public Reward GetRewardById(string userId)
        {
            RewardDAO dao = new RewardDAO();
            return dao.SelectByAccount(userId);


        }


        public void nextLogin()
        {

            RewardDAO dao = new RewardDAO();
          
            
        }

        public int UpdateAccount(Reward emp)
        {
            RewardDAO dao = new RewardDAO();
            int result = dao.UpdateCredit(emp);
            return result;
        }


    }
}