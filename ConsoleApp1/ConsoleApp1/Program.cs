using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Book
        {
            string author = "";
            string zhanr = "";
            string name = "";

            public Book (string a, string z, string n)
            {
                author = a;
                zhanr = z;
                name = n;
            }

            public string GetZhanr()
            {
                return zhanr;
            }

            public string GetName()
            {
                return name;
            }

            public string GetAuthor()
            {
                return author;
            }

            public override string ToString()
            {
                return "Автор: " + author + ", Жанр: " + zhanr + ", Название: " + name + "\n";
            }

        };

        class BookControl
        {
            private int n = 0;
            private Book[] books;

            public BookControl(int n)
            {
                this.n = n;
                books = new Book[n];
            }

            public void EnterParamsBooks()
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Введите автора книги №" + (i + 1));
                    string a = Console.ReadLine();

                    Console.Write("Введите жанр книги №" + (i + 1));
                    string z = Console.ReadLine();

                    Console.Write("Введите название книги №" + (i + 1));
                    string n = Console.ReadLine();

                    books[i] = new Book(a, z, n);
                    Console.WriteLine();
                }
            }

            public void PrintBooks()
            {
                Console.WriteLine("Записанные книги");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(books[i].ToString());
                }
            }

            public void SortBookByZhanr()
            {
                books = books.OrderByDescending(x => x.GetZhanr()).ToArray();
            }

            public void SortBookByAuthor()
            {
                books = books.OrderByDescending(x => x.GetAuthor()).ToArray();
            }

            public void SortBookByName()
            {
                books = books.OrderByDescending(x => x.GetName()).ToArray();
            }
        };

        static int getIntValue()
        {
            int num;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (num <= 0)
                    {
                        Console.WriteLine("Введите число больше нуля");
                    }
                    else
                    {
                        return num;
                    }
                }
                else
                {
                    Console.WriteLine("Введите корректное число");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите кол-во книг: ");

            int n = getIntValue();

            BookControl books = new BookControl(n);
            books.EnterParamsBooks();
            Console.WriteLine("");
            books.PrintBooks();

            Console.WriteLine("\n\rСортировка книг по жанрам");
            books.SortBookByZhanr();
            books.PrintBooks();

            Console.WriteLine("\n\rСортировка книг по авторам");
            books.SortBookByAuthor();
            books.PrintBooks();

            Console.WriteLine("\n\rСортировка книг по названию");
            books.SortBookByName();
            books.PrintBooks();
        }
    }
}
