using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_DatastructureConsoleApp.Models.Excepstion
{
    public class ProductCountIsZeroException:Exception
    {
        public static void Zero()
        {
            Console.WriteLine("Kitabın sayı sıfırdan az ola bilməz\n" +
                "Satış baş vermədi");
        }
    }
}
