using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Ques1
    {
        static void Main()
        {
            Console.WriteLine("Enter Amount You Owe= ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Monthly Payment = ");
            int n=int.Parse(Console.ReadLine());
            int totalPayments = 0;
            for(int i=0;m>=0;i++)
            {
                double temp = (m+(0.015*m))-n;
                totalPayments += n;
                Console.WriteLine("Month {0} balance : {1} total Payments: {2}" , i + 1,temp,totalPayments);
                m = temp;

            }
        }
    }
}
