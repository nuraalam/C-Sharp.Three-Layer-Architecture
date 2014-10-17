using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShopItem.DLL.DAO;

namespace SuperShopItem.DLL.Gateway
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
        public List<string> GetIdList()
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM Table_Item");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<string> idList = new List<string>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    idList.Add(aReader[1].ToString());
                }
            }
            connection.Close();
            return idList;
        }

        public void UpgreadeQuantity(Item anItem)
        {
           int value = anItem.Quantity;
            string id = anItem.Id;
            CallForConnection();
            connection.Open();
            query = "UPDATE Table_Item SET Quantity=Quantity+"+value+" WHERE ID='"+id+"'";
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Save(Item anItem)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("INSERT INTO Table_Item VALUES('{0}','{1}')", anItem.Id,anItem.Quantity);
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
