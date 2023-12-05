using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            book book1 = new book();

            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            book book2 = new book();
            book2.title = "Lord of rings";
            book2.author = "Tolkein";
            book2.pages = 900;


            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.title);

            Console.ReadLine();
        }
    }
}
