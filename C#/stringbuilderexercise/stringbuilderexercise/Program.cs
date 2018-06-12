using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilderexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string lName = "del Prado ";
            string fName = "Steffan ";
            string quote = "My name is ";
            string concatenate = quote + fName + lName;

            concatenate = concatenate.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append("I have lived in PDX for five years now. ");
            sb.Append("\n \t PDX is my new home. ");
            sb.Append("\nThank you.");

            Console.WriteLine(concatenate);
            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
