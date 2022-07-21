using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
    internal class Ques2
    {
        public int rolllno;
        public string name;
        public string classs;
        public string sem;
        int[] marks = new int[5];

        public string displayResult()
        {
            int avg = 0;
            for(int i = 0; i < marks.Length; i++)
            {
                avg+=marks[i];
                if (marks[i] < 35)
                    return "Fail";
            }
            avg = avg / 5;
            if (avg < 50)
                return "Fail";
            return "Passed";
        }
        Ques2(int rolllno, string name, string classs, string sem, int[] marks)
        {
            this.rolllno = rolllno;
            this.name = name;
            this.classs = classs;
            this.sem = sem;
            this.marks = marks;
        }

        public void display()
        {
            Console.WriteLine($"RollNo :{rolllno}");
            Console.WriteLine($"Name :{name}");
            Console.WriteLine($"Class :{classs}");
            Console.WriteLine($"SEM :{sem}");
            foreach(int i in marks)
            {
                Console.WriteLine(i);
            }

        }

        class Ques2_Test
        {
            static void Main()
            {
                Console.WriteLine("Enter no. of user = ");
                int n = int.Parse(Console.ReadLine());
                Ques2 [] test = new Ques2[n];
                for(int i=0;i<n;i++)
                {

                    int rolllno = int.Parse(Console.ReadLine());
                    string name = Console.ReadLine();
                    string classs = Console.ReadLine(); ;
                    string sem = Console.ReadLine(); ;
                    int[] marks = new int[5];

                }
            }
        }

    }
}
