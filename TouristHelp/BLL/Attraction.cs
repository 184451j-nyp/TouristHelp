﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouristHelp.DAL;

namespace TouristHelp.BLL
{
    public class Attraction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string DateTime { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Interest { get; set; }
        public string Type { get; set; }
        public string Transaction { get; set; }

        public Attraction()
        {
        }

        public Attraction(string name, float price, string date, string desc, string location, decimal latitude, decimal longitude, string interest, string type, string transaction)// for adding
        {
            Name = name;
            Price = price;
            DateTime = date;
            Description = desc;
            Location = location;
            Latitude = latitude;
            Longitude = longitude;
            Interest = interest;
            Type = type;
            Transaction = transaction;
        }

        public Attraction(int id, string name, float price, string date, string desc, string location, decimal latitude, decimal longitude, string interest, string type, string transaction)// for displaying
        {
            Id = id;
            Name = name;
            Price = price;
            DateTime = date;
            Description = desc;
            Location = location;
            Latitude = latitude;
            Longitude = longitude;
            Interest = interest;
            Type = type;
            Transaction = transaction;
        }

        public Attraction GetAttractionDataById(string attId)
        {
            AttractionDAO dao = new AttractionDAO();
            return dao.SelectById(attId);
        }

        public List<Attraction> ListAttractionAll()// un-filter
        {
            AttractionDAO dao = new AttractionDAO();
            return dao.SelectAll();
        }

        public List<Attraction> ListAttraction(string type)// filtered
        {
            AttractionDAO dao = new AttractionDAO();
            return dao.SelectByType(type);
        }

        public void AddAttraction(Attraction att)
        {
            AttractionDAO attDao = new AttractionDAO();
            attDao.InsertNewAttraction(att);
        }
        
    }
}