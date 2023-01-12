using System;
using System.Collections.Generic;
using System.Linq;
using static callingMethods.Math; // Importing class Math

namespace callingMethods
{
    
    class Program
    {
        static void Main()
        {
            Math myClass = new Math(); // Instantiating a new Math object

            Console.WriteLine("Enter a number to perform math operations on: \n");
            // Try to convert user input and perform math operations
            try
            {
                int userEntry = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Divide by 2 (rounded up): " + myClass.divideByTwo(userEntry) + "\n"); // Divide userEntry by two using method from class Math
                Console.WriteLine("Add 10: " + myClass.addTen(userEntry) + "\n"); // Adding 10 to userEntry with a method from class Math
                Console.WriteLine("Multiply by 2: " + myClass.multiplyByTwo(userEntry) + "\n"); // Multiply userEntry by two using a method from class Math
            }
            // Math operation unsuccessful or not an integer
            catch
            {
                Console.WriteLine("Please enter an integer...\n");
            }
            finally
            {
                Console.Read(); // Pause for user input before closing program
            }
        }
    }

}
