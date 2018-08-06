using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number and I'll divide it by two.");
            DivideTwo.Div(Convert.ToInt32(Console.ReadLine()), 2);
            Console.Read();
        }
    }
}
