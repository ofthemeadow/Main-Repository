using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEx63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two numbers and I'll multiply them together.");
            ClassMath.Mult(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
        }
    }
}
