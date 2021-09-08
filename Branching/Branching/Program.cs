using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        
            Console.WriteLine("Please enter package weight");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());
            //weight
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }


            //width
            Console.WriteLine("Please enter package width");
            decimal packageWidth = Convert.ToDecimal(Console.ReadLine());
            //height
            Console.WriteLine("Please enter package height");
            decimal packageHeight = Convert.ToDecimal(Console.ReadLine());
            //length
            Console.WriteLine("Please enter package length");
            decimal packageLength = Convert.ToDecimal(Console.ReadLine());

               

            //check if width + height + length > 50
            if (packageWidth + packageHeight + packageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            decimal total = (((packageWidth * packageHeight * packageLength) * packageWeight) / 100);
            Console.WriteLine("Your estimated total shipping cost for this package is: " + total);
            Console.ReadLine();
                
            }
            
        }
        
    }

    

