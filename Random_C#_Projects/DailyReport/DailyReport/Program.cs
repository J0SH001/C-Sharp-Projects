using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report");

            //Takes entered text and saves it as string variable "firstName"
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            //Takes entered text and saves it as string variable "course"
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            //Takes entered text, converts it into an integer, and saves it as int variable "pageNumber"
            Console.WriteLine("What page number?");
            string pageNumberText = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageNumberText);

            //Takes entered text, converts it into a booloean, and saves it as boolean variable "helpAnswer"
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string helpAnswerText = Console.ReadLine();
            bool helpAnswer = Convert.ToBoolean(helpAnswerText);

            //Takes entered text and saves it as string variable "positiveXP"
            Console.WriteLine("Were there any positive experiences that you would like to share? Please give specifics.");
            string positiveXP = Console.ReadLine();

            //Takes entered text and saves it as string variable "feedback"
            Console.WriteLine("Is there any other fedback that you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            //Takes entered text, converts it into an integer, and saves it as int variable "studyHours"
            Console.WriteLine("How many hours did you study today?");
            string studyHoursText = Console.ReadLine();
            int studyHours = Convert.ToInt32(studyHoursText);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
