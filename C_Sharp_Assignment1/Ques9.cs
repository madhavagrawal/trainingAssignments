using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment1
{
    internal class Ques9
    {
        static void Main()
        {
            int n1 = 0;
            int n2 = 1;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            while(n1+n2<=40)
            {
                Console.WriteLine(n1+n2);
                int temp = n1;
                n1 = n2;
                n2 = temp + n2;
            }
            
        }
    }
}
