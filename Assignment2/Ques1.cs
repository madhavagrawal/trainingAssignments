using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Ques1
    {
        static void Main()
        {
            double amount = 1000;
            int time = 0;
            while(amount <=100000)
            {
                time++;
                amount = 1.05 * amount;
            }
            Console.WriteLine(time);
        }
    }
}
