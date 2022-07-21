using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment1
{
    internal class Ques14
    {
        static void Main()
        {
            int[] n = new int[5];
            int ans = Int32.MaxValue;
            for(int i=0;i<5;i++)
            {
                n[i] =int.Parse(Console.ReadLine());
                if (n[i] < ans)
                    ans = n[i];
            }
            Console.WriteLine(ans);

        }
    }
}
