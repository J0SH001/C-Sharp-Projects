using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            //This gathers the user's input and converts it into the correct type variables
            Console.WriteLine("We're going to determine if you qualify for car insurance. Please answer the following questions and then hit \"Enter\".\nWhat is your age?");
            string ageText = Console.ReadLine();
            int age = Convert.ToInt16(ageText);

            Console.WriteLine("Have you ever had a DUI? Please answer with \"true\" or \"false\"");
            string DUIText = Console.ReadLine();
            bool DUI = Convert.ToBoolean(DUIText);

            Console.WriteLine("How many speeding tickets do you have?");
            string speedingText = Console.ReadLine();
            int speeding = Convert.ToInt16(speedingText);

            //This evaluates if the answers satisfied/met all the parameters
            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && DUI == false && speeding <= 3);

            Console.ReadLine();
        }
    }
}
