using System;
using System.Collections.Generic;

namespace classSubmission
{
    class Program
    {
        static void Main()
        {
            myClass myClass = new myClass(); // Instantiating new myClass object
            
            Console.WriteLine("Please enter a number: \n"); // Print instructions 
            Console.WriteLine("The number you entered divided by two equals: " + myClass.divideByTwo(Convert.ToInt32(Console.ReadLine()))); // Reads user input, calls myMethod using the users input, and prints the result to console
            anotherClass.anotherMethod(); // Calling anotherMethod from static class anotherClass
            Console.Read(); // Wait for user input to close program
        }
    }

    class myClass
    {
        public int divideByTwo(int number)
        {
            return number / 2;
        }

        public void divideByTwo(int number, out int result)
        {
            result = number / 2; 
        }
    }

    static class anotherClass 
    { 
        public static void anotherMethod()
        {
            Console.WriteLine("Called from a static class\n");
        }
    }

}
