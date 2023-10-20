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

        public static Employee operator== (Employee one, Employee two)
        {
            if (one.Id == two.Id)
            {
                Console.WriteLine("The Ids are equal!");
            }
            else
            {
                Console.WriteLine("The Ids are not equal.");
            }
            return one;
        }
        public static Employee operator!= (Employee one, Employee two)
        {
            if (one.Id == two.Id)
            {
                Console.WriteLine("The Ids are equal!");
            }
            else
            {
                Console.WriteLine("The Ids are not equal.");
            }
            return one;
        }
    }
}
