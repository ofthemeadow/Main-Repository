using System;

namespace welcomepage_express
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();
            Console.WriteLine("Please enter the package weight:");
            int packageWe = Convert.ToInt32(Console.ReadLine());
            if (packageWe >50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package express. Have a good day.");
            }
            Console.WriteLine("Please enter the package width:");
            int packageWi = Convert.ToInt32(Console.ReadLine());
            if (packageWi > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package express. Have a good day.");
            }
            Console.WriteLine("Please enter the package height:");
            int packageH = Convert.ToInt32(Console.ReadLine());
            if (packageH > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package express. Have a good day.");
            }
            Console.WriteLine("Please enter the package length:");
            int packageL = Convert.ToInt32(Console.ReadLine());
            if (packageL > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package express. Have a good day.");
            }
            int dimensions = packageH * packageL * packageWi * packageWe;
            Console.WriteLine("Your estimated total for shipping this package is: " + + "Thank you.");
            Console.ReadLine();
        }
    }
}
