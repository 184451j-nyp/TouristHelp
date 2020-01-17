using System.Collections.Generic;
using System.Data;
using TouristHelp.Models;
using System.Data.SqlClient;

namespace TouristHelp.DAL
{
    public class TourGuideDAO
    {
        private SqlHelper helper = new SqlHelper();

        public List<TourGuide> SelectAllTourGuides()
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
                string credentials = row["credentials"].ToString();
                TourGuide obj = new TourGuide(id, name, email, password, rating, desc, languages, credentials);
                userList.Add(obj);
            }
            return userList;
        }

        public TourGuide SelectTourGuideById(int user_id)
        {
            DataSet ds = helper.Query("Select * From TourGuides Where tourguide_id = " + user_id.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int id = int.Parse(row["tourguide_id"].ToString());
                string name = row["name"].ToString();
                string password = row["password"].ToString();
                string email = row["email"].ToString();
                double rating = double.Parse(row["rating"].ToString());
                string desc = row["desc"].ToString();
                string languages = row["languages"].ToString();
                string credentials = row["credentials"].ToString();
                TourGuide obj = new TourGuide(id, name, email, password, rating, desc, languages, credentials);
                return obj;
            }
            else
            {
                return null;
            }
        }
    }

    public class TouristDAO
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

        public Tourist SelectTouristById(int user_id)
        {
            DataSet ds = helper.Query("Select * From Tourists Where tourist_id = " + user_id.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int id = int.Parse(row["tourist_id"].ToString());
                string name = row["name"].ToString();
                string password = row["password"].ToString();
                string email = row["email"].ToString();
                string nationality = row["nationality"].ToString();
                Tourist obj = new Tourist(id, name, email, password, nationality);
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

            cmdUsers.Parameters.AddWithValue("@paraPswd", tourist.password);
            cmdUsers.Parameters.AddWithValue("@paraName", tourist.name);
            cmdUsers.Parameters.AddWithValue("@paraEmail", tourist.email);

            try
            {
                myConn.Open();
                int user_id = (int)cmdUsers.ExecuteScalar();
                string newStmt = "Insert into Tourists (nationality, user_id) Values (@paraNation, @paraUser);";

                SqlCommand cmdTourists = new SqlCommand(newStmt, myConn);

                cmdTourists.Parameters.AddWithValue("@paraNation", tourist.nationality);
                cmdTourists.Parameters.AddWithValue("@paraUser", user_id);

                cmdTourists.ExecuteNonQuery();
            }
            catch
            {

            }
        }
    }
}