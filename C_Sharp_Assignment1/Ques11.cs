using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment1
{
    internal class Ques11
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i =1 ;i<= 20;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
            }
        }
    }
}
