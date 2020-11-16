using Server.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Data
{
    public class InMemoryData
    {
        public static List<Employee> Employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                No = 1994,
                FirstName = "Po Hisu",
                LastName = "Su",
                Salary = 100000
            },
            new Employee
            {
                Id = 2,
                No = 1995,
                FirstName = "Po Jen",
                LastName = "Su",
                Salary = 100000
            }
        };
    }
}
