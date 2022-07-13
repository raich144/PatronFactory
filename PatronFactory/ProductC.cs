using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    public class ProductC : IProduct
    {
        public void doStuff()
        {
            Console.WriteLine("Haciendo algo producto C");
            
        }
    }
}
