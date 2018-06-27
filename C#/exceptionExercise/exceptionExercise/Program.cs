using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionExercise
{
    class Program
    {
        public static bool quotientRemainder { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("I have five numbers: 16, 31, 52, 29 and 24. \n\tGive me a number and I'll divide my list of numbers by it.");
            var myList = new List<int> (new int[]{16, 31, 52, 29, 24});
            foreach (int numero in myList)
            {
                try
                {
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    int quotientRemainder = numero / userNumber;
                    Console.WriteLine("Done. How about...");
                    Console.WriteLine(quotientRemainder);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("That decimal is not going to work.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please pick a different number other than zero.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
