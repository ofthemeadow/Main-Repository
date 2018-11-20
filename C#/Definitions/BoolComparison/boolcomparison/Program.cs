using System;

namespace boolcomparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess what number I am thinking of between 1 and 10.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool numberGuessed = number == 7;

            do
            {
                switch (number)
                {
                    case 3:
                        Console.WriteLine("Pick a different number.");
                        Console.WriteLine("I said a number between 1-10. Give me another one.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 1:
                        Console.WriteLine("That isn't the number I was thinking");
                        Console.WriteLine("1 seems like a number I would think of. Too bad it isn't it though. Try another one.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 7:
                        Console.WriteLine("YOU GOT IT!");
                        numberGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Nope, not it.");
                        Console.WriteLine("Keep guessing.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!numberGuessed);
            Console.ReadLine();

            Console.WriteLine("Now pick a number between 13 and 31 and I'll tell you if it's a good one or not.");
            int number2 = Convert.ToInt32(Console.ReadLine());
            bool numberGuessed2 = number2 == 7;


            while (!numberGuessed2)
            {
                switch (number2)
                {
                    case 13:
                        Console.WriteLine("13? Well, thats an unlucky number.");
                        Console.WriteLine("Pick a different number.");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 21:
                        Console.WriteLine("Thats the legal age to drink.");
                        Console.WriteLine("Too bad it's not the good number I'm thinking about.");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 31:
                        Console.WriteLine("That IS a good number because it's my age.");
                        numberGuessed2 = true;
                        break;
                    default:
                        Console.WriteLine("Nope.");
                        Console.WriteLine("Pick a different one.");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.Read();
        }
    }
}