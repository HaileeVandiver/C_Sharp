﻿using System;
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
            Employee empObject = new Employee();
            empObject.firstName = "Sample";
            empObject.lastName = "Student";
            //call method
            empObject.SayName();
            Console.ReadLine(); 
        }
    }
}
