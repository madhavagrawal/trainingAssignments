using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Assignment
{

    interface iinter
    {
        public int YearSalesValue();
    }

    abstract public class sal
    {
        public abstract int MonthlySalesvalue(int DailySalesValue);

        public int DailySalesValue()
        {
            return 400;
        }

    }



    internal class Ques4 : sal , iinter
    { 
            public override int MonthlySalesvalue(int DailySalesValue)
            {
                return 12000;

            }
            public int YearSalesValue()
            {
                return 144000;
            }

            static void Main()
            {
                Ques4 s = new Ques4();
                Console.WriteLine($"Monthly Sales Value : {s.MonthlySalesvalue(400)}");
                Console.WriteLine($"Daily Sales Value : {s.DailySalesValue()}");
                Console.WriteLine($"Year Sales Value : {s.YearSalesValue()}");
            }
    
     }
    }

    

