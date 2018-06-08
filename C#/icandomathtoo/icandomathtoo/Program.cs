using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number and I'll times it by 50.");
            int number1 = 50;
            int multiplyUser = Convert.ToInt32(Console.ReadLine());
            int product = number1 * multiplyUser;
            Console.WriteLine("It's.... " + product + "!!!");
            Console.ReadLine();

            Console.WriteLine("Pick a number and I'll just add 25 to it.");
            int number2 = 25;
            int addUser = Convert.ToInt32(Console.ReadLine());
            int combined = number2 + addUser;
            Console.WriteLine(combined + " BAM!");
            Console.ReadLine();

            Console.WriteLine("Now give me a number because I can divide it by 12.5.");
            double number3 = 12.5;
            double divideUser = Convert.ToInt32(Console.ReadLine());
            double quotient = divideUser / number3;
            Console.WriteLine(quotient + " is the answer I'll give you.");
            Console.ReadLine();


            Console.WriteLine("Give me a number and I'll tell you 'true' if it's greater than the one I'm thinking of.");
            int number4 = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = number4 >= 50;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();

            Console.WriteLine("One more time, give me another number. I'll divide it by 7.");
            int number5 = 7;
            int divideUser2 = Convert.ToInt32(Console.ReadLine());
            int quotient2 = divideUser2 % number5;
            Console.WriteLine("Your some number with a REMAINDER of " + quotient2);
            Console.ReadLine();
        }
    }
}
