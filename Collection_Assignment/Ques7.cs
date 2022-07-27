using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment
{
    class Student
    {
        int id;
        string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id;  }
        public string Name { get => name; }
    }

    internal class Ques7
    {
        static void Main()
        {
            Console.WriteLine("Enter no. of student = ");
            int n = int.Parse(Console.ReadLine());
            Student [] students = new Student[n];
            ArrayList arr = new ArrayList();
            for (int i=0;i< n; i++)
            {
                int temp=int.Parse(Console.ReadLine());
                string temp2 = Console.ReadLine();
                students[i] = new Student(temp, temp2);
                arr.Add(students[i]);
            }

            foreach(Student v in arr)
            {
                Console.WriteLine($"Student ID : {v.Id} \nStudent Name : {v.Name}");
            }
            

        }
       

    }
}
