using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee { fName = "William", lName = "Shatner", ID = 3 });
            empList.Add(new Employee { fName = "Leonard", lName = "Nimoy", ID = 1 });
            empList.Add(new Employee { fName = "Nichelle", lName = "Nichols", ID = 1774 });
            empList.Add(new Employee { fName = "DeForest", lName = "Kelley", ID = 1774 });
            empList.Add(new Employee { fName = "James", lName = "Doohan", ID = 5862 });
            empList.Add(new Employee { fName = "Joe", lName = "Koenig", ID = 8952 });
            empList.Add(new Employee { fName = "Jeffrey", lName = "Hunter", ID = 2 });
            empList.Add(new Employee { fName = "George", lName = "Takei", ID = 1693 });
            empList.Add(new Employee { fName = "Marianna", lName = "Hill", ID = 1984 });
            empList.Add(new Employee { fName = "Joe", lName = "Campbelle", ID = 3141 });

            List<Employee> dupJoe = new List<Employee>(); 


            foreach (Employee employee in empList)
            {
                if (employee.fName == "Joe")
                {
                    dupJoe.Add(employee);
                }
            }

            //lambda function to grab all the Joes 
            List<Employee> lamJoe = empList.Where(x => x.fName.Contains("Joe")).ToList();

            //lmbda to get Id greater than 5 
            List<Employee> lamIDJoe = empList.Where(x => x.ID > 5).ToList(); 
        }
    }
}
