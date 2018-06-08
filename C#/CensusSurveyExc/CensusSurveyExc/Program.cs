using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the U.S. Census Survey");
            Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours of television do you watch per day?");
                float hoursOfTv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your annual salary?");
                decimal annualSalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are you married? Please anser 'true' or 'false'.");
                bool isMarried = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("What is your favourite type of donut ?");
                string favouriteDonut = Convert.ToString(Console.ReadKey());
            Console.WriteLine("Thank you for your answers! Have a good day.");
            Console.ReadLine();
        }
    }
}
