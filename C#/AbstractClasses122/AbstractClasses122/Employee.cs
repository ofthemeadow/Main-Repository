using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses122
{
    public class Employee : Person, IQuittable
    {
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
