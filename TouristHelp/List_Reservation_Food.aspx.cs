using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;

namespace TouristHelp
{
    public partial class List_Reservation_Food : System.Web.UI.Page
    {
        List<Food_Reservation> resList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loadRepeater();
            }
        }

        private void loadRepeater()
        {
            Food_Reservation actt = new Food_Reservation();
            resList = actt.GetReservationById(1);
            
            RepeaterReserves.DataSource = resList;
            RepeaterReserves.DataBind();
        }
    }
}