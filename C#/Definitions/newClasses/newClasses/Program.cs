using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace newClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Give me a whole number to add to 31.");
            MatheOperations.Add(Convert.ToInt32(Console.ReadLine()), 31); 

            Console.WriteLine("Give me a whole number and I'll subtract 28 from it.");
            MatheOperations.Sub(Convert.ToInt32(Console.ReadLine()), 28);

            Console.WriteLine("Give me a whole number and I'll multiply it by 23.");
            MatheOperations.Multiply(Convert.ToInt32(Console.ReadLine()), 23);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("That decimal/character is not going to work.");
                Console.ReadLine();
            }
        }
    }
}
