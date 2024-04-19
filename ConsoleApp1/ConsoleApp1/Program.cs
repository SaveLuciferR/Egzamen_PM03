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
                    Console.Write("Введите автора книги");
                    string a = Console.ReadLine();

                    Console.Write("Введите жанр книги");
                    string z = Console.ReadLine();

                    Console.Write("Введите название книги");
                    string n = Console.ReadLine();

                    books[i] = new Book(a, z, n);
                }
            }

            public void PrintBooks()
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Записанные книги");
                    Console.Write(books[i].ToString());
                }
            }

            public void SortBookByZhanr()
            {
                books = books.OrderBy(x => x.GetZhanr()).ToArray();
            }

            public void SortBookByAuthor()
            {
                books = books.OrderBy(x => x.GetAuthor()).ToArray();
            }

            public void SortBookByName()
            {
                books = books.OrderBy(x => x.GetName()).ToArray();
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

            //BookControl books = new BookControl();
        }
    }
}
