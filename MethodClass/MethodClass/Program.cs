using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            Math firstOp = new Math();

            int numOne = 10;
            int numTwo = 6;

            //call method and pass in two numbers 

            firstOp.mathOp(numOne, numTwo);

            // call the method in the class and specify parameters by name 
            firstOp.mathOp(secondNum: numTwo, firstNum: numOne);
            Console.ReadLine(); 




        }
    }
}
