using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment1
{
    internal class Ques8
    {
        static void Main()
        {
            Console.WriteLine("Enter no to find factorial");
            int n=int.Parse(Console.ReadLine());
            int ans = 1;
            for(int i=1;i<=n;i++)
            {
                ans = ans * i;
            }
            Console.WriteLine(ans); 
        }
    }
}
