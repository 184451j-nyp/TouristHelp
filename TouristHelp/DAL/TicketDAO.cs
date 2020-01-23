using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TouristHelp.BLL;

namespace TouristHelp.DAL
{
    public class TicketDAO
    {
        public void AddTicket(Ticket tk)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Ticket (attractionName, attractionDesc, price, " +
                                    "dateExpire, ticketCode, paid, user_id)" +
                             "VALUES (@paraAttName,@paraAttDesc,@paraPrice,@paraDateExpire," +
                                    "@paraTicketCode,@paraPaid,@paraUserId)";

            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraAttName", tk.attractionName);
            sqlCmd.Parameters.AddWithValue("@paraAttDesc", tk.attractionDesc);
            sqlCmd.Parameters.AddWithValue("@paraPrice", tk.price);
            sqlCmd.Parameters.AddWithValue("@paraDateExpire", tk.dateExpire);
            sqlCmd.Parameters.AddWithValue("@paraTicketCode", tk.ticketCode);
            sqlCmd.Parameters.AddWithValue("@paraPaid", tk.paid);
            sqlCmd.Parameters.AddWithValue("@paraUserId", tk.userId);


            myConn.Open();
            sqlCmd.ExecuteNonQuery();

            myConn.Close();

        }
    }
}