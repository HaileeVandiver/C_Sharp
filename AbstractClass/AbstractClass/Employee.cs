using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable

    {
        public int employeeID { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.ReadLine();
        }

        public void Quit()
        {
            Console.WriteLine("This employee quit");
        }
        public static bool operator ==(Employee one, Employee two)
        {
            if (one.employeeID == two.employeeID)
            {
                Console.WriteLine("The ID's are equal");
                return true;
            }
            else
            {
                Console.WriteLine("The ID's are not equal.");
                return false;
            }

        }

        public static bool operator !=(Employee one, Employee two)
        {
            if (one.employeeID == two.employeeID)
            {
                Console.WriteLine("The ID's are equal");
                return false;
            }
            else
            {
                Console.WriteLine("The ID's are not equal.");
                return true;
            }
        }
    }
}
