using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic_Assignment
{
    internal class Ques3
    {
        static void Main()
        {
            SortedDictionary<int, string> dict = new SortedDictionary<int, string>();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter ID and name");
                int temp=int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                dict.Add(temp, name);
            }

            foreach (KeyValuePair<int, string> var in dict)
            {
                Console.WriteLine($"ID : {var.Key} \nName :{var.Value} ");
            }
        }

       
       
    }
}
