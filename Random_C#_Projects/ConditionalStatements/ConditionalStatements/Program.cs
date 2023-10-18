using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3;
            if (number > 7)
            {
                Console.WriteLine("The number is greater than 7");
            }
            else if (number <= 2)
            {
                Console.WriteLine("The number is less than or equal to 2");
            }
            else if (number != 3)
            {
                Console.WriteLine("The number is not equal to 3");
            }
            else
            {
                Console.WriteLine("The number is 3");
            }

            string numberText = number > 8 ? "The number is greater than 8" : "The number is less than 8";
            Console.WriteLine(numberText);
            
            Console.ReadLine();
        }
    }
}
