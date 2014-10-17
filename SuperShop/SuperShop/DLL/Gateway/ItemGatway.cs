using System;
using System.Collections.Generic;
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
            string conn = @"server=Hafiz;database=SuperShop;integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = conn;

        }
       
        public void UpgreadeQuantity(Item anItem)
        {
           int value = anItem.Quantity;
            string id = anItem.Id;
            int shopID = anItem.ShopID;
            CallForConnection();
            connection.Open();
            query = "UPDATE Table_Item SET Quantity=Quantity+"+value+" WHERE ID='"+id+"'AND ShopID='"+shopID+"'";
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Save(Item anItem)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("INSERT INTO Table_Item VALUES('{0}','{1}',{2})", anItem.Id,anItem.Quantity,anItem.ShopID);
            command = new SqlCommand(query, connection);
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
