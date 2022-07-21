using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Ques2
    {
        static void Main()
        {
            Dictionary<string,int> wordCount=new Dictionary<string, int>();
            string s=Console.ReadLine();
            string temp = "";
            for(int i=0;i<s.Length;i++)
            {
                
                if (s[i]==' ')
                {
                    if (wordCount.ContainsKey(temp))
                    {
                        wordCount[temp] += 1;
                    }
                    else
                        wordCount[temp] = 1;
                    temp = "";
                }
                else
                    temp += s[i];
            }
            


            foreach(var item in wordCount)
            {
                Console.WriteLine(item.Key + item.Value);
            }

        }
    }
}
