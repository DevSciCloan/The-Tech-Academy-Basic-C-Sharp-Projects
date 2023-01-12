using System;
using System.Collections.Generic;
using System.Linq;

namespace consoleAppAssignment
{
    class Program
    {
        static void Main()
        {
            // Create stringArray with length 3
            string[] stringArray = new string[3];

            // Add "So... " to each index of stringArray
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = "So... ";
            }

            // Ask the user to input 3 sentences to append at each index one at a time
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("\nPlease input a sentence of your choosing.\n");
                stringArray[i] += Console.ReadLine();
            }

            // Print the new string at each index of stringArray
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i] + "\n");
            }

            // This loop was an infinite loop until I changed i-- to i++
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.ReadLine(); // Just to slow down the infinite looping to avoid crashing/freezing
            }

            // for loop using <
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(i); // Just printing i on each iteration
            }

            // for loop using <=
            for (int i = 0; i <= stringArray.Length; i++)
            {
                Console.WriteLine(i); // Just printing i on each iteration
            }

            // PART FOUR

            List<string> stringList = new List<string>(); // Creating new List of type string

            stringList.Add("Cat");
            stringList.Add("Dog");
            stringList.Add("Bird");
            stringList.Add("Lizard");
            stringList.Add("Snake");
            stringList.Add("Rabbit");
            stringList.Add("Horse");
            stringList.Add("Guinnea Pig");
            stringList.Add("Mouse");
            stringList.Add("Rat");
            stringList.Add("Spider");

            Console.WriteLine("\nEnter a animal type that could be a pet:\n");
            string query = Console.ReadLine(); // Reading user input

            int countExists = 0; // Initializing countExists to 0
            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i].ToUpper() == query.ToUpper()) // Using ToUpper to make sure the strings match case
                {
                    Console.WriteLine("Found at index: " + i);
                    countExists++; // Incrementing countExists by 1
                    continue; // If user input query is found in the list then exit the loop
                }
            }

            // If countExists is less than 1 then the query was not found in the list
            if (countExists < 1)
            {
                Console.WriteLine("Could not find anything matching your entry");
            }

            // PART FIVE

            List<string> stringList2 = new List<string>();

            stringList2.Add("Cat");
            stringList2.Add("Dog");
            stringList2.Add("Bird");
            stringList2.Add("Lizard");
            stringList2.Add("Snake");
            stringList2.Add("Rabbit");
            stringList2.Add("Horse");
            stringList2.Add("Guinnea Pig");
            stringList2.Add("Mouse");
            stringList2.Add("Rat");
            stringList2.Add("Spider");
            stringList2.Add("Mouse");
            stringList2.Add("Rat");
            stringList2.Add("Spider");

            Console.WriteLine("\nEnter a animal type that could be a pet:\n");
            query = Console.ReadLine();
            countExists = 0;
            for (int i = 0; i < stringList2.Count; i++)
            {
                if (stringList2[i].ToUpper() == query.ToUpper())
                {
                    Console.WriteLine("Found at index: " + i + "\n");
                    countExists++;
                }
            }

            if (countExists < 1)
            {
                Console.WriteLine("Could not find anything matching your entry");
            }

            // PART SIX

            List<string> stringList3 = new List<string>();

            stringList3.Add("Cat");
            stringList3.Add("Dog");
            stringList3.Add("Bird");
            stringList3.Add("Lizard");
            stringList3.Add("Snake");
            stringList3.Add("Rabbit");
            stringList3.Add("Horse");
            stringList3.Add("Guinnea Pig");
            stringList3.Add("Mouse");
            stringList3.Add("Rat");
            stringList3.Add("Spider");
            stringList3.Add("Mouse");
            stringList3.Add("Rat");
            stringList3.Add("Spider");

            List<string> duplicates = stringList3.GroupBy(x => x).SelectMany(g => g.Skip(1)).Distinct().ToList(); // filtering out the duplicates and saving them into a new list
            List<string> noDupes = stringList3.Distinct().ToList(); // filtering out the duplicates and saving what's left into a new string

            // Iterate through noDupes and print each
            foreach (string item in noDupes)
            {
                Console.WriteLine(item + " - is unique");
            }

            // Iterate through duplicates and print each
            foreach (string item in duplicates)
            {
                Console.WriteLine(item + " - is a duplicate");
            }

            Console.Read(); // Wait for user input to close program
        }
    }
}
