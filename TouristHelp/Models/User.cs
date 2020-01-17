using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouristHelp.Models
{
    public class User
    {
        public int? userId { get; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public User(string name, string email, string pswd)
        {
            userId = null;
            this.name = name;

        }
        public User(int id, string name, string email, string pswd)
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
        public string languages { get; set; }
        public string credentials { get; set; }

        public TourGuide(string name, string email, string pswd, double rating, string description, string languages, string credentials):base(name, email, pswd)
        {
            this.rating = rating;
            this.description = description;
            this.languages = languages;
            this.credentials = credentials;
        }
        public TourGuide(int id, string name, string email, string pswd, double rating, string description, string languages, string credentials):base(id, name, email, pswd)
        {
            this.rating = rating;
            this.description = description;
            this.languages = languages;
            this.credentials = credentials;
        }
    }

    public class Tourist : User
    {
        public string nationality { get; set; }

        public Tourist(string name, string email, string pswd, string nationality):base(name, email, pswd)
        {
            this.nationality = nationality;
        }
        public Tourist(int id, string name, string email, string pswd, string nationality):base(id, name, email, pswd)
        {
            this.nationality = nationality;
        }
    }
}