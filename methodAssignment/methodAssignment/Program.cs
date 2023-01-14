using System;
using System.Collections.Generic;
using System.Linq;

namespace methodAssignment
{
    class Program
    {
        static void Main()
        {
            int one;
            int two;
            
            // Instantiating new object of myClass
            myClass myClass = new myClass();
            
            // Writing intro message to console
            Console.WriteLine("Please enter two integers. Second integer is optional (just hit enter without typing anything if you want):\n");

            // Asking for first number
            Console.WriteLine("Enter first number:\n");

            one = Convert.ToInt32(Console.ReadLine());
            
            
            try
            {
                // Asking for second number
                Console.WriteLine("Enter second number (optional):\n");

                two = Convert.ToInt32(Console.ReadLine());

                // If the second number is a number call myMothod using both arguments
                Console.WriteLine("" + myClass.myMethod(one, two));
            }
            catch
            {
                // Otherwise call myMethod using just one argument
                Console.WriteLine("" + myClass.myMethod(one));
            }
            
            Console.Read(); // Wait for user input to close program
        }
    }

    class myClass
    {
        // Method that adds the two integers, or default value for the second, together and returns the sum
        public int myMethod(int one, int two = 10)
        {
            int newInt = one + two;
            return newInt;
        }
    }
}
