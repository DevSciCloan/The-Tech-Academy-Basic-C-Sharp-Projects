using System;


namespace carInsurance
{
    class Program
    {
        static void Main()
        {
            // Instantiating required variables
            bool oldEnough;
            bool hasDUI;
            int tickets;

            // Collecting client information
            Console.WriteLine("What is your age?");
            oldEnough = Convert.ToInt32(Console.ReadLine()) > 15; // Getting user age and converting string input to int before testing if the result is > 15. Then storing result as bool in oldEnough
            Console.WriteLine("Have you ever had a DUI? (\"yes\" or \"no\")");
            hasDUI = Console.ReadLine() == "yes" ? true : false; // Getting user input as string and converting to bool using ternary operator
            Console.WriteLine("How many speeding tickets do you have?");
            tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Client is eligible: \n" + (oldEnough && !hasDUI && tickets <= 3)); // Are all three conditions in parentheses met? If True print true else false

            Console.Read(); // Waiting for user input before closing program
        }
    }
}
