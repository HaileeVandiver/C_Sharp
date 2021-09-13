using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //isntantiate a class
            Math firstOp = new Math();

            //takes int as a parameter 
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            
            //optional parameter
            Console.WriteLine("Please enter another number, if you feel like it, you don't have to");
            bool numberTwoValid = int.TryParse(Console.ReadLine(), out int numberTwo);

            //two numbers entered 

            int result = 0;
            if (numberTwoValid)
            {
                result = firstOp.mathOps(number, numberTwo);
            }
            else
            {
                result = firstOp.mathOps(number);
            }
            
            Console.WriteLine("Your result is: " + result);
            Console.ReadLine();



        }
    }
}
