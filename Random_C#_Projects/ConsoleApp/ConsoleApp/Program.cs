using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1 start
            string[] phrases = { "My pet\'s name is ", "Loud noises and water terrify ", "A thunderstorm is the worst nightmare of " };
            Console.WriteLine("Type a name and press \"Enter\".");
            string petName = Console.ReadLine();

            foreach (string i in phrases)
            {
                i.Concat(i + petName);
            }
            foreach (string i in phrases)
            {
                Console.WriteLine(i + petName);
            }
            //Assignment 1 end

            //Assignment 2 start
            bool loopy = false;
            while (loopy == false)
            {
                Console.WriteLine("This is an infinite loop.");
                loopy = true;
            }
            //fixed the infinite loop by switching the bool value to true
            //Assignment 2 end

            //Assignment 3 start
            string[] pies = { "Cherry", "Apple", "Blueberry", "Pumpkin", "Banana Cream", "Cherry" };

            for (int j = 0; j < pies.Length; j++)
            {
                Console.WriteLine(pies[j]);
            }

            int[] numbers = { 56, 11, 37, 94, 80 };

            for (int j = 0; j <= 3; j++)
            {
                Console.WriteLine(numbers[j]);
            }
            //Assignment 3 end

            //Assignment 4 start
            Console.WriteLine("Type a pie flavor and press \"Enter\".");
            string pietext = Console.ReadLine();
            int sum = 0;

            for (int j = 0; j < pies.Length; j++)
            {
                if (pies[j].Contains(pietext))
                {
                    Console.WriteLine(j);
                    sum = sum + 1;
                    break;
                }
            }
            if (sum == 0)
            {
                Console.WriteLine("No pie exists of that flavor.");
            }
            //Assignment 4 end

            //Assignment 5 start

            Console.WriteLine("Type a pie flavor and press \"Enter\".");
            string pietext2 = Console.ReadLine();
            int sum2 = 0;

            for (int j = 0; j < pies.Length; j++)
            {
                if (pies[j].Contains(pietext2))
                {
                    Console.WriteLine(j);
                    sum2 = sum2 + 1;
                }
            }
            if (sum2 == 0)
            {
                Console.WriteLine("No pie exists of that flavor.");
            }
            //Assignment 5 end

            //Assignment 6 start
            List<string> newPies = new List<string>();
            foreach (string pie in pies)
            {
                int pieNum = 0;
                foreach (string newPie in newPies)
                {
                    if (pie == newPie)
                    {
                        pieNum = pieNum + 1;
                    }
                }
                if (pieNum == 0)
                {
                    newPies.Add(pie);
                    Console.WriteLine(pie + " - Is unique!");
                }
                else
                {
                    Console.WriteLine(pie + " - Is a duplicate!");
                }
            }
            //Assignment 6 end

            Console.ReadLine();
        }
    }
}
