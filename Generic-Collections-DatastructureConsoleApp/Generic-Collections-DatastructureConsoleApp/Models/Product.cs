using Generic_Collections_DatastructureConsoleApp.Models.Excepstion;
using System;

namespace Generic_Collections_DatastructureConsoleApp.Models
{
    internal abstract class Product
    {
        #region Fields
        static int _id;
        string _name;
        double _price;
        int _count;
        double _totalInCome;
        #endregion

        #region Properties
        public int Id
        {
            get;
            
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value<=0)
                {

                P1: Console.Write("Qiymət 0-dan kiçik ola bilməz\n" +
                 "Yeniden cehd edin");
                    value =Convert.ToDouble(Console.ReadLine());
                    if(value<=0)
                    {
                        goto P1;
                    }
                    _price = value;
                }
                _price = value;
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value < 0)
                {
                    ProductCountIsZeroException.Zero();
                }
                _count = value;
            }
        }
        public double TotalIncome
        {
            get
            {
                return _totalInCome;
            }
            protected set
            {
                _totalInCome = value;
            }
        }
        #endregion

        public Product(string name, double price)
        {
            _id++;
            Id= _id;
            this.Name = name;
            this.Price = price;

        }
        #region Methods
        public abstract void Sell();

        public abstract void ShowInfo();

        #endregion
    }
}
