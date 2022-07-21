using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Ques3
    {
        static int Func(int a,int b)
        {
            return a + b;
        }
        static void Main()
        {
            //Program program = new Program();
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int ans =Func(a, b);
            Console.WriteLine(ans);
        }
    }
}
