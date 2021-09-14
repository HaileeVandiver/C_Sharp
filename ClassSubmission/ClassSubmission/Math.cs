using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Math
    {
        //void: division operation
        public void myMethodOp(int userNum)
        {
            Console.WriteLine("Your number divided by two is: " + (userNum / 2));
        }

        //overload method and static 

        public static int myMethodOp(int userNum, int numTwo)
        {
            int resultNum = userNum * numTwo;
            return resultNum;
        }

        
        //using out parameter 
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;


        }
    
    }
}
