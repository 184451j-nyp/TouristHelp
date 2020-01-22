using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouristHelp.DAL;

namespace TouristHelp.BLL
{
    public class TourGuide
    {
        public string Name { get; set; }

        public TourGuide()
        {
        }

        public TourGuide(string name)
        {
            Name = name;
        }

        
    }
}