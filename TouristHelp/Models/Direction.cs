using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouristHelp.Models
{
    public class Direction
    {
        public int Id { get; }
        public string Name { get; }
        public double Latitude { get; }
        public double Longitude { get; }
        public string Type { get; }

        public Direction(int id, string name, double latitude, double longitude, string type)
        {
            Id = id;
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            Type = type;
        }
    }
}