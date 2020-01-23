using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouristHelp.DAL;

namespace TouristHelp.BLL
{
    public class Ticket
    {
        public string attractionName { get; set; }
        public string attractionDesc { get; set; }
        public double price { get; set; }
        public DateTime dateExpire { get; set; }
        public string ticketCode { get; set; }
        public string paid { get; set; }
        public int userId { get; set; }

        public Ticket()
        {

        }

        public Ticket(string attName, string attDesc, double attPrice, DateTime expDate, string attCode, string statPaid, int user_id)
        {
            attractionName = attName;
            attractionDesc = attDesc;
            price = attPrice;
            dateExpire = expDate;
            ticketCode = attCode;
            paid = statPaid;
            userId = user_id;
        }

        public void AddNewTicket()
        {
            TicketDAO tkt = new TicketDAO();
            tkt.AddTicket(this);
        }
    }
}