using System;
using System.Collections.Generic;
using System.Linq;
using TouristHelp.DAL;

using System.Web;

namespace TouristHelp.Models
{
    public class Tours
    {
        public int Id { get; set; }
        public int TourGuide { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string Price { get; set; }

        public Tours(int id, int tourguide, string title, string desc, string details, string price)
        {
            Id = id;
            TourGuide = tourguide;
            Title = title;
            Description = desc;
            Details = details;
            Price = price;
        }
     


    }

    public class TouristBooking
    {
        public int TouristId { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public string TourTitle { get; set; }
        public string Timing { get; set; }
        public string Status { get; set; }

        public TouristBooking(int touristid, string name, int id, string title, string timing, string status)
        {
            TouristId = touristid;
            Name = name;
            Id = id;
            TourTitle = title;
            Timing = timing;
            Status = status;
        }

        public static List<TouristBooking> GetAllToursOfTourist(int userId)
        {
            return TouristBookingDAO.SelectTourByTouristId(userId);
        }

        public static List<TouristBooking> GetAllTourBookingsOfTourGuide(int userId)
        {
            return TouristBookingDAO.SelectTourByTourGuideId(userId);
        }

    }
}