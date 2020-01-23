﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouristHelp.DAL;

namespace TouristHelp.BLL
{
    public class Food_Reservation
    {
        public string Name { get; set; }
        public string Time { get; set; }
        public int Pax { get; set; }

        public Food_Reservation()
        {
        }

        public Food_Reservation(string name, string time, int pax)
        {
            Name = name;
            Time = time;
            Pax = pax;
        }

        public void InsertReservation(string name, string time, int pax, int id)
        {
            Food_ReservationDAO dao = new Food_ReservationDAO();
            dao.InsertReservation(name, time, pax, id);
        }

        public List<Food_Reservation> GetReservationById(int userId)
        {
            Food_ReservationDAO dao = new Food_ReservationDAO();
            return dao.SelectById(userId);
        }
    }
}