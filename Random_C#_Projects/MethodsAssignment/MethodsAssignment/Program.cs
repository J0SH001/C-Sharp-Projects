using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number and press \"Enter\".");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Numbers.Add(i));
            Console.WriteLine(Numbers.Multiply(i));
            Console.WriteLine(Numbers.Subtract(i));
            Console.ReadLine();
        }
    }
}
