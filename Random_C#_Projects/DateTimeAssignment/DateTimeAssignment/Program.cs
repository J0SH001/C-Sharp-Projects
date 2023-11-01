using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            DateTime now = DateTime.Now;
            Console.WriteLine("Enter a number.");
            Double number = Convert.ToDouble(Console.ReadLine());
            DateTime then = now.AddHours(number);
            Console.WriteLine(then);

            Console.WriteLine("Enter a date.");
            DateTime number = Convert.ToDateTime(Console.ReadLine());

            TimeSpan age = DateTime.Now - number;
            Console.WriteLine(age.Days / 365);

            Console.ReadLine();
        }
    }
}
