using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses122
{
    class Program
    {
        public static object num1 { get; private set; }

        static void Main(string[] args)
        {
            Employee fullname = new Employee();
            IQuittable justQuitIt = new Employee();
            fullname.firstName = "Sample ";
            fullname.lastName = "Student ";
            fullname.SayName();
            fullname.Quit();

            if (num1 == num1)
            {
                Console.WriteLine("The two employees share the same Employee ID Number.");
            }

            Console.ReadLine();


        }
    }
}
