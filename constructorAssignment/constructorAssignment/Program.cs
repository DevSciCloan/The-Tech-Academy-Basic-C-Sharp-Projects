using System;

namespace constructorAssignment
{
    class Program
    {
        static void Main()
        {
            var variable = "var Variable"; // Creating string variable with var type
            const string constant = "constant var"; // Creating constant string 

            var chain = new Chain(); // Instantiating new Chain object with no parameters
            var chain2 = new Chain(variable, constant); // Instantiating new Chain object with two string parameters and leaving the optional one out
            var chain3 = new Chain(1, 2); // Instantiating new Chain object with two integer parameters

            // Printing each chain object to display what we get using each of the three Chain class constructors 
            Console.WriteLine(chain.var1 + " " + chain.var2 + " " + chain.optional + " " + chain.var3 + " " + chain.var4 + "\n");
            Console.WriteLine(chain2.var1 + " " + chain2.var2 + " " + chain2.optional + "\n");
            Console.WriteLine(chain3.var3 + " " + chain3.var4 + "\n");

            Console.Read(); // Waiting for user input before closing the program
        }
    }

    class Chain
    {
        public string var1;
        public string var2;
        public string optional;
        public int var3;
        public int var4;

        public Chain() : this("test1", "test2", "test3")
        {
        }

        public Chain(string one, string two, string three = "test")
        {
            this.var1 = one;
            this.var2 = two;
            this.optional = three;
        }

        public Chain(int one, int two)
        {
            this.var3 = one;
            this.var4 = two;
        }
        
    }
}
