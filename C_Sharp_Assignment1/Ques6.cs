using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment1
{
    internal class Ques6
    {
        static void Main()
        {
            Console.WriteLine("Enter temp in F");
            float temp = float.Parse(Console.ReadLine());
            float temp2 = ((temp - 32) * 5) / 9;
            Console.WriteLine(temp2);
        }
    }
}
