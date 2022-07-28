using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic_Assignment
{
    internal class Ques2
    {
        static void Main()
        {
            List<string> l = new List<string>();
            for(int i = 0; i < 5; i++)
            {
                l.Add(Console.ReadLine());
            }

            l.Sort();
            l.Reverse();
            foreach(string s in l)
            {
                Console.WriteLine(s);
            }

        }
    }
}
