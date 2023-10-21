using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week.");
                string day = Console.ReadLine();
                DaysOfTheWeek theDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day);
                Console.WriteLine(theDay + " is a day in the enum.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();

        }
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
