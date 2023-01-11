using System;


namespace comparisonProgram
{
    // Creating Person class
    class Person
    {
        // Instantiating needed variables
        private decimal hourlyRate;
        private int weeklyHours;

        // Creating get method
        public decimal getRate()
        {
            return hourlyRate;
        }

        // Creating set method
        public void setRate(decimal rate)
        {
            hourlyRate = rate;
        }

        // Creating get method
        public int getWeekly()
        {
            return weeklyHours;
        }

        // Creating set method
        public void setWeekly(int hours)
        {
            weeklyHours = hours;
        }

        // Creating method to calculate salary if this Person works all 52 weeks out of the year.
        public decimal getSalary()
        {
            return this.getRate() * this.getWeekly() * 52;
        }

    }

    class Program
    {
        static void Main()
        {
            // Initializing person1 and person2 objects
            Person person1 = new Person();
            Person person2 = new Person();

            Console.WriteLine("Anonymous Income Comparison Program\n");

            // Requesting information for person1
            Console.WriteLine("Person 1\n");
            Console.WriteLine("Enter Hourly Rate (example: 12.50 or 12.00):\n");
            person1.setRate(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("\nEnter Weekly Hours:\n");
            person1.setWeekly(Convert.ToInt32(Console.ReadLine()));

            // Requesting information for person2
            Console.WriteLine("Person 2\n");
            Console.WriteLine("Enter Hourly Rate (example: 12.50 or 12.00):\n");
            person2.setRate(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("\nEnter Weekly Hours:\n");
            person2.setWeekly(Convert.ToInt32(Console.ReadLine()));

            // Printing salary information for person1 and person2
            Console.WriteLine("\nAnnual salary of Person 1:\n" + person1.getSalary() + "\n");
            Console.WriteLine("Annual salary of Person 2:\n" + person2.getSalary() + "\n");

            // Printing True or False resulting from comparing person1 salary greater than person2 salary
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + (person1.getSalary() > person2.getSalary()));

            // Waiting for user input to close program
            Console.ReadLine();
        }
    }

    
}
