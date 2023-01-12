using System;
using System.Collections.Generic;


namespace arrayAssignment
{
    class Program
    {
        static void Main()
        {

            string entry;

            string[] stringArray = new string[4]; // Creating a new array of length 4
            // Adding strings to the array
            stringArray[0] = "This is the first string";
            stringArray[1] = "This is the second string";
            stringArray[2] = "This is the third string";
            stringArray[3] = "This is the fourth string";

            int[] intArray = new int[4];
            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;
            intArray[3] = 4;

            List<string> stringList = new List<string>();
            stringList.Add("This is the first string");
            stringList.Add("This is the second string");
            stringList.Add("This is the third string");
            stringList.Add("This is the fourth string");

            Console.WriteLine("Enter any number from 0 to " + (stringArray.Length - 1) + ":\n"); // Asking the user to choose a number from 0 to one less than the length of the array because index starts from 0
            entry = Console.ReadLine(); // Get user input
            // Using a try catch statement to ensure the program continues even if an error is thrown
            try
            {
                Console.WriteLine(stringArray[Convert.ToInt32(entry)]); // Converting user entry to integer as an index and printing the string at that index in stringArray
            }
            catch
            {
                Console.WriteLine("The entry you submitted is either out of range or not an integer...\n");
            }

            Console.WriteLine("Enter any number from 0 to " + (intArray.Length - 1) + ":\n");
            entry = Console.ReadLine();
            try
            {
                Console.WriteLine(intArray[Convert.ToInt32(entry)]); // Converting user entry to integer as an index and printing the integer at that index in intArray
            }
            catch
            {
                Console.WriteLine("The entry you submitted is either out of range or not an integer...");
            }

            Console.WriteLine("Enter any number from 0 to " + (stringList.Count - 1) + ":\n");
            entry = Console.ReadLine();
            try
            {
                Console.WriteLine(stringList[Convert.ToInt32(entry)]); // Converting user entry to integer as an index and printing the string at that index in stringList
            }
            catch
            {
                Console.WriteLine("The entry you submitted is either out of range or not an integer...");
            }

            Console.Read(); // Wait for user input to close program
        }
    }
}
