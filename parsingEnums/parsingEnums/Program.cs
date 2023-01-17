using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parsingEnums
{
    

    class Program
    {
        enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main()
        {


            Console.WriteLine("Please enter the current day of the week:\n");

            // Try to read the next line from user input and Parse the string that is input by the user to enum Week. Also ignore case when attempting to Parse.
            try 
            {
                Week today = (Week)Enum.Parse(typeof(Week), Console.ReadLine(), true); // Cast returned string from method Parse to enum Week and store in variable today of type Week


            } 
            // If the user input does not exist in enum Week then write an error message to the console
            catch (Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.Read(); // Wait for user input before closing the program
        }
    }
}
