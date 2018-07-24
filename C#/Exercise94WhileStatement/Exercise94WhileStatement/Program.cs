using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise94WhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my \"bool while\" solution: \n\tWhat is the word that I am thinking of \n\tthat uses the letters: T, C, A.");
            string word = Convert.ToString(Console.ReadLine());
            bool wordGuessed = word == "CAT";
            while (!wordGuessed)
            {
                switch (word)
                {
                    case "tac":
                        Console.WriteLine("Sadly it's ont the word \"tac\". ");
                        word = Convert.ToString(Console.ReadLine());
                        break;
                    case "tca":
                        Console.WriteLine("I'm pretty sure it's not tca???");
                        word = Convert.ToString(Console.ReadLine());
                        break;
                    case "cta":
                        Console.WriteLine("That is not a word....");
                        word = Convert.ToString(Console.ReadLine());
                        break;
                    case "atc":
                        Console.WriteLine("I don't think that is a real word?");
                        word = Convert.ToString(Console.ReadLine());
                        break;
                    case "act":
                        Console.WriteLine("It is far from an act.");
                        word = Convert.ToString(Console.ReadLine());
                        break;
                    case "cat":
                        Console.WriteLine("That is it! meow \n\tCongratulations!");
                        wordGuessed = true;
                        break;
                    default:
                        Console.WriteLine("I said with the letters: t, c, a");
                        Console.WriteLine("Try again goober.");
                        word = Convert.ToString(Console.ReadLine());
                        break;
                }
            }
            Console.Read();

            Console.WriteLine("This is my \"bool do while\" solution: \n\tNow I am thinking of a three letter word between the words: \"BAT\" & \"DOG\".");
            string word2 = Convert.ToString(Console.ReadLine());
            bool wordGuessed2 = word2 == "CAT";

            do
            {
                switch (word2)
                {
                    case "COD":
                        Console.WriteLine("It's not cod like the fish.");
                        word2 = Convert.ToString(Console.ReadLine());
                        break;
                    case "CAM":
                        Console.WriteLine("Cam is short for CAMERA, it's not what I'm thinking of though.");
                        word2 = Convert.ToString(Console.ReadLine());
                        break;
                    case "CAT":
                        Console.WriteLine("Haha. Yea, it is CAT again.");
                        wordGuessed2 = true;
                        break;
                    default:
                        Console.WriteLine("Keep guessing.");
                        word2 = Convert.ToString(Console.ReadLine());
                        break;
                }
            }
            while (!wordGuessed2);
            Console.Read();
        }
    }
}
