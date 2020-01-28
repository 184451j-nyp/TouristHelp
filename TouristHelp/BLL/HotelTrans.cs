using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouristHelp.DAL;

namespace TouristHelp.BLL
{
    public class HotelTrans
    {
        public int hotelGen_Id { get; set; }

        public decimal totalCost { get; set; }

        public int roomQty { get; set; }

        public int stayDuration { get; set; }

        public int user_id { get; set; }

        public string hotelName { get; set; }

        public int verifyHotel { get; set; }

        public bool hotelPaid { get; set; }

        public HotelTrans()
        {

        }

        public HotelTrans(int hotelgen_id, decimal totalcost, int roomqty, int stayduration, int userid, string hotelname, int verifyhotel, bool hotelpaid)
        {
            this.hotelGen_Id = hotelgen_id;
            this.totalCost = totalcost;
            this.roomQty = roomqty;
            this.stayDuration = stayduration;
            this.user_id = userid;
            this.hotelName = hotelname;
            this.verifyHotel = verifyhotel;
            this.hotelPaid = hotelpaid;
        }

        public void AddNewHotel()
        {
            HotelTransDAO hotel = new HotelTransDAO();
            hotel.AddHotel(this);
        }
    }
}