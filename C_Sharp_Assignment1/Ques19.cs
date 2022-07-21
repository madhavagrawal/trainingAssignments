using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment1
{
    internal class Ques19
    {
        static void Main()
        {
            string s1=Console.ReadLine();
            string reverse = "";
            for(int i=s1.Length-1;i>=0;i--)
            {
                reverse += s1[i];
            }
            if (reverse == s1)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");


        }
    }
}
