using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndIntegersExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int>() { 80, 20, 12, 32 };
                Console.WriteLine("Pick a number to divide the list by.");
                int divider = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < intList.Count; j++)
                {
                    Console.WriteLine(intList[j] / divider);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("The program is now moving on past the try/catch block.");
            Console.ReadLine();
        }
    }
}
