using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number between 1 and 10?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool correct = number == 3;
            
            //Initiates the loop if the first answer is correct
            do
            {
                //Runs through the possible answers and asks the same question until the correct answer is given
                switch (number)
                {
                    case 7:
                        Console.WriteLine("Typical...");
                        Console.WriteLine("What is your favorite number between 1 and 10?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("That's the correct answer, good job!");
                        correct = true;
                        break;
                    default:
                        Console.WriteLine("You picked the worst number, for shame...");
                        Console.WriteLine("What is your favorite number between 1 and 10?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!correct);

            Console.WriteLine("Pick another number between 1 and 10.");
            int number2 = Convert.ToInt32(Console.ReadLine());
            bool correct2 = number2 == 8;

            while (!correct2)
            {
                if (number2 == 8)
                {
                    Console.WriteLine("That is the correct number!");
                    correct2 = true;
                }
                else
                {
                    Console.WriteLine("Pick another number between 1 and 10.");
                    number2 = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.ReadLine();
        }
    }
}
