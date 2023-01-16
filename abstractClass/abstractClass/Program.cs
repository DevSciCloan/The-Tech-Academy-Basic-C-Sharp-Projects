using System;

namespace abstractClass
{
    class Program
    {
        static void Main()
        {
            Employee someone = new Employee("Sample", "Student"); // Instantiating new Employee object

            someone.callSayName(); // Calling superclass method SayName by within callSayName from the Employee class

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
    class Employee : Person
    {
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
    }
}
