using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TouristHelp.Models;

namespace TouristHelp.DAL
{
    public class UserDAO
    {
        private SqlHelper helper = new SqlHelper();

        public List<Tourist> SelectAllTourists()
        {
            DataSet ds = helper.Query("Select Tourists.tourist_id, Users.name, Users.password, Users.email, Tourists.nationality" +
                "From Tourists " +
                "Inner Join Users On Tourists.user_id = Users.user_id");
            
            List<Tourist> userList = new List<Tourist>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                int id = int.Parse(row["tourist_id"].ToString());
                string name = row["name"].ToString();
                string password = row["password"].ToString();
                string email = row["email"].ToString();
                string nationality = row["nationality"].ToString();
                Tourist obj = new Tourist(id, name, email, password, nationality);
                userList.Add(obj);
            }
            return userList;
        }

        public Tourist SelectTourist(int user_id)
        {
            DataSet ds = helper.Query("Selec")
        }

        private List<TourGuide> SelectAllTourGuides()
        {
            DataSet ds = helper.Query("Select TourGuides.tourguide_id, Users.name, Users.password, Users.email, TourGuides.rating, TourGuides.desc, TourGuides.languages " +
                "From TourGuides " +
                "Inner Join Users On TourGuides.user_id = Users.user_id");

            List<TourGuide> userList = new List<TourGuide>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                int id = int.Parse(row["tourguide_id"].ToString());
                string name = row["name"].ToString();
                string password = row["password"].ToString();
                string email = row["email"].ToString();
                double rating = double.Parse(row["rating"].ToString());
                string desc = row["desc"].ToString();
                string languages = row["languages"].ToString();
                TourGuide obj = new TourGuide(id, name, email, password, rating, desc, languages);
                userList.Add(obj);
            }
            return userList;
        }
    }
}