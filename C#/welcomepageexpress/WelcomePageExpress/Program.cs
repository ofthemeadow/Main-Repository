using System;

namespace WelcomePageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();
            Console.WriteLine("Please enter the package weight:");
            int packageWe = Convert.ToInt32(Console.ReadLine());
            if (packageWe > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package express. Have a good day.");
            }
            else if (packageWe < 50)
            {
                Console.WriteLine("Please enter the package width:");
                int packageWi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int packageH = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int packageL = Convert.ToInt32(Console.ReadLine());
                int dimensions = packageH * packageL * packageWi;
                if (dimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped vi Packaging.");
                }
                else if (dimensions <= 50)
                {
                    int mass = dimensions * packageWe;
                    int dollAmount = mass % 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " + dollAmount + "Thank you.");
                    Console.ReadLine();

                }
            }
        }
    }
}
