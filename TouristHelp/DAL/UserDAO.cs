using System.Collections.Generic;
using System.Data;
using TouristHelp.Models;
using System.Data.SqlClient;
using System;

namespace TouristHelp.DAL
{
    public class TourGuideDAO
    {
        private SqlHelper helper = new SqlHelper();

        public List<TourGuide> SelectAllTourGuides()
        {
            DataSet ds = helper.Query("Select TourGuides.tourguide_id, TourGuides.user_id, Users.name, Users.password, Users.email, TourGuides.rating, TourGuides.description, TourGuides.languages " +
                "From TourGuides " +
                "Inner Join Users On TourGuides.user_id = Users.user_id");

            List<TourGuide> userList = new List<TourGuide>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                int id = int.Parse(row["TourGuides.tourguide_id"].ToString());
                int user_id = int.Parse(row["TourGuides.user_id"].ToString());
                string name = row["Users.name"].ToString();
                string password = row["Users.password"].ToString();
                string email = row["Users.email"].ToString();
                double rating = double.Parse(row["TourGuides.rating"].ToString());
                string desc = row["TourGuides.description"].ToString();
                string languages = row["languages"].ToString();
                string credentials = row["credentials"].ToString();
                TourGuide obj = new TourGuide(id, user_id, name, email, password, rating, desc, languages, credentials);
                userList.Add(obj);
            }
            return userList;
        }

        public TourGuide SelectTourGuideById(int id)
        {
            DataSet ds = helper.Query("Select TourGuides.tourguide_id, TourGuides.user_id, Users.name, Users.password, Users.email, TourGuides.rating, TourGuides.description, TourGuides.languages " +
                "From TourGuides " +
                "Inner Join Users On TourGuides.user_id = Users.user_id Where TourGuides.tourguide_id = " + id.ToString());
            if (ds.Tables[0].Rows.Count == 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int user_id = int.Parse(row["TourGuides.user_id"].ToString());
                string name = row["Users.name"].ToString();
                string password = row["Users.password"].ToString();
                string email = row["Users.email"].ToString();
                double rating = double.Parse(row["TourGuides.rating"].ToString());
                string desc = row["TourGuides.description"].ToString();
                string languages = row["TourGuides.languages"].ToString();
                string credentials = row["TourGuides.credentials"].ToString();
                TourGuide obj = new TourGuide(id, user_id, name, email, password, rating, desc, languages, credentials);
                return obj;
            }
            else
            {
                return null;
            }
        }

        public TourGuide SelectTourGuideByEmail(string email)
        {
            DataSet ds = helper.Query("Select TourGuides.tourguide_id, TourGuides.user_id, Users.name, Users.password, Users.email, TourGuides.rating, TourGuides.description, TourGuides.languages " +
                "From TourGuides " +
                "Inner Join Users On TourGuides.user_id = Users.user_id Where Users.email = " + email);

            if (ds.Tables[0].Rows.Count == 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int id = int.Parse(row["TourGuides.tourguide_id"].ToString());
                int user_id = int.Parse(row["TourGuides.user_id"].ToString());
                string name = row["Users.name"].ToString();
                string password = row["Users.password"].ToString();
                double rating = double.Parse(row["TourGuides.rating"].ToString());
                string desc = row["TourGuides.description"].ToString();
                string languages = row["TourGuides.languages"].ToString();
                string credentials = row["TourGuides.credentials"].ToString();
                TourGuide obj = new TourGuide(id, user_id, name, email, password, rating, desc, languages, credentials);
                return obj;
            }
            else
            {
                return null;
            }
        }

