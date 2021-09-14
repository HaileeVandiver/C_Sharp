using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {

            int returnStat;
            //instantiate MathOp class
            Math myNumObj = new Math();

            //user input is divided by 2 and output is displayed
            Console.WriteLine("Input a numba: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            myNumObj.myMethodOp(userNum);

            // method with an out parameter 
    
            int a;
            myNumObj.getValue(out a);
            Console.WriteLine("After method call, value of a : {0}", a);

            //static overload method 


            int numTwo = 2;
            Console.WriteLine("Your number times 2 is: " + Math.myMethodOp(userNum, numTwo));


            returnStat = StaticMath.MethodMult(userNum);
            Console.WriteLine("That number times 3 is: " + returnStat);

            Console.ReadLine();

            







            Console.ReadLine();

        }
    }
}
