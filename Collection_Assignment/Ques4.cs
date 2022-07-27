using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment
{
    internal class Ques4
    {

        static void Main()
        {
            ArrayList arr = new ArrayList();
            Console.WriteLine("Enter no. Of students");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                arr.Add(Console.ReadLine());
            }
            arr.Sort();
            arr.Reverse();
            for(int i=0;i<arr.Count;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
