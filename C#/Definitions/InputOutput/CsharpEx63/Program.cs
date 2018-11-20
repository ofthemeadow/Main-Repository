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
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            ClassMath.Mult(Convert.ToInt32(input1), Convert.ToInt32(input2), out int good);
            Console.WriteLine("Second variable: " + input2);
            Console.WriteLine(good);
            Console.Read();
        }
    }

}
