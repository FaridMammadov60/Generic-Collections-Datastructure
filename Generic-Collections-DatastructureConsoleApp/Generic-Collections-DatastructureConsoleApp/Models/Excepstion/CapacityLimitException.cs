using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_DatastructureConsoleApp.Models.Excepstion
{
        public class CapacityLimitException:Exception
    {
        public static void Capacity()
        {
            Console.WriteLine("Kitab limitini aşmısız");
        }
    }
}
