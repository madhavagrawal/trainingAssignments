using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic_Assignment
{
    internal class Ques1
    {

        static void Main()
        {
            List<int> l = new List<int>();
            for(int i=0;i<10;i++)
            {
                l.Add(int.Parse(Console.ReadLine()));
            }
            l.Sort();
            foreach(int i in l)
            {
                Console.WriteLine(i);
            }
        }

    }
}
