using System;

namespace EntityFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Hailee" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
