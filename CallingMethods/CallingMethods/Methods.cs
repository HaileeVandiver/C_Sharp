using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Methods
    {
        public static int addInt(int num)
        {
            int myNum = num;
            int myNumAdd = myNum + 10;
            return myNumAdd;
        }

        public static int subInt(int num)
        {
            int myNum = num;
            int myNumSub = myNum - 5;
            return myNumSub;
        }

        public static int multInt(int num)
        {
            int myNum = num;
            int myNumMult = myNum * 10;
            return myNumMult;
        }
    }
}
