using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Program
    {
        static void Main(string[] args)
        { 
            bool successFlag = false;
            while (successFlag == false)
            {
                try
                {
                    Console.WriteLine("What is the current day of the week?");
                    var userDay = Console.ReadLine();
                    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userDay);
                    Console.WriteLine("{0} is a good day", day.ToString());
                    successFlag = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            Console.ReadLine();
        }
        public enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
            
        }
    }
}
