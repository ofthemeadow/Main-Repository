using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 2. 3. & 4.
            Console.WriteLine("Type a place.");
            string[] animalArray = new string[]
                { "monkey", "fox", "panda", "penguin" };
            string userInput = Console.ReadLine();

            for (int i = 0; i < animalArray.Length; i++)
            {
                Console.WriteLine("The " + animalArray[i] + " went to the " + userInput);
                Console.ReadLine();
            }

            //5.
            Console.WriteLine("Next, is my loop comparison using the <= operator.");
            for (char h = 'a'; h <= 'z'; h++)
            {
                Console.WriteLine(h);
            }

            //6. 7. 8. 9. 10.
            Console.WriteLine("Please type in a primary colour.");
            string userInput2 = Console.ReadLine();
            List<string> colours = new List<string>()
                { "blue", "red", "yellow", "red"};
            bool itemInList = false;
            for (int c = 0; c < colours.Count(); c++)
            {

                if (userInput2 == colours.ElementAt(c))
                {
                    Console.WriteLine(c);
                    Console.WriteLine(colours.ElementAt(c));
                    itemInList = true;
                }

            }
            if (itemInList == false)
            {
                Console.WriteLine("That is not a Primary colour.");
            }
            Console.ReadLine();

            //11.

            List<string> pokemon = new List<string>()
                { "Charmander","Pikachu","Squirtle","Bulbasaur","Weedle","Meowth","Pikachu","Jigglypuff"};
            pokemon.Sort();
            for(int i = 0; i <= pokemon.Count - 1; i++)
            {
                Console.WriteLine(pokemon[i]);
            }
            Console.WriteLine("------------------------------");
                for (int i = 1; i <= pokemon.Count-1; i++)
            {
                if (pokemon[i].ToString() == pokemon[i - 1].ToString())
                {
                    Console.WriteLine("Duplicate: " + pokemon[i]);
                }
            }
            Console.Read();
        }
    }
}
