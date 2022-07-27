using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment
{


    internal class Ques8
    {
        static void Main()
        {
            Dictionary<string, List<String>> dict = new Dictionary<string, List<string>>();
            Console.WriteLine("Enter no. of employee");
            int n=int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter Designaiton");
                string s = Console.ReadLine();
                Console.WriteLine("Enter Name");
                string s2 = Console.ReadLine();
                if(!dict.ContainsKey(s))
                {
                    dict[s] = new List<String>();
                }
                dict[s].Add(s2);
            }

            ArrayList arrayList = new ArrayList() { "Program Managers", "Project Manager",
                "Team Lead","Senior Programmer","Junior Programmer"};

            foreach(string s in arrayList)
            {
                if (!dict.ContainsKey(s))
                    continue;
                foreach(string s2 in dict[s])
                {
                    
                    Console.WriteLine($"Designation : {s} \n Name : {s2}");
                    
                }
            }

        }
    }
}
