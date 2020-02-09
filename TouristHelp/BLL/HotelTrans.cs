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

        public DateTime stayDuration { get; set; }

        public int user_id { get; set; }

        public string hotelName { get; set; }

        public int verifyHotel { get; set; }

        public bool hotelPaid { get; set; }

        public int cartId { get; set; }

        public HotelTrans()
        {

        }

        public HotelTrans(int hotelgen_id, decimal totalcost, int roomqty, DateTime stayduration, int userid, string hotelname, int verifyhotel, bool hotelpaid, int cartid)
        {
            this.hotelGen_Id = hotelgen_id;
            this.totalCost = totalcost;
            this.roomQty = roomqty;
            this.stayDuration = stayduration;
            this.user_id = userid;
            this.hotelName = hotelname;
            this.verifyHotel = verifyhotel;
            this.hotelPaid = hotelpaid;
            this.cartId = cartid;
        }

        public void AddNewHotel()
        {
            HotelTransDAO hotel = new HotelTransDAO();
            hotel.AddHotel(this);
        }





        public List<HotelTrans> showPaidHotel(int user_id)
        {
            HotelTransDAO dao = new HotelTransDAO();
            return dao.showHotelPaid(user_id);
        }




        public void hotelPay(int cartId, int userId)
        {
            HotelTransDAO dao = new HotelTransDAO();
            dao.updateHotelBook(cartId, userId);
        }
    }
}