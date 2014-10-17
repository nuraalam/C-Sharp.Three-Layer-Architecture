using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department_App.DLL.DAO;
using Department_App.DLL.Gateway;

namespace Department_App.BLL
{
    class DepartmentBLL
    {
        DepartmentGatway aDepartmentGatway=new DepartmentGatway();
        public string Save(Department aDepartment)
        {
            aDepartmentGatway.GetDepartmentList();
            foreach (Department bDepartment in aDepartmentGatway.GetDepartmentList())
            {
                if (bDepartment.Name != aDepartment.Name)
                {
                    if (bDepartment.Code != aDepartment.Code)
                    {
                        aDepartmentGatway.Save(aDepartment);
                        return "data is save";
                    }
                    else
                    {
                        return "data is not valid";
                    }
                }
            }
            return "i dont know";
        }

    }
}
