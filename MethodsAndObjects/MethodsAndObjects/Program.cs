using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //create employee object 
            Employee empObject = new Employee();
            empObject.FirstName = "Sample";
            empObject.LastName = "Student";
            //call superclass method
            empObject.SayName(); 


        }
    }
}
