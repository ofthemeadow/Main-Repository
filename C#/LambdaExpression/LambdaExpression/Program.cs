using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main()
        {
            List<string> fName = new List<string>(new string[]
            {
                "Joe", "Mary-Laura", "Christian", "Shayfer", "Fred",
                "Wendy", "Joe", "Gabby", "Jill", "Mike"
            });
            List<string> lName = new List<string>(new string[]
            {
                "Moulett", "Schneider", "Espinoza", "Kardigay", "Erb",
                "Campbell", "Rodriquez", "Mercado", "Paris",
                "Graves"
            });
            List<int> id = new List<int>(new int[]
            {
                1566510, 1566511, 1566512, 1566513, 1566514,
                1566515, 1566516, 1566517, 1566518, 1566519,
            });
            List<string> joeIndex = new List<string> { };
            int i = 0;
            foreach (string sameName in fName)
            {
                if (sameName == "Joe")
                {
                    joeIndex.Add(sameName);
                    joeIndex.Add(lName[i]);
                    joeIndex.Add(id[i].ToString());
                }
                i++;
            }
            foreach (string name in joeIndex)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            //3. Do the same thing again, but this time with a lambda expression.//

            IEnumerable<string> joeIndex2 = fName.Where(j => j == "Joe");
            foreach (string name2 in joeIndex2)
            {
                Console.WriteLine(name2);
            }
            Console.ReadLine();

            //4. Using a lambda expression, make a list of all employees
            //  with an Id number greater than 5.

            IEnumerable<int> employeeId = id.Where(a => a > 5);
            foreach (int idGreaterThan5 in id)
            {
                Console.WriteLine(idGreaterThan5);
            }
            Console.ReadLine();
        }
    }
}
