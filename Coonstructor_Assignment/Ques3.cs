using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coonstructor_Assignment
{
    internal class Ques3
    {
        public double area(double a, double b)
        {
            return (a * b)/2;                     // area of triangle
        }
        public double area(double a)
        {
            return (3.14*a*a);                         // area of circle
        }
        public double area(int a, int b)
        {
            return a * b;                         // area of rectangle
        }

        public double area(int a)
        {
            return (a * a);                       // area of square
        }
    }

    class testing_Ques3
    {
        static void Main()
        {
            Ques3 ques3 = new Ques3();
            Console.WriteLine(ques3.area(2.1 , 3.1));   // area of triangle
            Console.WriteLine(ques3.area(3.1));          // area of circle
            Console.WriteLine(ques3.area(4));          // area of rectangle
            Console.WriteLine(ques3.area(5));           // area of square
        }
    }
}
