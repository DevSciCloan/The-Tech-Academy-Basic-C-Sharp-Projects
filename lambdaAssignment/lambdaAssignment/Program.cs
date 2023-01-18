using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaAssignment
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>() 
            {
                new Employee(1, "Joe", "Saprano"),
                new Employee(2, "Jen", "Stahp"),
                new Employee(3, "Noel", "Baker"),
                new Employee(4, "Greg", "Jones"),
                new Employee(5, "Polly", "Ritolli"),
                new Employee(6, "Jake", "Miller"),
                new Employee(7, "Joe", "Sloan"),
                new Employee(8, "Tiffany", "Lovridge"),
                new Employee(9, "Tony", "Parker"),
                new Employee(10, "Jess", "Fiddler")
            };

            List<Employee> wheresJoe = employees.Where( x => x.FirstName == "Joe").ToList(); // Filter employees where FirstName == Joe

            // For each employee in Employee List wheresJoe, print first and last name to console
            foreach (Employee employee in wheresJoe) 
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            // Using ForEach and a lambda expression to print First and Last names of all Employees in List wheresJoe
            wheresJoe.ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));

            List<Employee> employeesIds = employees.Where(x => x.Id > 5).ToList(); // Filter employees where the employees Id is greater than 5

            // Using ForEach and a lambda expression to print First and Last names of all Employees in List employeesIds
            employeesIds.ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));

            // Wait for user input before closing program
            Console.Read();
        }
    }

    class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;

        // Constructor 
        public Employee(int id, string fname, string lname)
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
        }
    }
}
