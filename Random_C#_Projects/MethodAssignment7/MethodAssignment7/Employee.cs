using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment7
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public static bool operator == (Employee one, Employee two  )
        {
            return one.Id == two.Id;
        }
        public static bool operator!= (Employee one, Employee two)
        {
            return one.Id != two.Id;
        }
    }
}
