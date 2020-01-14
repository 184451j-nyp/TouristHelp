using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouristHelp.Models
{
    public class Reward
    {
        public int user_id { get; }
        public int loginCount { get; set; }
        public int loginStreak { get; set; }
        public string loyaltyTier { get; set; }
        public int totalDiscount { get; set; }
        public int bonusCredits { get; set; }
        public string membershipTier { get; set; }
        public int creditBalance { get; set; }

        public Reward(int id, int loginCount, int loginStreak, string loyaltyTier, int totalDiscount, int bonusCredits, string membershipTier, int creditBalance)
        {
            user_id = id;
            this.loginCount = loginCount;
            this.loginStreak = loginStreak;
            this.loyaltyTier = loyaltyTier;
            this.totalDiscount = totalDiscount;
            this.bonusCredits = bonusCredits;
            this.membershipTier = membershipTier;
            this.creditBalance = creditBalance;
        }

        
    }

    //public class ShopVoucher : Reward
    //{
    //    public int shop_id { get; }
    //    public int voucher_id { get; set; }
    //    public int voucherQty { get; set; }
    //    public string voucherType { get; set; }
    //    public string voucherStatus { get; set; }
    //    public bool membershipCategory { get; set; }
    //    public bool foodCategory { get; set; }
    //    public bool categoryFilter { get; set; }
    //    public string nameFilter { get; set; }

    //    public ShopVoucher(int id, int loginCount, int loginStreak, string loyaltyTier, int totalDiscount, int bonusCredits, string membershipTier, int creditBalance)
    //    {

    //        this.voucher_id = voucher_id;
    //        this.voucherQty = voucherQty;
    //        this.voucherType = voucherType;
    //        this.voucherStatus = voucherStatus;
    //        this.membershipCategory = membershipCategory;
    //        this.foodCategory = foodCategory;
    //        this.categoryFilter = categoryFilter;
    //        this.nameFilter = nameFilter;
    //    }


    //}
}