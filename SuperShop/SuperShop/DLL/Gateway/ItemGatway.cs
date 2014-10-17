using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using SuperShop.DLL.DAO;
using SuperShop.DLL.DAO.View;

namespace SuperShop.DLL.Gateway
{
    class ItemGatway
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
       
        public void UpgreadeQuantity(Item anItem)
        {
           int value = anItem.Quantity;
           
            CallForConnection();
            connection.Open();
            query = "UPDATE Table_Item SET Quantity=Quantity+"+value+" WHERE ID=@1 AND ShopID= @3";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@1", anItem.Id);
            command.Parameters.AddWithValue("@3", anItem.ShopID);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Save(Item anItem)
        {
            CallForConnection();
            connection.Open();
            query = "INSERT INTO Table_Item (Id,Quantity,ShopID) Values(@0,@1,@2)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@0", anItem.Id);
            command.Parameters.AddWithValue("@1", anItem.Quantity);
            command.Parameters.AddWithValue("@2", anItem.ShopID);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<ShopItem> GetShopItemList()
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM View_1");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
                    
            List<ShopItem> aShopItemList=new List<ShopItem>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    ShopItem aShopItem = new ShopItem();
                    aShopItem.ShopID = (int) aReader[0];
                    aShopItem.ShopName = aReader[1].ToString();
                    aShopItem.ItemName = aReader[2].ToString();
                    aShopItem.Quantity = (int) aReader[3];
                    aShopItemList.Add(aShopItem);
                }
            }
            connection.Close();
            return aShopItemList;
        }
    }
}
