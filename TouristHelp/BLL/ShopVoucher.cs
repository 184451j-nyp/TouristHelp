using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouristHelp.DAL;
using TouristHelp.BLL;

namespace TouristHelp.BLL
{
    public class ShopVoucher
    {
        public int shop_Id { get; set; }
        public int voucher_Qty { get; set; }
        public string voucher_Type { get; set; }
        public string voucher_Status { get; set; }
        public bool membershipCategory { get; set; }
        public bool foodCategory { get; set; }
        public string nameFilter { get; set; }
        public int voucherCost { get; set; }
        public string shopImage { get; set; }
        public string shopDesc { get; set; }
        public string voucherName { get; set; }


        public ShopVoucher()
        {
        }

        public ShopVoucher(int shop_id,int voucherqty, string vouchertype, string voucherstatus, bool membershipcategory, bool foodcategory, string namefilter, int voucherCost, string shopimage, string shopdesc, string vouchername)
        {
            this.shop_Id = shop_id;
            this.voucher_Qty = voucherqty;
            this.voucher_Type = vouchertype;
            this.voucher_Status = voucherstatus;
            this.membershipCategory = membershipcategory;
            this.foodCategory = foodcategory;
            this.nameFilter = namefilter;
            this.voucherCost = voucherCost;
            this.shopImage = shopimage;
            this.shopDesc = shopdesc;
            this.voucherName = vouchername;
        }

        public ShopVoucher GetShopById(string shopId)
        {
            ShopVoucherDAO dao = new ShopVoucherDAO();
            return dao.SelectByShop(shopId);


        }

       
        public List<ShopVoucher> GetAllShop()
        {
            ShopVoucherDAO dao = new ShopVoucherDAO();
            return dao.SelectAll();
        }






    }
}