using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public List<Employee> employees = new List<Employee>();
    }
    public static void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }
}

