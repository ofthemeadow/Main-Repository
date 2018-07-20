using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEx66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number to divide by 2.");
            Class1.Div(Convert.ToInt32(Console.ReadLine()), 2);
        }
    }
}
