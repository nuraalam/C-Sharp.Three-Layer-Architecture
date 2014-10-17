using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStudentApp
{
    class Department
    {
        private const int MAX_NO_OF_STUDENTS = 10;
        public string Code { set; get; }
        public string Name { set; get; }
        public List<Student> Students { set; get; }
        public Department(string code, string name) : this()
        {
            Code = code;
            Name = name;
        }

        public Department()
        {
            Students = new List<Student>();
        }

        public string AddStudent(Student aStudent)
        {
            if (Students.Count < MAX_NO_OF_STUDENTS)
            {
                Students.Add(aStudent);
                return "Added";
            }
            else
            {
                return "Overflow";
            }
        }

    }
}
