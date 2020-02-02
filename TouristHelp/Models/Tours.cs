using System;
using System.Collections.Generic;
using System.Linq;
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
        public decimal Price { get; set; }

        public Tours(int id, int tourguide, string title, string desc, string details, decimal price)
        {
            Id = id;
            TourGuide = tourguide;
            Title = title;
            Description = desc;
            Details = details;
            Price = price;
        }
    }

    public class TouristBookings
    {
        public int Id { get; set; }
        public int TouristId { get; set; }
        public string Bookings { get; set; }
        public TouristBookings(int id, int tourist, string bookings)
        {
            Id = id;
            TouristId = tourist;
            Bookings = bookings;
        }
    }
}