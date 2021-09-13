using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate object of Math class
            Math firstOp = new Math(); 
           
            Console.WriteLine("Please enter a number");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number * 100 is: "+ firstOp.mathOps(inputNum));
            Console.ReadLine();

            //instantiate new object using second method 
            Math secondOp = new Math();

            Console.WriteLine("Please enter a decimal");
            decimal floatNum = Decimal.Parse(Console.ReadLine()); 
            Console.WriteLine(" Your number + 2 is: " + secondOp.mathOps(floatNum));
            Console.ReadLine();

            //instantiate new object using third method 
            Math thirdOp = new Math();
            Console.WriteLine("Please enter a number");
            Console.WriteLine("Your number divided by 2 is: " + thirdOp.mathOps(Console.ReadLine()));
            Console.ReadLine(); 
        }
    }
}
