using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment1
{
    internal class Ques10
    {
        static void Main()
        {
            double d = double.Parse(Console.ReadLine());
            double ans = 0;
            for(int i = 5; i <= d; i++)
            {
                ans += (i * i * i);
            }
            Console.WriteLine(ans);
        }
    }
}
