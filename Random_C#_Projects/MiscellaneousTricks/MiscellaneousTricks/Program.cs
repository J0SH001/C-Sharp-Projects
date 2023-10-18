using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscellaneousTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Josh";
            string quote = "The man said, \\Hello\", Josh. \n Hello on a new line \n \t Hello on a tab.";
            string fileName = @"C:\Users\Owner";

            bool trueOrFalse = name.Contains("s");
            bool trueOrFalse1 = name.EndsWith("s");

            int length = name.Length;

            string nameU = name.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Josh");

            Console.WriteLine(name);
            Console.WriteLine(quote);
            Console.WriteLine(fileName);
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(trueOrFalse1);
            Console.WriteLine(length);
            Console.WriteLine(nameU);
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
