using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses122
{
    public class Employee : Person
    {
        public new void SayName()
        {
            base.SayName();
        }
    }
}
