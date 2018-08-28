using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162Const
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a const variable
            const double Pi = 3.14;
            double area = Pi * 7 * 7;
            Console.WriteLine(area);


            // 2. Create a variable using the keyword "var"
            var a = "Steffan del Prado";
            Console.WriteLine(a);


            // 3. Chain two constructors together.
            Console.WriteLine("What is your first name?");
            var fname= Console.ReadLine();
            Console.WriteLine("What is your last name?");
            var lname= Console.ReadLine();
            Console.WriteLine("What is your favourite colour?");
            var favColor = Console.ReadLine();
            Person nPerson = new Person(fname, lname, favColor);
            Console.WriteLine(nPerson.fullname, nPerson.goodPerson);
            Console.Read();
        }
    }
    public class Person
    {
        public string fname;
        public string lname;
        public string fullname;
        public string favColor;
        public bool goodPerson;
        
        public Person(string fname, string lname, string favColor) //first constructor with three parameters
        {
            string fullName = fname + lname;
            this.fname = fname;
            this.lname = lname;
            this.favColor = favColor;
            if (favColor != "orange")
            {
                this.goodPerson = false;
            }
            else
            {
                this.goodPerson = true;
            }
        }

        public Person(string fname, string lname) : this(fname, lname,"orange") //chaining two constructors, inheriting from first constructor, giving a default value of orange, giving it three parameters to match
        {
            string fullName = fname + lname;
            this.fname = fname;
            this.lname = lname;
        }
    }

}
