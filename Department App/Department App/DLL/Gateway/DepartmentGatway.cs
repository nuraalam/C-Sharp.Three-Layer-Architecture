using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department_App.DLL.DAO;

namespace Department_App.DLL.Gateway
{
    class DepartmentGatway
    {
       

        public List<Department> GetDepartmentList()
        {
         
            string conn = @"server=BITM-401-PC22\SQLEXPRESS;database=Department;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = String.Format("SELECT* FROM t_department");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            List<Department> departments = new List<Department>();
            Department aDepartment=new Department();


            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aDepartment.Name = aReader[1].ToString();
                    aDepartment.Code = aReader[2].ToString();
                  
                    departments.Add(aDepartment);
                   
                }
            }
            connection.Close();
            return departments;
        }

        public void Save(Department aDepartment)
        {
            


            string conn = @"server=BITM-401-PC22\SQLEXPRESS;database=Department;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = String.Format("INSERT INTO t_department VALUES('{0}','{1}')", aDepartment.Name, aDepartment.Code);
            SqlCommand command = new SqlCommand(query, connection);
        
            connection.Close();
           
        }
    }
}
