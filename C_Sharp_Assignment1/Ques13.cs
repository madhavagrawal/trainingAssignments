using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment1
{
    internal class Ques13
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            a=Math.Max(a,b);
            a=Math.Max(a,c);
            Console.WriteLine(a);
        }
    }
}
