using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //This collects input from user 1 then converts it to int variables
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1: Please type your hourly rate and press \"Enter\"");
            string hourlyRate1 = Console.ReadLine();
            int rate1 = Convert.ToInt16(hourlyRate1);
            Console.WriteLine("Person 1: Please type your number of hours per week and press \"Enter\"");
            string hoursWorked1 = Console.ReadLine();
            int hours1 = Convert.ToInt16(hoursWorked1);

            //This collects input from user 2 then converts it to int variables
            Console.WriteLine("Person 2: Please type your hourly rate and press \"Enter\"");
            string hourlyRate2 = Console.ReadLine();
            int rate2 = Convert.ToInt16(hourlyRate2);
            Console.WriteLine("Person 2: Please type your number of hours per week and press \"Enter\"");
            string hoursWorked2 = Console.ReadLine();
            int hours2 = Convert.ToInt16(hoursWorked2);

            //This calculates the approximate annual salaries based on the users' input and compares them
            int salary1 = rate1 * hours1 * 52;
            int salary2 = rate2 * hours2 * 52;
            Console.WriteLine("Salary of Person 1 is: $" + salary1);
            Console.WriteLine("Salary of Person 2 is: $" + salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool comparison = salary1 > salary2;
            Console.WriteLine(comparison);
            Console.ReadLine();
        }
    }
}
