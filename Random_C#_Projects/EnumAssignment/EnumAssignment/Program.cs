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
                int counter = 0;

                foreach (string dayName in Enum.GetNames(typeof(DaysOfTheWeek)))
                {
                    if (Convert.ToString(Enum.Parse(typeof(DaysOfTheWeek), dayName)) == day)
                    {
                        Console.WriteLine(day + " is a day in the enum.");
                    }
                    else
                    {
                        counter++;
                    }
                }
                if (counter == 7)
                {
                    throw new Exception();
                }
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
