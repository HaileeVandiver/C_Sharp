using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to perform basic math operations on.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            int newNumAdd = Methods.addInt(userNum);
            int newNumSub = Methods.subInt(userNum);
            int newNumMult = Methods.multInt(userNum);

            Console.WriteLine("Your number plus 10 is: " + newNumAdd);
            Console.WriteLine("Your number subtracted by 5 is: " + newNumSub);
            Console.WriteLine("Your number multiplied by 10 is: " + newNumMult);
            Console.ReadLine();
        }
    }
}
