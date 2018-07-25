using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a whole number and I'll subtract 40 from it.");
            newIntegerMethods.Sub(Convert.ToInt32(Console.ReadLine()), 40);

            Console.WriteLine("Give me another number and I'll multiply it the number of centimeters in an inch: 2.54.");
            newIntegerMethods.Mult(Convert.ToDouble(Console.ReadLine()), 2.54);

            Console.WriteLine("Give me one more number and I'll add it to 13.");
            newIntegerMethods.Add(Convert.ToInt32(Console.ReadLine()), 13);
            Console.Read();
        }
    }
}
