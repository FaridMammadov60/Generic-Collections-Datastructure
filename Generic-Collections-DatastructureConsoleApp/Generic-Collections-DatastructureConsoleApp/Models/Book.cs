using System;

namespace Generic_Collections_DatastructureConsoleApp.Models
{
    internal class Book : Product
    {
        #region Fields
        string _authorName;
        int _pageCount;
        #endregion

        #region Properties
        public string AuthorName
        {
            get
            {
                return _authorName;
            }
            set
            {
                _authorName = value;
            }
        }
        public int PageCount
        {
            get
            {
                return _pageCount;
            }
            set
            {
                if (value < 1)
                {
                L1: Console.WriteLine("Kitabın sehifesi 1den az ola bilmez yeniden cehd edin");
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value < 1)
                    {
                        goto L1;
                    }
                    _pageCount = value;
                }
                _pageCount = value;
            }
        }

        #endregion
        #region Constructor
        public Book(string authorName, int pageCount,  string name, double price)
            : base(name, price)
        {
            this.AuthorName = authorName;
            this.PageCount = pageCount;
        }
        #endregion

        #region Method
        public override void Sell()
        {
            Count--;
            TotalIncome = TotalIncome + Price;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Book name: {Name}\n" +
                $"Book price: {Price}\n" +
                $"Book count: {Count}\n" +
                $"Book totalincome: {TotalIncome}\n" +
                $"Book authorname: {AuthorName}\n" +
                $"Book pagecount: {PageCount}\n" +
                $"Book id {Id}");
        }
        #endregion
     
    }
}
