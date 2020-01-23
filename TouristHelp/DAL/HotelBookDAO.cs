using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TouristHelp.BLL;

namespace TouristHelp.DAL
{
    public class HotelBookDAO
    {


        public HotelBook selectByHotel(string shopId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from HotelBook where hotelId = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", shopId);

            DataSet ds = new DataSet();
            da.Fill(ds);
            int rec_cnt = ds.Tables[0].Rows.Count;

            HotelBook td = null;
            if (rec_cnt > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
              

                int hotelId = Convert.ToInt32(row["hotelId"]);
                decimal hotelPrice = Convert.ToDecimal(row["hotelPrice"]);
                string hotelImage = row["hotelImage"].ToString();
                bool regionFilter = Convert.ToBoolean(row["regionFilter"]);
                int minPriceFilter = Convert.ToInt32(row["minPriceFilter"]);
                int maxPriceFilter = Convert.ToInt32(row["maxPriceFilter"]);
                string hotelName = row["hotelName"].ToString();



                td = new HotelBook(hotelId, hotelPrice, hotelImage, regionFilter, minPriceFilter, maxPriceFilter, hotelName);
            }
            return td;
        }



        public List<HotelBook> SelectAllHotel()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from HotelBook";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<HotelBook> empList = new List<HotelBook>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                int hotelId = Convert.ToInt32(row["hotelId"]);
                decimal hotelPrice = Convert.ToDecimal(row["hotelPrice"]);
                string hotelImage = row["hotelImage"].ToString();
                bool regionFilter = Convert.ToBoolean(row["regionFilter"]);
                int minPriceFilter = Convert.ToInt32(row["minPriceFilter"]);
                int maxPriceFilter = Convert.ToInt32(row["maxPriceFilter"]);
                string hotelName = row["hotelName"].ToString();


                HotelBook obj = new HotelBook(hotelId, hotelPrice, hotelImage, regionFilter, minPriceFilter, maxPriceFilter, hotelName);
                empList.Add(obj);
            }

            return empList;
        }
    }
}