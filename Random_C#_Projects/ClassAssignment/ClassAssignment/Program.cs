using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number and hit \"Enter\".");
            int input = Convert.ToInt32(Console.ReadLine());

            Numbers divide = new Numbers();
            divide.Divide(input);
            Console.ReadLine();

            int remainder = 0;
            int input2 = 7;
            Numbers add = new Numbers();
            add.Add(input2, out remainder);
        }
    }
}
