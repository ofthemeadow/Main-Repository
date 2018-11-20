using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _155dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);
            Console.WriteLine("Give me a number. \n\tI will give you the time it will be. \nX being the number of hours added to current time.");
            DateTime newHourDateTime = currentDateTime.AddHours(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(newHourDateTime);
            Console.Read();
        }
    }
}
