using System;
using System.Collections.Generic;
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
            string conn = @"server=Hafiz;database=SuperShop;integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = conn;

        }
        public List<string> GetShopNameList()
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM table_Shop");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<string> shopNameList=new List<string>();
            if(aReader.HasRows)
                while (aReader.Read())
                {
                    shopNameList.Add(aReader[1].ToString());
                }
            connection.Close();
            return shopNameList;
        }

        public void Save(Shop aShop)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("INSERT INTO Table_Shop VALUES('{0}','{1}')", aShop.Name, aShop.Address);
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
