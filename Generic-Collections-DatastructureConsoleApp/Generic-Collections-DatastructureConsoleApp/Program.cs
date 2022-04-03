using Generic_Collections_DatastructureConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Collections_DatastructureConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.Unicode;
            Console.InputEncoding=Encoding.Unicode;
            Book book = new Book("çingiz Abdullayev", 200, "Qərb Bürküsü", 5.90)
            {
                Count = 1

            };
            //book.ShowInfo();
            //book.Sell();           

            Book book1 = new Book("Dan Brown", 300, "Mələklər ve Şeytanlar", 6.90)
            {
                Count = 2
            };
            //book1.ShowInfo();
           // book.ShowInfo();
            
            List<Book> books = new List<Book>();
            books.Add(book);
            books.Add(book1);           
           
            Library library = new Library(2)
            {
                Books = books,  
            };
            Book book2 = new Book("Ilber Ortayli", 250, "Osmanli Tarixi", 10.90)
            {
                Count = 3
            };
            // Console.WriteLine(library.Books.Count);

            //library.AddBook(book2);
            //library.AddBook(book1);
            //library.AddBook(book1);
            //library.AddBook(book);

            //Console.WriteLine(library.Books.Count);

            Console.WriteLine(library.GetBookById(null));
           
        }
    }
}
