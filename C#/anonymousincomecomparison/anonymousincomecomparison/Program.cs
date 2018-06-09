using System;

namespace anonymousincomecomparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
                int HR1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
                int HperW1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate");
                int HR2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
                int HperW2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual salary of Person 1");
            int AS1 = HR1 * HperW1;
            Console.WriteLine(AS1);
            Console.WriteLine("Annual salary of Person 2");
            int AS2 = HR2 * HperW2;
            Console.WriteLine(AS2);
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalso = AS1 > AS2;
            Console.WriteLine(trueOrFalso);
            Console.ReadLine();
        }
    }
}
