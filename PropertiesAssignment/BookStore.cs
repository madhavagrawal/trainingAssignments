using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAssignment
{
    internal class BookStore
    {
        private string isbn, bookName, bookTitle, bookAuthor;
        int quantityOfBooks, bookPrice;

        public string isbn_prop
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }
        public string bookName_prop
        {
            get
            {
                return bookName;
            }

            set
            {
                bookName = value;
            }
        }
        public string bookTitle_prop
        {
            get
            {
                return bookTitle;
            }

            set
            {
                bookTitle = value;
            }
        }

        public string bookAuthor_prop
        {
            get
            {
                return bookAuthor;
            }

            set
            {
                bookAuthor = value;
            }
        }
        public int quantityOfBooks_prop
        {
            get
            {
                return quantityOfBooks;
            }

            set
            {
                quantityOfBooks = value;
            }
        }

        public int bookPrice_prop
        {
            get
            {
                return bookPrice;
            }

            set
            {
                bookPrice = value;
            }
        }

    }

    class testing
    {
        static void Main()
        {
            Console.WriteLine("Enter no. of different books");
            int n = int .Parse(Console.ReadLine());
            BookStore[] books = new BookStore[n];
            int totalAmount = 0;
            for(int i = 0; i < n; i++)
            {
                books[i] = new BookStore();
                Console.WriteLine("Enter ISBN of {0} book" , i+1);
                books[i].isbn_prop = Console.ReadLine();

                Console.WriteLine("Enter Book Name of {0} book", i + 1);
                books[i].bookName_prop = Console.ReadLine();

                Console.WriteLine("Enter Book Title of {0} book", i + 1);
                books[i].bookTitle_prop = Console.ReadLine();

                Console.WriteLine("Enter book author of {0} book", i + 1);
                books[i].bookAuthor_prop = Console.ReadLine();

                Console.WriteLine("Enter Quantity Of Books of {0} book", i + 1);
                books[i].quantityOfBooks_prop =int.Parse( Console.ReadLine());

                Console.WriteLine("Enter book price of {0} book", i + 1);
                books[i].bookPrice_prop = int.Parse(Console.ReadLine());

                totalAmount += (books[i].quantityOfBooks_prop * books[i].bookPrice_prop);
            }

            Console.WriteLine($"Total Amount = {totalAmount}");
        }
    }
}
