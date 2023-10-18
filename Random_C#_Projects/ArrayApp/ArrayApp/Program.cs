using System;
using System.Collections.Generic;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining our lists and arrays
            int[] numArray = { 9, 2, 13, 200, 85 };
            string[] stringArray = { "Blue", "Red", "Green", "Yellow", "Purple" };
            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("Salutations");
            stringList.Add("Howdy");
            stringList.Add("Hey");
            stringList.Add("Sup?");

            //Creates a loop in case an improper index is selected for the number array
            Console.WriteLine("Select the array position of the number that you would like to be displayed (0-4)");
            int numArrayPosition = Convert.ToInt16(Console.ReadLine());
            bool numPosition = false;
            do
            {
                if (numArrayPosition >= 0 && numArrayPosition <= 4)
                {
                    Console.WriteLine(numArray[numArrayPosition]);
                    numPosition = true;
                }
                else
                {
                    Console.WriteLine("Please select an index between 0 and 4.");
                    numArrayPosition = Convert.ToInt16(Console.ReadLine());
                }
            }
            while (!numPosition);

            //Creates a loop in case an improper index is selected for the string array
            Console.WriteLine("Select the array position of the string that you would like to be displayed (0-4)");
            int stringArrayPosition = Convert.ToInt16(Console.ReadLine());
            bool stringPosition = false;
            do
            {
                if (stringArrayPosition >= 0 && stringArrayPosition <= 4)
                {
                    Console.WriteLine(stringArray[stringArrayPosition]);
                    stringPosition = true;
                }
                else
                {
                    Console.WriteLine("Please select an index between 0 and 4.");
                    stringArrayPosition = Convert.ToInt16(Console.ReadLine());
                }
            }
            while (!stringPosition);

            //Creates a loop in case an improper index is selected for the string list
            Console.WriteLine("Select the list position of the string that you would like to be displayed (0-4)");
            int stringListPosition = Convert.ToInt16(Console.ReadLine());
            bool stringPosition2 = false;
            do
            {
                if (stringListPosition >= 0 && stringListPosition <= 4)
                {
                    Console.WriteLine(stringList[stringListPosition]);
                    stringPosition2 = true;
                }
                else
                {
                    Console.WriteLine("Please select an index between 0 and 4.");
                    stringListPosition = Convert.ToInt16(Console.ReadLine());
                }
            }
            while (!stringPosition2);

            Console.ReadLine();

        }
    }
}
