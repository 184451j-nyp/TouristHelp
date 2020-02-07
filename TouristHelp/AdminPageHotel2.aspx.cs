using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;


namespace TouristHelp
{
    public partial class AdminPageHotel2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(regionSelect.SelectedItem.Value);


        }


        protected void BtnAdd_Click(object sender, EventArgs e)
        {

         decimal hotelPrice = Convert.ToDecimal(TbPrice.Text);
         string hotelImage = Convert.ToString(FileUpload1);
            bool centralFilter = false;
            bool northFilter = false;
            bool southFilter = false;
            bool westFilter = false;
            bool eastFilter = false;
            string hotelName = TbName.Text;

            if (regionSelect.SelectedItem.Value == "Central")
            {
                centralFilter = true;
                northFilter = false;
                southFilter = false;
                westFilter = false;
                eastFilter = false;
            }
            else if (regionSelect.SelectedItem.Value == "North")
            {
                northFilter = true;
                centralFilter = false;
                southFilter = false;
                westFilter = false;
                eastFilter = false;
            }
            else if (regionSelect.SelectedItem.Value == "South")
            {
                southFilter = true;
                northFilter = false;
                centralFilter = false;
                westFilter = false;
                eastFilter = false;
            }
            else if (regionSelect.SelectedItem.Value == "West")
            {
                westFilter = true;
                southFilter = false;
                northFilter = false;
                centralFilter = false;
                eastFilter = false;

            }
            else if (regionSelect.SelectedItem.Value == "East")
            {
                eastFilter = true;
                westFilter = false;
                southFilter = false;
                northFilter = false;
                centralFilter = false;
            }

            HotelBook addHotel = new HotelBook(hotelPrice, hotelImage, centralFilter, northFilter, southFilter, westFilter,eastFilter, hotelName);
            addHotel.addHotel(addHotel);
            Response.Redirect("AdminPageAddHotel.aspx");
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPageHotel.aspx");
        }

        protected void UploadFile(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Images/");

            //Save the file to dictionary (Folder)
            FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));

            //Display the Picture in Image Control

            Image1.ImageUrl = "~/Images/" + Path.GetFileName(FileUpload1.FileName);

        }
    }
}