using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouristHelp.Models
{
    public class Direction
    {
        public int Id { get; }
        public int User { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Group { get; set; }
        public int Order { get; set; }

        public Direction(int id, int user, double lat, double longi, int group, int order)
        {
            Id = id;
            User = user;
            Latitude = lat;
            Longitude = longi;
            Group = group;
            Order = order;
        }
    }
}