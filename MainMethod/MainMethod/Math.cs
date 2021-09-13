using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
   public class Math
    {
        public int mathOps(int number)
        {
            return number * 100; 
        }

        //method overload to accept decimal 
        public int mathOps(decimal number)
        {
            int newNum = Convert.ToInt32(number);
            return newNum + 2;
            
        }

        //method overload to accept a string 
        public int mathOps(string number)
        {
            int newNum = Convert.ToInt32(number);
            return newNum / 2; 
        }

    }
}
