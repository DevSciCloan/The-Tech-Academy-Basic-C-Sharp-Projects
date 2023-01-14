using System;
using System.Collections.Generic;
using System.Linq;

namespace mainMethod
{
    class Program
    {
        static void Main()
        {
            myClass myClass = new myClass(); // Instantiating a new object of class myClass

            Console.WriteLine("Passing int 16: \n" + myClass.myMethod(16));
            Console.WriteLine("Passing decimal 16.9: \n" + myClass.myMethod((decimal)16.90));
            Console.WriteLine("Passing string 15: \n" + myClass.myMethod("15"));

            Console.Read(); // Waiting for user input to close program
        }
    }

    // Creating myClass with three methods that have the same name
    class myClass
    {
        // Passing in an integer, subtracting it by 10, and returning the new value as an integer
        public int mytMethod(int number)
        {
            int newNumber = number - 10;
            return newNumber;
        }

        // Passing in a decimal number, dividing the number by 3, converting the decimal to an integer, and returning the integer
        public int myMethod(decimal number)
        {
            int newNumber = Convert.ToInt32(number / 3);
            return newNumber;
        }

        // Taking in a string, converting the string to an integer if possible, multiplying the number by 2, and returning the newNumber. Otherwise, write error message to console and return 0
        public int myMethod(string number)
        {
            try
            {
                int newNumber = Convert.ToInt32(number);
                newNumber = newNumber * 2;
                return newNumber;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + " Returning a 0.");
            }
            return 0;
        }
    }
}

