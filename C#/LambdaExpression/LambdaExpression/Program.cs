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
            string[] lName =
            {
                "Moulett", "Schneider", "Espinoza", "Kardigay", "Erb",
                "Campbell", "Rodriquez", "Mercado", "Paris",
                "Graves"
            };
            int[] id =
            {
                1566510, 1566511, 1566512, 1566513, 1566514,
                1566515, 1566516, 1566517, 1566518, 1566519,
            };
            int i = 0;
            //string employee = fName.ToString() + lName + id;
            foreach (string sameName in fName)
            {
                if (sameName == "Joe")
                {
                    Console.WriteLine(sameName.ToString());
                    Console.WriteLine(lName[i].ToString());
                    Console.WriteLine(id[i]);
                    Console.ReadLine();
                }
                i++;
            }
        }
    }
}
