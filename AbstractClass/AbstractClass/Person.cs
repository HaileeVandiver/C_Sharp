using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //class is abstract because we do not need a person object 
    public abstract class Person
    {
        //properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        //void because arguments are't passed into it 
        public abstract void SayName();
      
    }
}
 