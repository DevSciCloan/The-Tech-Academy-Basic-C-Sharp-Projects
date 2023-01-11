using System;


namespace opertaions.cs
{
    class Program
    {
        static void Main()
        {
            long userInputInt; // Instantiate userInput as type long

            Console.WriteLine("Enter an integer."); // Tell user to enter an integer

            userInputInt = Convert.ToInt64(Console.ReadLine()); // Takes user input as string and converts to 64 bit integer. Stores result in userInput

            Console.WriteLine("Multiply by 50: " + userInputInt*50); // Multiply userInput by 50 and write result to console
            Console.WriteLine("Add 25: " + (userInputInt+25)); // Add 25 to userInput and write result to console
            Console.WriteLine("Divide by 12.5: " + (float)userInputInt/12.5); // Divide userInput by 12.5 cast to float and write result to console
            Console.WriteLine("Greater than 50: " + (userInputInt>50).ToString()); // Check if userInput is greater than 50, convert bool result to string and write result to console
            Console.WriteLine("Divide by 7 and show remainder: " + userInputInt%7); // Perform modulus 7 on userInput and write result to console
            Console.Read(); // Wait for user input before closing 
        }
    }
}
