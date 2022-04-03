using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_DatastructureConsoleApp.Models.Excepstion
{
    public class NotFoundException:Exception
    {
        public static void NotFound()
        {
            Console.WriteLine("Kitab yoxdur");
        }
    }
}
