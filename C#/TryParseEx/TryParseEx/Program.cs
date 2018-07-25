using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will take the product of the two numbers and add them together. \n\tIf you choose not to give me a second number then I'll just multiply the first number within itself.");

            Console.WriteLine("\nPlease give me the first number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nGive me another number. \n\tPress ENTER if you would rather not.");
            bool ifNotPicked = Int32.TryParse(Console.ReadLine(), out int num2);
            
            int result = MaybeSo.Mult(num1, num2);
            Console.WriteLine("Your answer is: " + result);

            Console.Read();
        }
    }
    public class MaybeSo
    {
        public static int Mult(int num1, int num2 = 0)
        {
            int results = (num1 * num1) + (num2 * num2);
            return results;
        }
    }
}
