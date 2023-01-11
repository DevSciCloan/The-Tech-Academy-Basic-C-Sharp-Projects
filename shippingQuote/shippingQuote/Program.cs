using System;


namespace shippingQuote
{
    class Program
    {
        static void Main()
        {
            // Initializing required variables
            int weight;
            int width;
            int height;
            int length;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            Console.WriteLine("Enter package weight: \n");
            weight = Convert.ToInt32(Console.ReadLine()); // Collecting user input for weight as an integer

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Enter package width: \n");
                width = Convert.ToInt32(Console.ReadLine()); // Collecting user input for width as an integer

                Console.WriteLine("Enter package height: \n");
                height = Convert.ToInt32(Console.ReadLine()); // Collecting user input for height as an integer

                Console.WriteLine("Enter package length: \n");
                length = Convert.ToInt32(Console.ReadLine()); // Collecting user input for length as an integer
                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express."); // Writing error message to console if the sum of the dimensions is greater than 50
                }
                else
                {
                    Console.WriteLine("Quote: \n$" + (decimal)(((height * width * length) * weight) / 100) + "\nThank you!"); // Writing the quote to the console. The quote is calculated by the volume times the weight divided by 100
                }
            }
            Console.Read();
        }
    }
}
