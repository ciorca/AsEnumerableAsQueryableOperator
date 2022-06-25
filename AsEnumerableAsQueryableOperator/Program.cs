using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsEnumerableAsQueryableOperator
{
    class Program
    {
        static void Main()
        {
            EmployeeDBDataContext dbContext = new EmployeeDBDataContext();
            // TOP 5 Male Employees By Salary
            var result = dbContext.Employees                         
                           .Where(x => x.Gender == "Male")
                           .AsEnumerable()
                           .OrderByDescending(x => x.Salary).Take(5);
            foreach (Employee e in result)
            {
                Console.WriteLine(e.Name + "\t" + e.Gender + "\t" + e.Salary);
            }
        }
    }
}
