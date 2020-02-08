using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IronPdf;

namespace TouristHelp
{
    public partial class PrintPlanner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            URLHidden.Value = Session["DirUrl"].ToString();
            MarkersHidden.Value = Session["MarkersDir"].ToString();
            AspxToPdf.RenderThisPageAsPdf(AspxToPdf.FileBehavior.Attachment, "SingaporeDirections.pdf", new PdfPrintOptions() { 
                DPI=300, 
                EnableJavaScript = true, 
                PaperOrientation=PdfPrintOptions.PdfPaperOrientation.Landscape 
                });
        }
    }
}