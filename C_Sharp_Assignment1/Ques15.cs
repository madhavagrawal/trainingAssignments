using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment1
{
    internal class Ques15
    {
        static void Main()
        {
            int[] arr = new int[10];
            int total = 0;
            int minMarks = int.MaxValue;
            int maxMarks = int.MinValue;
            for (int i =0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                total += arr[i];
                minMarks=Math.Min(minMarks, arr[i]);
                maxMarks=Math.Max(maxMarks, arr[i]);
            }
            Console.WriteLine(total);
            Console.WriteLine(total / 10);
            Console.WriteLine(minMarks);
            Console.WriteLine(maxMarks);
            Array.Sort(arr);
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            for(int j=arr.Length-1; j>=0 ; j--)
            {
                Console.WriteLine(arr[j]);
            }


        }
    }
}
