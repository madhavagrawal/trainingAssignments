using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment1
{
    internal class Ques5
    {
        static void Main()
        {
            Console.WriteLine("Enter total no. you want to enter = ");
            int n = int.Parse(Console.ReadLine());
            int odd_count = 0;
            int even_count = 0;
            while(n>0)
            {
                int no = int.Parse(Console.ReadLine());
                if(no%2 == 0)
                {
                    even_count++;
                }
                else
                    odd_count++;
                n--;
            }
            Console.WriteLine("Odd Count = " + odd_count);

            Console.WriteLine("even Count = " + even_count);

            
        }
    }
}
