using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayNameEx119
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee fullname = new Employee();
            fullname.FirstName = "Sample ";
            fullname.LastName = "Student ";
            fullname.SayName();
            Console.Read();
        }
    }
}
