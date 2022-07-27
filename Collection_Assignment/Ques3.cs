using System;
using System.Collections.Generic;

using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment
{
    internal class Ques3
    {

        static void Main()
        {
            ArrayList arr = new ArrayList();
            Console.WriteLine("Enter 10 nos . ");

            for(int i = 0; i < 10; i++)
            {
                arr.Add(int.Parse(Console.ReadLine()));
            }

            arr.Sort();

            for(int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
