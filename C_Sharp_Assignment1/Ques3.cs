using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment1
{
    internal class Ques3
    {
        static void Main()
        {
            Console.WriteLine("Enter 1st no.");
            int n1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1st no.");
            int n2 = int.Parse(Console.ReadLine());
            for(int n=n1+1;n<n2;n++)
            {
                Console.WriteLine(n);
            }
        }
    }
}
