using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class DivideTwo
    {
        public static void Div(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
        public static void Div(double num1, int num2)
        {
            Console.WriteLine(num1 / num2 );
        }
    }
}
