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
    public class CartDAO
    {
        public void InsertTicket(Cart cart)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Cart (productName, productPrice, productQuantity, user_id, productDesc, active) " +
                             "VALUES (@paraProductName, @paraProductPrice, @paraProductQuantity, @paraUserId, @paraProductDesc, 'active')";


            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraProductName", cart.productName);
            sqlCmd.Parameters.AddWithValue("@paraProductPrice", cart.productPrice);
            sqlCmd.Parameters.AddWithValue("@paraProductQuantity", cart.productQuantity);
            sqlCmd.Parameters.AddWithValue("@paraProductDesc", cart.productDesc);
            sqlCmd.Parameters.AddWithValue("@paraUserId", cart.userId);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();

            myConn.Close();
        }

        public List<Cart> SelectCartById(int userId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * From Cart " +
                             "where user_id = @paraUserId AND active = 'active'";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraUserId", userId);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Cart> cartList = new List<Cart>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                cartList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int productId = Convert.ToInt32(row["cartId"].ToString());
                    string productName = row["productName"].ToString();
                    double productPrice = Convert.ToDouble(row["productPrice"].ToString());
                    int productQuantity = Convert.ToInt32(row["productQuantity"].ToString());
                    string productDesc = row["productDesc"].ToString();
                    double productTotalPrice = productPrice * productQuantity;
                    Cart obj = new Cart(productId, productName, productDesc, productPrice, productQuantity, productTotalPrice);
                    cartList.Add(obj);
                }
            }
            return cartList;
        }

        public void UpdateItem(int prodId, int prodQuantity)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Cart SET productQuantity = @paraProductQuantity where active =  'active' AND user_id = @paraProdId ";

            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraProductQuantity", prodQuantity);
            sqlCmd.Parameters.AddWithValue("@paraProdId", prodId);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();

            myConn.Close();


        }

        public void ItemPay(int userId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Cart SET active = 'inactive' where active = 'active' AND user_id = @paraUserId";

            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraUserId", userId);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();

            myConn.Close();


        }

    }

}