        public void InsertTourGuide(TourGuide tg)
        {
            SqlConnection myConn = new SqlConnection(helper.DBConnect);

            string sqlStmt = "Insert into Users (password, name, email) Values (@paraPswd, @paraName, @paraEmail); " +
                "Select Cast(scope_identity() as int)";

            SqlCommand cmdUsers = new SqlCommand(sqlStmt, myConn);

            cmdUsers.Parameters.AddWithValue("@paraPswd", tg.Password);
            cmdUsers.Parameters.AddWithValue("@paraName", tg.Name);
            cmdUsers.Parameters.AddWithValue("@paraEmail", tg.Email);

            try
            {
                myConn.Open();
                int user_id = (int)cmdUsers.ExecuteScalar();
                string newStmt = "Insert into Tourists (user_id, rating, description, languages, credentials) Values (@paraUser, @paraRate, @paraDesc, @paraLang, @paraCred);";

                SqlCommand cmdTG = new SqlCommand(newStmt, myConn);

                cmdTG.Parameters.AddWithValue("@paraUser", user_id);
                cmdTG.Parameters.AddWithValue("@paraRate", tg.Rating);
                cmdTG.Parameters.AddWithValue("@paraDesc", tg.Description);
                cmdTG.Parameters.AddWithValue("@paraLang", tg.Languages);
                cmdTG.Parameters.AddWithValue("@paraCred", tg.Credentials);

                cmdTG.ExecuteNonQuery();
            }
            catch
            {

            }
        }
    }

    public class TouristDAO
    {
        private SqlHelper helper = new SqlHelper();

        public List<Tourist> SelectAllTourists()
        {
            DataSet ds = helper.Query("Select Tourists.tourist_id, Tourists.user_id, Users.name, Users.password, Users.email, Tourists.nationality" +
                "From Tourists " +
                "Inner Join Users On Tourists.user_id = Users.user_id");

            List<Tourist> userList = new List<Tourist>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                int id = int.Parse(row["Tourists.tourist_id"].ToString());
                int user_id = int.Parse(row["Tourists.user_id"].ToString());
                string name = row["name"].ToString();
                string password = row["password"].ToString();
                string email = row["email"].ToString();
                string nationality = row["nationality"].ToString();
                Tourist obj = new Tourist(id, user_id, name, email, password, nationality);
                userList.Add(obj);
            }
            return userList;
        }

        public Tourist SelectTouristById(int id)
        {
            DataSet ds = helper.Query("Select Tourists.tourist_id, Tourists.user_id, Users.name, Users.password, Users.email, Tourists.nationality" +
                "From Tourists " +
                "Inner Join Users On Tourists.user_id = Users.user_id Where Tourists.user_id = " + id);

            if (ds.Tables[0].Rows.Count == 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int user_id = int.Parse(row["Tourists.user_id"].ToString());
                string name = row["name"].ToString();
                string password = row["password"].ToString();
                string email = row["email"].ToString();
                string nationality = row["nationality"].ToString();
                Tourist obj = new Tourist(id, user_id, name, email, password, nationality);
                return obj;
            }
            else
            {
                return null;
            }
        }

        public void InsertTourist(Tourist tourist)
        {
            SqlConnection myConn = new SqlConnection(helper.DBConnect);

            string sqlStmt = "Insert into Users (password, name, email) Values (@paraPswd, @paraName, @paraEmail); " +
                "Select Cast(scope_identity() as int)";

            SqlCommand cmdUsers = new SqlCommand(sqlStmt, myConn);

            cmdUsers.Parameters.AddWithValue("@paraPswd", tourist.Password);
            cmdUsers.Parameters.AddWithValue("@paraName", tourist.Name);
            cmdUsers.Parameters.AddWithValue("@paraEmail", tourist.Email);

            try
            {
                myConn.Open();
                int user_id = (int)cmdUsers.ExecuteScalar();
                string newStmt = "Insert into Tourists (nationality, user_id) Values (@paraNation, @paraUser);";

                SqlCommand cmdTourists = new SqlCommand(newStmt, myConn);

                cmdTourists.Parameters.AddWithValue("@paraNation", tourist.Nationality);
                cmdTourists.Parameters.AddWithValue("@paraUser", user_id);

                cmdTourists.ExecuteNonQuery();
            }
            catch
            {
                
            }
        }
    }
}