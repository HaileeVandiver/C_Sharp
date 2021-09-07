using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            //get data for person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            int p1Hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            int p1Weekly = Convert.ToInt32(Console.ReadLine());
            
            //get data for person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            int p2Hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            int p2Weekly = Convert.ToInt32(Console.ReadLine());

            //multiply p1hourly and weekly to get salary
            Console.WriteLine("Annual Salary of Person 1: ");
            int p1Total = p1Hourly * p1Weekly;
            Console.WriteLine(p1Total);

            //multiply p2hourly and weekly to get salary
            Console.WriteLine("Annual Salary of Person 2: ");
            int p2Total = p2Hourly * p2Weekly;
            Console.WriteLine(p2Total);

            //create boolean for if person 1 has larger sala
            Console.WriteLine("Does Person 1 make more than Person 2");
            bool biggerSalary = p1Total > p2Total;
            Console.WriteLine(biggerSalary);
            Console.ReadLine();
           

        }
    }
}
