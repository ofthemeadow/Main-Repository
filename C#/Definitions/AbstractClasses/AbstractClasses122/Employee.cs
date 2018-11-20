using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses122
{
    public class Employee<T> : Person, IQuittable
    {
        public List<T> Things { get; set;}

        public static void Id(int num1)
        {
            throw new NotImplementedException();
        }
        public new void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
