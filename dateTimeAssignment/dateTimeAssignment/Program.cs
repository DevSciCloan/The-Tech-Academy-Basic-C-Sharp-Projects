using System;

namespace dateTimeAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now.ToString("f")); // Writes the current date and time to the console in standard date and time format f

            Console.WriteLine("Please enter a number: \n"); // Prompts user to enter a number

            // Gets current date and time from user's computer,
            // reads user input and converts to integer,
            // passes the integer into AddHours() and formats the returned DateTime object to format f using ToString,
            // Writes the final formatted string to the console
            Console.WriteLine((DateTime.Now.AddHours(Convert.ToInt32(Console.ReadLine()))).ToString("f")); 

            Console.Read(); // Waits for user input before closing the program
        }
    }
}
