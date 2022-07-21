using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Ques2_using_jagged
    {
        static void Main()
        {
            int[][] jg = new int[3][];
            for(int i = 0; i < jg.Length; i++)
            {
                int[] temp = new int[3];
                for(int j=0;j<3;j++)
                {
                    temp[j] = int.Parse(Console.ReadLine());
                }
                jg[i]= temp;
            }
            for(int i = 0; i < jg.Length; i++)
            {
                foreach(int j in jg[i])
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
