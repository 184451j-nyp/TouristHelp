using System;
using TouristHelp.Models;
using TouristHelp.BLL;
using TouristHelp.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace TouristHelp
{
    public partial class TourGuideUpdateDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TourGuide tg = TourGuideDAO.SelectTourGuideById(int.Parse(Session["tourguide_id"].ToString()));
                tourguidenameTextBox.Text = tg.Name;
                tourguidedescriptionTextBox.Text = tg.Description;
                tourguidelanguagesTextBox.Text = tg.Languages;
                tourguidecredentialsTextBox.Text = tg.Credentials;
                tourguideemailLabel.Text = tg.Email;
                tourguideidLabel.Text = tg.TourGuideId.ToString();
                tourguideuseridLabel.Text = tg.UserId.ToString();
                tourguidepasswordLabel.Text = tg.Password.ToString();


            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            TourGuide tg = new TourGuide(int.Parse(tourguideidLabel.Text), int.Parse(tourguideuseridLabel.Text), tourguidenameTextBox.Text, tourguideemailLabel.Text, tourguidepasswordLabel.Text, tourguidedescriptionTextBox.Text, tourguidelanguagesTextBox.Text, tourguidecredentialsTextBox.Text);
            TourGuide.UpdateTourGuide(tg);


        }

        protected void UploadFile(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Files/");

            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }

            //Save the File to the Directory (Folder).
            FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));

            //Display the Picture in Image control.
            Image1.ImageUrl = "~/Files/" + Path.GetFileName(FileUpload1.FileName);
        }

    }
}