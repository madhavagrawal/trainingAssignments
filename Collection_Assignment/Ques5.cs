using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment
{
    internal class Ques5
    {

        static void Main()
        {
            SortedList list = new SortedList();
            Console.WriteLine("Enter no. of employee");
            int n=int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter EmpID");
                int t = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Emp name :");
                string name = Console.ReadLine();
                list.Add(t,name);
            }

            foreach(var key in list.Keys)
            {
                Console.WriteLine($"EmpID : {key} \nEmp Name: {list[key]}");
            }
        }
        
    }
}
