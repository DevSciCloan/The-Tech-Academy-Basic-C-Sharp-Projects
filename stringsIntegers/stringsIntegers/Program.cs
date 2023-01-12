using System;
using System.Collections.Generic;
using System.Linq;

namespace stringsIntegers
{
    class Program
    {
        static void Main()
        {
            // Creating list of integers
            List<int> integerList = new List<int>();

            // Adding integers to list
            integerList.Add(100);
            integerList.Add(150);
            integerList.Add(1000);
            integerList.Add(12);
            integerList.Add(15);
            integerList.Add(19);
            integerList.Add(17);

            // While conditional initialization
            bool invalid = true;

            // Creating variable to store user entry
            string userEntry;

            // Asking user to enter an integer to divide each integer in integerList by
            Console.WriteLine("Please enter an integer: \n");
            do
            {
                userEntry = Console.ReadLine(); // Storing user entry
                try
                {
                    int convertedEntry = Convert.ToInt32(userEntry); // Attempt to Convert userEntry to integer

                    // Iterate through the integerList and divide by userEntry
                    foreach (int number in integerList)
                    {
                        Console.WriteLine(number / convertedEntry);
                    }
                    invalid = false; // Set invalid to false to break out of the do while
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message + " Please enter a non-zero integer...\n");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message + " Please enter a number\n");
                }
                finally
                {
                    Console.WriteLine("Try again!\n");
                }
            }
            while (invalid);
            Console.Read();
        }
    }
}
