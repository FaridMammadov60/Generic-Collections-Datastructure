using Generic_Collections_DatastructureConsoleApp.Models.Excepstion;
using System;
using System.Collections.Generic;

namespace Generic_Collections_DatastructureConsoleApp.Models
{
    internal class Library
    {
        #region Fields
        int _bookLimit;
        List<Book> _books;
        #endregion

        #region Properties
        public int BookLimit
        {
            get
            {
                return _bookLimit;
            }
            set
            {
                _bookLimit = value;
            }
        }
        public List<Book> Books
        {
            get
            {
                return _books;
            }
            set
            {
                _books = value;
            }
        }

        #endregion

        #region Constructor
        public Library(int bookLimit)
        {
            this.BookLimit = bookLimit;
        }
        #endregion

        #region Methods
        public void AddBook(Book book)
        {
            if (book.Count > BookLimit)
            {
                CapacityLimitException.Capacity();
                return;
            }
            Books.Add(book);
        }
        public Book GetBookById(int? id)
        {

            if (id == null)
            {
                NullReferenceException ex = null;
                Console.WriteLine(ex.Message);
            }         
            
                foreach (var item in Books)
                {
                    if (id == item.Id)
                    {
                        Console.WriteLine(item.Id);
                        return item;
                    }
                }
                Console.WriteLine("Daxil edilen ID-li element yoxdur");
                return null;
            
           
        }

        public void RemoveById(int? id)
        {
            if (id == null)
            {
                Exception ex = null;
                Console.WriteLine(ex.Message);
            }
            else
            {
                foreach (var item in Books)
                {
                    if (id == item.Id)
                    {
                        Books.Remove(item);
                        return;
                    }
                }
                NotFoundException.NotFound();
            }
            
        }
        #endregion
    }
}
