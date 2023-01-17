using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace parametersAssignment
{
    class Program
    {
        static void Main()
        {
            Employee<int> intEmployee = new Employee<int>(new List<int> {1,2,3,4,5}); // Instantiating Employee of type int and passing a list of type int to the constructor

            Employee<string> stringEmployee = new Employee<string>(new List<string> {"one", "two", "three", "four", "five"}); // Instantiating Employee of type string and passing a list of type string to the constructor


            Console.WriteLine("int List Employee: \n"); // Printing a title for the list of items that will print next

            // Printing each item in things to console
            foreach (int item in intEmployee.things) 
            {
                Console.WriteLine(item + "\n");
            }

            Console.WriteLine("string List Employee: \n"); // Printing a title for the list of items that will print next

            // Printing each item in things to console
            foreach (string item in stringEmployee.things)
            {
                Console.WriteLine(item + "\n");
            }

            Console.Read(); // Wait for user input before closing program
        }
    }

    public class Employee<T>
    {
        public List<T> things;

        // Constructor 
        public Employee(List<T> list)
        {
            this.things = list;
        }
    }
}
