using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee one = new Employee();
            one.FirstName = "First";
            one.LastName = "Employee";
            one.Id = 14;

            Employee two = new Employee();
            two.FirstName = "First";
            two.LastName = "Employee";
            two.Id = 13;

            _=one == two;
            Console.ReadLine();
        }
    }
}
