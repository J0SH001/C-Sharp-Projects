using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test = new Employee();
            test.FirstName = "Sample";
            test.LastName = "Student";
            test.SayName();
            Console.ReadLine();

            IQuittable quitter = new Employee();
            quitter.quit();
            Console.ReadLine();
        }
    }
}
