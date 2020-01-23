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
        //public void AddItem(Cart cart)
        //{
        //    string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        //    SqlConnection myConn = new SqlConnection(DBConnect);

        //    string sqlStmt = "INSERT INTO Interest (productName, productPrice, productQuantity, user_id, productDesc) " +
        //                     "VALUES (@paraProductName, @paraProductPrice, @paraProductQuantity, @paraProductDesc)";


        //    SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

        //    sqlCmd.Parameters.AddWithValue("@paraProductName", cart.productName);
        //    sqlCmd.Parameters.AddWithValue("@paraProductPrice", cart.productPrice);
        //    sqlCmd.Parameters.AddWithValue("@paraProductQuantity", cart.productPrice);
        //    sqlCmd.Parameters.AddWithValue("@paraProductDesc", cart.productPrice);

        //    myConn.Open();
        //    sqlCmd.ExecuteNonQuery();

        //    myConn.Close();
        //}

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
                    string productName = row["productName"].ToString();
                    double productPrice = Convert.ToDouble(row["productPrice"].ToString());
                    int productQuantity = Convert.ToInt32(row["productQuantity"].ToString());
                    string productDesc = row["productDesc"].ToString();
                    double productTotalPrice = productPrice * productQuantity;
                    Cart obj = new Cart(productName, productDesc, productPrice, productQuantity, productTotalPrice);
                    cartList.Add(obj);
                }
            }
            return cartList;
        }

        public void UpdateItem(int prodQuantity)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Cart SET productQuantity = @paraProductQuantity where active =  active";

            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraRenewMode", prodQuantity);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();

            myConn.Close();


        }

    }

}