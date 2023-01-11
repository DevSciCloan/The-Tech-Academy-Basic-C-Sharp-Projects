using System;

namespace dailyReport.cs
{
    class Program
    {
        static void Main()
        {
            // Instantiating the variables we need.
            string studentName;
            string currentCourse;
            int currentPage;
            bool needsHelp;
            string positiveExperiences;
            string feedback;
            int hoursStudied;

            Console.WriteLine("The Tech Academy.\n"); // Writes string to console
            Console.WriteLine("Student Daily Report.\n"); // Writes string to console

            Console.WriteLine("What is your name?\n");// Writes string to console
            studentName = Console.ReadLine(); // Reads string and stores in a string variable

            Console.WriteLine("What course are you on?\n");// Writes string to console
            currentCourse = Console.ReadLine();// Reads string and stores in a string variable

            Console.WriteLine("What page number?\n");// Writes string to console
            currentPage = Convert.ToInt32(Console.ReadLine()); // Reads a string and converts to integer before storing in currentPage

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"\n");// Writes string to console
            needsHelp = Convert.ToBoolean(Console.ReadLine()); // Reads a string and converts to bool before storing in needsHelp

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.\n");// Writes string to console
            positiveExperiences = Console.ReadLine();// Reads string and stores in a string variable

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.\n");// Writes string to console
            feedback = Console.ReadLine();// Reads string and stores in a string variable

            Console.WriteLine("How many hours did you study today?\n");// Writes string to console
            hoursStudied = Convert.ToInt32(Console.ReadLine()); // Reads a string and converts to integer before storing in hoursStudied

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!"); // Closing thank you message that is written in the console.
            Console.Read();
        }
    }
}
