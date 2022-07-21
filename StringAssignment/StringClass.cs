using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class StringClass
    {
        public string str = "The quick brown fox jumps over the lazy dog";

        public string str2 = "The quick brown Fox jumps over the lazy dog";


        public void a()
        {
            Console.WriteLine(str[12]);
        }

        public void b()
        {
            if (str.Contains("is"))
            {
                Console.WriteLine("string Contains the word-is");
            }
            else
                Console.WriteLine("String does not contain word-is");
        }
        
        public void c()
        {
            str = str + " and killed it";
            Console.WriteLine(str);
        }

        public void d()
        {
            if (str.EndsWith("dogs"))
            {
                Console.WriteLine("sentence ends with word-dogs");
            }
            else
                Console.WriteLine("sentence does not ends with word-dogs");
        }

        public void e()
        {
            if (str == str2)
            {
                Console.WriteLine("String is equal to the sentence - " ,str2 );
            }
            else
            {
                Console.WriteLine("String is not equal to the sentence - ",str2);
            }
        }

        public void f()
        {
            if (str ==str2.ToUpper())
            {
                Console.WriteLine("String is equal to the sentence  - " , str2.ToUpper());
            }
            else
            {
                Console.WriteLine("String is not equal to the sentence - ", str2.ToUpper());
            }

        }

        public void g()
        {
            int len=str.Length;

            Console.WriteLine("Length of string is " + len);
        }

        public void h()
        {
            if (str == str2)
            {
                Console.WriteLine("String is equal to the sentence - ", str2);
            }
            else
            {
                Console.WriteLine("String is not equal to the sentence - ", str2);
            }

        }

        public void i()
        {
            str = str.Replace("The", "A");
            Console.WriteLine(str);
        }
        public void j()
        {
            string[] s = str.Split("jumps");
            foreach(string s2 in s)
            {
                Console.WriteLine(s2);
            }
        }

        public void k()
        {
            if (str.Contains("dog"))
                Console.WriteLine("dog");
            if (str.Contains("fox"))
                Console.WriteLine("fox");

        }

        public void l()
        {
            Console.WriteLine(str.ToLower());
        }

        public void m()
        {
            Console.WriteLine(str.ToUpper());
        }

        public void n()
        {
            Console.WriteLine(str.IndexOf('a'));
        }

        public void o()
        {
            Console.WriteLine(str.LastIndexOf('e'));
        }

        public void p()
        {
            string @str = Console.ReadLine();
            str = str + @"WebApps/MyApps/Images";
            Console.WriteLine(str);
        }

        public void q()
        {
            string str = @"I WANDERE'D lonely as a cloud
That floats on high o'er vales and hills
When all at once I saw a crowd,
A host, of golden daffodils;Beside the lake, beneath the trees,
Fluttering and dancing in the breeze.";
            Console.WriteLine(str);
        }
    }
}
