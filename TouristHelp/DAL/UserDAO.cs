using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using TouristHelp.Models;

namespace TouristHelp.DAL
{
    public static class UserDAO
    {
        public static string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        public static bool UserWithEmailExists(string email)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Select * From Users Where email = @paraEmail";

            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraEmail", email);

            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }

            return false;
        }
    }

    public static class TourGuideDAO
    {
        public static string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        public static List<TourGuide> SelectAllTourGuides()
        {
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Select TourGuides.tourguide_id, TourGuides.user_id, Users.name, Users.password, Users.email, TourGuides.tours, TourGuides.description, TourGuides.languages, TourGuides.credentials " +
                "From [TourGuides] " +
                "Inner Join [Users] On TourGuides.user_id = Users.user_id";

            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<TourGuide> userList = new List<TourGuide>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                int id = int.Parse(row["tourguide_id"].ToString());
                int user_id = int.Parse(row["user_id"].ToString());
                string name = row["name"].ToString();
                string password = row["password"].ToString();
                string email = row["email"].ToString();
                string tours = row["tours"].ToString();
                string desc = row["description"].ToString();
                string languages = row["languages"].ToString();
                string credentials = row["credentials"].ToString();
                TourGuide obj = new TourGuide(id, user_id, name, email, password, tours, desc, languages, credentials);
                userList.Add(obj);
            }
            return userList;
        }

        public static TourGuide SelectTourGuideById(int id)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Select TourGuides.tourguide_id, TourGuides.user_id, Users.name, Users.password, Users.email, TourGuides.tours, TourGuides.description, TourGuides.languages " +
                "From TourGuides " +
                "Inner Join Users On TourGuides.user_id = Users.user_id Where TourGuides.tourguide_id = @paraId";

            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", id.ToString());

            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int user_id = int.Parse(row["user_id"].ToString());
                string name = row["name"].ToString();
                string password = row["password"].ToString();
                string email = row["email"].ToString();
                string tours = row["tours"].ToString();
                string desc = row["description"].ToString();
                string languages = row["languages"].ToString();
                string credentials = row["credentials"].ToString();
                TourGuide obj = new TourGuide(id, user_id, name, email, password, tours, desc, languages, credentials);
                return obj;
            }
            else
            {
                return null;
            }
        }

        public static TourGuide SelectTourGuideByEmail(string email)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);
            string sqlStmt = "Select TourGuides.tourguide_id, TourGuides.user_id, Users.name, Users.password, Users.email, TourGuides.tours, TourGuides.description, TourGuides.languages " +
                "From TourGuides " +
                "Inner Join Users On TourGuides.user_id = Users.user_id Where Users.email = @paraEmail";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraEmail", email);

            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int id = int.Parse(row["tourguide_id"].ToString());
                int user_id = int.Parse(row["user_id"].ToString());
                string name = row["name"].ToString();
                string password = row["password"].ToString();
                string tours = row["tours"].ToString();
                string desc = row["description"].ToString();
                string languages = row["languages"].ToString();
                string credentials = row["credentials"].ToString();
                TourGuide obj = new TourGuide(id, user_id, name, email, password, tours, desc, languages, credentials);
                return obj;
            }
            else
            {
                return null;
            }
        }

        public static void InsertTourGuide(TourGuide tg)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);

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
                string newStmt = "Insert into TourGuides (user_id, tours, description, languages, credentials) Values (@paraUser, @paraTours, @paraDesc, @paraLang, @paraCred);";

                SqlCommand cmdTG = new SqlCommand(newStmt, myConn);

                cmdTG.Parameters.AddWithValue("@paraUser", user_id);
                cmdTG.Parameters.AddWithValue("@paraTours", tg.Tours);
                cmdTG.Parameters.AddWithValue("@paraDesc", tg.Description);
                cmdTG.Parameters.AddWithValue("@paraLang", tg.Languages);
                cmdTG.Parameters.AddWithValue("@paraCred", tg.Credentials);

                cmdTG.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void UpdateTourGuide(TourGuide tg)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Update TourGuides Set tours = @paraTours, description = @paraDesc, languages = @paraLang, credentials = @paraCred Where tourguide_id = @paraTG; " +
                "Update Users Set name = @paraName, password = @paraPswd, email = @paraEmail Where user_id = @paraUser;";

            SqlCommand cmd = new SqlCommand(sqlStmt, myConn);
            cmd.Parameters.AddWithValue("@paraTours", tg.Tours);
            cmd.Parameters.AddWithValue("@paraDesc", tg.Description);
            cmd.Parameters.AddWithValue("@paraLang", tg.Languages);
            cmd.Parameters.AddWithValue("@paraCred", tg.Credentials);
            cmd.Parameters.AddWithValue("@paraTG", tg.TourGuideId);
            cmd.Parameters.AddWithValue("@paraName", tg.Name);
            cmd.Parameters.AddWithValue("@paraPswd", tg.Password);
            cmd.Parameters.AddWithValue("@paraEmail", tg.Email);
            cmd.Parameters.AddWithValue("@paraUser", tg.UserId);
            try
            {
                myConn.Open();
                cmd.ExecuteNonQuery();
                myConn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }

    public static class TouristDAO
    {
        public static string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        public static List<Tourist> SelectAllTourists()
        {
            SqlConnection myConn = new SqlConnection(DBConnect);
            string sqlStmt = "SELECT Tourists.tourist_id, Tourists.user_id, Users.name, Users.password, Users.email, Tourists.nationality " +
                "FROM Tourists " +
                "INNER JOIN Users ON Tourists.user_id = Users.user_id";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Tourist> userList = new List<Tourist>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                int id = int.Parse(row["tourist_id"].ToString());
                int user_id = int.Parse(row["user_id"].ToString());
                string name = row["name"].ToString();
                string password = row["password"].ToString();
                string email = row["email"].ToString();
                string nationality = row["nationality"].ToString();
                Console.WriteLine(name);
                Console.WriteLine(password);
                Tourist obj = new Tourist(id, user_id, name, email, password, nationality);
                userList.Add(obj);
            }
            return userList;
        }

        public static Tourist SelectTouristById(int id)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);
            string sqlStmt = "Select Tourists.tourist_id, Tourists.user_id, Users.name, Users.password, Users.email, Tourists.nationality " +
                "From Tourists " +
                "Inner Join Users On Tourists.user_id = Users.user_id Where Tourists.tourist_id = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", id.ToString());

            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int user_id = int.Parse(row["user_id"].ToString());
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

        public static Tourist SelectTouristByEmail(string email)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);
            string sqlStmt = "Select Tourists.tourist_id, Tourists.user_id, Users.name, Users.password, Users.email, Tourists.nationality " +
                "From Tourists " +
                "Inner Join Users On Tourists.user_id = Users.user_id Where Users.email = @paraEmail";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraEmail", email);

            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int id = int.Parse(row["tourist_id"].ToString());
                int user_id = int.Parse(row["user_id"].ToString());
                string name = row["name"].ToString();
                string password = row["password"].ToString();
                string nationality = row["nationality"].ToString();
                Tourist obj = new Tourist(id, user_id, name, email, password, nationality);
                return obj;
            }
            else
            {
                return null;
            }
        }

        public static void InsertTourist(Tourist tourist)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);

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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void UpdateTourist(Tourist t)
        {
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Update Tourists Set nationality = @paraNation Where tourist_id = @paraT; " +
                "Update Users Set name = @paraName, password = @paraPswd, email = @paraEmail Where user_id = @paraUser;";

            SqlCommand cmd = new SqlCommand(sqlStmt, myConn);
            cmd.Parameters.AddWithValue("@paraNation", t.Nationality);
            cmd.Parameters.AddWithValue("@paraT", t.TouristId);
            cmd.Parameters.AddWithValue("@paraName", t.Name);
            cmd.Parameters.AddWithValue("@paraPswd", t.Password);
            cmd.Parameters.AddWithValue("@paraEmail", t.Email);
            cmd.Parameters.AddWithValue("@paraUser", t.UserId);
            try
            {
                myConn.Open();
                cmd.ExecuteNonQuery();
                myConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
    }
}