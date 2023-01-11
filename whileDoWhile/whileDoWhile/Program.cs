using System;


namespace whileDoWhile
{
    class Program
    {
        static void Main()
        {
            // Initializing variables
            int userInput;
            Random randInt;
            int toGuess;
            bool correct = false;

            Console.WriteLine("While: \n");
            Console.WriteLine("Guess a number between and including 0 to 100: \n");
            randInt = new Random(); // Instantiating new instance of Random
            toGuess = randInt.Next(0, 101); // Generating a random integer between and including 0 to 100
            while (!correct)
            {
                userInput = Convert.ToInt32(Console.ReadLine()); // Reading user input and converting it to int
                if (toGuess == userInput) // Comparing userInput to the random integer stored in toGuess
                {
                    Console.WriteLine("Yay, you guessed the right number!\n");
                    correct = true;
                }
                else if (userInput < toGuess)
                {
                    Console.WriteLine("You guessed too low...\n");
                }
                else
                {
                    Console.WriteLine("You guessed too high...\n");
                }
            } // Program exits while loop if correct is set to true


            Console.WriteLine("Do While: \n");
            Console.WriteLine("Guess a number between and including 0 to 100: \n");
            do
            {
                userInput = Convert.ToInt32(Console.ReadLine()); // Getting user input again just like line 22
                if (toGuess == userInput) // toGuess is still the same number 
                {
                    Console.WriteLine("Yay, you guessed the right number!\n");
                    correct = true; // Setting correct to true since it will be false if the number is guessed wrong on the first iteration of the doWhile
                }
                else if (userInput < toGuess)
                {
                    Console.WriteLine("You guessed too low...\n");
                    correct = false; // Setting correct to false since it was true on the first iteration of this doWhile from the last while loop.
                }
                else
                {
                    Console.WriteLine("You guessed too high...\n");
                    correct = false; // Setting correct to false since it was true on the first iteration of this doWhile from the last while loop.
                }

            } while (!correct);
            Console.Read(); // Waiting for user input before exiting program
        }
    }
}
