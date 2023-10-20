using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Type in a second number if it strikes your fancy.");
            string num2 = Console.ReadLine();

            if (num2 == "")
            {
                Numbers math = new Numbers();
                Console.WriteLine(math.Add(num1));
            }
            else
            {
                int num3 = Convert.ToInt32(num2);
                Numbers math = new Numbers();
                Console.WriteLine(math.Add(num1, num3));
            }

            Console.ReadLine();
        }
    }
}
