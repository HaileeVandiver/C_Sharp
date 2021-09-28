using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
           
        {
            //current time
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            //print to console

            Console.WriteLine("The time {0} hours from now is {1}", num, dateTime.AddHours(num));
            Console.ReadLine();


        }
    }
}
