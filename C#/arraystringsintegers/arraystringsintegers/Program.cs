using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraystringsintegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an index number, \n\tbetween 0 and 5, \nI will gather and display the string at that string.");
            string[] spArray = new string[] { "one", "two", "three", "four", "five", "six" };
            int userNum = Convert.ToInt32(Console.ReadLine());
            if (userNum > 5)
                Console.WriteLine("You have selected an index number that does not exist.");
            Console.WriteLine(spArray[userNum]);
            Console.ReadLine();

            Console.WriteLine("Select an index number, \n\tbetween 0 and 5, \nI will gather and display the integer at that integer.");
            int[] numArray = new int[] { 47, 987, 56, 777, 23, 365 };
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            if (userNum2 > 5)
                Console.WriteLine("You have selected an index number that does not exist.");
            Console.WriteLine(numArray[userNum2]);
            Console.ReadLine();

            Console.WriteLine("Select an index number, \n\tbetween 0 and 5, \nI will gather and display it from my List.");
            List<string> mixArray = new List<string> { "I", "love", "my", "dog", "Curious", "Hendricks" };
            int userNum3 = Convert.ToInt32(Console.ReadLine());
            if (userNum3 > 5)
                Console.WriteLine("You have selected an index number that does not exist.");
            Console.WriteLine(mixArray[userNum3]);
            Console.ReadLine();
        }
    }
}
