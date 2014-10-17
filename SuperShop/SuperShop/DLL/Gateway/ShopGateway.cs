using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShop.DLL.DAO;

namespace SuperShop.DLL.Gateway
{
    class ShopGateway
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string query;

        private static void CallForConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["SuperShop"].ConnectionString;
           
            connection = new SqlConnection(conn);
            connection.ConnectionString = conn;

        }
        public List<Shop> GetShopList()
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM table_Shop");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Shop> shopList=new List<Shop>();
           
            if(aReader.HasRows)
                while (aReader.Read())
                {
                    Shop aShop = new Shop();
                    aShop.ShopID = (int) aReader[0];
                    aShop.Name = aReader[1].ToString();
                    aShop.Address = aReader[2].ToString();
                    shopList.Add(aShop);
                }
            connection.Close();
            return shopList;
        }

        public void Save(Shop aShop)
        {
            CallForConnection();
            connection.Open();
            query = "INSERT INTO Table_Shop (Name,Address) Values(@0,@1)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@0", aShop.Name);
            command.Parameters.AddWithValue("@1", aShop.Address);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
