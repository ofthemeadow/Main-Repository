using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEx64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two numbers and I'll subtract 1986 from the first number and display the second number.");
            Class64.Sub(Convert.ToInt32(Console.ReadLine()), 1986);
        }
    }
}
