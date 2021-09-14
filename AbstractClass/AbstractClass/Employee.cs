using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.ReadLine();
        }

        public void Quit()
        {
            Console.WriteLine("This employee quit");
        }
    }
}
