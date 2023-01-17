using System;

namespace abstractClass
{
    class Program
    {
        static void Main()
        {
            Employee someone = new Employee("Sample", "Student"); // Instantiating new Employee object

            someone.callSayName(); // Calling superclass method SayName by within callSayName from the Employee class

            // Printing whether or not Employee is employed
            Console.WriteLine(someone.SayName() + " is employed: " + someone.employed);

            someone.Quit(someone); // Employee quits

            // Printing whether or not Employee is employed
            Console.WriteLine(someone.SayName() + " is employed: " + someone.employed);

            // Instantiating two new Employee objects
            Employee employee1 = new Employee("George", "Hendrix");
            Employee employee2 = new Employee("Paul", "Green");

            // Setting employee ids to 1 and 2
            employee1.iD = 1;
            employee2.iD = 2;

            // Printing both employee names and whether or not employee1 == employee2 using overloaded operator == in class Employee
            Console.WriteLine("Employee: " + employee1.SayName() + "\nEmployee: " + employee2.SayName() + "\nHave the same id number: " + (employee1 == employee2));

            Console.Read(); // Waits for user input before closing program
        }
    }

    abstract class Person
    {
        public string firstName;
        public string lastName;

        // Returns firstName and lastName with a space in between
        public string SayName()
        {
            return this.firstName + " " + this.lastName;
        }
    }

    // Employee inherits Person
    class Employee : Person, IQuittable
    {
        public int iD;
        public bool employed = true;
        // Constructor
        public Employee(string fname, string lname)
        {
            this.firstName = fname;
            this.lastName = lname;
        }

        // Calls SayName method from Person class, appends it to Name: \n, and writes it to console
        public void callSayName()
        {
            Console.WriteLine("Name: \n" + this.SayName());
        }

        // Employee can quit. Sets employed to false
        public void Quit(Employee employee)
        {
            employee.employed = false;
        }

        // Overloads == operator to determine if employee1.iD == employee2.iD and returns true or false
        public static bool operator==(Employee employee1, Employee employee2)
        {
            bool equal = employee1.iD == employee2.iD;
            return equal;
        }

        // Overloads != operator to determine if employee1.iD != employee2.iD and returns true or false
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool equal = employee1.iD != employee2.iD;
            return equal;
        }
    }
}
