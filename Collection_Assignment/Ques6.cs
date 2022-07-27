using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment
{

    class BookStore
    {
        public int BookID;
        public string BookName;

        public BookStore(int bookID, string bookName)
        {
            BookID = bookID;
            BookName = bookName;
        }

        public string book
        {
            get
            {
                return BookName;
            }
        }
    }

    internal class Ques6
    {
        static void Main()
        {
            Console.WriteLine("Enter no. of entries");
            int n = int.Parse(Console.ReadLine());
            BookStore [] bs = new BookStore[n];
            Hashtable ht = new Hashtable();
            for (int i=0;i<n;i++)
            {
                Console.WriteLine($"Enter {i + 1} bookID : ");
                int temp=int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter {i + 1} bookName : ");
                string temp2=Console.ReadLine();
                bs[i] = new BookStore(temp, temp2);
                ht.Add(temp, bs[i].BookName);
            }
            foreach(var v in ht.Keys)
            {
                Console.WriteLine($"BookID : {v} \nBookName  : {ht[v]}");
            }


        }
    }
}
