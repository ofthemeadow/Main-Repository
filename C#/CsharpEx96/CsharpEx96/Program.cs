using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEx96
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string fname = Convert.ToString(Console.ReadLine());

            Console.WriteLine("What is your last name?");
            string lname = Convert.ToString(Console.ReadLine());

            Console.WriteLine("What is your favourite colour?");
            string fcolour = Convert.ToString(Console.ReadLine());
            fcolour = fcolour.ToUpper();

            Console.WriteLine("Thank you " + fname +" " + lname + " for telling me that " + fcolour + " is your favourite colour.");

            StringBuilder warning = new StringBuilder();
            warning.Append("That is my favourite too! ");
            warning.Append("We have so much in common. ");
            warning.Append("Lets get drinks and talk about them all.");

            Console.WriteLine(warning);
            Console.Read();
        }
    }
}
