using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouristHelp.BLL;

namespace TouristHelp
{
    public partial class TicketList : System.Web.UI.Page
    {
        List<Ticket> tixList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int user_id = Convert.ToInt32(Session["tourist_id"]);
                Ticket ticket = new Ticket();
                tixList = ticket.GetAllTicket(user_id);

                Repeater1.DataSource = tixList;
                Repeater1.DataBind();
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}