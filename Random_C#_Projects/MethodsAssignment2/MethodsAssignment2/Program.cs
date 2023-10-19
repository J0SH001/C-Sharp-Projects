using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number and press \"Enter\".");
            int i = Convert.ToInt32(Console.ReadLine());

            int newNumber = Numbers.Add(i);
            Console.WriteLine(newNumber);

            Console.WriteLine("Type a decimal number and press \"Enter\".");
            decimal i2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(Numbers.Add(i2));

            Console.WriteLine("Type a decimal number and press \"Enter\".");
            string i3 = Console.ReadLine();

            Console.WriteLine(Numbers.Add(i3));

            Console.ReadLine();
        }
    }
}
