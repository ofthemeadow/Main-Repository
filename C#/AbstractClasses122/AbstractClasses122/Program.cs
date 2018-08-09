using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses122
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee fullname = new Employee();
            IQuittable justQuitIt = new Employee();
            fullname.firstName = "Sample ";
            fullname.lastName = "Student ";
            fullname.SayName();
            fullname.Quit();

            Console.ReadLine();


        }
    }
}
