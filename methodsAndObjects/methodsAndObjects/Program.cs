using System;
using System.Collections.Generic;

namespace methodsAndObjects
{
    class Program
    {
        static void Main()
        {
            Employee sample = new Employee("Sample", "Student"); // Instantiating new Employee and passing superclass perameters to Employee's constructor
            sample.sayName(); // Calling superclass method sayName
            Console.Read(); // Wait for user input before closing program
        }
    }

    class Person
    {
        public string FirstName;
        public string LastName;

        public void sayName()
        {
            Console.WriteLine("Name: \n" + this.FirstName + " " + this.LastName + "\n");
        }
    }

    class Employee : Person
    {
        // Constructor
        public Employee(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        } 
        int Id;
    }
}
