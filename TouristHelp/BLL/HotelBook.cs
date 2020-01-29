using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouristHelp.DAL;
using TouristHelp.BLL;

namespace TouristHelp.BLL
{
    public class HotelBook
    {
        public int hotelId { get; set; }
        public decimal hotelPrice { get; set; }
        public string hotelImage { get; set; }
        public bool centralFilter { get; set; }
        public bool northFilter { get; set; }
        public bool southFilter { get; set; }
        public bool westFilter { get; set; }
        public bool eastFilter { get; set; }
        public string hotelName { get; set; }

        public HotelBook()
        {
        }

        public HotelBook(int hotelid, decimal hotelprice, string hotelimage, bool centralfilter, bool northfilter, bool southfilter, bool westfilter, bool eastfilter, string hotelname )
        {
            this.hotelId = hotelid;
            this.hotelPrice = hotelprice;
            this.hotelImage = hotelimage;
            this.centralFilter = centralFilter;
            this.northFilter = northfilter;
            this.southFilter = southfilter;
            this.westFilter = westfilter;
            this.eastFilter = eastfilter;
            this.hotelName = hotelname;
        }

        public HotelBook getHotelById(string hotelId)
        {
            HotelBookDAO dao = new HotelBookDAO();
            return dao.selectByHotel(hotelId);


        }

        public List<HotelBook> GetAllHotel()
        {
            HotelBookDAO dao = new HotelBookDAO();
            return dao.SelectAllHotel();
        }


        public List<HotelBook> getNorthHotels()
        {
            HotelBookDAO dao = new HotelBookDAO();
            return dao.getNorthHotels();
        }

    }
}