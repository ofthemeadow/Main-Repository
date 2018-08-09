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
            IQuittable justQuitIt = new Employee<string>();

            Employee<string> fullname = new Employee<string>();
            fullname.firstName = "Sample ";
            fullname.lastName = "Student ";
            fullname.SayName();
            fullname.Quit();

            Employee<string> DoB = new Employee<string>();
            DoB.Things.Add("12.27.86");
            foreach (Employee<string> date in (dynamic)DoB)
            {
                Console.WriteLine("Birthdate is: " + date);
            }

            Employee<int> favNum = new Employee<int>();
            favNum.Things.Add(7);
            foreach (Employee<int> numeroUno in (dynamic)favNum)
            {
                Console.WriteLine("Favourite number is: " + numeroUno);
            }
            
            if (num1 == num1)
            {
                Console.WriteLine("The two employees share the same Employee ID Number.");
            }

            Console.ReadLine();


        }
    }
}
