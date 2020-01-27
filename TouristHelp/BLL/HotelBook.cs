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
        public bool regionFilter { get; set; }
        public int minPrice { get; set; }
        public int maxPrice { get; set; }
        public string hotelName { get; set; }

        public HotelBook()
        {
        }

        public HotelBook(int hotelid, decimal hotelprice, string hotelimage, bool regionfilter, int minprice, int maxprice, string hotelname )
        {
            this.hotelId = hotelid;
            this.hotelPrice = hotelprice;
            this.hotelImage = hotelimage;
            this.regionFilter = regionfilter;
            this.minPrice = minprice;
            this.maxPrice = maxPrice;
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




    }
}