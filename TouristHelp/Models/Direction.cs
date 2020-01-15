using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouristHelp.Models
{
    public class Direction
    {
        public int id { get; }
        public int user { get; set; }
        public string nodeCoord { get; set; }
        public int group { get; set; }
        public int order { get; set; }

        public Direction(int id, int user, string node, int group, int order)
        {
            this.id = id;
            this.user = user;
            nodeCoord = node;
            this.group = group;
            this.order = order;
        }
    }
}