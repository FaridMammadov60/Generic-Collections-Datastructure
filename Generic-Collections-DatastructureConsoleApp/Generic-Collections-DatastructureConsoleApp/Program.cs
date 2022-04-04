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
            //Birinci book
            Book book = new Book("çingiz Abdullayev", 200, "Qərb Bürküsü", 5.90)
            {
                Count = 5

            };
            //book.ShowInfo();
            //book.Sell();           
            //book.Sell();           
            //book.ShowInfo();

            //ikinci book
            Book book1 = new Book("Dan Brown", 300, "Mələklər ve Şeytanlar", 6.90)
            {
                Count = 2
            };            
            //book1.ShowInfo();
           // book.ShowInfo();
            
            //List book
            List<Book> books = new List<Book>();
            books.Add(book);
            books.Add(book1);           
           
            Library library = new Library(3)
            {
                Books = books,  
            };
            Book book2 = new Book("Ilber Ortayli", 250, "Osmanli Tarixi", 10.90)
            {
                Count = 3
            };
            Book book3 = new Book("GS", 1905, "UEFA", 2000)
            {
                Count = 3
            };
            //Console.WriteLine(library.Books.Count);

            library.AddBook(book2);
            library.AddBook(book3);          

            //Console.WriteLine(library.Books.Count);

            //Console.WriteLine(library.GetBookById(null));
            //Console.WriteLine(library.GetBookById(2));
            //Console.WriteLine("----");
            //Console.WriteLine(library.GetBookById(5));
            library.RemoveById(2);
            foreach (var item in library.Books)
            {
                item.ShowInfo();
                Console.WriteLine("-------");
            }
            library.AddBook(book3);
           
        }
    }
}
