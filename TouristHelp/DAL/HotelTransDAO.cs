using System;
using System.Collections.Generic;
using System.Configuration;
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
                                    "stayDuration, user_id, hotelName, verifyHotel, hotelPaid) " +
                             "VALUES (@paraHotelGenId ,@paraTotalcost,@paraRoomQty, @paraStayDuration," +
                                    "@parauser_id, @paraHotelName, @paraVerifyHotel, @paraHotelPaid)";
             
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraHotelGenId", hotel.hotelGen_Id);
            sqlCmd.Parameters.AddWithValue("@paraTotalcost", hotel.totalCost);
            sqlCmd.Parameters.AddWithValue("@paraRoomQty", hotel.roomQty);
            sqlCmd.Parameters.AddWithValue("@paraStayDuration", hotel.stayDuration);
            sqlCmd.Parameters.AddWithValue("@parauser_id", hotel.user_id);
            sqlCmd.Parameters.AddWithValue("@paraHotelName", hotel.hotelName);
            sqlCmd.Parameters.AddWithValue("@paraVerifyHotel", hotel.verifyHotel);
            sqlCmd.Parameters.AddWithValue("@paraHotelPaid", hotel.hotelPaid);


            myConn.Open();
            sqlCmd.ExecuteNonQuery();

            myConn.Close();

        }

    }
}