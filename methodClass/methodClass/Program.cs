using System;

namespace methodClass
{
    class Program
    {
        static void Main()
        {
            myClass myClass = new myClass(); // Creating new instance of myClass
            myClass.myMethod(2, 5); // Calling myMethod and passing in two integers
            myClass.myMethod(one: 2, two: 5); // Calling myMethod and passing in named parameters
            Console.Read(); // Waiting for user input before closing program
        }
    }

    class myClass
    {
        public static void myMethod(int one, int two)
        {
            int sum = one + 5; // adding 5 to var one and saving in var sum
            Console.WriteLine(two + "\n"); // Printing two with a new line after it
        }
    }
}
