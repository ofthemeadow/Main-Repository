using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses122
{
    public abstract class Person //abstract means nothing will change or needs to be manipulated, final
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);
        }
    }
}
