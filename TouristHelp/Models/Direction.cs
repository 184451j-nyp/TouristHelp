using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouristHelp.Models
{
    public class Direction
    {
        public string id { get; }
        public string user { get; set; }
        public string nextDir { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public int group { get; set; }

        public Direction(string id, string user, string nextDir, string origin, string destination, int group)
        {
            this.id = id;
            this.user = user;
            this.nextDir = nextDir;
            this.origin = origin;
            this.destination = destination;
            this.group = group;
        }
    }
}