using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouristHelp.DAL;

namespace TouristHelp.BLL
{
    public class Food_Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Pax { get; set; }
        public string Status { get; set; }
        public string QR { get; set; }

        public Food_Reservation()
        {
        }

        public Food_Reservation(string name, string date, string time, int pax, string qr) // creating reservation
        {
            Name = name;
            Date = date;
            Time = time;
            Pax = pax;
            QR = qr;
        }


        public Food_Reservation(int id, string name, string date, string time, int pax, string status, string qr) // displaying/updating reservation
        {
            Id = id;
            Name = name;
            Date = date;
            Time = time;
            Pax = pax;
            Status = status;
            QR = qr;
        }

        public void InsertReservation(string name, string date, string time, int pax, int id, string qr)
        {
            Food_ReservationDAO dao = new Food_ReservationDAO();
            dao.InsertReservation(name, date, time, pax, id, qr);
        }

        public List<Food_Reservation> GetReservationById(int userId)
        {
            Food_ReservationDAO dao = new Food_ReservationDAO();
            return dao.SelectById(userId);
        }

        public Food_Reservation GetReservationByIdSingle(int userId)
        {
            Food_ReservationDAO dao = new Food_ReservationDAO();
            return dao.SelectByIdSingle(userId);
        }

        public void CancelReservation(int resId)
        {
            Food_ReservationDAO dao = new Food_ReservationDAO();
            dao.ReservationStatusDisable(resId);
        }

        public List<string> GetQRCodesList()
        {
            Food_ReservationDAO dao = new Food_ReservationDAO();
            return dao.GetAllCode();
        }
    }
}