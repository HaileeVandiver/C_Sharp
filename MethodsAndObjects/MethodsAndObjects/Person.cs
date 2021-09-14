using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        //class properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //void method because no arguments are passed through
        public void SayName()
        {
            //prints names to console
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
            Console.ReadLine(); 
        }
    }
}
