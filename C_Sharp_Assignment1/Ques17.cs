using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment1
{
    internal class Ques17
    {
        static void Main()
        {
            string s=Console.ReadLine();
            string reverse = "";
            for(int i=s.Length-1;i>=0;i--)
            {
                reverse += s[i];
            }
            Console.WriteLine(reverse);
        }
    }
}
