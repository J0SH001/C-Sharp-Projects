using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 12;
            int num2 = 4;
            
            int sum = num1 + num2;
            Console.WriteLine(sum);

            int difference = num1 - num2;
            Console.WriteLine(difference);

            int product = num1 * num2;
            Console.WriteLine(product);

            int quotient = num1 / num2;
            Console.WriteLine(quotient);

            double quotient2 = 100.0 / 17.0;
            Console.WriteLine(quotient2);

            int remainder = 11 % 2;
            Console.WriteLine(remainder);



            bool trueOrFalse = 12 < 5;
            Console.WriteLine(trueOrFalse);

            int roomTemp = 70;
            int currentTemp = 70;

            bool isWarm = currentTemp >= roomTemp;
            Console.WriteLine(isWarm);

            bool isEqual = currentTemp == roomTemp;
            Console.WriteLine(isEqual);


            string word1 = "What\'s ";
            string word2 = "up?";
            string greeting = word1 + word2;
            Console.WriteLine(greeting);
            Console.ReadLine();

            Console.WriteLine("Enter a number to be multiplied by 50");
            string multiplierText = Console.ReadLine();
            int multiplier = Convert.ToInt32(multiplierText);
            int productx = multiplier * 50;
            Console.WriteLine(productx);
            Console.ReadLine();

            Console.WriteLine("Enter a number to be increased by 25");
            string additionText = Console.ReadLine();
            int addition = Convert.ToInt32(additionText);
            int additionx = addition + 25;
            Console.WriteLine(additionx);
            Console.ReadLine();

            Console.WriteLine("Enter a number to be divided by 12.5");
            string dividendText = Console.ReadLine();
            int dividend = Convert.ToInt32(dividendText);
            double dividendx = dividend / 12.5;
            Console.WriteLine(dividendx);
            Console.ReadLine();

            Console.WriteLine("Enter a number to determine if it's greater than 50 or not");
            string greaterText = Console.ReadLine();
            int greater = Convert.ToInt32(greaterText);
            bool greaterx = greater > 50;
            Console.WriteLine(greaterx);
            Console.ReadLine();

            Console.WriteLine("Enter a number to be get the remainder of when divided by 7");
            string remainderText = Console.ReadLine();
            int remainder1 = Convert.ToInt32(remainderText);
            int remainderx = remainder1 % 7;
            Console.WriteLine(remainderx);
            Console.ReadLine();
        }
    }
}
