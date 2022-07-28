using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic_Assignment
{

    class Student
    {
        int Id;
        string Name;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name1 { get => Name; }
        public int IDD { get => Id; }
    }

    internal class Ques5
    {

        static void Main()
        {
            Console.WriteLine("Enter 3 student details");
            List<Student> students = new List<Student>();
            for(int i=0;i<3;i++)
            {
                Console.WriteLine($"Enter student ID :");
                int temp = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter student name");
                string str= Console.ReadLine();
                Student st = new Student(temp, str);
                students.Add(st);
            }

            foreach(Student student in students)
            {
                Console.WriteLine($"Student ID : {student.Name1} \nStudent Name : {student.IDD}");
            }
        }
    }
}
