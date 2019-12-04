using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouristHelp.Models
{
    public class User
    {
        public string userId { get; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public User(string id, string name, string email, string pswd)
        {
            userId = id;
            this.name = name;
            this.email = email;
            password = pswd;
        }
    }

    public class TourGuide : User
    {
        public double rating { get; set; }
        public string description { get; set; }
        public List<string> languages { get; set; }

        public TourGuide(string id, string name, string email, string pswd, double rating, string description, List<string> languages):base(id, name, email, pswd)
        {
            this.rating = rating;
            this.description = description;
            this.languages = languages;
        }
    }

    public class Tourist : User
    {
        public string nationality { get; set; }

        public Tourist(string id, string name, string email, string pswd, string nationality):base(id, name, email, pswd)
        {
            this.nationality = nationality;
        }
    }
}