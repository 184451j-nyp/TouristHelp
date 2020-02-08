using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;
using System.Drawing;
using System.IO;

namespace TouristHelp
{
    public partial class AdminPageShop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPageRewardSytem.aspx");

        }

        protected void UploadFile(object sender, EventArgs e)
        {


            string folderPath = Server.MapPath("~/Images/");

            //Save the file to dictionary (Folder)
            FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName).ToString());

            //Display the Picture in Image Control

            Image1.ImageUrl = "~/Images/" + Path.GetFileName(FileUpload1.FileName).ToString();

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {

            int voucherQty;
            string voucherType;
            string voucherStatus;
            bool membershipCategory;
            bool foodCategory;
            string nameFilter;
            int voucherPrice;
            string shopImage = "Images/" + FileUpload1.FileName;
            string shopDesc;
            string voucherName;

            if (TbVoucherStock.Text != "" && TbVoucherType.Text != "" && CBVoucherCategory.SelectedIndex != -1 && TbPrice.Text != "" && TbName.Text != "")
            {

                voucherQty = Convert.ToInt32(TbVoucherStock.Text);
                voucherType = TbVoucherType.Text;
                voucherStatus = "Active";
                shopDesc = TbVoucherDesc.Text;
                voucherName = TbName.Text;
                nameFilter = "";
                voucherPrice = Convert.ToInt32(TbPrice.Text);

                if (CBVoucherCategory.Items[0].Selected && CBVoucherCategory.Items[1].Selected)
                {
                    membershipCategory = true;
                    foodCategory = true;

                    ShopVoucher shop = new ShopVoucher(voucherQty, voucherType, voucherStatus, membershipCategory, foodCategory, nameFilter, voucherPrice, shopImage, shopDesc, voucherName);
                    shop.addShopVoucher(shop);
                    Response.Redirect("AdminPageRewardSystem.aspx");

                }


                else if (CBVoucherCategory.Items[0].Selected)
                {
                    foodCategory = false;
                    membershipCategory = true;

                    ShopVoucher shop = new ShopVoucher(voucherQty, voucherType, voucherStatus, membershipCategory, foodCategory, nameFilter, voucherPrice, shopImage, shopDesc, voucherName);
                    shop.addShopVoucher(shop);
                    Response.Redirect("AdminPageRewardSystem.aspx");
                }

                else if (CBVoucherCategory.Items[1].Selected)
                {
                    foodCategory = true;
                    membershipCategory = false;

                    ShopVoucher shop = new ShopVoucher(voucherQty, voucherType, voucherStatus, membershipCategory, foodCategory, nameFilter, voucherPrice, shopImage, shopDesc, voucherName);
                    shop.addShopVoucher(shop);
                    Response.Redirect("AdminPageRewardSystem.aspx");
                }

               


           

            }


        }
    }
}