using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _165Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for their age.
            Console.WriteLine("What is your age?");

            //3. Exceptions must be handled using "try/catch"
            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine());
                if(userAge > 0)
                {
                    DateTime currentDateTime = DateTime.Now;
                    int year = currentDateTime.Year;
                    int yearBorn = Convert.ToInt32(year - userAge -1);

                    //2. Display the user's birth year.
                    Console.WriteLine("You were born in: " + yearBorn);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            //4. Display appropriate error messages if user enters zero or negative numbers.
            catch (FormatException)
            {
                Console.WriteLine("Please use whole numbers. Not decimals, letters or special characters.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please pick a number greater than zero.");
            }

            //5. Display a general message if exception caused by anything else.
            catch (Exception)
            {
                Console.WriteLine("Please read the instructions carefully");
            }
            Console.Read();
        }
    }
}