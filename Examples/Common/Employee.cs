using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Examples.Delegates.Delegates;

namespace Examples.Common
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach(Employee employee in employeeList)
            {
                if(IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }
}
