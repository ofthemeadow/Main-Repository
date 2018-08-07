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
            Console.WriteLine("Give me a whole number and I'll subtract 12 from it.");
            newIntegerMethods.math101(Convert.ToInt32(Console.ReadLine()), 12);

            Console.WriteLine("Give me another number and I'll multiply it the number of centimeters in an inch: 2.54.");
            newIntegerMethods.math101(Convert.ToDouble(Console.ReadLine()), 2.54);

            Console.WriteLine("Give me one more number and I'll add it to 13.");
            newIntegerMethods.math101(Convert.ToString(Console.ReadLine()), Convert.ToString(13));
            Console.Read();
        }
    }
}
