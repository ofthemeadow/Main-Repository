using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _154Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number to log.");
            string userNumber = Console.ReadLine();
            File.WriteAllText(@"C:\Users\srdp8\Documents\log.txt", userNumber);
            File.ReadAllText(@"C:\Users\srdp8\Documents\log.txt");
            Console.WriteLine(userNumber);
            Console.Read();
        }
    }
}
