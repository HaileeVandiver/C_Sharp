using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints to console
            Console.WriteLine("The Tech Academy.");
            Console.ReadLine();
            //prints to console
            Console.WriteLine("Student Daily Report.");
            Console.ReadLine();
            //prints question to console
            Console.WriteLine("What is your name?");
            //saves name as a string
            string yourName = Console.ReadLine();
            //prints to console
            Console.WriteLine("What course are you on?");
            //saves yourCourse as a string
            string yourCourse = Console.ReadLine();
            //prints to console
            Console.WriteLine("What page are you on?");
            //saves answer as string
            string yourPage = Console.ReadLine();
            //makes answer into int data type
            int uPage = Convert.ToInt32(yourPage);
            //prints to console
            Console.WriteLine("Do you need help with anything? Please respond \"True\" or \"False\" ");
            //saves as a string
            string help = Console.ReadLine();
            //prints to console
            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific");
            //saves as a string
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int numberHours = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day");


        }
    }
}
