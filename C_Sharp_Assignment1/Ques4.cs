using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment1
{
    internal class Ques4
    {
        static void Main()
        {
            int no = int.Parse(Console.ReadLine());
            if (no % 2 == 0)
            {
                Console.WriteLine("EVEN");
            }
            else
                Console.WriteLine("ODD");
        }
    }
}
