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

            public string ToString()
            {
                return "Автор: " + author + ", Жанр: " + zhanr + ", Название: " + name + "\n";
            }

        };

        class BookControl
        {
            int n = 0;
            public BookControl(int n)
            {
                this.n = n;
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
