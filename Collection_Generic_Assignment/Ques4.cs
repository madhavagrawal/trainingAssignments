using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic_Assignment
{

    class BookStore
    {
        int Id;
        string Name;

        public BookStore(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name1 { get => Name;  }
    }

    internal class Ques4
    {
        static void Main()
        {
            Dictionary<int, BookStore> booksDict = new Dictionary<int, BookStore>();
            Console.WriteLine("Enter 3 book Details");
            for (int i = 0; i < 3; i++)
            {
                int id = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                BookStore book=new BookStore(id, name);
                booksDict.Add(id, book);
            }
            foreach(KeyValuePair<int, BookStore> book in booksDict)
            {
                Console.WriteLine($"BookID : {book.Key} \n Book Name : {book.Value.Name1}");
            }

        }
    }
}
