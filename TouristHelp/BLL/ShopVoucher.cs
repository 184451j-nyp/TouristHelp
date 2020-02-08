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
        public int voucher_id { get; set; }
        public int voucherQty { get; set; }
        public string voucherType { get; set; }
        public string voucherStatus { get; set; }
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

        public ShopVoucher(int shop_id,int voucherqty, string vouchertype, string voucherstatus, bool membershipcategory, bool foodcategory, string namefilter, int vouchercost, string shopimage, string shopdesc, string vouchername)
        {
            this.voucher_id = shop_id;
            this.voucherQty = voucherqty;
            this.voucherType = vouchertype;
            this.voucherStatus = voucherstatus;
            this.membershipCategory = membershipcategory;
            this.foodCategory = foodcategory;
            this.nameFilter = namefilter;
            this.voucherCost = vouchercost;
            this.shopImage = shopimage;
            this.shopDesc = shopdesc;
            this.voucherName = vouchername;
        }


        public ShopVoucher(int voucherqty, string vouchertype, string voucherstatus, bool membershipcategory, bool foodcategory, string namefilter, int vouchercost, string shopimage, string shopdesc, string vouchername)
        {
            this.voucherQty = voucherqty;
            this.voucherType = vouchertype;
            this.voucherStatus = voucherstatus;
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


        public void addShopVoucher(ShopVoucher shopVoucher)
        {
            ShopVoucherDAO shop = new ShopVoucherDAO();
            shop.addNewShopVoucher(shopVoucher);
        }



    }
}