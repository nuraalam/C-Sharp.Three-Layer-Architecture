using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_App.DLL.DAO
{
    class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Department(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public Department()
        {
        }
    }
}
