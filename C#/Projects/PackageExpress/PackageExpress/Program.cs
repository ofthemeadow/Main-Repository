using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int we = Convert.ToInt32(Console.ReadLine());
            if (we > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
            }
            else if (we <= 50)
            {
                Console.WriteLine("Please enter the package width:");
                int wi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int h = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int l = Convert.ToInt32(Console.ReadLine());

                var total = wi * h * l;
                if (total > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else if (total <= 50)
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + total);
                }
            }             
            Console.ReadLine();
        }
    }
}
