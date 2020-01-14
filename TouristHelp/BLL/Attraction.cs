using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouristHelp.DAL;

namespace TouristHelp.BLL
{
    public class Attraction
    {
        public string Name { get; set; }

        public Attraction()
        {
        }

        public Attraction(string name)
        {
            Name = name;
        }

        public Attraction GetAttractionDataById(string attId)
        {
            AttractionDAO dao = new AttractionDAO();
            return dao.SelectByAccount(attId);
        }
    }
}