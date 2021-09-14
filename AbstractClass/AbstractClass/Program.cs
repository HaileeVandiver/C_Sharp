using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object
            //Employee empObject = new Employee();
            //empObject.firstName = "Sample";
            //empObject.lastName = "Student";


            //call method
            //empObject.SayName();

            //use polymorphism to create an object of IQuittable and call Quit()
            //IQuittable empQuit = new Employee();
            //empQuit.Quit();

            Employee employeeOne = new Employee();
            employeeOne.firstName = "Hailee";
            employeeOne.lastName = "Vandiver";
            employeeOne.employeeID = 1234;


            Employee employeeTwo = new Employee();
            employeeTwo.firstName = "Tami";
            employeeTwo.lastName = "Lenee";
            employeeTwo.employeeID = 2345;

            bool doesEqual = employeeTwo == employeeOne; 

            Console.ReadLine(); 
        }
    }
}
