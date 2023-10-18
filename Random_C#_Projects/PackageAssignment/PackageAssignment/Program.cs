using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nWhat is the weight of your package?");
            int weight = Convert.ToInt16(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is the width of your package in inches?");
                int width = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("What is the height of your package in inches?");
                int height = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("What is the length of your package in inches?");
                int length = Convert.ToInt16(Console.ReadLine());

                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    double quote = (width * weight * height * length) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00.\nThank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
