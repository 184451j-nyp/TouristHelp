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
    public class HotelTransDAO
    {
        public void AddHotel(HotelTrans hotel)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO ReservationHotel (hotelGen_Id, totalcost, roomQty, " +
                                    "stayDuration, user_id, hotelName, verifyHotel, hotelPaid, cartId) " +
                             "VALUES (@paraHotelGenId ,@paraTotalcost,@paraRoomQty, @paraStayDuration," +
                                    "@parauser_id, @paraHotelName, @paraVerifyHotel, @paraHotelPaid, @paracartid)";

            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraHotelGenId", hotel.hotelGen_Id);
            sqlCmd.Parameters.AddWithValue("@paraTotalcost", hotel.totalCost);
            sqlCmd.Parameters.AddWithValue("@paraRoomQty", hotel.roomQty);
            sqlCmd.Parameters.AddWithValue("@paraStayDuration", hotel.stayDuration);
            sqlCmd.Parameters.AddWithValue("@parauser_id", hotel.user_id);
            sqlCmd.Parameters.AddWithValue("@paraHotelName", hotel.hotelName);
            sqlCmd.Parameters.AddWithValue("@paraVerifyHotel", hotel.verifyHotel);
            sqlCmd.Parameters.AddWithValue("@paraHotelPaid", hotel.hotelPaid);
            sqlCmd.Parameters.AddWithValue("@paracartid", hotel.cartId);


            myConn.Open();
            sqlCmd.ExecuteNonQuery();

            myConn.Close();

        }





        public List<HotelTrans> showHotelPaid(int getUserId)
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from ReservationHotel " +
                              "WHERE user_id =  @paraUserId " +
                               "AND hotelPaid = 'Paid' OR hotelPaid = 'Verified' ";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraUserId", getUserId);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<HotelTrans> intList = new List<HotelTrans>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                intList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int hotelGen_Id = Convert.ToInt32(row["hotelGen_Id"]);
                    int totalCost = Convert.ToInt32(row["totalCost"]);
                    int roomQty = Convert.ToInt32(row["roomQty"]);
                    DateTime stayDuration = Convert.ToDateTime(row["stayDuration"]);
                    string hotelName = row["hotelName"].ToString();
                    int verifyHotel = Convert.ToInt32(row["verifyHotel"]);
                    string hotelPaid = row["hotelPaid"].ToString();
                    int cartId = Convert.ToInt32(row["cartId"]);

                    HotelTrans objRate = new HotelTrans(hotelGen_Id, totalCost, roomQty, stayDuration, getUserId, hotelName, verifyHotel, hotelPaid, cartId);
                    intList.Add(objRate);
                }
            }
            return intList;

        }




        public void updateHotelBook(int cartId, int userId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE ReservationHotel SET hotelPaid = 'Paid' where user_id = @paraUserId AND cartId = @paraCartId ";

            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@parauserId", userId);
            sqlCmd.Parameters.AddWithValue("@paraCartId", cartId);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();

            myConn.Close();


        }



        //public void hotelVerified(string code)
        //{
        //    string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        //    SqlConnection myConn = new SqlConnection(DBConnect);

        //    string sqlStmt = "UPDATE Ticket SET paid = 'claimed' where ticketCode = @paraTicketCode ";

        //    SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


        //    sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

        //    sqlCmd.Parameters.AddWithValue("@paraTicketCode", code);

        //    myConn.Open();
        //    sqlCmd.ExecuteNonQuery();

        //    myConn.Close();


        //}
    }
}